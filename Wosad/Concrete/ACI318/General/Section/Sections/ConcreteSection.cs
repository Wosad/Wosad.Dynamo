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
using dm =Wosad.Common.Mathematics;
using Concrete.ACI318.General;
using Concrete.ACI318.General.Reinforcement;
using Concrete.ACI318.General.Concrete;


#endregion

namespace Concrete.ACI318.General
{

  [IsVisibleInDynamoLibrary(false)]
    public partial class ConcreteSection
    {



        [IsVisibleInDynamoLibrary(false)]
        protected ConcreteSection()
        {

        }


        private Wosad.Concrete.ACI.IConcreteSection section;

        [IsVisibleInDynamoLibrary(false)]
        public Wosad.Concrete.ACI.IConcreteSection Section
        {
            get { return section; }
            set { section = value; }
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

        private RebarMaterial transverseRebarMaterial;

        [IsVisibleInDynamoLibrary(false)]
        public RebarMaterial TransverseRebarMaterial
        {
            get { return transverseRebarMaterial; }
            set { transverseRebarMaterial = value; }
        }

        private double _A_tr;

        [IsVisibleInDynamoLibrary(false)]
        public double A_tr
        {
            get { return _A_tr; }
            set { _A_tr = value; }
        }

        private double _s;

        [IsVisibleInDynamoLibrary(false)]
        public double s
        {
            get { return _s; }
            set { _s = value; }
        }



    }
}
