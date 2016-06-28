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
using Dynamo.Graph;
using System.Xml;


namespace Wosad.Loads.ASCE7.Lateral.Seismic.BuildingFundamentalPeriod
{

    /// <summary>
    ///Selection of seismic lateral system for general fundamental period determination  
    /// </summary>

    [NodeName("Seismic system type general procedure selection")]
    [NodeCategory("Wosad.Loads.ASCE7.Lateral.Seismic.BuildingFundamentalPeriod")]
    [NodeDescription("Selection of seismic lateral system for general fundamental period determination")]
    [IsDesignScriptCompatible]
    public class SeismicSystemTypeGeneralProcedureSelection : UiNodeBase
    {

        public SeismicSystemTypeGeneralProcedureSelection()
        {
            
            //OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("SeismicSystemTypeGeneralProcedure", "Seismic lateral system type (used in approximate procedure for fundamental period determination)"));
            RegisterAllPorts();
            SetDefaultParameters();
            //PropertyChanged += NodePropertyChanged;
        }

        private void SetDefaultParameters()
        {
            //ReportEntry="";
            SeismicSystemTypeGeneralProcedure = "OtherStructuralSystem";
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

		#region SeismicSystemTypeGeneralProcedureProperty
		
		/// <summary>
		/// SeismicSystemTypeGeneralProcedure property
		/// </summary>
		/// <value>Seismic lateral system type (used in approximate procedure for fundamental period determination)</value>
		public string _SeismicSystemTypeGeneralProcedure;
		
		public string SeismicSystemTypeGeneralProcedure
		{
		    get { return _SeismicSystemTypeGeneralProcedure; }
		    set
		    {
		        _SeismicSystemTypeGeneralProcedure = value;
		        RaisePropertyChanged("SeismicSystemTypeGeneralProcedure");
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
            nodeElement.SetAttribute("SeismicSystemTypeGeneralProcedure", SeismicSystemTypeGeneralProcedure);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["SeismicSystemTypeGeneralProcedure"];
            if (attrib == null)
                return;
           
            SeismicSystemTypeGeneralProcedure = attrib.Value;
            //SetComponentDescription();

        }


        #endregion





        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class SeismicSystemTypeGeneralProcedureSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<SeismicSystemTypeGeneralProcedureSelection>
        {
            public void CustomizeView(SeismicSystemTypeGeneralProcedureSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                SeismicSystemTypeGeneralProcedureSelectionView control = new SeismicSystemTypeGeneralProcedureSelectionView();
                control.DataContext = model;
                
               
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }

        }
    }
}