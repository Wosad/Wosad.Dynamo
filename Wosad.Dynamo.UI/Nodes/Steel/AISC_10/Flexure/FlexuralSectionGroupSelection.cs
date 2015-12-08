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


namespace Wosad.Steel.AISC_10.Flexure
{

    /// <summary>
    ///Section group selection for flexure  
    /// </summary>

    [NodeName("Flexural section group selection")]
    [NodeCategory("Wosad.Steel.AISC_10.Flexure")]
    [NodeDescription("Section group selection for flexure")]
    [IsDesignScriptCompatible]
    public class FlexuralSectionGroupSelection : UiNodeBase
    {

        public FlexuralSectionGroupSelection()
        {
            
            OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("SteelShapeGroupFlexure", "Type of steel shape for flexural calculations"));
            RegisterAllPorts();
            //PropertyChanged += NodePropertyChanged;
            SetDefaultParameters();
        }

        private void SetDefaultParameters()
        {
            ReportEntry = "";
            SteelShapeType = "IShape";
            SymmetryType = "DoublySymmetric";
            IsMajorAxisShapeIOrChannel = true;
            IsDoublySymmetric = true;
            IsSinglySymmetric = false;
            BendingAxis = "Major";
            SteelShapeGroupFlexure = "F2";
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

		#region SteelShapeGroupFlexureProperty
		
		/// <summary>
		/// SteelShapeGroupFlexure property
		/// </summary>
		/// <value>Type of steel shape for flexural calculations</value>
		public string _SteelShapeGroupFlexure;
		
		public string SteelShapeGroupFlexure
		{
		    get { return _SteelShapeGroupFlexure; }
		    set
		    {
		        _SteelShapeGroupFlexure = value;
		        RaisePropertyChanged("SteelShapeGroupFlexure");
		        OnNodeModified();
                UpdateValuesAndView();
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


        #region Display parameters

        private void UpdateValuesAndView()
        {
            switch (SteelShapeType)
            {
                case "IShape": SteelShapeGroupFlexure = "F2"; IsMajorAxisShapeIOrChannel = true; IsIShapeOrChannel = true; break;
                case "Channel": SteelShapeGroupFlexure = "F2"; IsMajorAxisShapeIOrChannel = true; IsIShapeOrChannel = true; break;
                case "Angle": SteelShapeGroupFlexure = "F10"; IsMajorAxisShapeIOrChannel = false; IsIShapeOrChannel = false; break;
                case "Tee": SteelShapeGroupFlexure = "F9"; IsMajorAxisShapeIOrChannel = false; IsIShapeOrChannel = false; break;
                case "DoubleAngle": SteelShapeGroupFlexure = "F9"; IsMajorAxisShapeIOrChannel = false; IsIShapeOrChannel = false; break;
                case "RectangularHSS": SteelShapeGroupFlexure = "F7"; IsMajorAxisShapeIOrChannel = false; IsIShapeOrChannel = false; break;
                case "CircularHSS": SteelShapeGroupFlexure = "F8"; IsMajorAxisShapeIOrChannel = false; IsIShapeOrChannel = false; break;
                case "SolidRectangle": SteelShapeGroupFlexure = "F11"; IsMajorAxisShapeIOrChannel = false; IsIShapeOrChannel = false; break;
                case "SolidCircle": SteelShapeGroupFlexure = "F11"; IsMajorAxisShapeIOrChannel = false; IsIShapeOrChannel = false; break;
                default: SteelShapeGroupFlexure = "F2"; IsMajorAxisShapeIOrChannel = true; IsIShapeOrChannel = true; break;
            }

            if (IsMajorAxisShapeIOrChannel == false)
            {
                IsDoublySymmetric = false;
                IsSinglySymmetric = false;
            }
            else
            {
                if (BendingAxis == "Minor")
                {
                    IsMajorAxisShapeIOrChannel = false;
                    IsDoublySymmetric = false;
                    IsSinglySymmetric = false;
                    SteelShapeGroupFlexure = "F6";
                }
                else
                {

                    if (SymmetryType == "DoublySymmetric")
                    {
                        IsDoublySymmetric = true;
                        IsSinglySymmetric = false;
                    }
                    else
                    {
                        SteelShapeGroupFlexure = "F4"; //default value
                        IsDoublySymmetric = false;
                        IsSinglySymmetric = true;
                    }
                }
            }

        }


        private string _SteelShapeType;

        public string SteelShapeType
        {
            get { return _SteelShapeType; }
            set
            {
                _SteelShapeType = value;
                RaisePropertyChanged("SteelShapeType");
                UpdateValuesAndView();
            }
        }

        #region I-Shapes and Channels

        #region IsShapeIOrChannel Property
        private bool _IsMajorAxisShapeIOrChannel;
        public bool IsMajorAxisShapeIOrChannel
        {
            get { return _IsMajorAxisShapeIOrChannel; }
            set
            {
                _IsMajorAxisShapeIOrChannel = value;
                RaisePropertyChanged("IsMajorAxisShapeIOrChannel");
            }

        }
        #endregion

        #region IsDoublySymmetric Property
        private bool _IsDoublySymmetric;
        public bool IsDoublySymmetric
        {
            get { return _IsDoublySymmetric; }
            set
            {
                _IsDoublySymmetric = value;
                RaisePropertyChanged("IsDoublySymmetric");
            }

        }
        #endregion

        #region IsSinglySymmetric Property
        private bool _IsSinglySymmetric;
        public bool IsSinglySymmetric
        {
            get { return _IsSinglySymmetric; }
            set
            {
                _IsSinglySymmetric = value;
                RaisePropertyChanged("IsSinglySymmetric");
            }

        }
        #endregion



        #region IsIShapeOrChannel Property
        private bool _IsIShapeOrChannel;
        public bool IsIShapeOrChannel
        {
            get { return _IsIShapeOrChannel; }
            set
            {
                _IsIShapeOrChannel = value;
                RaisePropertyChanged("IsIShapeOrChannel");
            }
        }
        #endregion


        #region SymmetryType Property
        private string _SymmetryType;
        public string SymmetryType
        {
            get { return _SymmetryType; }
            set
            {
                _SymmetryType = value;
                RaisePropertyChanged("SymmetryType");
                UpdateValuesAndView();
            }
        }
        #endregion



        #region BendingAxis Property
        private string _BendingAxis;
        public string BendingAxis
        {
            get { return _BendingAxis; }
            set
            {
                _BendingAxis = value;
                RaisePropertyChanged("BendingAxis");
                UpdateValuesAndView();
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
            nodeElement.SetAttribute("SteelShapeGroupFlexure", SteelShapeGroupFlexure);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["SteelShapeGroupFlexure"];
            if (attrib == null)
                return;
           
            SteelShapeGroupFlexure = attrib.Value;

        }


        #endregion


        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class FlexuralSectionGroupSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<FlexuralSectionGroupSelection>
        {
            public void CustomizeView(FlexuralSectionGroupSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                SteelShapeGroupFlexureView control = new SteelShapeGroupFlexureView();
                control.DataContext = model;
                
                
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }

        }
    }
}
