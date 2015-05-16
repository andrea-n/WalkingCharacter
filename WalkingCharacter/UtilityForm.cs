using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Max;
using MaxCustomControls;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WalkingCharacter
{
    public partial class UtilityForm : Form
    {
        public Character Character { get; private set; }
        public BindingList<IModifier> Animation { get; set; }
        IGlobal global;
        IInterface13 i;
        IIUtil iu;
        string file;

        public UtilityForm(IGlobal global, IIUtil iu)
        {
            InitializeComponent();
            this.global = global;
            i = global.COREInterface14;
            this.iu = iu;

            Character = new Character("WalkingCharacterBody", "WalkingCharacterBip", 38);
            Animation = new BindingList<IModifier>();

            Animation.ListChanged += Animation_ListChanged;
            listBoxAnimation.DataSource = Animation;
            listBoxAnimation.DisplayMember = "Name";
            listBoxAnimation.ValueMember = "Name";
        }

        private void UtilityForm_Load(object sender, EventArgs e)
        {
            GetNodes();
        }

        // Merge character from file with current scene
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (file == null)
            {
                file = FindFile();
            }

            if (file != null && File.Exists(file) && i.MergeFromFile(file, true, false, true, 3, null, 1000, 0) != 0)
            {
                if (!GetNodes())
                {
                    MessageBox.Show("Merged scene doesn't contain '" + Character.Name + "' and '" + Character.BipedName + "' objects.");
                }
            }
        }

        private bool GetNodes()
        {
            IINode characterNode = i.GetINodeByName(Character.Name);
            IINode bipedNode = i.GetINodeByName(Character.BipedName);
            if (characterNode != null && bipedNode != null)
            {
                Character.Node = characterNode;
                Character.BipedNode = bipedNode;
                global.ExecuteMAXScriptScript("animationRange = interval 0 " + (Character.StepLength - 1), false, null);

                groupAnimation.Enabled = true;
                groupCreateAnimation.Enabled = true;
                return true;
            }
            else return false;
        }

        private string FindFile()
        {
            string currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string filePath = Path.Combine(currentDirectory, "bin\\assemblies\\src\\Scene.max");
            FileInfo fileInfo = new FileInfo(filePath);

            OpenFileDialog openDialog;
            string file = null;

            if (fileInfo.Exists)
            {
                file = fileInfo.FullName;
            }
            else
            {
                MessageBox.Show("File <3ds Max installation folder>/bin/assemblies/src/Scene.max wasn't found. Please select the path.");
                openDialog = new OpenFileDialog();
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    file = openDialog.FileName;
                }
            }
            return file;
        }

        private void buttonAddFur_Click(object sender, EventArgs e)
        {
            FurDialog addFurdialog = new FurDialog();
            if (addFurdialog.ShowDialog() == DialogResult.OK)
            {
                Animation.Add(addFurdialog.FurModifier);
                addFurdialog.FurModifier.Apply(Character);
            }
        }

        private void listBoxAnimation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAnimation.SelectedIndex != -1)
            {
                groupEditAnimation.Enabled = true;
                Animation.ElementAt(listBoxAnimation.SelectedIndex).Apply(Character);
            }
            else
            {
                groupEditAnimation.Enabled = false;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxAnimation.SelectedIndex != -1)
            {
                Animation.RemoveAt(listBoxAnimation.SelectedIndex);
            }

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int i = listBoxAnimation.SelectedIndex;
            if (i != -1 && i > 0)
            {
                Animation.Insert(i + 1, Animation.ElementAt(i - 1));
                Animation.RemoveAt(i - 1);
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int i = listBoxAnimation.SelectedIndex;
            if (i != -1 && i < Animation.Count - 1)
            {
                Animation.Insert(i, Animation.ElementAt(i + 1));
                Animation.RemoveAt(i + 2);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int i = listBoxAnimation.SelectedIndex;
            if (i != -1)
            {
                IModifier mod = Animation[i];
                if (mod != null && mod is FurModifier)
                {
                    FurDialog editFurdialog = new FurDialog((FurModifier)mod);
                    if (editFurdialog.ShowDialog() == DialogResult.OK)
                    {
                        Animation[i] = editFurdialog.FurModifier;
                    }
                }
            }
        }

        private void buttonCreateKeys_Click(object sender, EventArgs e)
        {
            int frame = 0;
            int steps = 0;
            int transition = 0;
            this.DeleteKeys();
            foreach (IModifier modifier in Animation)
            {
                transition = (modifier.Steps * Character.StepLength) / 10 * modifier.TransitionSpeed;
                transition = Math.Min(transition, modifier.Steps * Character.StepLength - 3);
                modifier.AddKey(frame, Character);
                if (transition != 0) modifier.AddKey(frame + transition, Character);
                steps += modifier.Steps;
                frame += modifier.Steps * Character.StepLength;
            }
            CopySteps(steps);
        }

        private void CopySteps(int steps)
        {
            string interval = "(interval 0 " + (Character.StepLength - 1) + ")";
            string biped = "($" + Character.BipedName + "...* as array)";

            global.ExecuteMAXScriptScript("for bone in " + biped + " do (selectKeys bone.pos.controller " + interval + ")", false, null);
            global.ExecuteMAXScriptScript("for bone in " + biped + " do (selectKeys bone.rotation.controller " + interval + ")", false, null);
            global.ExecuteMAXScriptScript("fn bumpTime t delta = t + delta", false, null);
            for (int i = 1; i < steps; i++)
            {
                global.ExecuteMAXScriptScript("for bone in " + biped + " do (copyPasteKeys bone.pos.controller bumpTime " + Character.StepLength + ")", false, null);
                global.ExecuteMAXScriptScript("for bone in " + biped + " do (copyPasteKeys bone.rotation.controller bumpTime " + Character.StepLength + ")", false, null);
            }
            global.ExecuteMAXScriptScript("animationRange = interval 0 " + (steps * Character.StepLength - 1), false, null);
        }

        private void DeleteKeys()
        {
            string interval = "(interval " + Character.StepLength + " 10000)";
            string biped = "($" + Character.BipedName + "...* as array)";

            global.ExecuteMAXScriptScript("deleteKeys $" + Character.Name + " #allKeys", false, null);

            global.ExecuteMAXScriptScript("for bone in " + biped + " do (selectKeys bone.pos.controller " + interval + ")", false, null);
            global.ExecuteMAXScriptScript("for bone in " + biped + " do (selectKeys bone.rotation.controller " + interval + ")", false, null);
            global.ExecuteMAXScriptScript("for bone in " + biped + " do (deleteKeys bone.pos.controller #selection)", false, null);
            global.ExecuteMAXScriptScript("for bone in " + biped + " do (deleteKeys bone.rotation.controller #selection)", false, null);

            global.ExecuteMAXScriptScript("animationRange = interval 0 " + (Character.StepLength - 1), false, null);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.AddExtension = true;
            saveDialog.Filter = "Walking Character Animation (*.wca)|*.wca";
            saveDialog.DefaultExt = "wca";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(JsonConvert.SerializeObject(Animation));
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Walking Character Animation (*.wca)|*.wca";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openDialog.FileName;

                Animation.Clear();

                using (StreamReader sr = new StreamReader(path))
                {
                    JArray jsonArray = JArray.Parse(sr.ReadToEnd());

                    foreach (JObject jsonObject in jsonArray.Children<JObject>())
                    {
                        Type modifierType = Type.GetType(jsonObject.Property("ClassName").Value.ToString());
                        Animation.Add((IModifier)JsonConvert.DeserializeObject(jsonObject.ToString(), modifierType));
                    }
                }
            }
        }

        void Animation_ListChanged(object sender, ListChangedEventArgs e)
        {
            buttonSave.Enabled = (Animation.Count != 0);
            buttonCreateKeys.Enabled = (Animation.Count != 0);
            groupEditAnimation.Enabled = (Animation.Count != 0);
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.DeleteKeys();
        }

        private void UtilityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            iu.CloseUtility();
        }
    }
}
