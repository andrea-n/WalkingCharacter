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

namespace WalkingCharacter
{
    public partial class UtilityForm : Form
    {
        public Character Character { get; private set; }
        public BindingList<IModifier> Animation { get; set; }
        IGlobal global;

        public UtilityForm(IGlobal global)
        {
            InitializeComponent();
            this.global = global;
            Character = new Character("WalkingCharacterBody");
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
            OpenFileDialog dialog = new OpenFileDialog();
            string file = null;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = dialog.FileName;
                i.PushPrompt(dialog.FileName);
            }
            if (file != null)
            {
                if (i.MergeFromFile(dialog.FileName, true, true, true, 3, null, 3, 2) == 0)
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
                        i.PushPrompt("Couldn't find character's node in the scene");
                    }
                    IINode bipedNode = i.GetINodeByName("Hips");
                    if (bipedNode != null)
                    {
                        Character.BipedNode = bipedNode;
                    }
                    else
                    {
                        i.PushPrompt("Couldn't find character's skeleton in the scene");
                    }
                }
            }
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
            /*if (listBoxAnimation.SelectedIndex != -1)
            {
                Animation.RemoveAt(listBoxAnimation.SelectedIndex);
            }*/
            int frame = 0;
            foreach (FurModifier fur in Animation)
            {
                frame += fur.Steps;
                fur.AddKey(frame, Character);
            }
            /*if (Character.BipedNode != null)
            {
                for (int i = 0; i <= 37; i++)
                {
                    Character.BipedNode.TMController.CopyKeysFromTime(i, i + 38, 3);
                }
            }*/
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
                Animation.Insert(i + 2, Animation.ElementAt(i));
                Animation.RemoveAt(i);
                listBoxAnimation.SelectedIndex++;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int i = listBoxAnimation.SelectedIndex;
            if (i != -1)
            {
                IModifier mod = Animation.ElementAt(i);
                if (mod != null && mod is FurModifier)
                {
                    //FurDialog editFurdialog = new FurDialog((FurModifier)mod);
                    MessageBox.Show(mod.ToString());
                    /*if (editFurdialog.ShowDialog() == DialogResult.OK)
                    {
                        Animation[i] = editFurdialog.FurModifier;
                    }*/
                }
            }
        }
    }
}
