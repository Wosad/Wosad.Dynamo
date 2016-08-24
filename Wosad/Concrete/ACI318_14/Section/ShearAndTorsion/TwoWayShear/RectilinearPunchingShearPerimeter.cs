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

namespace Concrete.ACI318_14.Section.ShearAndTorsion
{

/// <summary>
///     Rectilinear punching shear perimeter
///     Category:   Concrete.ACI318_14.Section.ShearAndTorsion
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class TwoWayShear 
    {
/// <summary>
///     Rectilinear punching shear perimeter
/// </summary>
        /// <param name="ColumnLocationCase">  Indicates the location and type of punching perimeter for two-way shear calculations (interior, edge, corner) </param>
/// <param name="d">   Distance from extreme compression fiber to centroid  of longitudinal tension reinforcement  </param>
/// <param name="c_1">   Dimension of rectangular or equivalent rectangular  column, capital, or bracket measured in the direction of the span for which moments are being determined  </param>
/// <param name="c_2">   Dimension of rectangular or equivalent rectangular  column, capital, or bracket measured in the direction perpendicular to c1  </param>
/// <param name="b_1">   Dimension of the critical section bo measured in the  direction of the span for which moments are determined  </param>
/// <param name="b_2">   Dimension of the critical section bo measured in the  direction perpendicular to b1  </param>

        /// <returns name="PunchingShearPerimeter"> Punching shear (two-way shear) perimeter object. Create the object using input parameters first </returns>

        [MultiReturn(new[] { "PunchingShearPerimeter" })]
        public static Dictionary<string, object> RectilinearPunchingShearPerimeter(string ColumnLocationCase,double d,double c_1,double c_2,double b_1,double b_2)
        {
            //Default values
            PunchingShearPerimeter PunchingShearPerimeter = 


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "PunchingShearPerimeter", PunchingShearPerimeter }
 
            };
        }


        //internal TwoWayShear (string ColumnLocationCase,double d,double c_1,double c_2,double b_1,double b_2)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static TwoWayShear  ByInputParameters(string ColumnLocationCase,double d,double c_1,double c_2,double b_1,double b_2)
        //{
        //    return new TwoWayShear(ColumnLocationCase ,d ,c_1 ,c_2 ,b_1 ,b_2 );
        //}

    }
}


