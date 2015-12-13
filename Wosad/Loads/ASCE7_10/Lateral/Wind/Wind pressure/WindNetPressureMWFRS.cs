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

namespace Loads.ASCE7_10.Lateral.Wind.WindPressure
{
    /// <summary>
    ///     Wind net pressure (MWFRS)
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind.Wind pressure
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class WindNetPressureMWFRS 
    {
        /// <summary>
        ///    Calculates Wind net pressure on Main Wind-Force Resisting System (MWFRS) elements excluding effects of internal pressure (psf) - ASCE7-10. USC units
        /// </summary>
        /// <param name="q_z">  velocity pressure evaluated at height z above ground /param>
/// <param name="q_h">  velocity pressure evaluated at height z=h /param>
/// <param name="G">  gust-effect factor /param>
/// <param name="C_p_l">  leeward external pressure coefficient to be used in determination of wind loads for buildings /param>
/// <param name="C_p_w">  windward external pressure coefficient to be used in determination of wind loads for buildings /param>

        /// <returns> "Parameter name: p", Parameter description: design pressure to be used in determination of wind loads for buildings </returns>

        /// 
        [MultiReturn(new[] { "p" })]
        public static Dictionary<string, object> WindNetPressureMWFRS_p(double q_z,double q_h,double G,double C_p_l,double C_p_w)
        {
            //Default values
            double p = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "p", p }
 
            };
        }



    }
}


