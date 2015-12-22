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
///     Eccentrically loaded weld group strength
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Welded 
    {
/// <summary>
///    Calculates Eccentrically loaded weld group strength
/// </summary>
        /// <param name="C_WeldGroup">  Coefficient for eccentrically loaded weld group </param>
/// <param name="w_weld">  Size of weld leg </param>
/// <param name="F_EXX">  Filler metal classification strength </param>

        /// <returns name="phiR_n"> Strength of member or connection </returns>

        [MultiReturn(new[] { "phiR_n" })]
        public static Dictionary<string, object> WeldGroupStrength(double C_WeldGroup,double w_weld,double F_EXX)
        {
            //Default values
            double phiR_n = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_n", phiR_n }
 
            };
        }


        //internal Welded (double C_WeldGroup,double w_weld,double F_EXX)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Welded  ByInputParameters(double C_WeldGroup,double w_weld,double F_EXX)
        //{
        //    return new Welded(C_WeldGroup ,w_weld ,F_EXX );
        //}

    }
}


