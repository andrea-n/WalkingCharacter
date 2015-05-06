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

namespace WalkingCharacter
{
    public partial class UtilityForm : Form
    {
        public Character Character { get; private set; }
        public BindingList<IModifier> Animation { get; set; }
        Autodesk.Max.IGlobal global;
        string file;

        public UtilityForm(IGlobal global)
        {
            InitializeComponent();
            this.global = global;
            Character = new Character("WalkingCharacterBody", "WalkingCharacterBip", 38);
            Animation = new BindingList<IModifier>();
            listBoxAnimation.DataSource = Animation;
            listBoxAnimation.DisplayMember = "Name";
            listBoxAnimation.ValueMember = "Name";
        }

        private void UtilityForm_Load(object sender, EventArgs e)
        {

        }

        // Merge character from file with current scene
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            IInterface13 i = global.COREInterface14;

            if (file == null)
            {
                file = FindFile();
            }

            if (file != null && File.Exists(file))
            {
                if (i.MergeFromFile(file, true, false, true, 3, null, 1000, 0) == 0)
                {
                    i.PushPrompt("Nothing merged");
                }
                else
                {
                    IINode characterNode = i.GetINodeByName(Character.Name);
                    if (characterNode != null)
                    {
                        Character.Node = characterNode;
                    }
                    else
                    {
                        MessageBox.Show("Couldn't find character's node in the scene");
                    }
                    IINode bipedNode = i.GetINodeByName(Character.BipedName);
                    if (bipedNode != null)
                    {
                        Character.BipedNode = bipedNode;
                    }
                    else
                    {
                        MessageBox.Show("Couldn't find character's skeleton in the scene");
                    }
                }
            }
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
                groupBoxEditAnimation.Enabled = true;
                Animation.ElementAt(listBoxAnimation.SelectedIndex).Apply(Character);
            }
            else
            {
                groupBoxEditAnimation.Enabled = false;
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
            int steps = 0; ;
            foreach (FurModifier fur in Animation)
            {
                fur.AddKey(frame, Character);
                steps += fur.Steps;
                frame += fur.Steps * Character.StepLength;
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
            for (int i = 0; i <= steps; i++)
            {
                global.ExecuteMAXScriptScript("for bone in " + biped + " do (copyPasteKeys bone.pos.controller bumpTime " + (Character.StepLength - 1) + ")", false, null);
                global.ExecuteMAXScriptScript("for bone in " + biped + " do (copyPasteKeys bone.rotation.controller bumpTime " + (Character.StepLength - 1) + ")", false, null);
            }
        }
    }
}
