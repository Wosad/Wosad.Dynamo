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
    ///     Compressive strength with slender elements
    ///     Category:   Wosad.Steel.AISC_10.Compression
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class CompressiveStrengthWithSlenderElements 
    {
        /// <summary>
        ///    Calculates Compressive strength for members with slender elements
        /// </summary>
        /// <param name="F_cr">  Critical stress /param>
/// <param name="A_g">  Gross cross-sectional area of member /param>
/// <param name="Q_a">  Reduction factor for slender stiffened elements /param>
/// <param name="Q_s">  Reduction factor for slender unstiffened elements /param>

        /// <returns> "Parameter name: phiP_n", Parameter description: Compressive strength </returns>

        /// 
        [MultiReturn(new[] { "phiP_n" })]
        public static Dictionary<string, object> Compressive strength(double F_cr,double A_g,double Q_a,double Q_s)
        {
            //Default values
            double phiP_n = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "phiP_n", phiP_n }
 
            };
        }

        string _CompressiveStrengthWithSlenderElements ;

        internal CompressiveStrengthWithSlenderElements (double F_cr,double A_g,double Q_a,double Q_s)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static CompressiveStrengthWithSlenderElements  ByInputParameters(double F_cr,double A_g,double Q_a,double Q_s)
        {
            return new CompressiveStrengthWithSlenderElements(double F_cr,double A_g,double Q_a,double Q_s);
        }

    }
}


