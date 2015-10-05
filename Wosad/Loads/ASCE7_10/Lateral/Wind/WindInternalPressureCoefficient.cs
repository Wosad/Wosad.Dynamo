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

namespace Loads.ASCE7_10.Lateral.Wind
{
    /// <summary>
    ///     Wind internal pressure coefficient
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class WindInternalPressureCoefficient 
    {
        /// <summary>
        ///    Calculates Wind internal pressure coefficient (GC_pi) accounting for the effects of the internal pressure on the component wind pressures - ASCE7-10
        /// </summary>
        /// <param name="WindEnclosureType">  type of enclosure (open, partially-enclosed or enclosed)  /param>

        /// <returns> "Parameter name: GC_pi", Parameter description: product of internal pressure coefficient and gust-effect factor to be used in determination of wind loads for buildings </returns>

        /// 
        [MultiReturn(new[] { "GC_pi" })]
        public static Dictionary<string, object> WindInternalPressureCoefficient_GC_pi(string WindEnclosureType)
        {
            //Default values
            double GC_pi = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "GC_pi", GC_pi }
 
            };
        }



    }
}


