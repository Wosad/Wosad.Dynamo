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
using System.Collections.Generic;
using Wosad.Loads.ASCE.ASCE7_10.LiveLoads;

#endregion

namespace Loads.ASCE7_10.Lateral.Seismic
{
    /// <summary>
    ///     Seismic response coefficient
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class SeismicResponseCoefficient 
    {
        /// <summary>
        ///    Calculates Seismic response coefficient which multiplied by the building seismic weight, gives the building seismic base shear (lateral pseudo-acceleration, expressed in units of gravity) - ASCE7-10
        /// </summary>
        /// <param name="T">  fundamental period of the building /param>
/// <param name="S_DS">  design, 5 percent damped, spectral response acceleration parameter at short periods /param>
/// <param name="S_D1">  design, 5 percent damped, spectral response acceleration parameter at a period of 1 s /param>
/// <param name="T_L">  long-period transition period /param>
/// <param name="R">  resonant response factor /param>
/// <param name="I_e">  seismic importance factor  /param>
/// <param name="S_1">  mapped MCER, 5 percent damped, spectral response acceleration parameter at a period of 1 s /param>

        /// <returns> "Parameter name: C_s", Parameter description: seismic response coefficient which multiplied by the building seismic weight, gives the building seismic base shear (lateral pseudo-acceleration, expressed in units of gravity) </returns>

        /// 
        [MultiReturn(new[] { "C_s" })]
        public static Dictionary<string, object> SeismicResponseCoefficient_C_s(double T,double S_DS,double S_D1,double T_L,double R,double I_e,double S_1)
        {
            //Default values
            double C_s = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "C_s", C_s }
 
            };
        }



    }
}


