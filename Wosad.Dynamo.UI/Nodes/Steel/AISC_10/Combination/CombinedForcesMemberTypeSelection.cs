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

        #region Display parameters


        #region IsMember Property
        private bool _IsMember;
        public bool IsMember
        {
            get { return _IsMember; }
            set
            {
                _IsMember = value;
                RaisePropertyChanged("IsMember");
            }
        }
        #endregion


        #region IsAxialAndFlexureMember Property
        private bool _IsAxialAndFlexureMember;
        public bool IsAxialAndFlexureMember
        {
            get { return _IsAxialAndFlexureMember; }
            set
            {
                _IsAxialAndFlexureMember = value;
                RaisePropertyChanged("IsAxialAndFlexureMember");
            }
        }
        #endregion


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


        #region ElementType Property
        private string _ElementType;
        public string ElementType
        {
            get { return _ElementType; }
            set
            {
                _ElementType = value;
                RaisePropertyChanged("ElementType");
                UpdateValuesAndView();
            }
        }


        #endregion


        #region MemberForceCase Property
        private string _MemberForceCase;
        public string MemberForceCase
        {
            get { return _MemberForceCase; }
            set
            {
                _MemberForceCase = value;
                RaisePropertyChanged("MemberForceCase");
                UpdateValuesAndView();
            }
        }
        #endregion


        #region MemberSectionType Property
        private string _MemberSectionType;
        public string MemberSectionType
        {
            get { return _MemberSectionType; }
            set
            {
                _MemberSectionType = value;
                RaisePropertyChanged("MemberSectionType");
                UpdateValuesAndView();
            }
        }
        #endregion


        #region ConnectionCombinationType Property
        private string _ConnectionCombinationType;
        public string ConnectionCombinationType
        {
            get { return _ConnectionCombinationType; }
            set
            {
                _ConnectionCombinationType = value;
                RaisePropertyChanged("ConnectionCombinationType");
                UpdateValuesAndView();
            }
        }
        #endregion



        private void UpdateValuesAndView()
        {
            if (ElementType == "Member")
            {
                IsMember = true;
                if (MemberForceCase == "FlexureAndAxial")
                {
                    IsAxialAndFlexureMember = true;
                    if (MemberSectionType == "DoublyOrSinglySymmetric")
                    {
                        CombinationCaseId = "H1";
                    }
                    else
                    {
                        CombinationCaseId = "H2";
                    }

                }
                else
                {
                    IsAxialAndFlexureMember = false;
                    CombinationCaseId = "H3";
                }
            }
            else
            {
                IsMember = false;
                switch (ConnectionCombinationType)
                {
                    case "Linear": CombinationCaseId = "Linear"; break;
                    case "Elliptical": CombinationCaseId = "Elliptical"; break;
                    case "Plastic": CombinationCaseId = "Plastic"; break;
                    default:
                        CombinationCaseId = "Linear";
                        break;
                }
            }
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
