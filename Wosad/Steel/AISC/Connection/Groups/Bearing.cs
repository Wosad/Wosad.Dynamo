using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wosad.Steel.AISC;

namespace Steel.AISC.Connection.BasePlate
{
    public partial class Bearing
    {

        internal Bearing()
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static Bearing ByInputParameters()
        {
            return new Bearing();
        }
    }
}
