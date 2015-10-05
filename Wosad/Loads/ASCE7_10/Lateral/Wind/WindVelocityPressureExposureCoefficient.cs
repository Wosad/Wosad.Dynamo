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
    ///     Wind velocity pressure exposure coefficient
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class WindVelocityPressureExposureCoefficient 
    {
        /// <summary>
        ///    Calculates Velocity pressure exposure coefficient ( K_z or K_h) accounting for the wind pressure variation as a function of  height - ASCE7-10. USC units
        /// </summary>
        /// <param name="z">  height above ground level /param>
/// <param name="z_g">  nominal height of the atmospheric boundary layer used in this standard /param>
/// <param name="alpha">  3-sec gust-speed power law exponent /param>
/// <param name="WindVelocityLocation">  Location type for wind velocity used in pressure calculations /param>

        /// <returns> "Parameter name: K_z", Parameter description: velocity pressure exposure coefficient evaluated at height z=h </returns>

        /// 
        [MultiReturn(new[] { "K_z" })]
        public static Dictionary<string, object> WindVelocityPressureExposureCoefficient_K_z(double z,double z_g,double alpha,string WindVelocityLocation)
        {
            //Default values
            double K_z = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "K_z", K_z }
 
            };
        }



    }
}


