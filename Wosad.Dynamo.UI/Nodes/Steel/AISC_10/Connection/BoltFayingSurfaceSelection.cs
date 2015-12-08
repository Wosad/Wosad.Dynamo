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


namespace Wosad.Steel.AISC_10.Connection
{

    /// <summary>
    ///Bolt faying surface selection  
    /// </summary>

    [NodeName("Bolt faying surface selection")]
    [NodeCategory("Wosad.Steel.AISC_10.Connection")]
    [NodeDescription("Bolt faying surface selection")]
    [IsDesignScriptCompatible]
    public class BoltFayingSurfaceSelection : UiNodeBase
    {

        public BoltFayingSurfaceSelection()
        {
            
            OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("BoltFayingSurfaceClass", "Identifies the type of faying surface for slip critical bolts"));
            RegisterAllPorts();
            SetDefaultParameters();
            //PropertyChanged += NodePropertyChanged;
        }

        private void SetDefaultParameters()
        {
            ReportEntry="";
            BoltFayingSurfaceClass = "ClassA";
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

		#region BoltFayingSurfaceClassProperty
		
		/// <summary>
		/// BoltFayingSurfaceClass property
		/// </summary>
		/// <value>Identifies the type of faying surface for slip critical bolts</value>
		public string _BoltFayingSurfaceClass;
		
		public string BoltFayingSurfaceClass
		{
		    get { return _BoltFayingSurfaceClass; }
		    set
		    {
		        _BoltFayingSurfaceClass = value;
		        RaisePropertyChanged("BoltFayingSurfaceClass");
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
            nodeElement.SetAttribute("BoltFayingSurfaceClass", BoltFayingSurfaceClass);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["BoltFayingSurfaceClass"];
            if (attrib == null)
                return;
           
            BoltFayingSurfaceClass = attrib.Value;

        }


        #endregion





        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class BoltFayingSurfaceSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<BoltFayingSurfaceSelection>
        {
            public void CustomizeView(BoltFayingSurfaceSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                BoltFayingSurfaceView control = new BoltFayingSurfaceView();
                control.DataContext = model;
                
                
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }


        }
    }
}
