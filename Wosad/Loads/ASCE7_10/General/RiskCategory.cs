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
using Wosad.Loads.ASCE.ASCE7_10.General;
using Wosad.Loads.ASCE.ASCE7_10.LiveLoads;

#endregion

namespace Loads.ASCE7_10.General
{
    /// <summary>
    ///     Building risk category
    ///     Category:   Wosad.Loads.ASCE7-10.General
    /// </summary>
    /// 


    public class RiskCategory 
    {
        /// <summary>
        ///    Calculates Selection of Building risk category - ASCE7-10
        /// </summary>
        /// <param name="BuildingOccupancy">  Occupancy description /param>

        /// <returns> "Parameter name: BuildingRiskCategory", Parameter description: Building risk category </returns>

        /// 
        [MultiReturn(new[] { "BuildingRiskCategory" })]
        public static Dictionary<string, object> BuildingRiskCategory(string BuildingOccupancyId)
        {
            //Default values
            string BuildingRiskCategory = "";


            Structure st = new Structure();
            BuildingRiskCategory = st.GetRiskCategory(BuildingOccupancyId).ToString();


            return new Dictionary<string, object>
            {
                { "BuildingRiskCategory", BuildingRiskCategory }
 
            };
        }

        string buildingOccupancy;

        internal RiskCategory(string BuildingOccupancy)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static RiskCategory ByOccupancy(string BuildingOccupancy)
        {
            return new RiskCategory(BuildingOccupancy);
        }



    }
}


