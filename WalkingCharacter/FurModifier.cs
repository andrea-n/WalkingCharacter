using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace WalkingCharacter
{
    public class FurModifier : IModifier
    {
        public String Name { get; set; }
        public int Steps { get; set; }

        // Fur color, R, G, B properties
        public Color RootColor { get; set; }
        public Color TipColor { get; set; }

        // Cut length of fur, values 0 - 100
        public int CutLength { get; set; }

        public FurModifier(String name, int steps, Color rootColor, Color tipColor, int cutLenght)
        {
            Name = name;
            Steps = steps;
            RootColor = rootColor;
            TipColor = tipColor;
            cutLenght = cutLenght;
        }

        public void Apply(Character character)
        {

        }

    }
}
