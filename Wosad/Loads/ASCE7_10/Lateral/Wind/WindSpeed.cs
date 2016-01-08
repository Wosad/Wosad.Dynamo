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

namespace Loads.ASCE7_10.Lateral.Wind
{
    /// <summary>
    ///     Wind speed
    ///     Category:   Wosad.Loads.ASCE7-10.Lateral.Wind
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class WindSpeed 
    {
        /// <summary>
        ///    Calculates Basic wind speed (V) as a function of building location. (mph) - ASCE7-10
        /// </summary>
        /// <param name="Latitude">  Location latitude</param>
/// <param name="Longitude">  Location longitude</param>
        /// <returns> "Parameter name: V", Parameter description: basic wind speed </returns>

        [MultiReturn(new[] { "V" })]
        public static Dictionary<string, object> WindSpeed_V(double Latitude,double Longitude)
        {
            //Default values
            double V = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "V", V }
 
            };
        }



    }
}


