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
///     Maximum transverse rebar spacing
///     Category:   Concrete.ACI318_14.Section.ShearAndTorsion
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class OneWayShear 
    {
/// <summary>
///     Maximum transverse rebar spacing
/// </summary>
        /// <param name="b_w">   Web width or diameter of circular section  </param>
/// <param name="d">   Distance from extreme compression fiber to centroid  of longitudinal tension reinforcement  </param>
/// <param name="f_c_prime">   Specified compressive strength of concrete  </param>

        /// <returns name="s_max">  Maximum center-to-center spacing of  transverse reinforcement </returns>

        [MultiReturn(new[] { "s_max" })]
        public static Dictionary<string, object> MaximumTransverseRebarSpacing(double b_w,double d,double f_c_prime)
        {
            //Default values
             s_max = 


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "s_max", s_max }
 
            };
        }


        //internal OneWayShear (double b_w,double d,double f_c_prime)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static OneWayShear  ByInputParameters(double b_w,double d,double f_c_prime)
        //{
        //    return new OneWayShear(b_w ,d ,f_c_prime );
        //}

    }
}


