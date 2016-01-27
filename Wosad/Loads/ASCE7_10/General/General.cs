using Autodesk.DesignScript.Runtime;
using Dynamo.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loads.ASCE7_10
{
            [IsDesignScriptCompatible]
    public partial class General
    {


         [IsVisibleInDynamoLibrary(false)]
        internal General()
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static General ByOccupancy()
        {
            return new General();
        }


    }
}
