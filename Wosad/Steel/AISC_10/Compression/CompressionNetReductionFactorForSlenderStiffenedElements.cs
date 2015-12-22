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
    ///     Compression net reduction factor for slender stiffened elements
    ///     Category:   Wosad.Steel.AISC_10.Compression
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class CompressionNetReductionFactorForSlenderStiffenedElements 
    {
        /// <summary>
        ///    Calculates Net reduction factor for slender stiffened elements
        /// </summary>
        /// <param name="b">  Width of stiffened or unstiffened compression element /param>
/// <param name="t">  Thickness of element plate or element wall  /param>
/// <param name="f">  Design axial stress /param>
/// <param name="E">  Modulus of elasticity of steel /param>

        /// <returns> "Parameter name: Q_a", Parameter description: Reduction factor for slender stiffened elements </returns>

        /// 
        [MultiReturn(new[] { "Q_a" })]
        public static Dictionary<string, object> Net reduction factor (stiffened)(double b,double t,double f,double E)
        {
            //Default values
            double Q_a = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "Q_a", Q_a }
 
            };
        }

        string _CompressionNetReductionFactorForSlenderStiffenedElements ;

        internal CompressionNetReductionFactorForSlenderStiffenedElements (double b,double t,double f,double E)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static CompressionNetReductionFactorForSlenderStiffenedElements  ByInputParameters(double b,double t,double f,double E)
        {
            return new CompressionNetReductionFactorForSlenderStiffenedElements(double b,double t,double f,double E);
        }

    }
}


