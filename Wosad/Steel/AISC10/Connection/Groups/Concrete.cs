using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wosad.Steel.AISC;

namespace Steel.AISC10.Connection.BasePlate
{
     [IsVisibleInDynamoLibrary(false)]
    public partial class Concrete
    {

         internal Concrete()
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static Concrete ByInputParameters()
        {
            return new Concrete();
        }
    }
}
