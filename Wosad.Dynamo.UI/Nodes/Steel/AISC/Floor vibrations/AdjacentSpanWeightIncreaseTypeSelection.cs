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
using Dynamo.Graph.Nodes;
using System.Xml;
using Dynamo.Graph;


namespace Wosad.Steel.AISC.FloorVibrations.EffectiveProperties
{

    /// <summary>
    ///Adjacent span weight increase type  
    /// </summary>

    [NodeName("Adjacent span weight increase type")]
    [NodeCategory("Wosad.Steel.AISC.FloorVibrations.EffectiveProperties")]
    [NodeDescription("Adjacent span weight increase type")]
    [IsDesignScriptCompatible]
    public class AdjacentSpanWeightIncreaseTypeSelection : UiNodeBase
    {

        public AdjacentSpanWeightIncreaseTypeSelection()
        {
            
            //OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("AdjacentSpanWeightIncreaseType", "Identifies whether the effective joist weight can be incretased due to continuous over the column and adjacent span is greater than 0.7 times the span considered, or for joists whether bottom chord is extended."));
            RegisterAllPorts();
            SetDefaultParameters();
            //PropertyChanged += NodePropertyChanged;
        }

        private void SetDefaultParameters()
        {
            //ReportEntry="";
            this.AdjacentSpanWeightIncreaseType ="None";
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

		#region AdjacentSpanWeightIncreaseTypeProperty
		
		/// <summary>
		/// AdjacentSpanWeightIncreaseType property
		/// </summary>
		/// <value>Identifies whether the effective joist weight can be incretased due to continuous over the column and adjacent span is greater than 0.7 times the span considered, or for joists whether bottom chord is extended.</value>
		public string _AdjacentSpanWeightIncreaseType;
		
		public string AdjacentSpanWeightIncreaseType
		{
		    get { return _AdjacentSpanWeightIncreaseType; }
		    set
		    {
		        _AdjacentSpanWeightIncreaseType = value;
		        RaisePropertyChanged("AdjacentSpanWeightIncreaseType");
		        OnNodeModified();
		    }
		}
		#endregion



        #region ReportEntryProperty

        /// <summary>
        /// log property
        /// </summary>
        /// <value>Calculation entries that can be converted into a report.</value>

        public string reportEntry;

        public string ReportEntry
        {
            get { return reportEntry; }
            set
            {
                reportEntry = value;
                RaisePropertyChanged("ReportEntry");
                OnNodeModified();
            }
        }




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
            nodeElement.SetAttribute("AdjacentSpanWeightIncreaseType", AdjacentSpanWeightIncreaseType);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["AdjacentSpanWeightIncreaseType"];
            if (attrib == null)
                return;
           
            AdjacentSpanWeightIncreaseType = attrib.Value;

        }


        #endregion



        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class AdjacentSpanWeightIncreaseTypeSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<AdjacentSpanWeightIncreaseTypeSelection>
        {
            public void CustomizeView(AdjacentSpanWeightIncreaseTypeSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                AdjacentSpanWeightIncreaseTypeSelectionView control = new AdjacentSpanWeightIncreaseTypeSelectionView();
                control.DataContext = model;
                
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }

        }
    }
}
