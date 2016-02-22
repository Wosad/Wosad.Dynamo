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
using Wosad.Concrete.ACI;
using Wosad.Concrete.ACI318_14;
using Wosad.Concrete.ACI.Infrastructure.Entities.Rebar;
using Concrete.ACI318_14.General.Material;

#endregion

namespace Concrete.ACI318_14.General.Section
{

/// <summary>
///     Rectangular section singly reinforced
///     Category:   Concrete.ACI318_14.General
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class RectangularSectionSinglyReinforced : ConcreteSection
    {

            //Default values
            double b;
            double h;
            double A_s;
            double c_cntr;
            Concrete.ACI318_14.General.Material.ConcreteMaterial ConcreteMaterial;
            RebarMaterial LongitudinalRebarMaterial;
            RebarMaterial TransverseRebarMaterial;

         [IsVisibleInDynamoLibrary(false)]
        internal RectangularSectionSinglyReinforced(double b, double h, double A_s, double c_cntr,double A_tr, double s,
        Concrete.ACI318_14.General.Material.ConcreteMaterial ConcreteMaterial, RebarMaterial LongitudinalRebarMaterial, RebarMaterial TransverseRebarMaterial)
        {

            CrossSectionRectangularShape section = new CrossSectionRectangularShape(ConcreteMaterial.Concrete, null, b, h);
            List<RebarPoint> LongitudinalBars = new List<RebarPoint>();
            this.Section = section;
           
            Wosad.Concrete.ACI.Infrastructure.Entities.Rebar.Rebar thisBar = new Wosad.Concrete.ACI.Infrastructure.Entities.Rebar.Rebar(A_s, LongitudinalRebarMaterial.Material);
            RebarPoint point = new RebarPoint(thisBar, new RebarCoordinate() { X = 0, Y = -h / 2.0 + c_cntr });
            LongitudinalBars.Add(point);

            this.A_tr = A_tr;
            this.s = s;

            this.LongitudinalBars = LongitudinalBars;
        }

        /// <summary>
        ///     Rectangular section singly reinforced
        /// </summary>
        /// <param name="b">  Width of compression face of member  </returns>
        /// <param name="h">  Overall thickness, height, or depth of member  </returns>
        /// <param name="A_s">  Area of nonprestressed longitudinal tension reinforcement  </returns>
        /// <param name="c_cntr"> Concrete cover to tension rebar centroid </returns>
        /// <param name="A_tr">  Total cross-sectional area of all transverse reinforcement within spacing s that crosses the potential  plane of splitting through the reinforcement being  developed  </returns>
        /// <param name="s">  Center-to-center spacing of transverse reinforcement  </returns>
        ///  <param name="ConcreteMaterial"> Concrete material </returns>
        ///  <param name="LongitudinalRebarMaterial"> Rebar material for longitudinal bars </returns>
        ///  <param name="TransverseRebarMaterial"> Rebar material for transverse bars </returns>
        /// <returns name="RectangularSectionSinglyReinforced"> Concrete sction </returns>


        public static RectangularSectionSinglyReinforced ByWidthHeigthAndReinforcementArea(double b, double h, double A_s, double c_cntr, double A_tr, double s,
            Concrete.ACI318_14.General.Material.ConcreteMaterial ConcreteMaterial,RebarMaterial LongitudinalRebarMaterial, RebarMaterial TransverseRebarMaterial)
        {
            return new RectangularSectionSinglyReinforced(b, h, A_s, c_cntr, A_tr,s, ConcreteMaterial, LongitudinalRebarMaterial, TransverseRebarMaterial);
        }

    }
}


