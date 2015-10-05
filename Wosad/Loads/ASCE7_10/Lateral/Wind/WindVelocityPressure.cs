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
    ///     Wind velocity pressure
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class WindVelocityPressure 
    {
        /// <summary>
        ///    Calculates Velocity pressure (q_z), evaluated at height z accounting for the basic wind pressure prior to adjustment by the building –specific aerodynamic and dynamic factors - ASCE7-10. USC units
        /// </summary>
        /// <param name="V">  basic wind speed /param>
/// <param name="WindVelocityLocation">  Location type for wind velocity used in pressure calculations /param>

        /// <returns> "Parameter name: q_z", Parameter description: velocity pressure evaluated at height z above ground </returns>

        /// 
        [MultiReturn(new[] { "q_z" })]
        public static Dictionary<string, object> WindVelocityPressure_q_z(double V,string WindVelocityLocation)
        {
            //Default values
            double q_z = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "q_z", q_z }
 
            };
        }



    }
}


