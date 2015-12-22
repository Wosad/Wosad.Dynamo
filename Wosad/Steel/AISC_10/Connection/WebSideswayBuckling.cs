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
///     Concentrated force web sidesway buckling 
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class AffectedElements 
    {
/// <summary>
///    Calculates Concentrated force web sidesway buckling 
/// </summary>
        /// <param name="M_u">  Required flexural strength </param>
/// <param name="M_y">  Moment at yielding of the extreme fiber  </param>
/// <param name="b_f">  Width of flange  </param>
/// <param name="t_f">  Thickness of flange   </param>
/// <param name="t_w">  Thickness of web  </param>
/// <param name="L_b_flange">  Largest laterally unbraced lengthalong either flange at the point of load </param>
/// <param name="h_web">  Clear distance between flanges less the fillet or corner radius for rolled shapes </param>

        /// <returns name="phiR_n"> Strength of member or connection </returns>

        [MultiReturn(new[] { "phiR_n" })]
        public static Dictionary<string, object> WebSideswayBuckling(double M_u,double M_y,double b_f,double t_f,double t_w,double L_b_flange,double h_web)
        {
            //Default values
            double phiR_n = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_n", phiR_n }
 
            };
        }


        //internal AffectedElements (double M_u,double M_y,double b_f,double t_f,double t_w,double L_b_flange,double h_web)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static AffectedElements  ByInputParameters(double M_u,double M_y,double b_f,double t_f,double t_w,double L_b_flange,double h_web)
        //{
        //    return new AffectedElements(M_u ,M_y ,b_f ,t_f ,t_w ,L_b_flange ,h_web );
        //}

    }
}


