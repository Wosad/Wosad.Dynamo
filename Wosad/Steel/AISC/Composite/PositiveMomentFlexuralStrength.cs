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
using Wosad.Steel.AISC.AISC360v10.Composite;
using Analysis.Section;
using Wosad.Common.Section.Interfaces;
using System;

#endregion

namespace Steel.AISC.Composite
{

/// <summary>
///     Positive moment flexural strength 
///     Category:   Wosad.Steel.AISC_10.Composite
/// </summary>
/// 


    public partial class Flexure 
    {
        /// <summary>
        ///    Calculates Positive moment flexural strength for composite beam
        /// </summary>
        /// <param name="Shape">  Steel shape instance (must be of CompositeSteelShape type) </param>
        /// <param name="b_eff">  Effective width of concrete slab in composite beam design </param>
        /// <param name="h_solid">  Depth of solid portion of concrete slab on metal deck (fill above deck) </param>
        /// <param name="h_rib">  Depth of ribs for corrugated metal deck </param>
        /// <param name="F_y">  Specified minimum yield stress </param>
        /// <param name="fc_prime">  Specified compressive strength of concrete   </param>
        /// <param name="SumQ_n">  Sum of the nominal strengths of steel anchors between the point of maximum positive moment and the point of zero moment to either side </param>
        /// <param name="Code"> Applicable version of code/standard</param>
        /// <returns name="phiM_n"> Moment strength </returns>

        [MultiReturn(new[] { "phiM_n" })]
        public static Dictionary<string, object> PositiveMomentFlexuralStrength(CustomProfile Shape, double b_eff, double h_solid, double h_rib, double F_y, double fc_prime,
            double SumQ_n, string Code = "AISC360-10")
        {
            //Default values
            double phiM_n = 0;


            //Calculation logic:
            if (Shape.Section is ISliceableShapeProvider)
            {
                ISliceableShapeProvider prov = Shape.Section as ISliceableShapeProvider;
                ISliceableSection sec = prov.GetSliceableShape();
                CompositeBeamSection cs = new CompositeBeamSection(sec, b_eff, h_solid, h_rib, F_y, fc_prime);
                phiM_n = cs.GetFlexuralStrength(SumQ_n);
            }
            else
            {
                if (Shape.Section is ISliceableSection)
                {
                    ISliceableSection sec = Shape.Section as ISliceableSection;
                    CompositeBeamSection cs = new CompositeBeamSection(sec, b_eff, h_solid, h_rib, F_y, fc_prime);
                    phiM_n = cs.GetFlexuralStrength(SumQ_n);
                }
                else
                {
                    throw new Exception("Shape type not supported. Please provide a shape object of standard geometry");
                }
                
            }


            return new Dictionary<string, object>
            {
                { "phiM_n", phiM_n }
 
            };
        }



    }
}


