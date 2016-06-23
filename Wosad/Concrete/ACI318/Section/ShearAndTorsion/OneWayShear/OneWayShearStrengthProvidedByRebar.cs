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

namespace Concrete.ACI318.Section.OneWayShear
{

/// <summary>
///     One way rebar shear strength
///     Category:   Concrete.ACI318_14.Section.ShearAndTorsion
/// </summary>
/// 



    public partial class NonPrestressed 
    {
        /// <summary>
        ///     One way  shear strength provided by rebar
        /// </summary>
        /// <param name="A_v">   Area of shear reinforcement within spacing s  </param>
        /// <param name="f_yt">   Specified yield strength of transverse reinforcement  </param>
        /// <param name="d">   Distance from extreme compression fiber to centroid  of longitudinal tension reinforcement  </param>
        /// <param name="s">   Center-to-center spacing of items, such as longitudinal reinforcement, transverse reinforcement,  tendons, or anchors  </param>
        /// <param name="Code"> Applicable version of code/standard</param>
        /// <returns name="phiV_s">  Design shear strength provided by shear reinforcement  </returns>

        [MultiReturn(new[] { "phiV_s" })]
        public static Dictionary<string, object> OneWayShearStrengthProvidedByRebar(double A_v, double f_yt, double d, double s, string Code = "ACI318-14")
        {
            //Default values
            double phiV_s = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiV_s", phiV_s }
 
            };
        }

    }
}


