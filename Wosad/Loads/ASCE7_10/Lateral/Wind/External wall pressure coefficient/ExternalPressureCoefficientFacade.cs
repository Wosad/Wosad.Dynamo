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

namespace Loads.ASCE7_10.Lateral.Wind.ExternalWallPressureCoefficient
{
    /// <summary>
    ///     External pressure coefficient (Facade)
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind.External wall pressure coefficient
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class ExternalPressureCoefficientFacade 
    {
        /// <summary>
        ///    Calculates External pressure coefficient (GC_p) used in calculation of wind loads on Components and Cladding   - ASCE7-10. USC units
        /// </summary>
        /// <param name="WindWallCladdingZone">  zone of the façade for wind pressure calculation</param>
/// <param name="theta">  angle of plane of roof from horizontal</param>
/// <param name="B">  horizontal dimension of building measured normal to wind direction</param>
/// <param name="L">  horizontal dimension of a building measured parallel to the wind direction</param>
/// <param name="h">  mean roof height of a building or height of other structure</param>
        /// <returns> "Parameter name: GC_p", Parameter description: product of external pressure coefficient and gust-effect factor to be used in determination of wind loads for buildings </returns>

        [MultiReturn(new[] { "GC_p" })]
        public static Dictionary<string, object> ExternalPressureCoefficientFacade_GC_p(string WindWallCladdingZone,double theta,double B,double L,double h)
        {
            //Default values
            double GC_p = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "GC_p", GC_p }
 
            };
        }



    }
}


