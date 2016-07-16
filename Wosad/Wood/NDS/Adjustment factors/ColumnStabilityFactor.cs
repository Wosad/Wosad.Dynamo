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
///     Column stability factor
///     Category:   Wood.NDS
/// </summary>
/// 



    public partial class AdjustmentFactor 
    {
        /// <summary>
        ///     Column stability factor
        /// </summary>
        /// <param name="d_comp">  Cross-sectional dimension of rectangular column associated with axis of column buckling  </param>
        /// <param name="F_c">  Out-of-plane seismic forces for concrete and masonry walls  </param>
        /// <param name="E_min">  Reference modulus of elasticity for stability calculations  </param>
        /// <param name="l_e">  Effective unbraced length of column  </param>
        /// <param name="C_M_Fc">  Wet service factor for adjusted compression value </param>
        /// <param name="C_M_E">  Wet service factor for modulus of elasticity E and minimum modulus of elasticity E_min </param>
        /// <param name="C_t">  Temperature factor </param>
        /// <param name="C_F">  Size factor </param>
        /// <param name="C_i">  Incising factor for dimension lumber </param>
        /// <param name="C_T">  Buckling stiffness factor for increased chord stiffness relative to axial loads where a 2" x 4" or smaller sawn lumber truss compression chord is subjected to combined flexure and axial compression under dry service condition and  has 3/8" or thicker plywood sheathing nailed to the narrow face of the chord </param>
        /// <param name="lambda">  Time effect factor  </param>
        /// <param name="WoodMemberType">  Distinguishes between dimensional lumber, timber,glulam etc. </param>
        /// <param name="Code">  Identifies the code or standard used for calculations </param>
        /// <returns name="C_P"> Column stability factor </returns>

        [MultiReturn(new[] { "C_P" })]
        public static Dictionary<string, object> ColumnStabilityFactor(double d_comp,double F_c,double E_min,double l_e,double C_M_Fc,double C_M_E,double C_F,double lambda,
            double C_t = 1, double C_i = 1, double C_T = 1, string WoodMemberType = "SawnDimensionLumber", string Code = "NDS2015")
        {
            //Default values
            double C_P = 0;


            //Calculation logic:
            if (WoodMemberType.Contains("Sawn") && WoodMemberType.Contains("Lumber"))
            {
                DimensionalLumber m = new DimensionalLumber();
                C_P = m.GetColumnStabilityFactor(d_comp, F_c, E_min, l_e, C_M_Fc, C_M_E, C_t, C_F, C_i, C_T, lambda);
            }
            else
	        {
                throw new Exception("Wood member type not supported.");
	        }

            return new Dictionary<string, object>
            {
                { "C_P", C_P }
 
            };
        }


    }
}


