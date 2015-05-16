using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Max;
using Autodesk.Max.Plugins;

namespace WalkingCharacter
{
    class WalkingCharacterClassDesc : ClassDesc2
    {
        IGlobal global;
        internal static IClass_ID WalkingCharacterClassID;

        public WalkingCharacterClassDesc(IGlobal global)
        {
            this.global = global;
            WalkingCharacterClassID = global.Class_ID.Create(0x5cd75bd2, 0xc497dd9);
        }

        public override string Category
        {
            get { return "Utility plugin"; }
        }

        public override IClass_ID ClassID
        {
            get { return WalkingCharacterClassID; }
        }

        public override string ClassName
        {
            get { return "WalkingCharacter"; }
        }

        public override object Create(bool loading)
        {
            return new WalkingCharacterUtility(global);
        }

        public override bool IsPublic
        {
            get { return true; }
        }

        public override SClass_ID SuperClassID
        {
            get { return SClass_ID.Utility; }
        }
    }
}
