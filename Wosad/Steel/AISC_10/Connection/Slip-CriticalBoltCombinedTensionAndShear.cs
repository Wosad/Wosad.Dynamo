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
///     Slip-critical bolt combined tension and shear
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Bolted 
    {
/// <summary>
///    Calculates Slip-critical bolt Combined Tension and Shear 
/// </summary>
        /// <param name="phiR_n">  Strength of member or connection </param>
/// <param name="d_b">  Nominal fastener diameter </param>
/// <param name="T_u">  Required tension force </param>
/// <param name="BoltMaterialId">  Bolt material specification </param>

        /// <returns name="phiR_nModified"> Modified shear strength of bolt subjected to tension </returns>

        [MultiReturn(new[] { "phiR_nModified" })]
        public static Dictionary<string, object> Slip-CriticalBoltCombinedTensionAndShear(double phiR_n,double d_b,double T_u,string BoltMaterialId)
        {
            //Default values
            double phiR_nModified = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_nModified", phiR_nModified }
 
            };
        }


        //internal Bolted (double phiR_n,double d_b,double T_u,string BoltMaterialId)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Bolted  ByInputParameters(double phiR_n,double d_b,double T_u,string BoltMaterialId)
        //{
        //    return new Bolted(phiR_n ,d_b ,T_u ,BoltMaterialId );
        //}

    }
}


