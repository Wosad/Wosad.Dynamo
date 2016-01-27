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

namespace Steel.AISC_10.Shear
{



    [IsDesignScriptCompatible]
    public partial class Strength 
    {


        internal Strength(double D, double t_nom, bool Is_SAW_member, double L_v, double F_y)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static Strength ByInputParameters(double D, double t_nom, bool Is_SAW_member, double L_v, double F_y)
        {
            return new Strength(D, t_nom, Is_SAW_member, L_v, F_y);
        }

    }
}


