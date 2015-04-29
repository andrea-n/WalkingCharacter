using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingCharacter
{
    public static class AssemblyFunctions
    {
        public static void AssemblyMain()
        {
            var global = Autodesk.Max.GlobalInterface.Instance;
            var interf = global.COREInterface13;
            interf.AddClass(new WalkingCharacterClassDesc(global));
        }

        public static void AssemblyShutdown()
        {
        }
    }
}
