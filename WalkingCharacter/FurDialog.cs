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

        public FurDialog(FurModifier modifier)
        {
            InitializeComponent();
            FurModifier = modifier;
            numericSteps.Value = FurModifier.Steps;
            trackBarTransitionSpeed.Value = FurModifier.TransitionSpeed;
            numericScale.Value = FurModifier.Scale;
            numericSegments.Value = FurModifier.Segments;
            numericRandomScale.Value = FurModifier.RandomScale;
            numericRootThick.Value = FurModifier.RootThick;
            numericFlyAway.Value = FurModifier.FlyAway;
            numericClump.Value = FurModifier.Clump;
            numericKink.Value = FurModifier.Kink;
            buttonRootColor.BackColor = FurModifier.RootColor;
            buttonTipColor.BackColor = FurModifier.TipColor;
            buttonMutantColor.BackColor = FurModifier.MutantColor;
            numericHueVariation.Value = FurModifier.HueVariation;
            numericValueVariation.Value = FurModifier.ValueVariation;
            numericMutant.Value = FurModifier.Mutant;
            numericSpecular.Value = FurModifier.Specular;
            numericGlossiness.Value = FurModifier.Glossiness;
            textBoxName.Text = FurModifier.Name;
            buttonAdd.Text = "Edit";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FurModifier = new FurModifier(textBoxName.Text, (int)numericSteps.Value, (int)trackBarTransitionSpeed.Value, buttonRootColor.BackColor, buttonTipColor.BackColor, buttonMutantColor.BackColor, (int)numericScale.Value, (int)numericSegments.Value, (int)numericRandomScale.Value, (int)numericRootThick.Value, (int)numericHueVariation.Value, (int)numericValueVariation.Value, (int)numericMutant.Value, (int)numericSpecular.Value, (int)numericGlossiness.Value, (int)numericFlyAway.Value, (int)numericClump.Value, (int)numericKink.Value);
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
