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
///     Arbitrary punching shear perimeter
///     Category:   Concrete.ACI318_14.Section.ShearAndTorsion
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class TwoWayShear 
    {
/// <summary>
///     Arbitrary punching shear perimeter
/// </summary>
        
        /// <returns name="PunchingShearPerimeter"> Punching shear (two-way shear) perimeter object. Create the object using input parameters first </returns>

        [MultiReturn(new[] { "PunchingShearPerimeter" })]
        public static Dictionary<string, object> ArbitraryPunchingShearPerimeter()
        {
            //Default values
            PunchingShearPerimeter PunchingShearPerimeter = 


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "PunchingShearPerimeter", PunchingShearPerimeter }
 
            };
        }


        //internal TwoWayShear ()
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static TwoWayShear  ByInputParameters()
        //{
        //    return new TwoWayShear();
        //}

    }
}


