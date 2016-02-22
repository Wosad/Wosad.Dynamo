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
using Concrete.ACI318_14.General;
using Wosad.Common.Section.Interfaces;
using System;

#endregion

namespace Concrete.ACI318_14
{

/// <summary>
///     Flexural strength
///     Category:   Concrete.ACI318_14.Flexure
/// </summary>
/// 



    public partial class Flexure 
    {
        /// <summary>
        ///     Flexural strength
        /// </summary>
        /// <param name="ReinforcedConcreteSection">  Reinforced concrete section object. Create the object using input parameters first </param>
        /// <param name="FlexuralCompressionFiberLocation"> Indicates whether the section in flexure has top or bottom in compression due to stresses from bending moment </param>
        /// <returns name="phiM_n"> Design flexural strength at section </returns>      


        

        [MultiReturn(new[] { "phiM_n" })]
        public static Dictionary<string, object> SectionFlexuralStrength(ConcreteSection ConcreteSection, string FlexuralCompressionFiberLocation="Top")
        {
            //Default values
            bool IsTensionControlled = true;
            double phiM_n = 0;

            //Calculation logic:

            FlexuralCompressionFiberPosition p;
            bool IsValidString = Enum.TryParse(FlexuralCompressionFiberLocation, true, out p);
            if (IsValidString == false)
            {
                throw new Exception("Flexural compression fiber location is not recognized. Check input.");
            }

            ConcreteSectionFlexure beam = new ConcreteSectionFlexure(ConcreteSection.Section, ConcreteSection.LongitudinalBars, null);
            phiM_n = beam.GetNominalFlexuralCapacity(p).Moment;

            return new Dictionary<string, object>
            {
                { "phiM_n", phiM_n }
 
            };
        }



    }
}


