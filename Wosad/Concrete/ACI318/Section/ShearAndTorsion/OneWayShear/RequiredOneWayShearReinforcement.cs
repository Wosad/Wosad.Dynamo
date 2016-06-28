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
///     Required one way shear reinforcement
///     Category:   Concrete.ACI318_14.Section.ShearAndTorsion
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class OneWayShear 
    {
/// <summary>
///     Required one way shear reinforcement
/// </summary>
        /// <param name="V_u">   Factored shear force at section  </param>
/// <param name="phiV_c">   Design shear strength provided by concrete  </param>
/// <param name="s">   Center-to-center spacing of items, such as longitudinal reinforcement, transverse reinforcement,  tendons, or anchors  </param>

        /// <returns name="A_v">  Area of shear reinforcement within spacing s  </returns>

        [MultiReturn(new[] { "A_v" })]
        public static Dictionary<string, object> RequiredOneWayShearReinforcement(double V_u,double phiV_c,double s)
        {
            //Default values
            double A_v = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "A_v", A_v }
 
            };
        }


        //internal OneWayShear (double V_u,double phiV_c,double s)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static OneWayShear  ByInputParameters(double V_u,double phiV_c,double s)
        //{
        //    return new OneWayShear(V_u ,phiV_c ,s );
        //}

    }
}

