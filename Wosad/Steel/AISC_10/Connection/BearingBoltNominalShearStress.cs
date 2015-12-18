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
///     Bolt nominal shear stress
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    public partial class Bolted 
    {
        /// <summary>
        ///    Calculates Bolt nominal shear stress from AISC Table J3.2
        /// </summary>
        /// <param name="BoltMaterialId">  Bolt material specification </param>
        /// <param name="BoltThreadCase">  Identifies whether threads are included or excluded from shear planes </param>

        /// <returns name="F_nv"> Nominal shear stress </returns>

        [MultiReturn(new[] { "F_nv" })]
        public static Dictionary<string, object> BearingBoltNominalShearStress(string BoltMaterialId,string BoltThreadCase)
        {
            //Default values
            double F_nv = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "F_nv", F_nv }
 
            };
        }


    }
}


