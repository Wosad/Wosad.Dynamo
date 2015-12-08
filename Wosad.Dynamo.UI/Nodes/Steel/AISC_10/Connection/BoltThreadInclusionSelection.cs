using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Dynamo.Controls;
using Dynamo.Models;
using Dynamo.Wpf;
using ProtoCore.AST.AssociativeAST;
using Wosad.Common.CalculationLogger;
using Wosad.Dynamo.Common;
using Wosad.Loads.ASCE7.Entities;
using System.Xml;


namespace Wosad.Steel.AISC_10.Connection
{

    /// <summary>
    ///Bolt thread inclusion selection  
    /// </summary>

    [NodeName("Bolt thread inclusion selection")]
    [NodeCategory("Wosad.Steel.AISC_10.Connection")]
    [NodeDescription("Bolt thread inclusion selection")]
    [IsDesignScriptCompatible]
    public class BoltThreadInclusionSelection : UiNodeBase
    {

        public BoltThreadInclusionSelection()
        {
            
            OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("BoltThreadCase", "Identifies whether threads are included or excluded from shear planes"));
            RegisterAllPorts();
            //PropertyChanged += NodePropertyChanged;
            SetDefaultParameters();

        }

        private void SetDefaultParameters()
        {
            ReportEntry = "";
            BoltThreadCase = "N";
        }


        /// <summary>
        ///     Gets the type of this class, to be used in base class for reflection
        /// </summary>
        protected override Type GetModelType()
        {
            return GetType();
        }

        #region properties

        #region InputProperties



	    #endregion

        #region OutputProperties

		#region BoltThreadCaseProperty
		
		/// <summary>
		/// BoltThreadCase property
		/// </summary>
		/// <value>Identifies whether threads are included or excluded from shear planes</value>
		public string _BoltThreadCase;
		
		public string BoltThreadCase
		{
		    get { return _BoltThreadCase; }
		    set
		    {
		        _BoltThreadCase = value;
		        RaisePropertyChanged("BoltThreadCase");
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
            nodeElement.SetAttribute("BoltThreadCase", BoltThreadCase);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["BoltThreadCase"];
            if (attrib == null)
                return;
           
            BoltThreadCase = attrib.Value;

        }


        #endregion



        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class BoltThreadInclusionSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<BoltThreadInclusionSelection>
        {
            public void CustomizeView(BoltThreadInclusionSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                BoltThreadCaseView control = new BoltThreadCaseView();
                control.DataContext = model;
                
                 
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }


        }
    }
}
