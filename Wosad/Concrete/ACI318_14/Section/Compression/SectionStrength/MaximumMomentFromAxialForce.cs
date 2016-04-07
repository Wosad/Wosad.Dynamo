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
///     Moment strength with axial force
///     Category:   Concrete.ACI318_14.Section.Compression
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class SectionStrength 
    {
/// <summary>
///     Moment strength with axial force
/// </summary>
        /// <param name="P_u">   Factored axial force; to be taken as positive for  compression and negative for tension  </param>
/// <param name="ConcreteSection">  Reinforced concrete section </param>
/// <param name="CompressionMemberType">  Type of compression member (tied, spiral etc) </param>

        
        [MultiReturn(new[] {  })]
        public static Dictionary<string, object> MaximumMomentFromAxialForce(double P_u,ConcreteSection ConcreteSection,string CompressionMemberType)
        {
            //Default values
            

            //Calculation logic:


            return new Dictionary<string, object>
            {
                 
            };
        }


        //internal SectionStrength (double P_u,ConcreteSection ConcreteSection,string CompressionMemberType)
        //{

        //}
        //[IsVisibleInDynamoLibrary(false)]
        //public static SectionStrength  ByInputParameters(double P_u,ConcreteSection ConcreteSection,string CompressionMemberType)
        //{
        //    return new SectionStrength(P_u ,ConcreteSection ,CompressionMemberType );
        //}

    }
}


