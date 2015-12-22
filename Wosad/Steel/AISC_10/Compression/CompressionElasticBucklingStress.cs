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
    ///     Compression elastic buckling stress
    ///     Category:   Wosad.Steel.AISC_10.Compression
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class CompressionElasticBucklingStress 
    {
        /// <summary>
        ///    Calculates Elastic buckling stress
        /// </summary>
        /// <param name="K">  Effective length factor /param>
/// <param name="L">  Length of member length of span or unbraced length of member    /param>
/// <param name="r">  Radius of gyration   /param>
/// <param name="E">  Modulus of elasticity of steel /param>

        /// <returns> "Parameter name: F_e", Parameter description: Elastic buckling stress </returns>

        /// 
        [MultiReturn(new[] { "F_e" })]
        public static Dictionary<string, object> Elastic buckling stress(double K,double L,double r,double E)
        {
            //Default values
            double F_e = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "F_e", F_e }
 
            };
        }

        string _CompressionElasticBucklingStress ;

        internal CompressionElasticBucklingStress (double K,double L,double r,double E)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static CompressionElasticBucklingStress  ByInputParameters(double K,double L,double r,double E)
        {
            return new CompressionElasticBucklingStress(double K,double L,double r,double E);
        }

    }
}


