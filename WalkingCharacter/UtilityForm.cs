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
                }
            }
        }

        private void buttonAddFur_Click(object sender, EventArgs e)
        {
            FurDialog furdialog = new FurDialog();
            if (furdialog.ShowDialog() == DialogResult.OK)
            {
                Animation.Add(furdialog.FurModifier);
                Animation.ElementAt(0).Apply(Character);
            }
        }

        private void listBoxAnimation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAnimation.SelectedIndex != -1)
            {
                groupBoxEditAnimation.Enabled = true;
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
            if (i != -1 && i > 1)
            {
                Animation.Insert(i - 2, Animation.ElementAt(i));
                Animation.RemoveAt(i - 1);
                listBoxAnimation.SelectedIndex--;
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int i = listBoxAnimation.SelectedIndex;
            if (i != -1 && i < Animation.Count - 2)
            {
                Animation.Insert(i + 2, Animation.ElementAt(i));
                Animation.RemoveAt(i);
                listBoxAnimation.SelectedIndex++;
            }
        }
    }
}
