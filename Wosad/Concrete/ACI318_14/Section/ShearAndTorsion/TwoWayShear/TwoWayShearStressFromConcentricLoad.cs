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
///     Two way shear  stress from concentric  load
///     Category:   Concrete.ACI318_14.Section.ShearAndTorsion
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class TwoWayShear 
    {
/// <summary>
///     Two way shear  stress from concentric  load
/// </summary>
        /// <param name="V_u">   Factored shear force at section  </param>
/// <param name="PunchingShearPerimeter">  Punching shear (two-way shear) perimeter object. Create the object using input parameters first </param>

        /// <returns name="v_u">  Maximum factored two-way shear stress calculated  around the perimeter of a given critical section  </returns>

        [MultiReturn(new[] { "v_u" })]
        public static Dictionary<string, object> TwoWayShearStressFromConcentricLoad(double V_u,PunchingShearPerimeter PunchingShearPerimeter)
        {
            //Default values
            double v_u = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "v_u", v_u }
 
            };
        }


        //internal TwoWayShear (double V_u,PunchingShearPerimeter PunchingShearPerimeter)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static TwoWayShear  ByInputParameters(double V_u,PunchingShearPerimeter PunchingShearPerimeter)
        //{
        //    return new TwoWayShear(V_u ,PunchingShearPerimeter );
        //}

    }
}


