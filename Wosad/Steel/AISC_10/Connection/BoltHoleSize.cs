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
using b = Wosad.Steel.Tests.AISC.AISC360_10.Connections.Bolt;
using Wosad.Steel.AISC.SteelEntities.Bolts;
using System;

#endregion

namespace Steel.AISC_10.Connection
{

/// <summary>
///     Bolt nominal hole dimension
///     Category:   Steel.AISC_10.Connection
/// </summary>
/// 


    public partial class Bolted 
    {
        /// <summary>
        ///    Calculates Bolt nominal hole dimension
        /// </summary>
        /// <param name="d_b">  Nominal fastener diameter </param>
        /// <param name="BoltHoleType">  Type of bolt hole </param>
        /// <returns name="d_hole"> Bolt hole diameter </returns>

        [MultiReturn(new[] { "d_hole" })]
        public static Dictionary<string, object> BoltHoleSize(double d_b,string BoltHoleType)
        {
            //Default values
            double d_hole = 0;
            BoltHoleType holeType;
            bool IsValidString =Enum.TryParse(BoltHoleType, true, out holeType);
            if (IsValidString == true)
            {
                b.BoltGeneral b = new b.BoltGeneral(d_b, 0, 0);
                d_hole = b.GetBoltHoleWidth(holeType, true);
            }
            else
            {
                throw new Exception("Bolt hole calculation failed. Invalid hole type designation.");
            }

            return new Dictionary<string, object>
            {
                { "d_hole", d_hole }
 
            };
        }


    }
}


