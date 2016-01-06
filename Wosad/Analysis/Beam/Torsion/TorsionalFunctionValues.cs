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
using Wosad.Analysis.Torsion;

#endregion

namespace Analysis.Beam.Torsion
{

/// <summary>
///     Torsional function values
///     Category:   Analysis.Beam.Torsion
/// </summary>
/// 


    public partial class BeamAnalysis 
    {
            /// <summary>
            ///    Calculates Evaluation of torsional functions 
            /// </summary>
            /// <param name="TorsionalFunctionCaseId">  Case ID used in calculation of the values of torsional functions (per AISC design guide 9) </param>
            /// <param name="E">  Modulus of elasticity </param>
            /// <param name="G">  Shear modulus of elasticity </param>
            /// <param name="J">  Torsional constant for the cross-section </param>
            /// <param name="L">  member span length </param>
            /// <param name="z">  Distance from left support </param>
            /// <param name="T">  Concentrated torque </param>
            /// <param name="C_w">  Warping constant for the cross-section </param>
            /// <param name="t">  Uniformly distributed torque </param>
            /// <param name="alpha">  Fraction of total span at the point of concentrated torque </param>
            /// <returns name="theta"> Angle of rotation </returns>
            /// <returns name="theta_1der"> First derivative of angle of rotation with respect to z </returns>
            /// <returns name="theta_2der"> Second derivative of angle of rotation with respect to z </returns>
            /// <returns name="theta_3der"> Third derivative of angle of rotation with respect to z </returns>

        [MultiReturn(new[] { "theta","theta_1der","theta_2der","theta_3der" })]
        public static Dictionary<string, object> TorsionalFunctionValues(string TorsionalFunctionCaseId,double E, double G,double J,double L,double z,double T,double C_w,double t,double alpha)
        {
            //Default values
            double theta = 0;
            double theta_1der = 0;
            double theta_2der = 0;
            double theta_3der = 0;


            //Calculation logic:
            TorsionalFunctionFactory tf = new TorsionalFunctionFactory();
            ITorsionalFunction function = tf.GetTorsionalFunction(TorsionalFunctionCase.Case3, E, G, J, L, z, T, C_w, t, alpha);
            theta_1der = function.Get_theta_1();
            theta_2der = function.Get_theta_1();
            theta_3der = function.Get_theta_1();

            return new Dictionary<string, object>
            {
                { "theta", theta }
                ,{ "theta_1der", theta_1der }
                ,{ "theta_2der", theta_2der }
                ,{ "theta_3der", theta_3der }
 
            };
        }


    }
}


