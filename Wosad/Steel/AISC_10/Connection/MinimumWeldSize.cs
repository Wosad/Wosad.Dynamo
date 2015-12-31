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

namespace Steel.AISC_10.Connection
{

/// <summary>
///     Weld minimum size
///     Category:   Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Welded 
    {
/// <summary>
///    Calculates Weld minimum size
/// </summary>
        /// <param name="WeldType">  Weld type </param>

        /// <returns name="w_weld"> Size of weld leg </returns>

        [MultiReturn(new[] { "w_weld" })]
        public static Dictionary<string, object> MinimumWeldSize(string WeldType)
        {
            //Default values
            double w_weld = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "w_weld", w_weld }
 
            };
        }


        //internal Welded (string WeldType)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Welded  ByInputParameters(string WeldType)
        //{
        //    return new Welded(WeldType );
        //}

    }
}


