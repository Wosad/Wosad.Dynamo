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
    ///     Compression critical stress flexural buckling no slender elements
    ///     Category:   Wosad.Steel.AISC_10.Compression
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class CompressionCriticalStressFlexuralBucklingNoSlenderElements 
    {
        /// <summary>
        ///    Calculates Critical stress for flexural buckling strength of members without slender elements
        /// </summary>
        /// <param name="F_y">  Specified minimum yield stress /param>
/// <param name="F_e">  Elastic buckling stress /param>

        /// <returns> "Parameter name: F_cr", Parameter description: Critical stress </returns>

        /// 
        [MultiReturn(new[] { "F_cr" })]
        public static Dictionary<string, object> Critical stress(double F_y,double F_e)
        {
            //Default values
            double F_cr = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "F_cr", F_cr }
 
            };
        }

        string _CompressionCriticalStressFlexuralBucklingNoSlenderElements ;

        internal CompressionCriticalStressFlexuralBucklingNoSlenderElements (double F_y,double F_e)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static CompressionCriticalStressFlexuralBucklingNoSlenderElements  ByInputParameters(double F_y,double F_e)
        {
            return new CompressionCriticalStressFlexuralBucklingNoSlenderElements(double F_y,double F_e);
        }

    }
}


