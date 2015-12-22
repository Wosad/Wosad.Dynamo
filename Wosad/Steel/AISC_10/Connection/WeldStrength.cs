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
///     Weld strength
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Welded 
    {
/// <summary>
///    Calculates Weld strength
/// </summary>
        /// <param name="A_weld">  Effective area of the weld </param>
/// <param name="F_EXX">  Filler metal classification strength </param>
/// <param name="WeldType">  Weld type </param>
/// <param name="WeldLoadTypeId">  Type of load on weld  under consideration </param>

        /// <returns name="phiR_n"> Strength of member or connection </returns>

        [MultiReturn(new[] { "phiR_n" })]
        public static Dictionary<string, object> WeldStrength(double A_weld,double F_EXX,string WeldType,string WeldLoadTypeId)
        {
            //Default values
            double phiR_n = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_n", phiR_n }
 
            };
        }


        //internal Welded (double A_weld,double F_EXX,string WeldType,string WeldLoadTypeId)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Welded  ByInputParameters(double A_weld,double F_EXX,string WeldType,string WeldLoadTypeId)
        //{
        //    return new Welded(A_weld ,F_EXX ,WeldType ,WeldLoadTypeId );
        //}

    }
}


