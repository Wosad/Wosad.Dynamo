//#region Copyright
///*Copyright (C) 2015 Wosad Inc

//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at

//   http://www.apache.org/licenses/LICENSE-2.0

//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//   */
//#endregion

//#region

//using Autodesk.DesignScript.Runtime;
//using Dynamo.Models;
//using System.Collections.Generic;
//using Dynamo.Nodes;
//using Wosad.Concrete.ACI318_14;
//using Wosad.Concrete.ACI;
//using Concrete.ACI318.General;
//using Wosad.Common.Section.Interfaces;
//using System;
//using Concrete.ACI318.Section.SectionTypes;
//using wosadAci = Wosad.Concrete.ACI;
//using Wosad.Common.CalculationLogger;
//using Wosad.Common.CalculationLogger.Interfaces;

//#endregion

//namespace Concrete.ACI318.Section //.FlexureAndAxialForce
//{

//    /// <summary>
//    ///     SectionFlexural strength
//    ///     Category:   Concrete.ACI318_14.Section.Flexure
//    /// </summary>
//    /// 


//    public partial class FlexureAndAxialForce
//    {
//        /// <summary>
//        ///     Section flexural and axial strength
//        /// </summary>
//        /// <param name="ConcreteSection">  Reinforced concrete section </param>
//        /// <param name="FlexuralCompressionFiberLocation">  Indicates whether the section in flexure has top or bottom in compression due to stresses from bending moment </param>
//        /// <param name="ConfinementReinforcementType">  Type of confinement reinforcement (spiral, ties or none) </param>
//        /// <param name="Code"> Applicable version of code/standard</param>
//        /// <returns name="phiM_n">  Design flexural strength at section   </returns>

//        [MultiReturn(new[] { "phiM_n"})]
//        public static Dictionary<string, object> FlexuralStrength(ConcreteFlexureAndAxiaSection ConcreteSection,
//            string FlexuralCompressionFiberLocation = "Top", string CompressionMemberType = "NonPrestressedWithTies", string Code = "ACI318-14")
//        {
//            //Default values
//            double phiM_n = 0;


//        //NonPrestressedWithTies = 0,
//        //NonPrestressedWithSpirals = 1,
//        //PrestressedWithTies = 2,
//        //PrestressedWithSpirals = 3,
//        //Composite = 4,

//            //Calculation logic:

//            FlexuralCompressionFiberPosition p;
//            bool IsValidStringFiber = Enum.TryParse(FlexuralCompressionFiberLocation, true, out p);
//            if (IsValidStringFiber == false)
//            {
//                throw new Exception("Flexural compression fiber location is not recognized. Check input.");
//            }

//            CompressionMemberType co;
//            bool IsValidStringConf = Enum.TryParse(CompressionMemberType, true, out co);
//            if (IsValidStringConf == false)
//            {
//                throw new Exception("Confinement reinforcement type is not recognized. Check input.");
//            }

//            ICalcLog log = new CalcLog();

//            //ConcreteSectionCompression column = new ConcreteSectionCompression(ConcreteSection.FlexuralSection, ConcreteSection.LongitudinalBars, co, log);
//            //ConcreteFlexuralStrengthResult result = column.GetDesignMomentWithCompressionStrength(P_u,p,)

//            //note that internally ACI nodes in Wosad use psi units consistent with ACI code
//            //convert to ksi units consistent with the rest of Dynamo nodes here

//            //phiM_n = result.phiM_n / 1000.0;

//            return new Dictionary<string, object>
//            {
//            { "phiM_n", phiM_n }
 
//            };
//        }




//    }
//}


