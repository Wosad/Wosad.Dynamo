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
using Dynamo.Graph.Nodes;
using Analysis.Section;
using Wosad.Steel.AISC.SteelEntities.Materials;
using Wosad.Steel.AISC.AISC360v10.Flexure;
using System;
using Wosad.Common.Entities;
using Wosad.Common.Section.Interfaces;
using Wosad.Steel.AISC.SteelEntities;
using Wosad.Steel.AISC.Interfaces;

#endregion

namespace Steel.AISC10
{

/// <summary>
///     Limiting length for flexural yielding
///     Category:   Steel.AISC10
/// </summary>
/// 



    public partial class Flexure 
    {
        /// <summary>
        ///     Limiting length for flexural yielding
        /// </summary>
        /// <param name="Shape">  Shape object   </param>
        /// <param name="F_y">  Specified minimum yield stress </param>
        /// <param name="BendingAxis">  Distinguishes between bending with respect to section x-axis vs x-axis </param>
        /// <param name="FlexuralCompressionLocation">  Identifies whether top or bottom fiber of the section are subject to flexural compression (depending on the sign of moment) </param>
        /// <param name="E">  Modulus of elasticity of steel </param>
        /// <param name="IsRolledMember">  Identifies if member is rolled or built up from individual plates or shapes </param>
        /// <returns name="L_p"> Limiting length for flexural yielding </returns>
        /// <returns name="IsApplicable"> Identifies whether the selected limit state is applicable </returns>

        [MultiReturn(new[] { "L_p","IsApplicable" })]
        public static Dictionary<string, object> LimitingLengthForFlexuralYielding(CustomProfile Shape, double F_y, string BendingAxis="XAxis", string FlexuralCompressionLocation="Top", 
            double E = 29000, bool IsRolledMember = true)
        {
            //Default values
            double L_pValue = 0;
            bool IsApplicable = false;


            //Calculation logic:

            MomentAxis Axis;
            //Calculation logic:
            bool IsValidStringAxis = Enum.TryParse(BendingAxis, true, out Axis);
            if (IsValidStringAxis == false)
            {
                throw new Exception("Axis selection not recognized. Check input string.");
            }

            FlexuralCompressionFiberPosition FlexuralCompression;
            //Calculation logic:
            bool IsValidStringCompressionLoc = Enum.TryParse(FlexuralCompressionLocation, true, out FlexuralCompression);
            if (IsValidStringCompressionLoc == false)
            {
                throw new Exception("Flexural compression location selection not recognized. Check input string.");
            }


            SteelMaterial mat = new SteelMaterial(F_y, E);
            FlexuralMemberFactory factory = new FlexuralMemberFactory();
            ISteelBeamFlexure beam = factory.GetBeam(Shape.Section, mat, null, Axis, FlexuralCompression, IsRolledMember);

            SteelLimitStateValue L_p =
            beam.GetLimitingLengthForFullYielding_Lp(FlexuralCompression);
            L_pValue = L_p.Value;

            IsApplicable = L_p.IsApplicable;

            IsApplicable = L_p.IsApplicable;

            return new Dictionary<string, object>
            {
                { "L_p", L_pValue }
                ,{ "IsApplicable", IsApplicable }
 
            };
        }



    }
}


