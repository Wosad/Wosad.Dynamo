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

namespace Steel.AISC_10.Connection
{

/// <summary>
///     Concentrated force web local crippling 
///     Category:   Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class AffectedElements 
    {
/// <summary>
///    Calculates Concentrated force web local crippling 
/// </summary>
        /// <param name="t_w">  Thickness of web  </param>
/// <param name="t_f">  Thickness of flange   </param>
/// <param name="l_b">  Length of bearing   </param>
/// <param name="d">  Full nominal depth of the section    </param>
/// <param name="F_u">  Specified minimum tensile strength   </param>
/// <param name="E">  Modulus of elasticity of steel </param>

        /// <returns name="phiR_n"> Strength of member or connection </returns>

        [MultiReturn(new[] { "phiR_n" })]
        public static Dictionary<string, object> WebLocalCrippling(double t_w,double t_f,double l_b,double d,double F_u,double E)
        {
            //Default values
            double phiR_n = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_n", phiR_n }
 
            };
        }


        //internal AffectedElements (double t_w,double t_f,double l_b,double d,double F_u,double E)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static AffectedElements  ByInputParameters(double t_w,double t_f,double l_b,double d,double F_u,double E)
        //{
        //    return new AffectedElements(t_w ,t_f ,l_b ,d ,F_u ,E );
        //}

    }
}


