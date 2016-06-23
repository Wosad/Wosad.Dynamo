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

namespace Concrete.ACI318_14.Section.Compression
{

/// <summary>
///     Moment gradient coefficient
///     Category:   Concrete.ACI318_14.Section.Compression
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class Stability 
    {
/// <summary>
///     Moment gradient coefficient
/// </summary>
        /// <param name="ColumnTransverseLoadCase">  Type of column transverse load arrangement (determines whether transverse loads are present  along member length) </param>
/// <param name="M_1">   Lesser factored end moment on a compression  member   </param>
/// <param name="M_2">   Greater factored end moment on a compression  member. If transverse loading occurs between  supports, m2 is taken as the largest moment occurring in member. Value of m2 is always positive   </param>
/// <param name="P_u">   Factored axial force; to be taken as positive for  compression and negative for tension  </param>
/// <param name="h">   Overall thickness, height, or depth of member  </param>

        /// <returns name="C_m">  Factor relating actual moment diagram to an equivalent uniform moment diagram </returns>

        [MultiReturn(new[] { "C_m" })]
        public static Dictionary<string, object> MomentGradientCoefficient(string ColumnTransverseLoadCase,double M_1,double M_2,double P_u,double h)
        {
            //Default values
            double C_m = 0;


            //Calculation logic:


            return new Dictionary<string, object>
            {
                { "C_m", C_m }
 
            };
        }


        //internal Stability (string ColumnTransverseLoadCase,double M_1,double M_2,double P_u,double h)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static Stability  ByInputParameters(string ColumnTransverseLoadCase,double M_1,double M_2,double P_u,double h)
        //{
        //    return new Stability(ColumnTransverseLoadCase ,M_1 ,M_2 ,P_u ,h );
        //}

    }
}


