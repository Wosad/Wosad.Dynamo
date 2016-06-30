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
using Wosad.Concrete.ACI318_14;
using Concrete.ACI318.General;
using Concrete.ACI318.General.Reinforcement;
using Concrete.ACI318.General.Concrete;
using Dynamo.Graph.Nodes;
using wosadAci = Wosad.Concrete.ACI;
using wosadAci14 = Wosad.Concrete.ACI318_14;
using Wosad.Common.CalculationLogger;

#endregion

namespace Concrete.ACI318.Section.FlexureAndAxialForce.SectionTypes
{

/// <summary>
///   Rectangular section singly reinforced
///   Category:   Concrete.ACI318_14.General
/// </summary>
 


    [IsDesignScriptCompatible]
    public partial class RectangularSectionSinglyReinforced : ConcreteFlexureAndAxiaSection
    {

            //Default values
            double b;
            double h;
            double A_s;
            double c_cntr;
            ConcreteMaterial ConcreteMaterial;
            RebarMaterial LongitudinalRebarMaterial;
            RebarMaterial TransverseRebarMaterial;

         [IsVisibleInDynamoLibrary(false)]
        internal RectangularSectionSinglyReinforced(double b, double h, double A_s, double c_cntr,
        ConcreteMaterial ConcreteMaterial, RebarMaterial LongitudinalRebarMaterial, bool hasTies=false)
        {

            CrossSectionRectangularShape shape = new CrossSectionRectangularShape(ConcreteMaterial.Concrete, null, b, h);
            base.ConcreteMaterial = ConcreteMaterial; //duplicate save of concrete material into base Dynamo class

            List<wosadAci.RebarPoint> LongitudinalBars = new List<wosadAci.RebarPoint>();

                wosadAci.Rebar thisBar = new wosadAci.Rebar(A_s, LongitudinalRebarMaterial.Material);
                wosadAci.RebarPoint point = new wosadAci.RebarPoint(thisBar, new wosadAci.RebarCoordinate() { X = 0, Y = -h / 2.0 + c_cntr });
            LongitudinalBars.Add(point);

            wosadAci.IConcreteFlexuralMember fs = new wosadAci14.ConcreteSectionFlexure(shape, LongitudinalBars, new CalcLog());
            this.FlexuralSection = fs;
        }

        /// <summary>
         /// Rectangular section singly reinforced
        /// </summary>
         /// <param name="b">Width of compression face of member</param>
         /// <param name="h">Overall thickness, height, or depth of member</param>
         /// <param name="A_s">Area of nonprestressed longitudinal tension reinforcement</param>
         /// <param name="c_cntr">Concrete cover to tension rebar centroid</param>
         /// <param name="ConcreteMaterial">Concrete material</param>
         /// <param name="LongitudinalRebarMaterial">Rebar material for longitudinal bars</param>
         /// <returns name="RectangularSectionSinglyReinforced">  Section [OBJECT] </returns>

        public static RectangularSectionSinglyReinforced ByWidthHeigthAndReinforcementArea(double b, double h, double A_s, double c_cntr,
            ConcreteMaterial ConcreteMaterial,RebarMaterial LongitudinalRebarMaterial)
        {
            return new RectangularSectionSinglyReinforced(b, h, A_s, c_cntr, ConcreteMaterial, LongitudinalRebarMaterial);
        }


    }
}


