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

namespace Wosad.Steel.AISC_10.Combination
{

/// <summary>
///     Interaction ratio
///     Category:   Wosad.Steel.AISC_10.Combination
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Interaction 
    {
/// <summary>
///    Calculates Interaction ratio for the combination of forces
/// </summary>
        /// <param name="CombinationCaseId">  Defines a type of interaction equation to be used </param>
/// <param name="P_u">  Required axial strength </param>
/// <param name="M_ux">  Required flexural strength with respect to x-axis </param>
/// <param name="M_uy">  Required flexural strength with respect to x-axis </param>
/// <param name="V_ux">  Required shear strength with respect to x-axis </param>
/// <param name="V_uy">  Required shear strength with respect to x-axis </param>
/// <param name="phiP_n">  Compressive strength </param>
/// <param name="phiM_nx">  Moment strength with respect to section x-axis </param>
/// <param name="phiM_ny">  Moment strength with respect to section y-axis </param>
/// <param name="phiV_nx">  Shear strength with respect to section y-axis </param>
/// <param name="phiV_ny">  Shear strength with respect to section x-axis </param>

        /// <returns name="PMM_Ratio"> Interaction ratio </returns>

        [MultiReturn(new[] { "PMM_Ratio" })]
        public static Dictionary<string, object> PMM(string CombinationCaseId,double P_u,double M_ux,double M_uy,double V_ux,double V_uy,double phiP_n,double phiM_nx,double phiM_ny,double phiV_nx,double phiV_ny)
        {
            //Default values
            double PMM_Ratio = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "PMM_Ratio", PMM_Ratio }
 
            };
        }


        //internal Interaction (string CombinationCaseId,double P_u,double M_ux,double M_uy,double V_ux,double V_uy,double phiP_n,double phiM_nx,double phiM_ny,double phiV_nx,double phiV_ny)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Interaction  ByInputParameters(string CombinationCaseId,double P_u,double M_ux,double M_uy,double V_ux,double V_uy,double phiP_n,double phiM_nx,double phiM_ny,double phiV_nx,double phiV_ny)
        //{
        //    return new Interaction(CombinationCaseId ,P_u ,M_ux ,M_uy ,V_ux ,V_uy ,phiP_n ,phiM_nx ,phiM_ny ,phiV_nx ,phiV_ny );
        //}

    }
}


