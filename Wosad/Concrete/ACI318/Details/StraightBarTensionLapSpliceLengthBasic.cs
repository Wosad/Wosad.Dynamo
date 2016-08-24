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
using Concrete.ACI318.General.Reinforcement;

#endregion

namespace Concrete.ACI318.Details
{

/// <summary>
///     Tension lap splice length Basic
///     Category:   Concrete.ACI318.Details
/// </summary>
/// 


    public partial class LapSplice
    {
        /// <summary>
        ///     Tension lap splice length (basic)
        /// </summary>
        /// <param name="ConcreteMaterial">  Concrete material object used to extract material properties, create the object using input parameters first </param>
        /// <param name="d_b">   Nominal diameter of bar, wire, or prestressing  strand  </param>
        /// <param name="RebarMaterial">   Reinforcement material </param>
        /// <param name="RebarSpliceClass">  Identifies if splice is class A or class B </param>
        /// <param name="RebarCoatingType">  Type of rebar surface coating (epoxy coated or black) </param>
        /// <param name="RebarCastingPosition">  Indicates if rebar is  a horizontal bar placed over 12 in. of concrete. </param>
        /// <param name="ExcessRebarRatio">  Indicates the ration of areas of required reinforcement and provided renforcement. This value must be less than 1 </param>
        /// <param name="MeetsRebarSpacingAndEdgeDistance">  Identifies if clear spacing of bars being developed or lap spliced is at least 2d_b and clear cover at least d_b </param>
        /// <param name="HasMinimumTransverseReinforcement">  Identifies if member meets minimum code requirements for transverse reinforcement. Many current practical construction cases use spacing and cover values along with confining reinforcement, such as stirrups or ties,that result in a value of (cb + Ktr)/db of at least 1.5. See ACI 318-04 section 25.4.2.2  </param>
        /// <returns name="l_st">  Tension lap splice length  </returns>

        [MultiReturn(new[] { "l_st" })]
        public static Dictionary<string, object> StraightBarTensionLapSpliceLengthBasic(Concrete.ACI318.General.Concrete.ConcreteMaterial ConcreteMaterial, double d_b,
            RebarMaterial RebarMaterial, string RebarSpliceClass, string RebarCoatingType, string RebarCastingPosition, double ExcessRebarRatio, bool MeetsRebarSpacingAndEdgeDistance, bool HasMinimumTransverseReinforcement)
        {
            //Default values
            double l_st = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "l_st", l_st }
 
            };
        }



    }
}


