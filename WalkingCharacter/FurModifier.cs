using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using Autodesk.Max;

namespace WalkingCharacter
{
    public class FurModifier : IModifier
    {
        IGlobal global;
        public String Name { get; set; }
        public int Steps { get; set; }

        // Fur color, R, G, B properties
        public Color RootColor { get; set; }
        public Color TipColor { get; set; }
        public Color MutantColor { get; set; }


        public int Scale { get; set; }
        public int Segments { get; set; }
        public int RandomScale { get; set; }
        public int RootThick { get; set; }

        public int HueVariation { get; set; }
        public int ValueVariation { get; set; }
        public int Mutant { get; set; }
        public int Specular { get; set; }
        public int Glossiness { get; set; }

        public int FlyAway { get; set; }
        public int Clump { get; set; }
        public int Kink { get; set; }

        public FurModifier(String name, int steps, Color rootColor, Color tipColor, Color mutantColor, int cutLength, int segments, int randomScale, int rootThick, int hueVariation, int valueVariation, int mutant, int specular, int glossiness, int flyAway, int clump, int kink)
        {
            Name = name;
            Steps = steps;

            RootColor = rootColor;
            TipColor = tipColor;
            MutantColor = mutantColor;

            Scale = cutLength;
            Segments = segments;
            RandomScale = randomScale;
            RootThick = rootThick;

            HueVariation = hueVariation;
            ValueVariation = valueVariation;
            Mutant = mutant;
            Specular = specular;
            Glossiness = glossiness;

            FlyAway = flyAway;
            Clump = clump;
            Kink = kink;

            global = Autodesk.Max.GlobalInterface.Instance;
        }

        public void Apply(Character character)
        {
            if (character != null)
            {
                string charName = character.Name;
                string modifier = ".modifiers[#Hair_and_Fur]";

                global.ExecuteMAXScriptScript("$" + charName + modifier + ".MaterialRootColor = color " + RootColor.R + " " + RootColor.G + " " + RootColor.B, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".MaterialTipColor = color " + TipColor.R + " " + TipColor.G + " " + TipColor.B, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".MaterialMutantHairColor = color " + MutantColor.R + " " + MutantColor.G + " " + MutantColor.B, false, null);

                global.ExecuteMAXScriptScript("$" + charName + modifier + ".HairScale = " + Scale, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".HairSegments = " + Segments, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".HairRandScale = " + RandomScale, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".HairRootThickness = " + RootThick, false, null);

                global.ExecuteMAXScriptScript("$" + charName + modifier + ".MaterialHueVariation = " + HueVariation, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".MaterialValueVariation = " + ValueVariation, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".MaterialPercentMutantHair = " + Mutant, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".MaterialSpecular = " + Specular, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".MaterialGlossness = " + Glossiness, false, null);

                global.ExecuteMAXScriptScript("$" + charName + modifier + ".FlyawayStren = " + FlyAway/100, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".Clumps = " + Clump, false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".KinkTip = " + Kink, false, null);

                global.ExecuteMAXScriptScript("$" + charName + modifier + ".FlyawayPerc = 100", false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".ClumpsStren = 1", false, null);
                global.ExecuteMAXScriptScript("$" + charName + modifier + ".KinkRoot = 0", false, null);

            }
            else
            {
                MessageBox.Show("Can't find 'WalkingCharacterBody'");
            }
        }

        public void AddKey(int frame, Character character)
        {
            if (character != null)
            {
                string charName = character.Name;
                string modifier = ".modifiers[#Hair_and_Fur]";

                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".MaterialRootColor.controller " + frame + ").value = [" + RootColor.R + ", " + RootColor.G + ", " + RootColor.B + "]", false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".MaterialTipColor.controller " + frame + ").value = [" + TipColor.R + ", " + TipColor.G + ", " + TipColor.B + "]", false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".MaterialMutantHairColor.controller " + frame + ").value = [" + MutantColor.R + ", " + MutantColor.G + ", " + MutantColor.B + "]", false, null);

                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".HairScale.controller " + frame + ").value = " + Scale, false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".HairSegments.controller " + frame + ").value = " + Segments, false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".HairRandScale.controller " + frame + ").value = " + RandomScale, false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".HairRootThickness.controller " + frame + ").value = " + RootThick, false, null);

                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".MaterialHueVariation.controller " + frame + ").value = " + HueVariation, false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".MaterialValueVariation.controller " + frame + ").value = " + ValueVariation, false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".MaterialPercentMutantHair.controller " + frame + ").value = " + Mutant, false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".MaterialSpecular.controller " + frame + ").value = " + Specular, false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".MaterialGlossness.controller " + frame + ").value = " + Glossiness, false, null);

                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".FlyawayStren.controller " + frame + ").value = " + FlyAway/100, false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".Clumps.controller " + frame + ").value = " + Clump, false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".KinkTip.controller " + frame + ").value = " + Kink, false, null);

                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".FlyawayPerc.controller " + frame + ").value = 100", false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".ClumpsStren.controller " + frame + ").value = 1", false, null);
                global.ExecuteMAXScriptScript("(addnewkey $" + charName + modifier + ".KinkRoot.controller " + frame + ").value = 0", false, null);
            }
            else
            {
                MessageBox.Show("Can't find 'WalkingCharacterBody'");
            }
        }

    }
}
