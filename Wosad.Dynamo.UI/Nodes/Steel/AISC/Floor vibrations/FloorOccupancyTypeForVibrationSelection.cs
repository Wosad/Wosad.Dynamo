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
using Dynamo.Graph.Nodes;
using System.Xml;
using Dynamo.Graph;


namespace Wosad.Steel.AISC.FloorVibrations.Acceleration
{

    /// <summary>
    ///Floor occupancy type for vibration  
    /// </summary>

    [NodeName("Floor sevice occupancy Id")]
    [NodeCategory("Wosad.Steel.AISC.FloorVibrations.Acceleration")]
    [NodeDescription("Floor sevice occupancy Id")]
    [IsDesignScriptCompatible]
    public class FloorOccupancyTypeForVibrationSelection : UiNodeBase
    {

        public FloorOccupancyTypeForVibrationSelection()
        {
            
            //OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("FloorSeviceOccupancyId", "Indicates type of floor occupancy used for vibration checks"));
            RegisterAllPorts();
            SetDefaultParameters();
            //PropertyChanged += NodePropertyChanged;
        }

        private void SetDefaultParameters()
        {
            //ReportEntry="";
            FloorSeviceOccupancyId = "Office";
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

		#region FloorSeviceOccupancyIdProperty
		
		/// <summary>
		/// FloorSeviceOccupancyId property
		/// </summary>
		/// <value>Indicates type of floor occupancy used for vibration checks</value>
		public string _FloorSeviceOccupancyId;
		
		public string FloorSeviceOccupancyId
		{
		    get { return _FloorSeviceOccupancyId; }
		    set
		    {
		        _FloorSeviceOccupancyId = value;
		        RaisePropertyChanged("FloorSeviceOccupancyId");
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
            nodeElement.SetAttribute("FloorSeviceOccupancyId", FloorSeviceOccupancyId);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["FloorSeviceOccupancyId"];
            if (attrib == null)
                return;

            FloorSeviceOccupancyId = attrib.Value;

        }


        #endregion





        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class FloorOccupancyTypeForVibrationSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<FloorOccupancyTypeForVibrationSelection>
        {
            public void CustomizeView(FloorOccupancyTypeForVibrationSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                FloorOccupancyTypeForVibrationSelectionView control = new FloorOccupancyTypeForVibrationSelectionView();
                control.DataContext = model;
                

                
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }

        }
    }
}
