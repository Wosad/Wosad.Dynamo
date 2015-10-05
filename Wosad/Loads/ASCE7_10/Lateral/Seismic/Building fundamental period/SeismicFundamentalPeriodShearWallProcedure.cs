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

namespace Loads.ASCE7_10.Lateral.Seismic.BuildingFundamentalPeriod
{
    /// <summary>
    ///     Seismic fundamental period (Shear wall procedure)
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic.Building fundamental period
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class SeismicFundamentalPeriodShearWallProcedure 
    {
        /// <summary>
        ///    Calculates Approximate fundamental period of the building used to account for building dynamic response to base accelerations (s). Procedure applicable to  concrete and masonry shear wall buildings - ASCE7-10. USC units
        /// </summary>
        
        /// <returns> "Parameter name: T_a", Parameter description: approximate fundamental period of the building </returns>

        /// 
        [MultiReturn(new[] { "T_a" })]
        public static Dictionary<string, object> SeismicFundamentalPeriodShearWallProcedure_T_a()
        {
            //Default values
            double T_a = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "T_a", T_a }
 
            };
        }



    }
}


