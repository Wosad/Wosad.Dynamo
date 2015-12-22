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
///     Bearing strength at bolt hole
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Bolted 
    {
/// <summary>
///    Calculates Bearing strength at bolt hole
/// </summary>
        /// <param name="BoltHoleType">  Type of bolt hole </param>
/// <param name="l_c">  Clear distance in the direction of the force between the edge of the hole and the edge of the adjacent hole or edge of the material  </param>
/// <param name="F_u">  Specified minimum tensile strength   </param>
/// <param name="F_y">  Specified minimum yield stress </param>
/// <param name="d_b">  Nominal fastener diameter </param>
/// <param name="t">  Thickness of element plate or element wall  </param>
/// <param name="BoltHoleDeformationType">  Identifies of bolt deformation is a design consideration </param>
/// <param name="IsUnstiffenedHollowSection">  Distinguishes between connections made using bolts that pass completely through an unstiffened box member or HSS and all other cases </param>

        /// <returns name="phiR_nv"> Connection shear strength </returns>

        [MultiReturn(new[] { "phiR_nv" })]
        public static Dictionary<string, object> BearingStrengthAtBoltHole(string BoltHoleType,double l_c,double F_u,double F_y,double d_b,double t,string BoltHoleDeformationType,bool IsUnstiffenedHollowSection)
        {
            //Default values
            double phiR_nv = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_nv", phiR_nv }
 
            };
        }


        //internal Bolted (string BoltHoleType,double l_c,double F_u,double F_y,double d_b,double t,string BoltHoleDeformationType,bool IsUnstiffenedHollowSection)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Bolted  ByInputParameters(string BoltHoleType,double l_c,double F_u,double F_y,double d_b,double t,string BoltHoleDeformationType,bool IsUnstiffenedHollowSection)
        //{
        //    return new Bolted(BoltHoleType ,l_c ,F_u ,F_y ,d_b ,t ,BoltHoleDeformationType ,IsUnstiffenedHollowSection );
        //}

    }
}


