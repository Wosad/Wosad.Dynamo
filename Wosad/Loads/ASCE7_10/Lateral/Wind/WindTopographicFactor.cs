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
    ///     Wind topographic factor
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class WindTopographicFactor 
    {
        /// <summary>
        ///    Calculates Wind topographic factor (K_zt) accounting for the effects of wind speed-up over hills, ridges, and escarpments - ASCE7-10. USC units
        /// </summary>
        /// <param name="x">  distance upwind or downwind of crest /param>
/// <param name="z">  height above ground level /param>
/// <param name="H">  height of hill or escarpment /param>
/// <param name="L_h">  distance upwind of crest of hill or escarpment to where the difference in ground elevation is half the height of the hill or escarpment /param>
/// <param name="TopographicLocation">  Location on the topographic feature (upwind of crest, downwind of crest) /param>
/// <param name="TopographyType">  type of topographic feature (two-dimensional ridge,two-dimensional ecarpment or 3-dimensional axisymmetric hill) /param>

        /// <returns> "Parameter name: K_zt", Parameter description: topographic factor </returns>

        /// 
        [MultiReturn(new[] { "K_zt" })]
        public static Dictionary<string, object> WindTopographicFactor_K_zt(double x,double z,double H,double L_h,string TopographicLocation,string TopographyType)
        {
            //Default values
            double K_zt = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "K_zt", K_zt }
 
            };
        }



    }
}


