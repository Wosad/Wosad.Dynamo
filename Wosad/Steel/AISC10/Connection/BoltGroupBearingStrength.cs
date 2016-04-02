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
using Wosad.Steel.AISC360v10.Connections.AffectedElements;

#endregion

namespace Steel.AISC10.Connection
{

/// <summary>
///     Bolt group bearing strength
///     Category:   Steel.AISC_10.Connection
/// </summary>
/// 


    public partial class AffectedElements 
    {
        /// <summary>
        ///    Calculates Strength of bolt group for the bearing on base material limit state
        /// </summary>
        /// <param name="N_BoltRowParallel">  Number of bolt rows parallel  to direction of load </param>
        /// <param name="N_BoltRowPerpendicular">  Number of bolt columns perpendicular to direction of load </param>
        /// <param name="phiR_nFirstRow">  Bolt bearing strength for first row of bolts </param>
        /// <param name="phiR_nInnerRow">  Bolt bearing strength for inner row of bolts </param>
        /// <returns name="phiR_n"> Strength of member or connection </returns>

        [MultiReturn(new[] { "phiR_n" })]
        public static Dictionary<string, object> BoltGroupBearingStrength(double N_BoltRowParallel,double N_BoltRowPerpendicular,double phiR_nFirstRow,double phiR_nInnerRow)
        {
            //Default values
            double phiR_n = 0;


            //Calculation logic:
            AffectedElementWithHoles el = new AffectedElementWithHoles();
            phiR_n = el.GetBoltGroupBearingStrength(N_BoltRowParallel, N_BoltRowPerpendicular, phiR_nFirstRow, phiR_nInnerRow);
            return new Dictionary<string, object>
            {
                { "phiR_n", phiR_n }
 
            };
        }


    }
}


