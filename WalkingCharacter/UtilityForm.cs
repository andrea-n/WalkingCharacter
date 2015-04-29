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
        public List<IModifier> Animation { get; set; }
        IGlobal global;

        public UtilityForm(IGlobal global)
        {
            InitializeComponent();
            this.global = global;
            Character = new Character("WalkingCharacterBody");
            listBoxAnimation.DataSource = Animation;
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
            if (furdialog.DialogResult == DialogResult.OK)
            {
                Animation.Add(furdialog.FurModifier);
            }
        }
    }
}
