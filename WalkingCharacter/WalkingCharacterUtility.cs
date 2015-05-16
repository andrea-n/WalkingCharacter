using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Max;
using Autodesk.Max.Plugins;

namespace WalkingCharacter
{
    public class WalkingCharacterUtility : UtilityObj
    {
        IGlobal global;
        IInterface ip;
        IIUtil iu;
        UtilityForm form;


        public WalkingCharacterUtility(IGlobal global)
        {
            this.global = global;
        }

        // Methods from UtilityObj

        // Called by the system when the user may edit the entities parameters
        public override void BeginEditParams(IInterface ip, IIUtil iu)
        {
            this.ip = ip;
            this.iu = iu;

            System.Windows.Forms.MessageBox.Show("sdfsfsdf");

            if (form == null)
            {
                form = new UtilityForm(global, iu);
            }
            form.Show();

            ip.PushPrompt("Walking character utility");
        }

        // Called when the user is finished editing an object's parameters
        public override void EndEditParams(IInterface ip, IIUtil iu)
        {
            ip.PopPrompt();
        }
    }
}
