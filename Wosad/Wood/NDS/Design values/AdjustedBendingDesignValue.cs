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
using Wosad.Wood.NDS.NDS2015;
using System;

#endregion

namespace Wood.NDS
{

/// <summary>
///     Adjusted bending design value
///     Category:   Wood.NDS
/// </summary>
/// 


    public partial class DesignValues
    {
        /// <summary>
        ///     Adjusted bending design value
        /// </summary>
        /// <param name="F_b">  Reference bending design value  </param>
        /// <param name="C_M">  Wet service factor </param>
        /// <param name="C_t">  Temperature factor </param>
        /// <param name="C_L">  Beam stability factor </param>
        /// <param name="C_F">  Size factor </param>
        /// <param name="C_fu">  Flat use factor for bending design values </param>
        /// <param name="C_i">  Incising factor for dimension lumber </param>
        /// <param name="C_r">  Repetitive-member factor for bending design values </param>
        /// <param name="lambda">  Time effect factor  </param>
        /// <param name="WoodMemberType">  Distinguishes between dimensional lumber, timber,glulam etc. </param>
        /// <param name="Code">  Identifies the code or standard used for calculations </param>
        /// <returns name="F_b_prime"> Adjusted bending design value  </returns>

        [MultiReturn(new[] { "F_b_prime" })]
        public static Dictionary<string, object> AdjustedBendingDesignValue(double F_b,double C_M,double C_t,double C_L,double C_F,
            double C_fu, double C_i, double C_r, double lambda, string WoodMemberType = "SawnDimensionLumber", string Code = "NDS2015")
        {
            //Default values
            double F_b_prime = 0;


            //Calculation logic:
            if (WoodMemberType.Contains("Sawn") && WoodMemberType.Contains("Lumber"))
            {
                DimensionalLumber m = new DimensionalLumber();
                F_b_prime = m.GetAdjustedBendingDesignValue(F_b, C_M, C_t, C_L, C_F, C_fu, C_i, C_r, lambda);
            }
            else
            {
                throw new Exception("Wood member type not supported.");
            }

            
            

            return new Dictionary<string, object>
            {
                { "F_b_prime", F_b_prime }
 
            };
        }


    }
}


