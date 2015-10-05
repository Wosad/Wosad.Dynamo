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
    ///     Wind gust effect factor
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class WindGustEffectFactor 
    {
        /// <summary>
        ///    Calculates Wind gust effect factor (G or G_f) accounting for the dynamic interaction between the building and the structure - ASCE7-10. USC units
        /// </summary>
        /// <param name="WindStructureDynamicResponseType">  type of wind dynamic response (flexible or rigid) /param>
/// <param name="B">  horizontal dimension of building measured normal to wind direction /param>
/// <param name="h">  mean roof height of a building or height of other structure /param>
/// <param name="L">  horizontal dimension of a building measured parallel to the wind direction /param>
/// <param name="beta">  damping ratio, percent critical for buildings or other structures /param>
/// <param name="V">  basic wind speed /param>

        /// <returns> "Parameter name: G", Parameter description: gust-effect factor </returns>

        /// 
        [MultiReturn(new[] { "G" })]
        public static Dictionary<string, object> WindGustEffectFactor_G(string WindStructureDynamicResponseType,double B,double h,double L,double beta,double V)
        {
            //Default values
            double G = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "G", G }
 
            };
        }



    }
}


