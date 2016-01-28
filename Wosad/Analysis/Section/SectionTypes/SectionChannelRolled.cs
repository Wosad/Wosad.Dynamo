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
using Wosad.Common.Section.Interfaces;
using ds = Wosad.Common.Section.SectionTypes;

#endregion

namespace Analysis.Section.SectionTypes
{


    public partial class SectionChannelRolled: CustomProfile
    {

        [IsVisibleInDynamoLibrary(false)]
        internal SectionChannelRolled(double d, double b_f, double t_f, double t_w, double k)
        {
            ISection r = new ds.SectionChannelRolled("", d, b_f, t_f, t_w, k);
            Section = r;
        }

        public static SectionChannelRolled ByFlangeAndWebDimensions(double d, double b_f, double t_f, double t_w, double k)
        {
            return new SectionChannelRolled(d, b_f, t_f, t_w, k);
        }

    }
}