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
///     Non sway moment magnification
///     Category:   Concrete.ACI318_14.Section.Compression
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Stability 
    {
/// <summary>
///     Non sway moment magnification
/// </summary>
        /// <param name="C_m">   Factor relating actual moment diagram to an equivalent uniform moment diagram </param>
/// <param name="P_u">   Factored axial force; to be taken as positive for  compression and negative for tension  </param>
/// <param name="P_c">   Critical buckling load  </param>

        
        [MultiReturn(new[] {  })]
        public static Dictionary<string, object> NonSwayMomentMagnification(double C_m,double P_u,double P_c)
        {
            //Default values
            

            //Calculation logic:


            return new Dictionary<string, object>
            {
                 
            };
        }


        //internal Stability (double C_m,double P_u,double P_c)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Stability  ByInputParameters(double C_m,double P_u,double P_c)
        //{
        //    return new Stability(C_m ,P_u ,P_c );
        //}

    }
}


