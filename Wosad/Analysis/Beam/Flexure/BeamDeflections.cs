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

namespace Analysis.Beam.Flexure
{

/// <summary>
///     Beam deflections
///     Category:   Analysis.Beam.Flexure
/// </summary>
/// 


    public partial class BeamAnalysis 
    {
            /// <summary>
            ///    Calculates Calculation of beam deflections
            /// </summary>
            /// <param name="L">  member span length </param>
            /// <param name="X">  Distance from left support </param>
            /// <param name="P">  Concentrated load in beam, or axial load in compression member </param>
            /// <param name="M">  Concentrated moment </param>
            /// <param name="w">  Uniformly distributed load </param>
            /// <param name="a_load">  Load offset dimension </param>
            /// <param name="b_load">  Load offset dimension </param>
            /// <param name="c_load">  Load offset dimension </param>
            /// <param name="P1">  Concentrated load 1, when multiple point loads are present </param>
            /// <param name="P2">  Concentrated load 2, when multiple point loads are present </param>
            /// <param name="M1">  Concentrated moment 1, when multiple point moments are applied </param>
            /// <param name="M2">  Concentrated moment 2, when multiple point moments are applied </param>
            /// <param name="E">  Modulus of elasticity of steel </param>
            /// <param name="I">  Moment of inertia (I_x or I_y where applicable) </param>
            /// <returns name="Delta_x"> Deflection at point X </returns>

        [MultiReturn(new[] { "Delta_x" })]
        public static Dictionary<string, object> BeamDeflections(double L,double X,double P,double M,double w,double a_load,double b_load,double c_load,double P1,double P2,double M1,double M2,double E,double I)
        {
            //Default values
            double Delta_x = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "Delta_x", Delta_x }
 
            };
        }




    }
}


