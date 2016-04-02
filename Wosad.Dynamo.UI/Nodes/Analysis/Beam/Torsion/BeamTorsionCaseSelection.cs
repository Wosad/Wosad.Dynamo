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
using System.Windows.Input;
using System.Windows;
using System.Xml;
using Wosad.Dynamo.Common.Infra.TreeItems;
using Wosad.Dynamo.UI.Views.Analysis.Beam.Flexure;
using GalaSoft.MvvmLight.CommandWpf;
using Wosad.Dynamo.UI.Common.TreeItems;
using Dynamo.Graph;
using Dynamo.Graph.Nodes;



namespace Wosad.Analysis.Beam.Torsion
{

    /// <summary>
    ///Selection of beam load and boundary condition case for torsional analysis  
    /// </summary>

    [NodeName("Torsion case selection")]
    [NodeCategory("Wosad.Analysis.Beam.Torsion")]
    [NodeDescription("Selection of beam load and boundary condition case for torsional analysis")]
    [IsDesignScriptCompatible]
    public class BeamTorsionCaseSelection : UiNodeBase
    {

        public BeamTorsionCaseSelection()
        {
            ReportEntry = "";
            BeamTorsionCaseDescription="Uniformly distributed torque";
            BeamTorsionCaseId = "Case4";
            //OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("BeamTorsionCaseId", "Case ID used in calculation of the values of torsional functions (per AISC design guide 9)"));
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

        #region Properties

        #region InputProperties



	    #endregion

        #region OutputProperties

		#region BeamTorsionCaseIdProperty
		
		/// <summary>
		/// BeamTorsionCaseId property
		/// </summary>
		/// <value>Case ID used in calculation of the beam forces</value>
		public string _BeamTorsionCaseId;
		
		public string BeamTorsionCaseId
		{
		    get { return _BeamTorsionCaseId; }
		    set
		    {
		        _BeamTorsionCaseId = value;
		        RaisePropertyChanged("BeamTorsionCaseId");
		        OnNodeModified(true); 
		    }
		}
		#endregion


        #region BeamTorsionCaseDescription Property
        private string _BeamTorsionCaseDescription;
        public string BeamTorsionCaseDescription
        {
            get { return _BeamTorsionCaseDescription; }
            set
            {
                _BeamTorsionCaseDescription = value;
                RaisePropertyChanged("BeamTorsionCaseDescription");
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
            nodeElement.SetAttribute("BeamFTorsionCaseId", BeamTorsionCaseId);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["BeamTorsionCaseId"];
            if (attrib == null)
                return;

            BeamTorsionCaseId = attrib.Value;
            SetCaseDescription();
        }

        private void SetCaseDescription()
        {
            Uri uri = new Uri("pack://application:,,,/WosadDynamoUI;component/Views/Analysis/Beam/Torsion/BeamTorsionCaseTreeData.xml");
            XmlTreeHelper treeHelper = new XmlTreeHelper();
            treeHelper.ExamineXmlTreeFile(uri, new EvaluateXmlNodeDelegate(FindCaseDescription));
        }



        private void FindCaseDescription(XmlNode node)
        {
            if (null != node.Attributes["Id"])
            {
                if (node.Attributes["Id"].Value == BeamTorsionCaseId)
                {
                    BeamTorsionCaseDescription = node.Attributes["Description"].Value;
                }
            }
        }


        public void UpdateSelectionEvents()
        {
            if (TreeViewControl != null)
            {
                TreeViewControl.SelectedItemChanged += OnTreeViewSelectionChanged;
            }
        }
        private void OnTreeViewSelectionChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            OnSelectedItemChanged(e.NewValue);
        }




        #endregion

        #region TreeView elements

        public TreeView TreeViewControl { get; set; }

        private ICommand selectedItemChanged;
        public ICommand SelectedItemChanged
        {
            get
            {


                    selectedItemChanged = new RelayCommand<object>((i) =>
                    {
                        OnSelectedItemChanged(i);
                    });


                return selectedItemChanged;
            }

        }



        public void DisplayComponentUI(XTreeItem selectedComponent)
        {

        }


        private XTreeItem selectedItem;

        public XTreeItem SelectedItem
        {
            get { return selectedItem; }
            set 
            { 
                
                selectedItem = value; 
            }
        }


        private void OnSelectedItemChanged(object i)
        {
            XmlElement item = i as XmlElement;
            XTreeItem xtreeItem = new XTreeItem()
            {
                Header = item.GetAttribute("Header"),
                Description = item.GetAttribute("Description"),
                Id = item.GetAttribute("Id"),
                ResourcePath = item.GetAttribute("ResourcePath"),
                Tag = item.GetAttribute("Tag"),
                TemplateName = item.GetAttribute("TemplateName")
            };

            if (item != null)
            {

                string id = xtreeItem.Id;
                if (id != "X")
                {
                    BeamTorsionCaseId = xtreeItem.Id;
                    SelectedItem = xtreeItem;
                    BeamTorsionCaseDescription = xtreeItem.Description;
                }
            }
        }

        #endregion



        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class BeamTorsionCaseSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<BeamTorsionCaseSelection>
        {
            public void CustomizeView(BeamTorsionCaseSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                BeamTorsionCaseView control = new BeamTorsionCaseView();
                control.DataContext = model;
                
                //remove this part if control does not contain tree
                TreeView tv = control.FindName("selectionTree") as TreeView;
                if (tv!=null)
                {
                    model.TreeViewControl = tv;
                    model.UpdateSelectionEvents();
                }
                
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }


        }
    }
}
