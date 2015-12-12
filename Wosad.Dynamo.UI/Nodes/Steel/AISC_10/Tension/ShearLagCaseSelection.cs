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
using Wosad.Dynamo.Common.Infra.TreeItems;
using System.Xml;
using System.Windows;
using Wosad.Dynamo.UI.Common.TreeItems;


namespace Wosad.Steel.AISC_10.Tension
{

    /// <summary>
    ///Selection of occupancy for determination of Risk Category  
    /// </summary>

    [NodeName("Shear lag case selection")]
    [NodeCategory("Wosad.Steel.AISC_10.Tension")]
    [NodeDescription("Selection of case for calculation of shear lag factor")]
    [IsDesignScriptCompatible]
    public class ShearLagCaseIdSelection : UiNodeBase
    {

        public ShearLagCaseIdSelection()
        {
            ReportEntry="";
            ShearLagCaseIdDescription ="General case";
            ShearLagCaseId = "Case 2";
            OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("ShearLagCaseId", "Shear lag case selection"));
            RegisterAllPorts();
            //PropertyChanged += NodePropertyChanged;
        }

        #region ShearLagCaseIdDescription Property
        private string _ShearLagCaseIdDescription;
        public string ShearLagCaseIdDescription
        {
            get { return _ShearLagCaseIdDescription; }
            set
            {
                _ShearLagCaseIdDescription = value;
                RaisePropertyChanged("ShearLagCaseIdDescription");
            }
        }
        #endregion

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

		#region ShearLagCaseIdProperty
		
		/// <summary>
		/// ShearLagCaseId property
		/// </summary>
		/// <value>Occupancy description</value>
		public string _ShearLagCaseId;
		
		public string ShearLagCaseId
		{
		    get { return _ShearLagCaseId; }
		    set
		    {
		        _ShearLagCaseId = value;
                RaisePropertyChanged("ShearLagCaseId");
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
            nodeElement.SetAttribute("ShearLagCaseId", ShearLagCaseId);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["ShearLagCaseId"];
            if (attrib == null)
                return;

            ShearLagCaseId = attrib.Value;
            SetCaseDescription();

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

        private void SetCaseDescription()
        {
            Uri uri = new Uri("pack://application:,,,/Wosad.Dynamo.UI;component/Views/Steel/AISC_10/Connection/ShearLagFactorIdTreeData.xml");
            XmlTreeHelper treeHelper = new XmlTreeHelper();
            treeHelper.ExamineXmlTreeFile(uri, new EvaluateXmlNodeDelegate(FindDescription));
        }

        private void FindDescription(XmlNode node)
        {
            if (null != node.Attributes["Id"])
            {
                   if (node.Attributes["Id"].Value== ShearLagCaseId)
                   {
                       ShearLagCaseIdDescription = node.Attributes["Description"].Value;
                   }
            }
        }

        #endregion

        #region treeView elements

        public TreeView TreeViewControl { get; set; }




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


                string Id = xtreeItem.Id;
                if (Id != "X")
                {
                    ShearLagCaseId = xtreeItem.Id;
                    ShearLagCaseIdDescription = xtreeItem.Description;
                    SelectedItem = xtreeItem;
                    DisplayComponentUI(xtreeItem);
                }
            }
        }

        #endregion

        //Additional UI is a user control which is based on the user selection
        // can remove this property

        #region Additional UI
        private UserControl additionalUI;

        public UserControl AdditionalUI
        {
            get { return additionalUI; }
            set
            {
                additionalUI = value;
                RaisePropertyChanged("AdditionalUI");
            }
        }
        #endregion




        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class ShearLagCaseIdViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<ShearLagCaseIdSelection>
        {
            public void CustomizeView(ShearLagCaseIdSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                ShearLagFactorIdView control = new ShearLagFactorIdView();
                control.DataContext = model;
                
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
