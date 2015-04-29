using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingCharacter
{
    /// <summary>
    /// Interface representing a modifier or shader which can be applied on the character
    /// </summary>
    public interface IModifier
    {
        // How many steps of the character is modifier/shader applied
        int Steps { get; set; }

        String Name { get; set; }

        // In this method a modifier/shader should be applied on character
        void Apply(Character character);
    }
}
