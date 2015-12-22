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

namespace Wosad.Steel.AISC_10.Flexure
{
    /// <summary>
    ///     Limiting length for flexural inelastic buckling
    ///     Category:   Wosad.Steel.AISC_10.Flexure
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class LimitingLengthForFlexuralInelasticBuckling 
    {
        /// <summary>
        ///    Calculates Limiting length for flexural yielding
        /// </summary>
        /// <param name="E">  Modulus of elasticity of steel /param>
/// <param name="F_y">  Specified minimum yield stress /param>
/// <param name="r_y">  Radius of gyration about y-axis  /param>
/// <param name="SteelShapeGroupFlexure">  Type of steel shape for flexural calculations /param>

        /// <returns> "Parameter name: L_p", Parameter description: Limiting laterally unbraced length for the limit state of yielding  </returns>

        /// 
        [MultiReturn(new[] { "L_p" })]
        public static Dictionary<string, object> Limiting length for flexural yielding(double E,double F_y,double r_y,string SteelShapeGroupFlexure)
        {
            //Default values
            double L_p = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "L_p", L_p }
 
            };
        }

        string _LimitingLengthForFlexuralInelasticBuckling ;

        internal LimitingLengthForFlexuralInelasticBuckling (double E,double F_y,double r_y,string SteelShapeGroupFlexure)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static LimitingLengthForFlexuralInelasticBuckling  ByInputParameters(double E,double F_y,double r_y,string SteelShapeGroupFlexure)
        {
            return new LimitingLengthForFlexuralInelasticBuckling(double E,double F_y,double r_y,string SteelShapeGroupFlexure);
        }

    }
}


