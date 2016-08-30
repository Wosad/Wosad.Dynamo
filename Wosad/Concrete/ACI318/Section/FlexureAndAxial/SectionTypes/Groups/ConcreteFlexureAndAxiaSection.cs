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
using dm =Wosad.Common.Mathematics;
using Concrete.ACI318.General;
using Concrete.ACI318.General.Reinforcement;
using Concrete.ACI318.General.Concrete;
using wosadAci = Wosad.Concrete.ACI;

#endregion

namespace Concrete.ACI318.Section.SectionTypes
{

  [IsVisibleInDynamoLibrary(false)]
    public partial class ConcreteFlexureAndAxiaSection
    {



        [IsVisibleInDynamoLibrary(false)]
        protected ConcreteFlexureAndAxiaSection()
        {

        }


        private wosadAci.IConcreteFlexuralMember flexSection;

        [IsVisibleInDynamoLibrary(false)]
        public wosadAci.IConcreteFlexuralMember FlexuralSection
        {
            get { return flexSection; }
            set { flexSection = value; }
        }

        private List<RebarPoint> longitudinalBars;

        [IsVisibleInDynamoLibrary(false)]
        public List<RebarPoint> LongitudinalBars
        {
            get { return longitudinalBars; }
            set { longitudinalBars = value; }
        }

        private ConcreteMaterial concreteMaterial;

        [IsVisibleInDynamoLibrary(false)]
        public ConcreteMaterial ConcreteMaterial
        {
            get { return concreteMaterial; }
            set { concreteMaterial = value; }
        }

        //private RebarMaterial longitudinalRebarMateria;

        //public RebarMaterial LongitudinalRebarMaterial
        //{
        //    get { return longitudinalRebarMateria; }
        //    set { longitudinalRebarMateria = value; }
        //}




    }
}
