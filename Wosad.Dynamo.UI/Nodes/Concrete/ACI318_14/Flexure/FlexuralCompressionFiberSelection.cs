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
 
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Dynamo.Controls;
using Dynamo.Models;
using Dynamo.Wpf;
using ProtoCore.AST.AssociativeAST;
using Wosad.Common.CalculationLogger;
using Wosad.Dynamo.Common;
using Dynamo.Nodes;
using System.Xml;
using Dynamo.Graph;
using Dynamo.Graph.Nodes;


namespace Wosad.Concrete.ACI318_14.Flexure
{

    /// <summary>
    ///Flexural compression fiber location selection  
    /// </summary>

    [NodeName("Flexural compression fiber location selection")]
    [NodeCategory("Wosad.Concrete.ACI318_14.Flexure")]
    [NodeDescription("Flexural compression fiber location selection")]
    [IsDesignScriptCompatible]
    public class FlexuralCompressionFiberSelection : UiNodeBase
    {

        public FlexuralCompressionFiberSelection()
        {
            
            //OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("FlexuralCompressionFiberLocation", "Indicates whether the section in flexure has top or bottom in compression due to stresses from bending moment"));
            RegisterAllPorts();
            SetDefaultParameters();
            //PropertyChanged += NodePropertyChanged;
        }

        private void SetDefaultParameters()
        {
            //ReportEntry="";
            FlexuralCompressionFiberLocation = "Top";
        }


        /// <summary>
        ///     Gets the type of this class, to be used in base class for reflection
        /// </summary>
        protected override Type GetModelType()
        {
            return GetType();
        }

        #region Properties

        #region InputProperties



	    #endregion

        #region OutputProperties

		#region FlexuralCompressionFiberLocationProperty
		
		/// <summary>
		/// FlexuralCompressionFiberLocation property
		/// </summary>
		/// <value>Indicates whether the section in flexure has top or bottom in compression due to stresses from bending moment</value>
		public string _FlexuralCompressionFiberLocation;
		
		public string FlexuralCompressionFiberLocation
		{
		    get { return _FlexuralCompressionFiberLocation; }
		    set
		    {
		        _FlexuralCompressionFiberLocation = value;
		        RaisePropertyChanged("FlexuralCompressionFiberLocation");
		        OnNodeModified(true); 
		    }
		}
		#endregion



        #region ReportEntryProperty

        /// <summary>
        /// log property
        /// </summary>
        /// <value>Calculation entries that can be converted into a report.</value>

        //public string reportEntry;

        //public string ReportEntry
        //{
        //    get { return reportEntry; }
        //    set
        //    {
        //        reportEntry = value;
        //        RaisePropertyChanged("ReportEntry");
        //        OnNodeModified(true); 
        //    }
        //}




        #endregion

        #endregion
        #endregion

        #region Serialization

        /// <summary>
        ///Saves property values to be retained when opening the node     
        /// </summary>
        protected override void SerializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.SerializeCore(nodeElement, context);
            nodeElement.SetAttribute("FlexuralCompressionFiberLocation", FlexuralCompressionFiberLocation);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["FlexuralCompressionFiberLocation"];
            if (attrib == null)
                return;

            FlexuralCompressionFiberLocation = attrib.Value;
            //SetComponentDescription();

        }




        #endregion



        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class FlexuralCompressionFiberSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<FlexuralCompressionFiberSelection>
        {
            public void CustomizeView(FlexuralCompressionFiberSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                FlexuralCompressionFiberSelectionView control = new FlexuralCompressionFiberSelectionView();
                control.DataContext = model;
                
                
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }

        }
    }
}
