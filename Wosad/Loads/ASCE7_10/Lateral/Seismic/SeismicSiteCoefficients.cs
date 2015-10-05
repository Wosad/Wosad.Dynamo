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
    ///     Seismic site coefficients
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class SeismicSiteCoefficients 
    {
        /// <summary>
        ///    Calculates Seismic site coefficients (F_a and F_v) accounting for short-period  and long-period soil amplification of base accelerations - ASCE7-10
        /// </summary>
        /// <param name="S_S">  mapped MCER, 5 percent damped, spectral response acceleration parameter at short periods /param>
/// <param name="S_1">  mapped MCER, 5 percent damped, spectral response acceleration parameter at a period of 1 s /param>
/// <param name="SiteClass">  Seismic site class (as a function of soil type) /param>

        /// <returns> "Parameter name: F_a", Parameter description: short-period site coefficient (at 0.2 s-period) </returns>
/// <returns> "Parameter name: F_v", Parameter description: long-period site coefficient (at 1.0 s-period) </returns>

        /// 
        [MultiReturn(new[] { "F_a","F_v" })]
        public static Dictionary<string, object> SiteCoefficients(double S_S,double S_1,string SiteClass)
        {
            //Default values
            double F_a = 0;
double F_v = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "F_a", F_a }
,{ "F_v", F_v }
 
            };
        }



    }
}


