﻿#region Copyright
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
using Wosad.Common.Section.Predefined;
using Analysis.Section.SectionTypes;
using shapes = Wosad.Common.Section.SectionTypes;
using Wosad.Common.Entities;
using Analysis.Section;
using System;

#endregion

namespace Steel.AISC.Composite.Sections
{


    public partial class CompositeSectionGeneral : CompositeSteelShape
    {

        [IsVisibleInDynamoLibrary(false)]
        internal CompositeSectionGeneral(CustomProfile Shape)
        {
            ISliceableSection secI;


            if (Shape.Section is Wosad.Common.Section.CompoundShape )
            {
                if (Shape.Section is ISliceableSection)
                {
                    Section = Shape.Section as ISliceableSection;
                }
               
            }
            else
            {
                throw new Exception("Provided shape type is not supported. Please select a different shape as parameter.");
            }

        }


        public static CompositeSectionGeneral FromShape(CustomProfile Shape)
        {

            return new CompositeSectionGeneral(Shape);
        }
    }
}