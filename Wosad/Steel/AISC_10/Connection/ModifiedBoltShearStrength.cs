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

namespace Wosad.Steel.AISC_10.Connection
{

/// <summary>
///     Bearing bolt combined tension and shear
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    public partial class Bolted 
    {
        /// <summary>
        ///    Calculates Bearing bolt combined tension and shear
        /// </summary>
        /// <param name="V_u">  Required shear strength </param>
        /// <param name="F_nv">  Nominal shear stress </param>
        /// <param name="F_nt">  Nominal tensile stress </param>

        
        [MultiReturn(new[] {  })]
        public static Dictionary<string, object> ModifiedBoltShearStrength(double V_u,double F_nv,double F_nt)
        {
            //Default values
            

            //Calculation logic:


            return new Dictionary<string, object>
            {
                 
            };
        }




    }
}


