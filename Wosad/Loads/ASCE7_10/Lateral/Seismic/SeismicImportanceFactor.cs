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
    ///     Seismic importance factor
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class SeismicImportanceFactor 
    {
        /// <summary>
        ///    Calculates Importance factor (I_e) for seismic loads - ASCE7-10
        /// </summary>
        /// <param name="BuildingRiskCategory">  Building risk category /param>

        /// <returns> "Parameter name: I_e", Parameter description: seismic importance factor  </returns>

        /// 
        [MultiReturn(new[] { "I_e" })]
        public static Dictionary<string, object> SeismicImportanceFactor_I_e(string BuildingRiskCategory)
        {
            //Default values
            double I_e = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "I_e", I_e }
 
            };
        }



    }
}


