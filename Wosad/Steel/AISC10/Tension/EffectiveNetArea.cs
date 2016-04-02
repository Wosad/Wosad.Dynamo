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

namespace Steel.AISC_10.Tension
{

/// <summary>
///     Effective net area 
///     Category:   Steel.AISC_10.Tension
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class EffectiveArea 
    {
/// <summary>
///    Calculates Effective area for tensile strength
/// </summary>
        /// <param name="ShearLagCaseId">  Defines the type of tension element for shear lag calculation </param>
/// <param name="A_n">  Net area of member   </param>
/// <param name="A_connected">  Area of directly connected elements (to be used for Case 3 from AISC Table D3.1) </param>
/// <param name="t_p">  Thickness of plate   </param>
/// <param name="l">  Length of connection or weld   </param>
/// <param name="B">  Overall width of rectangular steel section along face transferring load or overall width of rectangular HSS member  </param>
/// <param name="H">  Flexural constant or overall height of rectangular HSS member measured in the plane of the connection  </param>
/// <param name="IsBoltedSplice">  Identifies whether member is spliced using bolted plates </param>

        /// <returns name="A_e"> Effective net area </returns>

        [MultiReturn(new[] { "A_e" })]
        public static Dictionary<string, object> EffectiveNetArea(string ShearLagCaseId,double A_n, A_connected,double t_p,double l,double B,double H,bool IsBoltedSplice)
        {
            //Default values
            double A_e = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "A_e", A_e }
 
            };
        }


        //internal EffectiveArea (string ShearLagCaseId,double A_n, A_connected,double t_p,double l,double B,double H,bool IsBoltedSplice)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static EffectiveArea  ByInputParameters(string ShearLagCaseId,double A_n, A_connected,double t_p,double l,double B,double H,bool IsBoltedSplice)
        //{
        //    return new EffectiveArea(ShearLagCaseId ,A_n ,A_connected ,t_p ,l ,B ,H ,IsBoltedSplice );
        //}

    }
}


