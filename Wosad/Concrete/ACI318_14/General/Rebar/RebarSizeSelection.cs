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
///     Rebar cover to group centroid
///     Category:   Concrete.ACI318_14.General.Rebar
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Rebar 
    {
/// <summary>
///     Rebar cover to group centroid
/// </summary>
        /// <param name="RebarSizeId">  Rebar designation (number) indicating the size of the bar </param>
/// <param name="s_clear">  Clear spacing between bars </param>
/// <param name="c_c">   Clear cover of reinforcement  </param>

        /// <returns name="c_cntr"> Concrete cover to rebar centroid </returns>

        [MultiReturn(new[] { "c_cntr" })]
        public static Dictionary<string, object> RebarSizeSelection(string RebarSizeId,double s_clear,double c_c)
        {
            //Default values
            double c_cntr = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "c_cntr", c_cntr }
 
            };
        }


        //internal Rebar (string RebarSizeId,double s_clear,double c_c)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Rebar  ByInputParameters(string RebarSizeId,double s_clear,double c_c)
        //{
        //    return new Rebar(RebarSizeId ,s_clear ,c_c );
        //}

    }
}


