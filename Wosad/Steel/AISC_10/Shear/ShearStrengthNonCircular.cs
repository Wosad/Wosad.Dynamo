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
using Wosad.Steel.AISC.AISC360_10.Shear;
using aisc = Wosad.Steel.AISC;
using System;

#endregion

namespace Steel.AISC_10.Shear
{

/// <summary>
///     Shear strength noncircular member
///     Category:   Steel.AISC_10.Shear
/// </summary>
/// 


    public partial class Strength 
    {
        /// <summary>
        ///     Shear strength noncircular member
        /// </summary>
        /// <param name="ShearCase">  Shape type for shear </param>
        /// <param name="F_y">  Specified minimum yield stress </param>
        /// <param name="t_w">  Thickness of web  </param>
        /// <param name="h">  Width of stiffened  element  </param>
        /// <param name="a_s">  Clear distance between transverse stiffeners    </param>
        /// <param name="E">  Modulus of elasticity of steel </param>
        /// <returns name="phiV_n"> Shear strength </returns>

        [MultiReturn(new[] { "phiV_n" })]
        public static Dictionary<string, object> ShearStrengthNonCircular(string ShearCase,double F_y,double t_w,double h,double a,double E)
        {
            //Default values
            double phiV_n = 0;


            //Calculation logic:
            ShearMemberFactory factory = new ShearMemberFactory();

            aisc.ShearCase shearCase;
            bool IsValidString = Enum.TryParse(ShearCase, true, out shearCase);
            if (IsValidString == true)
            {
                IShearMember member = factory.GetShearMemberNonCircular(shearCase,h,t_w,a,F_y);
                phiV_n = member.GetShearStrength();
            }
            else
            {
                throw new Exception("Invalid case selection for non-circular section.");
            }

            return new Dictionary<string, object>
            {
                { "phiV_n", phiV_n }
 
            };
        }


    }
}


