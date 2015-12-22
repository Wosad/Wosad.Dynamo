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
    ///     Flexural yielding
    ///     Category:   Wosad.Steel.AISC_10.Flexure
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class FlexuralYielding 
    {
        /// <summary>
        ///    Calculates Flexural yielding
        /// </summary>
        /// <param name="F_y">  Specified minimum yield stress /param>
/// <param name="Z">  Plastic section modulus about the axis of bending  /param>

        /// <returns> "Parameter name: phiM_n", Parameter description: Moment strength </returns>

        /// 
        [MultiReturn(new[] { "phiM_n" })]
        public static Dictionary<string, object> Flexural yielding strength(double F_y,double Z)
        {
            //Default values
            double phiM_n = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "phiM_n", phiM_n }
 
            };
        }

        string _FlexuralYielding ;

        internal FlexuralYielding (double F_y,double Z)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static FlexuralYielding  ByInputParameters(double F_y,double Z)
        {
            return new FlexuralYielding(double F_y,double Z);
        }

    }
}


