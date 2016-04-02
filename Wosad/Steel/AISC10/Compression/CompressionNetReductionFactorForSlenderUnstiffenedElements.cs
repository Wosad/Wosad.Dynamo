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
    ///     Compression net reduction factor for slender unstiffened elements
    ///     Category:   Wosad.Steel.AISC_10.Compression
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class CompressionNetReductionFactorForSlenderUnstiffenedElements 
    {
        /// <summary>
        ///    Calculates Net reduction factor for slender unstiffened elements
        /// </summary>
        /// <param name="LocalBucklingCaseID">  Defines element case for local buckling checks /param>
/// <param name="b">  Width of stiffened or unstiffened compression element /param>
/// <param name="t">  Thickness of element plate or element wall  /param>
/// <param name="F_y">  Specified minimum yield stress /param>
/// <param name="E">  Modulus of elasticity of steel /param>
/// <param name="h_web">  Clear distance between flanges less the fillet or corner radius for rolled shapes /param>
/// <param name="t_w">  Thickness of web  /param>

        /// <returns> "Parameter name: Q_s", Parameter description: Reduction factor for slender unstiffened elements </returns>

        /// 
        [MultiReturn(new[] { "Q_s" })]
        public static Dictionary<string, object> Net reduction factor (unstiffened)(string LocalBucklingCaseID,double b,double t,double F_y,double E,double h_web,double t_w)
        {
            //Default values
            double Q_s = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "Q_s", Q_s }
 
            };
        }

        string _CompressionNetReductionFactorForSlenderUnstiffenedElements ;

        internal CompressionNetReductionFactorForSlenderUnstiffenedElements (string LocalBucklingCaseID,double b,double t,double F_y,double E,double h_web,double t_w)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static CompressionNetReductionFactorForSlenderUnstiffenedElements  ByInputParameters(string LocalBucklingCaseID,double b,double t,double F_y,double E,double h_web,double t_w)
        {
            return new CompressionNetReductionFactorForSlenderUnstiffenedElements(string LocalBucklingCaseID,double b,double t,double F_y,double E,double h_web,double t_w);
        }

    }
}


