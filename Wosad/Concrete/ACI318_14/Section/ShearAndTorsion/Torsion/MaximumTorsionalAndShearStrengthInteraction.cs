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

namespace Concrete.ACI318_14.Section.ShearAndTorsion
{

/// <summary>
///     Maximum torsional and shear strength interaction
///     Category:   Concrete.ACI318_14.Section.ShearAndTorsion
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Torsion 
    {
/// <summary>
///     Maximum torsional and shear strength interaction
/// </summary>
        /// <param name="V_u">   Factored shear force at section  </param>
/// <param name="T_u">   Factored torsional moment at section   </param>
/// <param name="V_c">   Nominal shear strength provided by concrete  </param>
/// <param name="b_w">   Web width or diameter of circular section  </param>
/// <param name="d">   Distance from extreme compression fiber to centroid  of longitudinal tension reinforcement  </param>
/// <param name="A_oh">   Area enclosed by centerline of the outermost closed  transverse torsional reinforcement  </param>
/// <param name="p_h">   Perimeter of centerline of outermost closed transverse torsional reinforcement  </param>
/// <param name="f_c_prime">   Specified compressive strength of concrete  </param>

        /// <returns name="InteractionRatio"> Interaction ratio indicating demand to capacity for a given criterion. Values over 1.0 indicate failure to meet one ore more criteria </returns>

        [MultiReturn(new[] { "InteractionRatio" })]
        public static Dictionary<string, object> MaximumTorsionalAndShearStrengthInteraction(double V_u,double T_u,double V_c,double b_w,double d,double A_oh,double p_h,double f_c_prime)
        {
            //Default values
            double InteractionRatio = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "InteractionRatio", InteractionRatio }
 
            };
        }


        //internal Torsion (double V_u,double T_u,double V_c,double b_w,double d,double A_oh,double p_h,double f_c_prime)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Torsion  ByInputParameters(double V_u,double T_u,double V_c,double b_w,double d,double A_oh,double p_h,double f_c_prime)
        //{
        //    return new Torsion(V_u ,T_u ,V_c ,b_w ,d ,A_oh ,p_h ,f_c_prime );
        //}

    }
}


