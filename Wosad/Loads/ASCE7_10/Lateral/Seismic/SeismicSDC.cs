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
    ///     Seismic Design Category
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class SeismicSDC 
    {
        /// <summary>
        ///    Calculates Seismic Design Category (SDC)  classification assigned to a structure based on its Risk Category  and the severity of the design earthquake ground motion at the site - ASCE7-10
        /// </summary>
        /// <param name="BuildingRiskCategory">  Building risk category</param>
/// <param name="S_DS">  design, 5 percent damped, spectral response acceleration parameter at short periods</param>
/// <param name="S_D1">  design, 5 percent damped, spectral response acceleration parameter at a period of 1 s</param>
/// <param name="S_1">  mapped MCER, 5 percent damped, spectral response acceleration parameter at a period of 1 s</param>
        /// <returns>  seismic design category (SDC) </returns>

        [MultiReturn(new[] { "SeismicDesignCategory" })]
        public static Dictionary<string, object> SeismicDesignCategory(string BuildingRiskCategory,double S_DS,double S_D1,double S_1)
        {
            //Default values
            string SeismicDesignCategory = "";


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "SeismicDesignCategory", SeismicDesignCategory }
 
            };
        }



    }
}


