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
using Wosad.Steel.AISC.AISC360_10.Connections;

#endregion

namespace Steel.AISC_10.Connection
{

/// <summary>
///     Eccentrically loaded bolt group coefficient
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    public partial class Bolted 
    {
        /// <summary>
        ///    Calculates Eccentrically loaded bolt group coefficient
        /// </summary>
        /// <param name="N_rows">  Number of bolt rows in bolt groups </param>
        /// <param name="N_cols">  Number of bolt columns in bolt groups </param>
        /// <param name="p_h">	Horizontal bolt spacing  </param>
        /// <param name="p_v"> 	Vertical bolt spacing    </param>
        /// <param name="e_group">  Connection bolt or weld group eccentricity </param>
        /// <param name="theta">  Angle of loading for eccentric bolt or weld group </param>
        /// <returns name="C_BoltGroup"> Coefficient for eccentrically loaded bolt group </returns>

        [MultiReturn(new[] { "C_BoltGroup" })]
        public static Dictionary<string, object> BoltGroupCoefficient(double N_rows,double N_cols, double p_h, double p_v, double e_group,double theta)
        {
            //Default values
            double C_BoltGroup = 0;


            //Calculation logic:
            int N_r = (int) N_rows;
            int N_c = (int)N_cols;

            BoltGroup bg = new BoltGroup(N_r, N_c, p_h, p_v);
            C_BoltGroup = bg.GetInstantaneousCenterCoefficient(e_group, theta);

            return new Dictionary<string, object>
            {
                { "C_BoltGroup", C_BoltGroup }
 
            };
        }

    }
}


