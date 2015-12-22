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

namespace Wosad.Steel.AISC_10.Compression
{
    /// <summary>
    ///     Compression critical stress torsional and flexural-torsional buckling no slender elements 
    ///     Category:   Wosad.Steel.AISC_10.Compression
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class CompressionCriticalStressTorsionalAndFlexuralTorsionalBucklingNoSlenderElements 
    {
        /// <summary>
        ///    Calculates Critical stress for torsional and flexural-torsional buckling of members without slender elements 
        /// </summary>
        /// <param name="SteelShapeId">  Section name from steel shape database /param>
/// <param name="SteelSection">  Steel section group /param>
/// <param name="G">  Shear modulus of elasticity of steel /param>
/// <param name="K_x">  Effective length factor for flexural buckling about x-axis /param>
/// <param name="K_y">  Effective length factor for flexural buckling about y-axis /param>
/// <param name="K_z">  Effective length factor for torsional buckling /param>

        /// <returns> "Parameter name: F_cr", Parameter description: Critical stress </returns>

        /// 
        [MultiReturn(new[] { "F_cr" })]
        public static Dictionary<string, object> Critical stress(string SteelShapeId,string SteelSection,double G,double K_x,double K_y,double K_z)
        {
            //Default values
            double F_cr = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "F_cr", F_cr }
 
            };
        }

        string _CompressionCriticalStressTorsionalAndFlexuralTorsionalBucklingNoSlenderElements ;

        internal CompressionCriticalStressTorsionalAndFlexuralTorsionalBucklingNoSlenderElements (string SteelShapeId,string SteelSection,double G,double K_x,double K_y,double K_z)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static CompressionCriticalStressTorsionalAndFlexuralTorsionalBucklingNoSlenderElements  ByInputParameters(string SteelShapeId,string SteelSection,double G,double K_x,double K_y,double K_z)
        {
            return new CompressionCriticalStressTorsionalAndFlexuralTorsionalBucklingNoSlenderElements(string SteelShapeId,string SteelSection,double G,double K_x,double K_y,double K_z);
        }

    }
}


