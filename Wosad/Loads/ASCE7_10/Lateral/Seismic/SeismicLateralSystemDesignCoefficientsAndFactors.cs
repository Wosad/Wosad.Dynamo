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
    ///     Seismic lateral system design coefficients and factors
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class SeismicLateralSystemDesignCoefficientsAndFactors 
    {
        /// <summary>
        ///    Calculates Selection of lateral system and Design Coefficients and Factors for Seismic Force-Resisting System (R, C_d and Omega_0) - ASCE7-10
        /// </summary>
        /// <param name="LateralSystemId">  Id of the lateral system from ASCE7-10 Table 12.2-1 /param>

        /// <returns> "Parameter name: R", Parameter description: resonant response factor </returns>
/// <returns> "Parameter name: C_d", Parameter description: deflection amplification factor </returns>
/// <returns> "Parameter name: Omega_0", Parameter description: overstrength factor </returns>

        /// 
        [MultiReturn(new[] { "R","C_d","Omega_0" })]
        public static Dictionary<string, object> LateralSystemDesignCoefficientsAndFactors(string LateralSystemId)
        {
            //Default values
            double R = 0;
double C_d = 0;
double Omega_0 = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "R", R }
,{ "C_d", C_d }
,{ "Omega_0", Omega_0 }
 
            };
        }



    }
}


