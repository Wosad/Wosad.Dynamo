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
    ///     Tensile strength 
    ///     Category:   Wosad.Steel.AISC_10.Tension
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class TensileStrength 
    {
        /// <summary>
        ///    Calculates Member tensile strength 
        /// </summary>
        /// <param name="F_y">  Specified minimum yield stress /param>
/// <param name="F_u">  Specified minimum tensile strength   /param>
/// <param name="A_e">  Effective net area /param>
/// <param name="A_g">  Gross cross-sectional area of member /param>

        /// <returns> "Parameter name: phiP_n", Parameter description: Compressive strength </returns>

        /// 
        [MultiReturn(new[] { "phiP_n" })]
        public static Dictionary<string, object> phiP_n(double F_y,double F_u,double A_e,double A_g)
        {
            //Default values
            double phiP_n = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "phiP_n", phiP_n }
 
            };
        }

        string _TensileStrength ;

        internal TensileStrength (double F_y,double F_u,double A_e,double A_g)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static TensileStrength  ByInputParameters(double F_y,double F_u,double A_e,double A_g)
        {
            return new TensileStrength(double F_y,double F_u,double A_e,double A_g);
        }

    }
}

