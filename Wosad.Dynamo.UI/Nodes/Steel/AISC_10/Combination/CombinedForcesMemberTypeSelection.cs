using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Dynamo.Controls;
using Dynamo.Models;
using Dynamo.Wpf;
using ProtoCore.AST.AssociativeAST;
using Wosad.Common.CalculationLogger;
using Wosad.Dynamo.Common;
using System.Xml;



namespace Wosad.Steel.AISC_10.Combination
{

    /// <summary>
    ///Combined forces member type selection  
    /// </summary>

    [NodeName("Combined forces member type selection")]
    [NodeCategory("Wosad.Steel.AISC_10.CombinedForces")]
    [NodeDescription("Combined forces member type selection")]
    [IsDesignScriptCompatible]
    public class CombinedForcesMemberTypeSelection : UiNodeBase
    {

        public CombinedForcesMemberTypeSelection()
        {
            ReportEntry="";
            
            OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("CombinationCaseId", "Defines a type of interaction equation to be used"));
            RegisterAllPorts();
            //PropertyChanged += NodePropertyChanged;
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

		#region CombinationCaseIdProperty
		
		/// <summary>
		/// CombinationCaseId property
		/// </summary>
		/// <value>Defines a type of interaction equation to be used</value>
		public string _CombinationCaseId;
		
		public string CombinationCaseId
		{
		    get { return _CombinationCaseId; }
		    set
		    {
		        _CombinationCaseId = value;
		        RaisePropertyChanged("CombinationCaseId");
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
            nodeElement.SetAttribute("CombinationCaseId", CombinationCaseId);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["CombinationCaseId"];
            if (attrib == null)
                return;

            CombinationCaseId = attrib.Value;

        }


        #endregion


        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class CombinedForcesMemberTypeSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<CombinedForcesMemberTypeSelection>
        {
            public void CustomizeView(CombinedForcesMemberTypeSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                CombinationCaseIdView control = new CombinationCaseIdView();
                control.DataContext = model;
                
                
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }

        }
    }
}
