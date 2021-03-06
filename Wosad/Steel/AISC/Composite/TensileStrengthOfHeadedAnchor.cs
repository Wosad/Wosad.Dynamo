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

namespace Steel.AISC_10.Composite
{

/// <summary>
///     Tensile strength of headed anchor
///     Category:   Wosad.Steel.AISC_10.Composite
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Anchor 
    {
/// <summary>
///    Calculates Tensile strength of headed  anchor
/// </summary>
        
        /// <returns name="Q_n"> Nominal strength of one steel headed stud or steel channel anchor  </returns>

        [MultiReturn(new[] { "Q_n" })]
        public static Dictionary<string, object> TensileStrengthOfHeadedAnchor()
        {
            //Default values
            double Q_n = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "Q_n", Q_n }
 
            };
        }


        //internal Anchor ()
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Anchor  ByInputParameters()
        //{
        //    return new Anchor();
        //}

    }
}


