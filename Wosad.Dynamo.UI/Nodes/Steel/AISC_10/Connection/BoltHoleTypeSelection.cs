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
    ///Bolt hole type  
    /// </summary>

    [NodeName("Bolt hole type selection")]
    [NodeCategory("Wosad.Steel.AISC_10.Connection")]
    [NodeDescription("Bolt hole type")]
    [IsDesignScriptCompatible]
    public class BoltHoleTypeSelection : UiNodeBase
    {

        public BoltHoleTypeSelection()
        {
            ReportEntry="";
            
            OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("BoltHoleType", "Type of bolt hole"));
            RegisterAllPorts();
            //PropertyChanged += NodePropertyChanged;
            SetDefaultParameters();

        }

        private void SetDefaultParameters()
        {
            ReportEntry = "";
            BoltHoleType = "Standard";
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

		#region BoltHoleTypeProperty
		
		/// <summary>
		/// BoltHoleType property
		/// </summary>
		/// <value>Type of bolt hole</value>
		public string _BoltHoleType;
		
		public string BoltHoleType
		{
		    get { return _BoltHoleType; }
		    set
		    {
		        _BoltHoleType = value;
		        RaisePropertyChanged("BoltHoleType");
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
            nodeElement.SetAttribute("BoltHoleType", BoltHoleType);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["BoltHoleType"];
            if (attrib == null)
                return;
           
            BoltHoleType = attrib.Value;

        }


        #endregion




        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class BoltHoleTypeSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<BoltHoleTypeSelection>
        {
            public void CustomizeView(BoltHoleTypeSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                BoltHoleTypeView control = new BoltHoleTypeView();
                control.DataContext = model;
                
                
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }

        }
    }
}
