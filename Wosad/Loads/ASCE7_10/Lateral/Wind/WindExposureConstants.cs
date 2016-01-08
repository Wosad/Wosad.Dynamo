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

namespace Loads.ASCE7_10.Lateral.Wind
{
    /// <summary>
    ///     Wind  exposure constants
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class WindExposureConstants 
    {
        /// <summary>
        ///    Calculates Terrain exposure constants, as a function of Exposure Category - ASCE7-10. USC units
        /// </summary>
        /// <returns> "Parameter name: alpha", Parameter description: 3-sec gust-speed power law exponent </returns>
/// <returns> "Parameter name: z_g", Parameter description: nominal height of the atmospheric boundary layer used in this standard </returns>
/// <returns> "Parameter name: alpha_", Parameter description: mean hourly wind-speed power law exponent </returns>
/// <returns> "Parameter name: b_", Parameter description: mean hourly wind speed factor  </returns>
/// <returns> "Parameter name: c", Parameter description: turbulence intensity factor </returns>
/// <returns> "Parameter name: l", Parameter description: integral length scale factor </returns>
/// <returns> "Parameter name: epsilon_", Parameter description: integral length scale power law exponent </returns>
/// <returns> "Parameter name: z_min", Parameter description: exposure constant </returns>

        [MultiReturn(new[] { "alpha","z_g","alpha_","b_","c","l","epsilon_","z_min" })]
        public static Dictionary<string, object> WiindExposureConsatnts()
        {
            //Default values
            double alpha = 0;
double z_g = 0;
double alpha_ = 0;
double b_ = 0;
double c = 0;
double l = 0;
double epsilon_ = 0;
double z_min = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "alpha", alpha }
,{ "z_g", z_g }
,{ "alpha_", alpha_ }
,{ "b_", b_ }
,{ "c", c }
,{ "l", l }
,{ "epsilon_", epsilon_ }
,{ "z_min", z_min }
 
            };
        }



    }
}


