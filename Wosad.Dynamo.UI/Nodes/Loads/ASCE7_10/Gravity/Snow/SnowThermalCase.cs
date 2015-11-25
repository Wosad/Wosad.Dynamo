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
using System.Xml;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Input;
using System.Windows;
using Wosad.Dynamo.Common.Infra.TreeItems;
using Wosad.Dynamo.UI.Common.TreeItems;
using Wosad.Dynamo.UI.Views.Loads.ASCE7_10;


namespace Loads.ASCE7_10.Gravity.Snow
{

    /// <summary>
    ///Thermal condition - ASCE7-10  
    /// </summary>

    [NodeName("Snow thermal case")]
    [NodeCategory("Wosad.Loads.ASCE7_10.Gravity.Snow")]
    [NodeDescription("Thermal condition - ASCE7-10")]
    [IsDesignScriptCompatible]
    public class SnowThermalCase : UiNodeBase
    {

        public SnowThermalCase()
        {
            ReportEntry="";
            SnowThermalCaseId = "Regular structure";
            OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("SnowThermalCaseDescription", "Snow thermal case description"));
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

		#region SnowThermalCaseProperty
		
		/// <summary>
		/// SnowThermalCase property
		/// </summary>
		/// <value>Snow thermal case</value>
		public string _SnowThermalCaseId;
		
		public string SnowThermalCaseId
		{
		    get { return _SnowThermalCaseId; }
		    set
		    {
		        _SnowThermalCaseId = value;
		        RaisePropertyChanged("SnowThermalCaseId");
		        OnNodeModified();
		    }
		}
		#endregion


        #region SnowThermalCaseDescription Property
        private string liveLoadOccupancyDescription;
        public string SnowThermalCaseDescription
        {
            get { return liveLoadOccupancyDescription; }
            set
            {
                liveLoadOccupancyDescription = value;
                RaisePropertyChanged("SnowThermalCaseDescription");
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
            nodeElement.SetAttribute("SnowThermalCase", SnowThermalCaseId);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["SnowThermalCase"];
            if (attrib == null)
                return;

            this.SnowThermalCaseId = attrib.Value;
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
            Uri uri = new Uri("pack://application:,,,/Wosad.Dynamo.UI;component/Views/Loads/ASCE7_10/Snow/SnowThermalCase/SnowThermalCaseTreeData.xml");
            XmlTreeHelper treeHelper = new XmlTreeHelper();
            treeHelper.ExamineXmlTreeFile(uri, new EvaluateXmlNodeDelegate(FindDescription));
        }

        private void FindDescription(XmlNode node)
        {
            //check if attribute "Id" exists
            if (null != node.Attributes["Tag"])
            {
                   if (node.Attributes["Tag"].Value== SnowThermalCaseId)
                   {
                       SnowThermalCaseDescription = node.Attributes["Description"].Value;
                   }
            }
        }

        #endregion

        #region treeView elements

        public TreeView TreeViewControl { get; set; }

        private ICommand selectedItemChanged;
        public ICommand SelectedItemChanged
        {
            get
            {

                if (SnowThermalCaseDescription == null)
                {
                    selectedItemChanged = new RelayCommand<object>((i) =>
                    {
                        OnSelectedItemChanged(i);
                    });
                }

                return selectedItemChanged;
            }

        }



        public void DisplayComponentUI(XTreeItem selectedComponent)
        {

            //Example of parsing a string and creating a control from a string


            //if (selectedComponent != null && selectedComponent.Tag != "X" && selectedComponent.ResourcePath != null)
            //{
            //    Assembly execAssembly = Assembly.GetExecutingAssembly();
            //    AssemblyName assemblyName = new AssemblyName(execAssembly.FullName);
            //    string execAssemblyName = assemblyName.Name;
            //    string typeStr =execAssemblyName +".Views.Loads.ASCE7_10." + selectedComponent.ResourcePath;
            //    try
            //    {
            //        Type subMenuType = execAssembly.GetType(typeStr);
            //        UserControl subMenu = (UserControl)Activator.CreateInstance(subMenuType);
            //        AdditionalUI = subMenu;

            //        if (selectedComponent.Id != "X") //parse default values
            //        {
            //            int ind1, ind2;
            //            double numeric;

            //            string DefaultValues = selectedComponent.Id;
            //            string[] Vals = DefaultValues.Split(',');

            //            if (Vals.Length == 3)
            //            {
            //                bool ind1Res = int.TryParse(Vals[0], out ind1); if (ind1Res == true) ComponentOption1 = ind1;
            //                bool ind2Res = int.TryParse(Vals[1], out ind2); if (ind2Res == true) ComponentOption2 = ind2;
            //                bool numRes = double.TryParse(Vals[2], out numeric); if (numRes == true) ComponentValue = numeric;
            //            }
            //            else
            //            {
            //                ComponentOption1 = -1;
            //                ComponentOption2 = -1;
            //                ComponentValue = 0;
            //            }
            //        }

            //    }
            //    catch (Exception)
            //    {

            //        AdditionalUI = null;
            //    }
            //}
            //else
            //{
            //    AdditionalUI = null;
            //}
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
                // PropertyName = item.GetAttribute("XmlTag"),
            };

            if (item != null)
            {

                //Example
                //string id =xtreeItem.Tag;
                //if (id != "X")
                //{
                    //SnowThermalCaseId = id;
                    //SnowThermalCaseDescription = xtreeItem.Description;
                    //SelectedItem = xtreeItem;
                    //DisplayComponentUI(xtreeItem);
                //}
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
        public class SnowThermalCaseViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<SnowThermalCase>
        {
            public void CustomizeView(SnowThermalCase model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                SnowThermalCaseView control = new SnowThermalCaseView();
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
