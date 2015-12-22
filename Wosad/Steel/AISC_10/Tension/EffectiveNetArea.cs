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
using Wosad.Dynamo.Common;
using Dynamo.Nodes;

#endregion

namespace Wosad.Steel.AISC_10.Tension
{
    /// <summary>
    ///     Effective net area 
    ///     Category:   Wosad.Steel.AISC_10.Tension
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class EffectiveNetArea 
    {
        /// <summary>
        ///    Calculates Effective area for tensile strength
        /// </summary>
        /// <param name="A_g">  Gross cross-sectional area of member /param>
/// <param name="ShearLagCaseId">  Defines the type of tension element for shear lag calculation /param>
/// <param name="A_nTransverse">  Area of elements  connected only by transverse welds (applicable only if no longitudinal welds are used) /param>

        /// <returns> "Parameter name: A_e", Parameter description: Effective net area </returns>

        /// 
        [MultiReturn(new[] { "A_e" })]
        public static Dictionary<string, object> Effective Net Area (double A_g,string ShearLagCaseId,double A_nTransverse)
        {
            //Default values
            double A_e = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "A_e", A_e }
 
            };
        }

        string _EffectiveNetArea ;

        internal EffectiveNetArea (double A_g,string ShearLagCaseId,double A_nTransverse)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static EffectiveNetArea  ByInputParameters(double A_g,string ShearLagCaseId,double A_nTransverse)
        {
            return new EffectiveNetArea(double A_g,string ShearLagCaseId,double A_nTransverse);
        }

    }
}


