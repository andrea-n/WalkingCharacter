using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkingCharacter
{
    public partial class FurDialog : Form
    {
        public FurModifier FurModifier { get; private set; }

        public FurDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FurModifier = new FurModifier(textBoxName.Text, (int)numericSteps.Value, buttonRootColor.BackColor, buttonTipColor.BackColor, (int)numericSteps.Value);
        }
    }
}
