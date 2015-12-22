#region

using Autodesk.DesignScript.Runtime;
using Dynamo.Models;
using System.Collections.Generic;
using Wosad.Loads.ASCE.ASCE7_10.LiveLoads;

#endregion

namespace Wosad.Steel.AISC_10.Tension
{
    /// <summary>
    ///     Shear lag factor
    ///     Category:   Wosad.Steel.AISC_10.Tension
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class ShearLagFactor 
    {
        /// <summary>
        ///    Calculates Shear lag factor for tensile strength
        /// </summary>
        
        /// <returns> "Parameter name: U", Parameter description: Shear lag factor  </returns>

        /// 
        [MultiReturn(new[] { "U" })]
        public static Dictionary<string, object> Shearlag factor()
        {
            //Default values
            double U = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "U", U }
 
            };
        }

        string _ShearLagFactor ;

        internal ShearLagFactor ()
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static ShearLagFactor  ByInputParameters()
        {
            return new ShearLagFactor(BuildingOccupancy);
        }

    }
}


