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

namespace Wosad.Steel.AISC_10.Shear
{

/// <summary>
///     Shear case selection
///     Category:   Wosad.Steel.AISC_10.Shear
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class GeneralParameters 
    {
/// <summary>
///    Calculates Member shear case
/// </summary>
        
        /// <returns name="ShearCase"> Shape type for shear </returns>

        [MultiReturn(new[] { "ShearCase" })]
        public static Dictionary<string, object> ShearCase()
        {
            //Default values
            string ShearCase = "";


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "ShearCase", ShearCase }
 
            };
        }


        //internal GeneralParameters ()
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static GeneralParameters  ByInputParameters()
        //{
        //    return new GeneralParameters();
        //}

    }
}


