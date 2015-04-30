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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FurModifier = new FurModifier(textBoxName.Text, (int)numericSteps.Value, buttonRootColor.BackColor, buttonTipColor.BackColor, buttonMutantColor.BackColor, (int)numericCutLength.Value, (int)numericSegments.Value, (int)numericRandomScale.Value, (int)numericRootThick.Value, (int)numericHueVariation.Value, (int)numericValueVariation.Value, (int)numericMutant.Value, (int)numericSpecular.Value, (int)numericGlossiness.Value, (int)numericFlyAway.Value, (int)numericClump.Value, (int)numericKink.Value);
        }

        private void buttonRootColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonRootColor.BackColor = colorDialog.Color;
            }
        }

        private void buttonTipColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonTipColor.BackColor = colorDialog.Color;
            }
        }

        private void buttonMutantColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonMutantColor.BackColor = colorDialog.Color;
            }
        }
    }
}
