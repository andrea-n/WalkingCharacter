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

        // Cut length of fur, values 0 - 100
        public int CutLength { get; set; }
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

            CutLength = cutLength;
            Segments = segments;
            RandomScale = randomScale;
            RootThick = rootThick;

            HueVariation = hueVariation;
            valueVariation = valueVariation;
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
                
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].MaterialRootColor = color " + RootColor.R + " " + RootColor.G + " " + RootColor.B, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].MaterialTipColor = color " + TipColor.R + " " + TipColor.G + " " + TipColor.B, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].MaterialMutantHairColor = color " + MutantColor.R + " " + MutantColor.G + " " + MutantColor.B, false, null);

                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].HairCutLength = " + CutLength, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].HairSegments = " + Segments, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].HairScale = " + RandomScale, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].HairRootThickness = " + RootThick, false, null);

                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].MaterialHueVariation = " + HueVariation, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].MaterialValueVariation = " + ValueVariation, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].MaterialPercentMutantHair = " + Mutant, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].MaterialSpecular = " + Specular, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].MaterialGlossness = " + Glossiness, false, null);

                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].FlyawayStren = " + FlyAway, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].Clumps = " + Clump, false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].KinkTip = " + Kink, false, null);

                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].FlyawayPerc = 100", false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].ClumpsStren = 1", false, null);
                global.ExecuteMAXScriptScript("$" + charName + ".modifiers[#Hair_and_Fur].KinkRoot = " + Kink/100, false, null);

            }
            else
            {
                MessageBox.Show("Can't find 'WalkingCharacterBody'");
            }
        }

    }
}
