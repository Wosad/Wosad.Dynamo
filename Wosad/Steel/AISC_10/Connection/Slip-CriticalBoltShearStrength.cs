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

namespace Steel.AISC_10.Connection
{

/// <summary>
///     Slip-critical bolt shear strength
///     Category:   Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Bolted 
    {
/// <summary>
///    Calculates Slip-critical bolt shear strength
/// </summary>
        /// <param name="d_b">  Nominal fastener diameter </param>
/// <param name="BoltMaterialId">  Bolt material specification </param>
/// <param name="BoltFillerCase">  Distinguishes between filler cases for slip-critical bolt capacity calculations </param>
/// <param name="NumberShearPlanes">  Number of shear planes </param>

        /// <returns name="phiR_n"> Strength of member or connection </returns>

        [MultiReturn(new[] { "phiR_n" })]
        public static Dictionary<string, object> Slip-CriticalBoltShearStrength(double d_b,string BoltMaterialId,string BoltFillerCase,double NumberShearPlanes)
        {
            //Default values
            double phiR_n = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_n", phiR_n }
 
            };
        }


        //internal Bolted (double d_b,string BoltMaterialId,string BoltFillerCase,double NumberShearPlanes)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Bolted  ByInputParameters(double d_b,string BoltMaterialId,string BoltFillerCase,double NumberShearPlanes)
        //{
        //    return new Bolted(d_b ,BoltMaterialId ,BoltFillerCase ,NumberShearPlanes );
        //}

    }
}


