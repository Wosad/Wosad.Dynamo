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


namespace Wosad.Steel.AISC10.Composite
{

    /// <summary>
    ///Strength of headed  anchor  
    /// </summary>

    [NodeName("Deck condition selection")]
    [NodeCategory("Wosad.Steel.AISC10.Composite")]
    [NodeDescription("Strength of headed  anchor")]
    [IsDesignScriptCompatible]
    public class DeckConditionSelection : UiNodeBase
    {

        public DeckConditionSelection()
        {

            //OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("HeadedAnchorDeckCondition", "Identifies whether deck runs parallel or perpendicular to beam or there is no deck"));
            RegisterAllPorts();
            SetDefaultParameters();
            //PropertyChanged += NodePropertyChanged;
        }

        private void SetDefaultParameters()
        {
            //ReportEntry="";
            HeadedAnchorDeckCondition = "Perpendicular";
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

		#region HeadedAnchorDeckConditionProperty
		
		/// <summary>
		/// HeadedAnchorDeckCondition property
		/// </summary>
		/// <value>Identifies whether deck runs parallel or perpendicular to beam or there is no deck</value>
		public string _HeadedAnchorDeckCondition;
		
		public string HeadedAnchorDeckCondition
		{
		    get { return _HeadedAnchorDeckCondition; }
		    set
		    {
		        _HeadedAnchorDeckCondition = value;
		        RaisePropertyChanged("HeadedAnchorDeckCondition");
		        OnNodeModified(true); 
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
                OnNodeModified(true); 
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
            nodeElement.SetAttribute("HeadedAnchorDeckCondition", HeadedAnchorDeckCondition);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["HeadedAnchorDeckCondition"];
            if (attrib == null)
                return;

            HeadedAnchorDeckCondition = attrib.Value;

        }


        #endregion


        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class DeckConditionSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<DeckConditionSelection>
        {
            public void CustomizeView(DeckConditionSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                DeckConditionSelectionView control = new DeckConditionSelectionView();
                control.DataContext = model;
                
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }

        }
    }
}
