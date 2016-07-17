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
using System;

#endregion

namespace Wood.NDS
{

/// <summary>
///     ReferenceValues
///     Category:   Wood.NDS
/// </summary>
/// 



    public partial class General
    {
    /// <summary>
    ///     ReferenceValues
    /// </summary>
    /// <param name="WooodSpecies">  Identifies  wood species </param>
    /// <param name="WoodCommercialGrade">  Identifies commercial grade of wood being considered </param>
    /// <param name="WoodMemberType">  Distinguishes between dimensional lumber, timber,glulam etc. </param>
    /// <param name="Code">  Identifies the code or standard used for calculations </param>
    /// <returns name="F_b"> Reference bending design value  </returns>
    /// <returns name="F_c"> Out-of-plane seismic forces for concrete and masonry walls  </returns>
    /// <returns name="F_t"> Reference tension design value parallel to grain  </returns>
    /// <returns name="F_v"> Velocity-based seismic site coefficient at 1.0 second period </returns>
    /// <returns name="E"> Modulus of elasticity  </returns>
    /// <returns name="E_min"> Reference modulus of elasticity for stability calculations  </returns>
    /// <returns name="F_cPerp"> Reference compression design value perpendicular to grain  </returns>

        [MultiReturn(new[] { "F_b","F_c","F_t","F_v","E","E_min","F_cPerp" })]
        public static Dictionary<string, object> ReferenceValues(string WooodSpecies,string WoodCommercialGrade,string WoodMemberType,
            string Code = "NDS2015")
        {
            //Default values
            double F_b = 0;
            double F_c = 0;
            double F_t = 0;
            double F_v = 0;
            double E = 0;
            double E_min = 0;
            double F_cPerp = 0;


            //Calculation logic:
            if (WoodMemberType.Contains("Sawn") && WoodMemberType.Contains("Lumber"))
            {

            }
            else
            {
                throw new Exception("Wood member type not supported.");
            }

            return new Dictionary<string, object>
                        {
                            { "F_b", F_b }
            ,{ "F_c", F_c }
            ,{ "F_t", F_t }
            ,{ "F_v", F_v }
            ,{ "E", E }
            ,{ "E_min", E_min }
            ,{ "F_cPerp", F_cPerp }
 
                        };
                    }



    }
}

