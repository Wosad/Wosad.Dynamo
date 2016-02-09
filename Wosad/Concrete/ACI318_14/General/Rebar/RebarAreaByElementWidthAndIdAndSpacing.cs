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

namespace Concrete.ACI318_14.General
{

/// <summary>
///     Rebar area by element width and Id and spacing
///     Category:   Concrete.ACI318_14.General
/// </summary>
/// 


    public partial class Rebar 
    {
        /// <summary>
        ///     Rebar area by width and spacing
        /// </summary>
        /// <param name="RebarSizeId">  Rebar designation (number) indicating the size of the bar </param>
        /// <param name="b_element">  Element width </param>
        /// <param name="s">   Center-to-center spacing of items, such as longitudinal reinforcement, transverse reinforcement,  tendons, or anchors  </param>
        /// <param name="N_faces">  Number of faces (layers) of reinforcement </param>
        /// <returns name="A_s">  Area of nonprestressed longitudinal tension reinforcement  </returns>

        [MultiReturn(new[] { "A_s" })]
        public static Dictionary<string, object> RebarAreaByElementWidthAndIdAndSpacing(string RebarSizeId,double b_element,double s,double N_faces)
        {
            //Default values
            double A_s = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "A_s", A_s }
 
            };
        }


    }
}


