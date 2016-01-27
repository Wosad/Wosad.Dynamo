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

#endregion

namespace Steel.AISC_10.Compression
{

/// <summary>
///     Compression net reduction factor for slender unstiffened elements
///     Category:   Steel.AISC_10.Compression
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class SlenderElementReduction 
    {
/// <summary>
///    Calculates Net reduction factor for slender unstiffened elements
/// </summary>
        /// <param name="LocalBucklingCaseID">  Defines element case for local buckling checks </param>
/// <param name="b">  Width of stiffened or unstiffened compression element </param>
/// <param name="t">  Thickness of element plate or element wall  </param>
/// <param name="F_y">  Specified minimum yield stress </param>
/// <param name="E">  Modulus of elasticity of steel </param>
/// <param name="h_web">  Clear distance between flanges less the fillet or corner radius for rolled shapes </param>
/// <param name="t_w">  Thickness of web  </param>

        /// <returns name="Q_s"> Reduction factor for slender unstiffened elements </returns>

        [MultiReturn(new[] { "Q_s" })]
        public static Dictionary<string, object> NetReductionFactor_Unstiffened(string LocalBucklingCaseID,double b,double t,double F_y,double E,double h_web,double t_w)
        {
            //Default values
            double Q_s = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "Q_s", Q_s }
 
            };
        }


        //internal SlenderElementReduction (string LocalBucklingCaseID,double b,double t,double F_y,double E,double h_web,double t_w)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static SlenderElementReduction  ByInputParameters(string LocalBucklingCaseID,double b,double t,double F_y,double E,double h_web,double t_w)
        //{
        //    return new SlenderElementReduction(LocalBucklingCaseID ,b ,t ,F_y ,E ,h_web ,t_w );
        //}

    }
}


