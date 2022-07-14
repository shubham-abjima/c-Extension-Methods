using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Library
{
    public static  class TargetExtensions
    {
        internal static void ExtendInternal(this InternalTarget target)
        {

        }
        /*internal static void ExtendInternalProtected(this InternalTarget.ProtectedSubclass target)
        {

        }
        */

        public static string GetStandardizedId(this Target target)
        {
            return target.GetId().ToUpper();
        }
            
    }
}
