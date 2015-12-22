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
///     Connected element strength in tension 
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class AffectedElements 
    {
/// <summary>
///    Calculates Connected element strength in tension 
/// </summary>
        /// <param name="A_g">  Gross cross-sectional area of member </param>
/// <param name="F_y">  Specified minimum yield stress </param>
/// <param name="F_u">  Specified minimum tensile strength   </param>
/// <param name="A_e">  Effective net area </param>

        /// <returns name="phiR_n"> Strength of member or connection </returns>

        [MultiReturn(new[] { "phiR_n" })]
        public static Dictionary<string, object> ConnectedElementStrengthInTension(double A_g,double F_y,double F_u,double A_e)
        {
            //Default values
            double phiR_n = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_n", phiR_n }
 
            };
        }


        //internal AffectedElements (double A_g,double F_y,double F_u,double A_e)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static AffectedElements  ByInputParameters(double A_g,double F_y,double F_u,double A_e)
        //{
        //    return new AffectedElements(A_g ,F_y ,F_u ,A_e );
        //}

    }
}


