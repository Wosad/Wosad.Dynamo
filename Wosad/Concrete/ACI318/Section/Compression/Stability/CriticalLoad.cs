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

namespace Concrete.ACI318_14.Section.Compression
{

/// <summary>
///     Critical load
///     Category:   Concrete.ACI318_14.Section.Compression
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Stability 
    {
/// <summary>
///     Critical load
/// </summary>
        /// <param name="k">   Effective length factor for compression members </param>
/// <param name="l_u">   Unsupported length of column or wall  </param>
/// <param name="EI">   Flexural stiffness of member   </param>

        /// <returns name="P_c">  Critical buckling load  </returns>

        [MultiReturn(new[] { "P_c" })]
        public static Dictionary<string, object> CriticalLoad(double k,double l_u,double EI)
        {
            //Default values
            double P_c = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "P_c", P_c }
 
            };
        }


        //internal Stability (double k,double l_u,double EI)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Stability  ByInputParameters(double k,double l_u,double EI)
        //{
        //    return new Stability(k ,l_u ,EI );
        //}

    }
}


