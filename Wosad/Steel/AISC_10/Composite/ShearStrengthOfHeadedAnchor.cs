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
using Wosad.Steel.AISC.AISC360_10.Composite;

#endregion

namespace Wosad.Steel.AISC_10.Composite
{

/// <summary>
///     Shear strength of headed anchor
///     Category:   Wosad.Steel.AISC_10.Composite
/// </summary>
/// 


    public partial class Anchor 
    {
        /// <summary>
        ///    Calculates Shear strength of headed  anchor
        /// </summary>
        /// <param name="d_sa">  Headed anchor diameter </param>
        /// <param name="R_g">  Coefficient to account for group effect   </param>
        /// <param name="R_p">  Position effect factor for shear anchors   </param>
        /// <param name="fc_prime">  Specified compressive strength of concrete   </param>
        /// <param name="w_c">  Weight of concrete per unit volume (pcf)   </param>
        /// <param name="F_u">  Specified minimum tensile strength   </param>
        /// <returns name="Q_n"> Nominal strength of one steel headed stud or steel channel anchor  </returns>
        /// <returns name="phiQ_n"> Strength of one steel headed stud or steel channel anchor   </returns>

        [MultiReturn(new[] { "Q_n" })]
        public static Dictionary<string, object> ShearStrengthOfHeadedAnchor(double d_sa,double R_g,double R_p,double fc_prime, double w_c, double F_u=65)
        {
            //Default values
            double Q_n = 0;
            double phiQ_n = 0;

            //Calculation logic:
            HeadedAnchor a = new HeadedAnchor();
            Q_n =a.GetNominalShearStrength(d_sa,R_g,R_p,fc_prime,F_u,w_c);
            phiQ_n = a.GetShearStrength(d_sa, R_g, R_p, fc_prime, F_u,w_c);

            return new Dictionary<string, object>
            {
                { "Q_n", Q_n },
                { "phiQ_n", phiQ_n }
 
            };
        }


        //internal Anchor (double d_sa,double R_g,double R_p,double fc_prime,double F_u)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Anchor  ByInputParameters(double d_sa,double R_g,double R_p,double fc_prime,double F_u)
        //{
        //    return new Anchor(d_sa ,R_g ,R_p ,fc_prime ,F_u );
        //}

    }
}


