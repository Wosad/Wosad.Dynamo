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
using Dynamo.Nodes;
using Wosad.Steel.AISC.AISC360_10.Connections;
using Wosad.Steel.AISC;
using System;

#endregion

namespace Steel.AISC_10.Connection
{

/// <summary>
///     Eccentrically loaded weld group coefficient
///     Category:   Steel.AISC_10.Connection
/// </summary>
/// 


    public partial class Welded 
    {
            /// <summary>
            ///    Calculates Eccentrically loaded weld group coefficient
            /// </summary>
            /// <param name="WeldGroupPattern">  Weld group pattern type </param>
            /// <param name="l_Weld_horizontal">  Weld group horizontal dimension  </param>
            /// <param name="l_Weld_vertical">  Weld group vertical dimension  </param>
            /// <param name="e_group">  Connection bolt or weld group eccentricity </param>
            /// <param name="theta">  Angle of loading for eccentric bolt or weld group </param>
            /// <param name="w_weld">  Size of weld leg </param>
            /// <param name="F_EXX">  Filler metal classification strength </param>
            /// <returns name="C_WeldGroup"> Coefficient for eccentrically loaded weld group </returns>

        [MultiReturn(new[] { "C_WeldGroup" })]
        public static Dictionary<string, object> FilletWeldGroupCoefficient(string WeldGroupPattern,double l_Weld_horizontal,double l_Weld_vertical,double e_group,
            double theta, double w_weld, double F_EXX)
        {
            //Default values
            double C_WeldGroup = 0;


            //Calculation logic:
            WeldGroupPattern pattern;
            bool IsValidString = Enum.TryParse(WeldGroupPattern, true, out pattern);
            if (IsValidString == true)
            {
                FilletWeldGroup wg = new FilletWeldGroup(pattern, l_Weld_horizontal, l_Weld_vertical, w_weld, F_EXX);
                C_WeldGroup = wg.GetInstantaneousCenterCoefficient(e_group, theta); ;
            }
            else
            {
                throw new Exception("Weld group strength calculation failed. Invalid weld group pattern designation.");
            }


            return new Dictionary<string, object>
            {
                { "C_WeldGroup", C_WeldGroup }
 
            };
        }

    }
}


