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
///     Eccentrically loaded bolt group coefficient
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Bolted 
    {
/// <summary>
///    Calculates Eccentrically loaded bolt group coefficient
/// </summary>
        /// <param name="N_rows">  Number of bolt rows in bolt groups </param>
/// <param name="N_cols">  Number of bolt columns in bolt groups </param>
/// <param name="e_group">  Connection bolt or weld group eccentricity </param>
/// <param name="theta">  Angle of loading for eccentric bolt or weld group </param>

        /// <returns name="C_BoltGroup"> Coefficient for eccentrically loaded bolt group </returns>

        [MultiReturn(new[] { "C_BoltGroup" })]
        public static Dictionary<string, object> BoltGroupCoefficient(double N_rows,double N_cols,double e_group,double theta)
        {
            //Default values
            double C_BoltGroup = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "C_BoltGroup", C_BoltGroup }
 
            };
        }


        //internal Bolted (double N_rows,double N_cols,double e_group,double theta)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Bolted  ByInputParameters(double N_rows,double N_cols,double e_group,double theta)
        //{
        //    return new Bolted(N_rows ,N_cols ,e_group ,theta );
        //}

    }
}

