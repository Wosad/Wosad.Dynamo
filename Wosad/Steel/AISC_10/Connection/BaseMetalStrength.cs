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
///     Base metal strength
///     Category:   Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Welded 
    {
/// <summary>
///    Calculates Base metal strength
/// </summary>
        /// <param name="F_y">  Specified minimum yield stress </param>
/// <param name="A_base">  Area of base metal in a welded connection </param>

        /// <returns name="phiR_n"> Strength of member or connection </returns>

        [MultiReturn(new[] { "phiR_n" })]
        public static Dictionary<string, object> BaseMetalStrength(double F_y,double A_base)
        {
            //Default values
            double phiR_n = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "phiR_n", phiR_n }
 
            };
        }


        //internal Welded (double F_y,double A_base)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Welded  ByInputParameters(double F_y,double A_base)
        //{
        //    return new Welded(F_y ,A_base );
        //}

    }
}


