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
///     Effective weld area
///     Category:   Wosad.Steel.AISC_10.Connection
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Welded 
    {
/// <summary>
///    Calculates Effective weld area
/// </summary>
        /// <param name="l">  Length of connection or weld   </param>
/// <param name="t_weld">  Weld throat thickness </param>

        /// <returns name="A_weld"> Effective area of the weld </returns>

        [MultiReturn(new[] { "A_weld" })]
        public static Dictionary<string, object> WeldArea(double l,double t_weld)
        {
            //Default values
            double A_weld = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "A_weld", A_weld }
 
            };
        }


        //internal Welded (double l,double t_weld)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Welded  ByInputParameters(double l,double t_weld)
        //{
        //    return new Welded(l ,t_weld );
        //}

    }
}


