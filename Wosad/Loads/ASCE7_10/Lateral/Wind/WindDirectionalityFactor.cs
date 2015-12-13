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
    ///     Wind directionality factor
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class WindDirectionalityFactor 
    {
        /// <summary>
        ///    Calculates Wind directionality factor (K_d)  - ASCE7-10
        /// </summary>
        /// <param name="WindStructureDescriptionForExposure">  Description of the structure for exposure category determination /param>

        /// <returns> "Parameter name: K_d", Parameter description: wind directionality factor </returns>

        /// 
        [MultiReturn(new[] { "K_d" })]
        public static Dictionary<string, object> WindDirectionalityFactor_K_d(string WindStructureDescriptionForExposure)
        {
            //Default values
            double K_d = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "K_d", K_d }
 
            };
        }



    }
}


