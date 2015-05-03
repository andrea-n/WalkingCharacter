using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Max;

namespace WalkingCharacter
{
    public class Character
    {
        public String Name { get; set; }

        //Skeleton name
        public String BipedName { get; set; }

        //Number of frames in one character's step
        public int StepLength { get; set; }

        public IINode Node { get; set; }
        public IINode BipedNode { get; set; }

        public Character(String name, String bipedName, int stepLength)
        {
            Name = name;
            BipedName = bipedName;
            StepLength = stepLength;
        }
    }
}
