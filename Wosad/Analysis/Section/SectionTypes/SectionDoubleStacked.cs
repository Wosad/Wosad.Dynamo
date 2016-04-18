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
using Wosad.Common.Section.Interfaces;
using ds = Wosad.Common.Section.SectionTypes;
using dm = Wosad.Common.Mathematics;
using System;

#endregion

namespace Analysis.Section.SectionTypes
{


    public partial class SectionDoubleStacked : CustomProfile
    {

        [IsVisibleInDynamoLibrary(false)]
        internal SectionDoubleStacked(CustomProfile ShapeUpper, CustomProfile ShapeLower, double d_tops)
        {
            if (ShapeLower.Section is Wosad.Common.Section.CompoundShape && ShapeUpper.Section is Wosad.Common.Section.CompoundShape)
            {
                Wosad.Common.Section.CompoundShape lowerSectionComp = ShapeLower.Section as Wosad.Common.Section.CompoundShape;
                Wosad.Common.Section.CompoundShape upperSectionComp = ShapeUpper.Section as Wosad.Common.Section.CompoundShape;

            Wosad.Common.Section.SectionDoubleStacked section = new Wosad.Common.Section.SectionDoubleStacked(upperSectionComp, lowerSectionComp, d_tops);
            Section = section;
            }
            else
            {
                throw new Exception("Provided shape type is not supported. Please select a different shape as parameter.");
            }

        }

        /// <summary>
        /// Creates a custom profile object consisting of 2 stacked shapes on top of each other, separated by a vertical distance d_tops, measured as distance between  top of lower shape and top of upper shape.
        /// </summary>
        /// <param name="ShapeUpper">Upper shape object</param>
        /// <param name="ShapeLower">Lower shape object</param>
        /// <param name="d_tops">Distance measured  between  top of lower shape and top of upper shape.</param>
        /// <returns></returns>
        public static SectionDoubleStacked ByShapesAndTopToTopDistance(CustomProfile ShapeUpper, CustomProfile ShapeLower, double d_tops)
        {
            return new SectionDoubleStacked(ShapeUpper, ShapeLower, d_tops);
        }

    }
}