using Autodesk.DesignScript.Runtime;
using Dynamo.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loads.ASCE7_10.Gravity
{
        [IsDesignScriptCompatible]
    public partial class Dead
    {
         [IsVisibleInDynamoLibrary(false)]
        internal Dead()
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static Dead ByInputParameters()
        {
            return new Dead();
        }
    }
}
