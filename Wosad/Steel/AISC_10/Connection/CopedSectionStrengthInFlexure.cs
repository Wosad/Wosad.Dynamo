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
using System;
using Wosad.Steel.AISC;
using a=Wosad.Steel.AISC;

#endregion

namespace Steel.AISC_10.Connection
{

/// <summary>
///     Coped section strength in flexure
///     Category:   Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class AffectedElements 
    {
/// <summary>
///    Calculates Coped section strength in flexure
/// </summary>
/// <param name="d">  Full nominal depth of the section    </param>
        /// <param name="d_c">  Depth of cope    </param>
        /// <param name="c">  Length of cope    </param>
/// <param name="t_w">  Thickness of web  </param>
/// <param name="F_u">  Specified minimum tensile strength   </param>
/// <param name="BeamCopeCase">  Identifies beam cope condition for stability calculations: single cope vs double cope </param>

        /// <returns name="phiM_n"> Moment strength </returns>

        [MultiReturn(new[] { "phiM_n" })]
        public static Dictionary<string, object> CopedSectionStrengthInFlexure(double d, double d_cope, double c, double t_w, double F_u, string BeamCopeCase)
        {
            //Default values
            double phiM_n = 0;


            //Calculation logic:
              BeamCopeCase copeType;
              bool IsValidStringLoadType = Enum.TryParse(BeamCopeCase, true, out copeType);
                if (IsValidStringLoadType == true)
                {
                    switch (copeType)
                    {
                        case a.BeamCopeCase.CopedBothFlanges:
                            break;
                        case a.BeamCopeCase.CopedTopFlange:
                            break;
                        case a.BeamCopeCase.Uncoped:
                            break;
                        default:
                            break;
                    }
                    // logic`
                }
                else
                {
                    throw new Exception("Weld strength calculation failed. Invalid weld load case (type) designation.");
                }

            return new Dictionary<string, object>
            {
                { "phiM_n", phiM_n }
 
            };
        }


        //internal AffectedElements (double S_net,double d,double t_w,double F_u,string BeamCopeCase)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static AffectedElements  ByInputParameters(double S_net,double d,double t_w,double F_u,string BeamCopeCase)
        //{
        //    return new AffectedElements(S_net ,d ,t_w ,F_u ,BeamCopeCase );
        //}

    }
}


