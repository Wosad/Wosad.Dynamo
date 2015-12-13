#region Copyright
   /*Copyright (C) 2015 Wosad Inc

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   */
#endregion
 
#region

using Autodesk.DesignScript.Runtime;
using Dynamo.Models;
using Dynamo.Nodes;
using System.Collections.Generic;
using Wosad.Loads.ASCE.ASCE7_10.LiveLoads;

#endregion

namespace Loads.ASCE7_10.Lateral.Seismic
{
    /// <summary>
    ///     Seismic base shear
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class SeismicBaseShear 
    {
        /// <summary>
        ///    Calculates Seismic base shear (V_b)  - ASCE7-10. USC units
        /// </summary>
        /// <param name="W_e">  effective seismic weight of the building /param>
/// <param name="C_s">  seismic response coefficient which multiplied by the building seismic weight, gives the building seismic base shear (lateral pseudo-acceleration, expressed in units of gravity) /param>

        /// <returns> "Parameter name: V_b", Parameter description: Seismic base shear </returns>

        /// 
        [MultiReturn(new[] { "V_b" })]
        public static Dictionary<string, object> SeismicBaseShear_V_b(double W_e,double C_s)
        {
            //Default values
            double V_b = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "V_b", V_b }
 
            };
        }



    }
}


