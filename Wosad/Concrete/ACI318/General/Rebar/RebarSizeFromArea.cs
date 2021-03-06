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
///     Rebar size from area
///     Category:   Concrete.ACI318_14.General.Rebar
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Rebar 
    {
/// <summary>
///     Rebar size from area
/// </summary>
        /// <param name="A_req">  Required reinforcement area </param>
/// <param name="N_bars">  Number of bars </param>

        /// <returns name="RebarSizeId"> Rebar designation (number) indicating the size of the bar </returns>

        [MultiReturn(new[] { "RebarSizeId" })]
        public static Dictionary<string, object> RebarSizeFromArea(double A_req,double N_bars)
        {
            //Default values
            string RebarSizeId = "";


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "RebarSizeId", RebarSizeId }
 
            };
        }


        //internal Rebar (double A_req,double N_bars)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Rebar  ByInputParameters(double A_req,double N_bars)
        //{
        //    return new Rebar(A_req ,N_bars );
        //}

    }
}


