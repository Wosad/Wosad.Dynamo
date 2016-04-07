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
///     Total two way shear stress
///     Category:   Concrete.ACI318_14.Section.ShearAndTorsion
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class TwoWayShear 
    {
/// <summary>
///     Total two way shear stress
/// </summary>
        /// <param name="v_uc">   Maximum factored two-way shear stress due to effects of concentricload calculated  at the perimeter of a given critical section  </param>
/// <param name="v_um">   Maximum factored two-way shear stress due to effects of moment calculated  at the perimeter of a given critical section  </param>

        /// <returns name="v_u">  Maximum factored two-way shear stress calculated  around the perimeter of a given critical section  </returns>

        [MultiReturn(new[] { "v_u" })]
        public static Dictionary<string, object> TotalTwoWayShearStress(double v_uc,double v_um)
        {
            //Default values
            double v_u = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "v_u", v_u }
 
            };
        }


        //internal TwoWayShear (double v_uc,double v_um)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static TwoWayShear  ByInputParameters(double v_uc,double v_um)
        //{
        //    return new TwoWayShear(v_uc ,v_um );
        //}

    }
}


