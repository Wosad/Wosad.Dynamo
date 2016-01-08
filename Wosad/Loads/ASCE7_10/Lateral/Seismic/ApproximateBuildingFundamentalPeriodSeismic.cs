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
    ///     Building fundamental period (seismic)
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class ApproximateBuildingFundamentalPeriodSeismic 
    {
        /// <summary>
        ///    Calculates Fundamental period of the building  (T) used to account for building dynamic response to base accelerations (s) - ASCE7-10
        /// </summary>
        /// <param name="C_u">  Coefficient for upper limit on  calculated period</param>
        /// <returns> "Parameter name: T", Parameter description: fundamental period of the building </returns>

        [MultiReturn(new[] { "T" })]
        public static Dictionary<string, object> ApproximateBuildingFundamentalPeriodSeismic_T(double C_u)
        {
            //Default values
            double T = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "T", T }
 
            };
        }



    }
}


