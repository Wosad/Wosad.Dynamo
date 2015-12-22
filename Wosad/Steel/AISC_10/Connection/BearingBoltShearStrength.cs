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
///     Bolt shear strength
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Bolted 
    {
/// <summary>
///    Calculates Bolt shear strength
/// </summary>
        /// <param name="d_b">  Nominal fastener diameter </param>
/// <param name="F_nv">  Nominal shear stress </param>
/// <param name="NumberShearPlanes">  Number of shear planes </param>

        /// <returns name="phiR_nv"> Connection shear strength </returns>

        [MultiReturn(new[] { "phiR_nv" })]
        public static Dictionary<string, object> BearingBoltShearStrength(double d_b,double F_nv,double NumberShearPlanes)
        {
            //Default values
            double phiR_nv = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_nv", phiR_nv }
 
            };
        }


        //internal Bolted (double d_b,double F_nv,double NumberShearPlanes)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Bolted  ByInputParameters(double d_b,double F_nv,double NumberShearPlanes)
        //{
        //    return new Bolted(d_b ,F_nv ,NumberShearPlanes );
        //}

    }
}


