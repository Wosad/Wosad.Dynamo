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
using Wosad.Concrete.ACI.Entities;
using System;
using Wosad.Concrete.ACI;
using Dynamo.Graph.Nodes;

#endregion

namespace Concrete.ACI318_14.General.Concrete
{

/// <summary>
///     Concrete material
///     Category:   Concrete.ACI318_14.General
/// </summary>
/// 


    [IsDesignScriptCompatible]
    public partial class ConcreteMaterial 
    {

        [IsVisibleInDynamoLibrary(false)]
        internal ConcreteMaterial(double f_c_prime, string ConcreteMaterialWeight="Normalweight")
        {
            ConcreteTypeByWeight weightType;
            bool IsValidString = Enum.TryParse(ConcreteMaterialWeight, true, out weightType);
            if (IsValidString == false)
            {
                throw new Exception("Concrete weight selection string is not recognized. Check input.");
            }

            //Convert default ksi units to psi units used by ACI
            double f_c_prime_psi = f_c_prime * 1000;
            this.Concrete = new Wosad.Concrete.ACI318_14.Materials.ConcreteMaterial(f_c_prime_psi, weightType, null);
        }
        /// <summary>
        ///     Concrete material
        /// </summary>
        /// <param name="f_c_prime">   Specified compressive strength of concrete  </param>
        /// <param name="ConcreteMaterialWeight">  Type of concrete by weight (normalweight vs. lightweight) </param>
        /// <returns name="ConcreteMaterial"> Concrete materal object used to extract material properties, create the object using input parameters first </returns>
        
        public static ConcreteMaterial  ByStrengthAndWeight(double f_c_prime,string ConcreteMaterialWeight="Normalweight")
        {
            return new ConcreteMaterial(f_c_prime, ConcreteMaterialWeight);
        }

         [IsVisibleInDynamoLibrary(false)]
        public IConcreteMaterial Concrete { get; set; }
    }
}


