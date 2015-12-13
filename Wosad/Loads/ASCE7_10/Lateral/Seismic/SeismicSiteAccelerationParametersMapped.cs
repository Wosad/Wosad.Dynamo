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
    ///     Seismic site acceleration parameters (mapped)
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class SeismicSiteAccelerationParametersMapped 
    {
        /// <summary>
        ///    Calculates Mapped spectral response acceleration parameters (S_S and S_1) and long-period transition period (T_L) for Maximum Considered Earthquake, 5 percent damped structure) - ASCE7-10
        /// </summary>
        /// <param name="Latitude">  Location latitude /param>
/// <param name="Longitude">  Location longitude /param>

        /// <returns> "Parameter name: S_S", Parameter description: mapped MCER, 5 percent damped, spectral response acceleration parameter at short periods </returns>
/// <returns> "Parameter name: S_1", Parameter description: mapped MCER, 5 percent damped, spectral response acceleration parameter at a period of 1 s </returns>
/// <returns> "Parameter name: T_L", Parameter description: long-period transition period </returns>

        /// 
        [MultiReturn(new[] { "S_S","S_1","T_L" })]
        public static Dictionary<string, object> SiteAccelerationParametersMapped(double Latitude,double Longitude)
        {
            //Default values
            double S_S = 0;
double S_1 = 0;
double T_L = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "S_S", S_S }
,{ "S_1", S_1 }
,{ "T_L", T_L }
 
            };
        }



    }
}


