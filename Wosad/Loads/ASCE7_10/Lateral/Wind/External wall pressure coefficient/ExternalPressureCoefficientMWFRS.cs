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
    ///     External pressure coefficient (MWFRS)
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind.External wall pressure coefficient
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class ExternalPressureCoefficientMWFRS 
    {
        /// <summary>
        ///    Calculates External pressure coefficient (C_p) used in calculation of wind loads on Main Wind-Force Resisting System (MWFRS) elements - ASCE7-10. USC units
        /// </summary>
        /// <param name="B">  horizontal dimension of building measured normal to wind direction /param>

        /// <returns> "Parameter name: C_p", Parameter description: external pressure coefficient to be used in determination of wind loads for buildings </returns>

        /// 
        [MultiReturn(new[] { "C_p" })]
        public static Dictionary<string, object> ExternalPressureCoefficientMWFRS_C_p(double B)
        {
            //Default values
            double C_p = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "C_p", C_p }
 
            };
        }



    }
}


