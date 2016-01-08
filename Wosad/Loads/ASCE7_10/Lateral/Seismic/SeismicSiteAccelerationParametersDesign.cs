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
    ///     Seismic site acceleration parameters (design)
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Seismic
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class SeismicSiteAccelerationParametersDesign 
    {
        /// <summary>
        ///    Calculates Adjusted spectral response acceleration parameters (S_DS and S_D1) used in design - ASCE7-10
        /// </summary>
        /// <param name="S_S">  mapped MCER, 5 percent damped, spectral response acceleration parameter at short periods</param>
/// <param name="S_1">  mapped MCER, 5 percent damped, spectral response acceleration parameter at a period of 1 s</param>
/// <param name="T_L">  long-period transition period</param>
        /// <returns> design, 5 percent damped, spectral response acceleration parameter at short periods </returns>
/// <returns>  design, 5 percent damped, spectral response acceleration parameter at a period of 1 s </returns>


        [MultiReturn(new[] { "S_DS","S_D1" })]
        public static Dictionary<string, object> SeismicSiteCoefficients(double S_S,double S_1,double T_L)
        {
            //Default values
            double S_DS = 0;
double S_D1 = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "S_DS", S_DS }
,{ "S_D1", S_D1 }
 
            };
        }



    }
}


