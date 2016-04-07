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
///     Shear friction strength
///     Category:   Concrete.ACI318_14.Section.ShearAndTorsion
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class OneWayShear 
    {
/// <summary>
///     Shear friction strength
/// </summary>
        /// <param name="ShearFrictionContactSurface">  Indicates contact surface condition used to calculate coefficient of friction </param>
/// <param name="A_vf">   Area of shear-friction reinforcement  </param>
/// <param name="f_y">   Specified yield strength for nonprestressed reinforcement  </param>

        
        [MultiReturn(new[] {  })]
        public static Dictionary<string, object> ShearFrictionStrength(string ShearFrictionContactSurface,double A_vf,double f_y)
        {
            //Default values
            

            //Calculation logic:


            return new Dictionary<string, object>
            {
                 
            };
        }


        //internal OneWayShear (string ShearFrictionContactSurface,double A_vf,double f_y)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static OneWayShear  ByInputParameters(string ShearFrictionContactSurface,double A_vf,double f_y)
        //{
        //    return new OneWayShear(ShearFrictionContactSurface ,A_vf ,f_y );
        //}

    }
}


