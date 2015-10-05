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
 
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wosad.Common.CalculationLogger;
using Wosad.Common.CalculationLogger.Interfaces;
using Wosad.Reporting.ResultBuilder;

namespace Report
{
    public static class Report
    {
        public static string ReportCollector(List<string> ReportParts, string filename)
        {
            try
            {
                var reportsCollection = new List<ICalcLog>();
                foreach (var report in ReportParts)
                {
                    ICalcLog objectReport = JsonConvert.DeserializeObject<CalcLog>(report);
                    reportsCollection.Add(objectReport);
                }

                ResultBuilder buidler = new ResultBuilder();
                var result = buidler.BuildResultStream(reportsCollection, CalculatorOutputType.Word);

                File.WriteAllBytes(filename, result);

                return "File was saved successfully!";
            }
            catch (Exception ex)
            {
                return ex.Message;
                //return "Wrong input data!";
            }
        }
    }
}
