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

namespace Loads.ASCE7_10.Lateral.Seismic
{
    /// <summary>
    ///     Seismic fundamental period upper  limit coefficient
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class SeismicFundamentalPeriodUpperLimitCoefficient 
    {
        /// <summary>
        ///    Calculates Coefficient  (C_u) for upper limit on  calculated period  - ASCE7-10
        /// </summary>
        /// <param name="S_D1">  design, 5 percent damped, spectral response acceleration parameter at a period of 1 s /param>

        /// <returns> "Parameter name: C_u", Parameter description: Coefficient for upper limit on  calculated period </returns>

        /// 
        [MultiReturn(new[] { "C_u" })]
        public static Dictionary<string, object> SeismicFundamentalPeriodUpperLimitCoefficient_C_u(double S_D1)
        {
            //Default values
            double C_u = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "C_u", C_u }
 
            };
        }



    }
}


