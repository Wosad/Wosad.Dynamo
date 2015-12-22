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
///     Prying action minimum plate thickness
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Bolted 
    {
/// <summary>
///    Calculates Prying action minimum plate thickness
/// </summary>
        /// <param name="T_u">  Required tension force </param>
/// <param name="b_f">  Width of flange  </param>
/// <param name="g">  Transverse center-to-center spacing (gage) between fastener gage lines   </param>
/// <param name="p">  Pitch </param>
/// <param name="F_u">  Specified minimum tensile strength   </param>
/// <param name="B_c">  Bolt tensile strength for prying action </param>
/// <param name="SteelShapeGroupFlexure">  Type of steel shape for flexural calculations </param>

        /// <returns name="t_min"> Minimum thickness of connection material </returns>

        [MultiReturn(new[] { "t_min" })]
        public static Dictionary<string, object> MinimumPlateThicknessEffectsOfPryingAction(double T_u,double b_f,double g,double p,double F_u,double B_c,string SteelShapeGroupFlexure)
        {
            //Default values
            double t_min = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "t_min", t_min }
 
            };
        }


        //internal Bolted (double T_u,double b_f,double g,double p,double F_u,double B_c,string SteelShapeGroupFlexure)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Bolted  ByInputParameters(double T_u,double b_f,double g,double p,double F_u,double B_c,string SteelShapeGroupFlexure)
        //{
        //    return new Bolted(T_u ,b_f ,g ,p ,F_u ,B_c ,SteelShapeGroupFlexure );
        //}

    }
}


