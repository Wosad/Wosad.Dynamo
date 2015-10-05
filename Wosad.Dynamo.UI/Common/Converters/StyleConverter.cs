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
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Wosad.Dynamo.Common.Infra.Converters
{
    public class StyleConverter : IValueConverter
    {

        private ResourceDictionary resourceDictionary;
        public ResourceDictionary ResourceDictionary
        {
            get { return resourceDictionary; }
            set
            {
                resourceDictionary = value;
            }
        }

        public object Convert(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            Style style = null;
            //ResourceProvider loc = parameter as ResourceProvider;
            //if (loc != null)
            //{
            string iconKey = value as string;
            try
            {
                if (iconKey != null) style = resourceDictionary[iconKey] as Style;
            }
            catch (Exception)
            {

                //do nothing
            }


            return style;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
