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
        public IINode Node { get; set; }
        public IINode BipedNode { get; set; }

        public Character(String name)
        {
            Name = name;
        }
    }
}
