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

#endregion

namespace Steel.AISC_10.Flexure
{

/// <summary>
///     Flexural lateral-torsional buckling
///     Category:   Steel.AISC_10.Flexure
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Strength 
    {
/// <summary>
///    Calculates Flexural lateral-torsional buckling
/// </summary>
        /// <param name="E">  Modulus of elasticity of steel </param>
/// <param name="G">  Shear modulus of elasticity of steel </param>
/// <param name="I_y">  Moment of inertia about the principal y-axis  </param>
/// <param name="C_w">  Warping constant </param>
/// <param name="L_b">  Length between points that are either braced against lateral displacement of compression flange or braced against twist of the cross section   </param>
/// <param name="SteelShapeGroupFlexure">  Type of steel shape for flexural calculations </param>

        /// <returns name="phiM_n"> Moment strength </returns>

        [MultiReturn(new[] { "phiM_n" })]
        public static Dictionary<string, object> FlexuralLateralTorsionalBucklingStrength(double E,double G,double I_y,double C_w,double L_b,string SteelShapeGroupFlexure)
        {
            //Default values
            double phiM_n = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiM_n", phiM_n }
 
            };
        }


        //internal Strength (double E,double G,double I_y,double C_w,double L_b,string SteelShapeGroupFlexure)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Strength  ByInputParameters(double E,double G,double I_y,double C_w,double L_b,string SteelShapeGroupFlexure)
        //{
        //    return new Strength(E ,G ,I_y ,C_w ,L_b ,SteelShapeGroupFlexure );
        //}

    }
}


