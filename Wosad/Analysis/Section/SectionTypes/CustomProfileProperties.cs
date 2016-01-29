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
using Wosad.Common.CalculationLogger;
using Wosad.Common.Section.Predefined;
using Wosad.Common.Section.Interfaces;

#endregion

namespace Analysis.Section
{

    /// <summary>
    ///     Shape properties about X axis
    ///     Category:    Analysis.Section
    /// </summary>
    /// 


    public partial class CustomProfileProperties
    {
        /// <summary>
        ///    Calculates AISC shape properties about X axis
        /// </summary>
        /// <param name="SteelShapeId">  Section name from steel shape database </param>
        ///  <returns name="A"> Cross-sectional area </returns>
        /// <returns name="y_e"> Vertical distance from designated member edge to member elastic centroidal axis </returns>
        /// <returns name="y_p"> Vertical distance from designated member edge  to member plastic neutral axis </returns>
        /// <returns name="I_x"> Moment of inertia about the principal x-axis </returns>
        /// <returns name="Z_x"> Plastic section modulus about the x-axis  </returns>
        /// <returns name="S_xBot"> Elastic section modulus taken about the x-axis, with respect to bottom fiber  </returns>
        /// <returns name="S_xTop"> Elastic section modulus taken about the x-axis, with respect to top fiber  </returns>
        /// <returns name="r_y"> Radius of gyration about the y-axis  </returns>
        /// 

        [MultiReturn(new[] { "A","y_e", "y_p", "I_x", "Z_x", "S_xBot", "S_xTop", "r_y" })]
        public static Dictionary<string, object> XAxisProperties(CustomProfile shape)
        {
            //Default values
            double y_e = 0;
            double y_p = 0;
            double I_x = 0;
            double Z_x = 0;
            double S_xBot = 0;
            double S_xTop = 0;
            double r_y = 0;
            double A =0;

            A = shape.Section.A;
            y_e = shape.Section.y_Bar;
            y_p = shape.Section.x_pBar;
            I_x = shape.Section.I_x;
            Z_x = shape.Section.Z_x;
            S_xBot = shape.Section.S_xBot;
            S_xTop = shape.Section.S_xTop;
            r_y = shape.Section.r_y;

            return new Dictionary<string, object>
            {
             { "A", A }
            ,{ "y_e", y_e }
            ,{ "y_p", y_p }
            ,{ "I_x", I_x }
            ,{ "Z_x", Z_x }
            ,{ "S_xBot", S_xBot }
            ,{ "S_xTop", S_xTop }
            ,{ "r_x", r_y }
            };
            }

        [IsVisibleInDynamoLibrary(false)]
        internal CustomProfileProperties()
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static CustomProfileProperties ByInputParameters()
        {
            return new CustomProfileProperties();
        }

    }
}


