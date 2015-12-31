﻿#region Copyright
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


    [IsDesignScriptCompatible]
    public partial class Welded
    {


        internal Welded(string WeldGroupPattern, double l_transv, double l_longit, double w_weld, double F_EXX)
        {

        }
        [IsVisibleInDynamoLibrary(false)]
        public static Welded ByInputParameters(string WeldGroupPattern, double l_transv, double l_longit, double w_weld, double F_EXX)
        {
            return new Welded(WeldGroupPattern, l_transv, l_longit, w_weld, F_EXX);
        }
    }
}
