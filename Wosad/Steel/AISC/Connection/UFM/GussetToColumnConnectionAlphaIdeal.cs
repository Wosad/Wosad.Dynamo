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
using Wosad.Steel.AISC.UFM;
using Dynamo.Graph.Nodes;

#endregion

namespace Steel.AISC.Connection
{

/// <summary>
///     Alpha ideal (gusset to column connection)
///     Category:   Steel.AISC10.Connection
/// </summary>
/// 


    public partial class UniformForceMethod 
    {
        /// <summary>
        ///     Distance from the face of the column flange or web to the ideal centroid of the gusset-to-beam connection for brace connection.
        /// </summary>
        /// <param name="d_b">  Depth of beam </param>
        /// <param name="d_c">  Depth of column  </param>
        /// <param name="theta">  Angle of loading for eccentric bolt or weld group </param>
        /// <param name="beta"> Distance from the face of the beam flange to the ideal centroid of the gusset-to-column connection </param>
        /// <param name="Code"> Applicable version of code/standard</param>
        /// <returns name="alpha"> Distance from the face of the column flange or web to the ideal centroid of the gusset-to-beam connection </returns>

        [MultiReturn(new[] { "alpha" })]
        public static Dictionary<string, object> GussetToColumnConnectionAlphaIdeal(double d_b, double d_c, double theta, double beta, string Code = "AISC360-10")
        {
            //Default values
            double alpha = 0;


            //Calculation logic:
            UFMCase ufmCase = new UFMCase(d_b, d_c, theta);
            beta = ufmCase.Get_alpha(beta);

            return new Dictionary<string, object>
            {
                { "alpha", alpha }
 
            };
        }


    }
}


