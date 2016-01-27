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
using Wosad.Loads.ASCE7.Entities;
using Wosad.Dynamo.Common.Infra.TreeItems;
using System.Xml;
using System.Windows.Input;
using System.Windows;
using Wosad.Dynamo.UI.Common.TreeItems;
using GalaSoft.MvvmLight.Command;
using Wosad.Dynamo.UI.Views.Loads.ASCE7_10;
using Dynamo.Nodes;


namespace Wosad.Loads.ASCE7_10.Gravity.Live
{

    /// <summary>
    ///Occupancy or use  for selection of uniformly distributed loads - ASCE7-10  
    /// </summary>

    [NodeName("Live Load occupancy ID selection")]
    [NodeCategory("Wosad.Loads.ASCE7_10.Gravity.Live")]
    [NodeDescription("Occupancy or use  for selection of uniformly distributed loads - ASCE7-10")]
    [IsDesignScriptCompatible]
    public class LiveLoadOccupancyIdSelection : UiNodeBase
    {

        public LiveLoadOccupancyIdSelection()
        {
            ReportEntry="";
            LiveLoadOccupancyId = "Office";
            LiveLoadOccupancyDescription = "Office space";
            //OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("LiveLoadOccupancyId", "description of space for calculation of live loads"));
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

        

        #region OutputProperties

		#region LiveLoadOccupancyIdProperty
		
		/// <summary>
		/// LiveLoadOccupancyId property
		/// </summary>
		/// <value>description of space for calculation of live loads</value>
		public string _LiveLoadOccupancyId;
		
		public string LiveLoadOccupancyId
		{
		    get { return _LiveLoadOccupancyId; }
		    set
		    {
		        _LiveLoadOccupancyId = value;
		        RaisePropertyChanged("LiveLoadOccupancyId");
		        OnNodeModified();
		    }
		}
		#endregion

        
        #region LiveLoadOccupancyDescription Property
        private string liveLoadOccupancyDescription;
        public string LiveLoadOccupancyDescription
        {
            get { return liveLoadOccupancyDescription; }
            set
            {
                liveLoadOccupancyDescription = value;
                RaisePropertyChanged("LiveLoadOccupancyDescription"); 
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
            nodeElement.SetAttribute("LiveLoadOccupancyId", LiveLoadOccupancyId);
        }

        /// <summary>
        ///Retrieves property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["LiveLoadOccupancyId"];
            if (attrib == null)
                return;

            LiveLoadOccupancyId = attrib.Value;
            SetOcupancyDescription();

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

        private void SetOcupancyDescription()
        {
            Uri uri = new Uri("pack://application:,,,/Wosad.Dynamo.UI;component/Views/Loads/ASCE7_10/Live/LiveLoadOccupancyIdTreeData.xml");
            XmlTreeHelper treeHelper = new XmlTreeHelper();
            treeHelper.ExamineXmlTreeFile(uri, new EvaluateXmlNodeDelegate(FindOccupancyDescription));
        }

        private void FindOccupancyDescription(XmlNode node)
        {
            if (null != node.Attributes["Id"])
            {
                   if (node.Attributes["Id"].Value== LiveLoadOccupancyId)
                   {
                       LiveLoadOccupancyDescription = node.Attributes["Description"].Value;
                   }
            }
        }

        #endregion

        #region treeView elements

        public TreeView TreeViewControl { get; set; }

        public void DisplayComponentUI(XTreeItem selectedComponent)
        {

            //TODO: Add partition allowance here
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

                
                string id =xtreeItem.Id;
                if (id != "X")
                {
                    LiveLoadOccupancyId = xtreeItem.Id;
                    LiveLoadOccupancyDescription = xtreeItem.Description;
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
        public class LiveLoadOccupancyIdViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<LiveLoadOccupancyIdSelection>
        {
            public void CustomizeView(LiveLoadOccupancyIdSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                LiveLoadOccupancyIdView control = new LiveLoadOccupancyIdView();
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
