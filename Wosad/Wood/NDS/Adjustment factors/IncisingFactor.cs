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

#endregion

namespace Wood.NDS
{

/// <summary>
///     Incising factor
///     Category:   Wood.NDS
/// </summary>
/// 



    public partial class AdjustmentFactor 
    {
    /// <summary>
    ///     Incising factor
    /// </summary>
    /// <param name="ReferenceDesignValueType">  Identifies the type of value for which adjustment factor is calculated </param>
    /// <param name="WoodMemberType">  Distinguishes between dimensional lumber, timber,glulam etc. </param>
    /// <param name="Code">  Identifies the code or standard used for calculations </param>
    /// <returns name="C_i"> Incising factor for dimension lumber </returns>

        [MultiReturn(new[] { "C_i" })]
        public static Dictionary<string, object> IncisingFactor(string ReferenceDesignValueType,
             string WoodMemberType = "SawnDimensionLumber", string Code = "NDS2015")
        {
            //Default values
            double C_i = 0;


            //Calculation logic:
            if (WoodMemberType.Contains("Sawn") && WoodMemberType.Contains("Lumber"))
            {

            }
            else
            {
                throw new Exception("Wood member type not supported.");
            }

            return new Dictionary<string, object>
            {
                { "C_i", C_i }
 
            };
        }



    }
}


