using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wosad.Steel.AISC;

namespace Steel.AISC.Connection.BasePlate
{
     [IsVisibleInDynamoLibrary(false)]
    public abstract class BasePlateShapeObject
    {

        [IsVisibleInDynamoLibrary(false)]
        public IBasePlate Plate { get; set; }
    }
}
