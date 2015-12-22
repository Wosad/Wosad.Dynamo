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

namespace Wosad.Steel.AISC_10.Shear
{
    /// <summary>
    ///     Shear strength
    ///     Category:   Wosad.Steel.AISC_10.Shear
    /// </summary>
    /// 


    [IsDesignScriptCompatible]
    public class ShearStrength 
    {
        /// <summary>
        ///    Calculates Member shear strength
        /// </summary>
        /// <param name="F_y">  Specified minimum yield stress /param>
/// <param name="t_w">  Thickness of web  /param>
/// <param name="h">  Width of stiffened  element  /param>
/// <param name="E">  Modulus of elasticity of steel /param>

        /// <returns> "Parameter name: phiV_n", Parameter description: Shear strength </returns>

        /// 
        [MultiReturn(new[] { "phiV_n" })]
        public static Dictionary<string, object> Shear strength(double F_y,double t_w,double h,double E)
        {
            //Default values
            double phiV_n = 0;


            //Add calculation logic here:


            return new Dictionary<string, object>
            {
                { "phiV_n", phiV_n }
 
            };
        }

        string _ShearStrength ;

        internal ShearStrength (double F_y,double t_w,double h,double E)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static ShearStrength  ByInputParameters(double F_y,double t_w,double h,double E)
        {
            return new ShearStrength(double F_y,double t_w,double h,double E);
        }

    }
}

