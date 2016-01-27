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
    public partial class Live
    {
         [IsVisibleInDynamoLibrary(false)]
        internal Live()
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static Live ByInputParameters()
        {
            return new Live();
        }
    }
}
