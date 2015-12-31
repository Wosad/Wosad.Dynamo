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
///     Concentrated force web panel zone shear
///     Category:   Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class AffectedElements 
    {
/// <summary>
///    Calculates Concentrated force web panel zone shear
/// </summary>
        /// <param name="t_w">  Thickness of web  </param>
/// <param name="F_y">  Specified minimum yield stress </param>
/// <param name="d">  Full nominal depth of the section    </param>
/// <param name="P_u">  Required axial strength </param>
/// <param name="A_g">  Gross cross-sectional area of member </param>

        /// <returns name="phiR_n"> Strength of member or connection </returns>

        [MultiReturn(new[] { "phiR_n" })]
        public static Dictionary<string, object> WebPanelZoneShear(double t_w,double F_y,double d,double P_u,double A_g)
        {
            //Default values
            double phiR_n = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_n", phiR_n }
 
            };
        }


        //internal AffectedElements (double t_w,double F_y,double d,double P_u,double A_g)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static AffectedElements  ByInputParameters(double t_w,double F_y,double d,double P_u,double A_g)
        //{
        //    return new AffectedElements(t_w ,F_y ,d ,P_u ,A_g );
        //}

    }
}


