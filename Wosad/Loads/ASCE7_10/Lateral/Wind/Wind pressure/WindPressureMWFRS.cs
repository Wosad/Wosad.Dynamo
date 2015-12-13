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
    ///     Wind pressure (MWFRS)
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind.Wind pressure
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class WindPressureMWFRS 
    {
        /// <summary>
        ///    Calculates Wind pressure on Main Wind-Force Resisting System (MWFRS) elements (psf) - ASCE7-10. USC units
        /// </summary>
        /// <param name="q">  velocity pressure /param>
/// <param name="G">  gust-effect factor /param>
/// <param name="C_p">  external pressure coefficient to be used in determination of wind loads for buildings /param>
/// <param name="q_i">  velocity pressure for internal pressure determination /param>
/// <param name="GC_pi">  product of internal pressure coefficient and gust-effect factor to be used in determination of wind loads for buildings /param>

        /// <returns> "Parameter name: p", Parameter description: design pressure to be used in determination of wind loads for buildings </returns>

        /// 
        [MultiReturn(new[] { "p" })]
        public static Dictionary<string, object> WindPressureMWFRS_p(double q,double G,double C_p,double q_i,double GC_pi)
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


