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


    public partial class SectionPipe: CustomProfile
    {

        [IsVisibleInDynamoLibrary(false)]
        internal SectionPipe(double D, double t_nom, double t_des)
        {
            if (t_des == 0)
            {
                t_des = t_nom;
            }
            ISection  r = new ds.SectionPipe("", D, t_nom,t_des);
            Section = r;
        }

        public static SectionPipe ByDiameterWallThickness(double D, double t_nom, double t_des=0)
        {
            return new SectionPipe(D, t_nom, t_des);
        }

    }
}