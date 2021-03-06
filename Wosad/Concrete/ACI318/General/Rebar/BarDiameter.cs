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

namespace Concrete.ACI318_14.General.Rebar
{

/// <summary>
///     Bar diameter
///     Category:   Concrete.ACI318_14.General.Rebar
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Rebar 
    {
/// <summary>
///     Bar diameter
/// </summary>
        /// <param name="RebarSizeId">  Rebar designation (number) indicating the size of the bar </param>

        /// <returns name="d_b">  Nominal diameter of bar, wire, or prestressing  strand  </returns>

        [MultiReturn(new[] { "d_b" })]
        public static Dictionary<string, object> BarDiameter(string RebarSizeId)
        {
            //Default values
            double d_b = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "d_b", d_b }
 
            };
        }


        //internal Rebar (string RebarSizeId)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Rebar  ByInputParameters(string RebarSizeId)
        //{
        //    return new Rebar(RebarSizeId );
        //}

    }
}


