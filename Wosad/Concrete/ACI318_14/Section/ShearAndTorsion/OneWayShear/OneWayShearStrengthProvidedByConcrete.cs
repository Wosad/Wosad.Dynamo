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
using Concrete.ACI318_14.General;
using Wosad.Concrete.ACI318_14;
using Concrete.ACI318_14.General;
using Concrete.ACI318_14.General.Reinforcement;

#endregion

namespace Concrete.ACI318_14.Section.OneWayShear
{

/// <summary>
///     One way concrete shear strength
///     Category:   Concrete.ACI318_14.Section.ShearAndTorsion
/// </summary>
/// 


   
    public partial class NonPrestressed 
    {
        /// <summary>
        ///     One way  shear strength provided by concrete
        /// </summary>
        /// <param name="ConcreteSection">  Reinforced concrete section </param>
        /// <param name="d">   Distance from extreme compression fiber to centroid  of longitudinal tension reinforcement  </param>
        /// <param name="h">   Overall thickness, height, or depth of member  </param>
        /// <param name="N_u">   Factored axial force normal to cross section occurring simultaneously with vu or tu; to be taken as  positive for compression and negative for tension  </param>
        /// <param name="rho_w">   Ratio of A_s /( b_w*d) </param>
        /// <param name="M_u">   Factored moment at section   </param>
        /// <param name="V_u">   Factored shear force at section  </param>
        /// <returns name="phiV_c">  Design shear strength provided by concrete  </returns>

        [MultiReturn(new[] { "phiV_c" })]
        public static Dictionary<string, object> OneWayShearStrengthProvidedByConcrete(ConcreteSection ConcreteSection, RebarMaterial material, double d, double h, double N_u, double rho_w = 0, double M_u = 0, double V_u = 0)
        {
            //Default values
            double phiV_c = 0;


            //Calculation logic:

            ConcreteSectionOneWayShearNonPrestressed s = new ConcreteSectionOneWayShearNonPrestressed(d, ConcreteSection.Section, material.Material, ConcreteSection.A_tr, ConcreteSection.s);
            phiV_c=s.GetConcreteShearStrength();
            
            return new Dictionary<string, object>
            {
                { "phiV_c", phiV_c }
 
            };
        }



    }
}


