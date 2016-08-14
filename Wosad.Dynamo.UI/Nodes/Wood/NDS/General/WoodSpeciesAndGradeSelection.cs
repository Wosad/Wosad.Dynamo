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
using System.Reflection;
using Dynamo.Controls;
using Dynamo.Models;
using Dynamo.Wpf;
using Wosad.Dynamo.Common;
using System.Xml;
using System.Windows;
using Wosad.Dynamo.Common.Infra;
using System.Collections.ObjectModel;
using System.Windows.Resources;
using System.IO;
using System.Linq;
using Dynamo.Nodes;
using Dynamo.Graph;
using Dynamo.Graph.Nodes;


namespace Wosad.Wood.NDS.General


{

    /// <summary>
    ///Selection of species commercial grade and size class from NDS reference values
    /// </summary>
    [NodeName("Wood member type")]
    [NodeCategory("Wosad.Wood.NDS.General")]
    [NodeDescription("Wood member type")]
    [IsDesignScriptCompatible]
    public class AiscShapeSelection : UiNodeBase
    {

        public AiscShapeSelection()
        {
            
            
            //OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("WoodSpeciesId", "Wood species for reference value selection"));
            OutPortData.Add(new PortData("CommercialGradeId", "Wood commercial grade"));
            OutPortData.Add(new PortData("SizeClassId", "Wood species size classification for reference value selection"));
            OutPortData.Add(new PortData("WoodMemberType", "Wood member type"));
            RegisterAllPorts();
            SetDefaultParams();
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

		#region WoodSpeciesIdProperty
		
		/// <summary>
		/// WoodSpeciesId property
		/// </summary>
		/// <value>Section name from steel shape database</value>
		public string _WoodSpeciesId;
		
		public string WoodSpeciesId
		{
		    get { return _WoodSpeciesId; }
		    set
		    {
                if (value!=null)
                {
                    _WoodSpeciesId = value;
                    RaisePropertyChanged("WoodSpeciesId");
                    OnNodeModified(true);  
                }

		    }
		}
		#endregion

        #region CommercialGradeIdProperty

        /// <summary>
        /// CommercialGradeId property
        /// </summary>
        /// <value>Section name from steel shape database</value>
        public string _CommercialGradeId;

        public string CommercialGradeId
        {
            get { return _CommercialGradeId; }
            set
            {
                if (value != null)
                {
                    _CommercialGradeId = value;
                    RaisePropertyChanged("CommercialGradeId");
                    OnNodeModified(true);
                }

            }
        }
        #endregion

        #region SizeClassIdProperty

        /// <summary>
        /// SizeClassId property
        /// </summary>
        /// <value>Section name from steel shape database</value>
        public string _SizeClassId;

        public string SizeClassId
        {
            get { return _SizeClassId; }
            set
            {
                if (value != null)
                {
                    _SizeClassId = value;
                    RaisePropertyChanged("SizeClassId");
                    OnNodeModified(true);
                }

            }
        }
        #endregion


        #region WoodMemberTypeProperty

        /// <summary>
        /// WoodMemberType property
        /// </summary>
        /// <value>Section name from steel shape database</value>
        public string _WoodMemberType;

        public string WoodMemberType
        {
            get { return _WoodMemberType; }
            set
            {
                if (value != null)
                {
                    _WoodMemberType = value;
                    RaisePropertyChanged("WoodMemberType");
                    OnNodeModified(true);
                }

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


        #region SelectedItem Property
        private EnumDataElement selectedItem;
        public EnumDataElement SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; RaisePropertyChanged("SelectedItem"); }
        }
        #endregion


        private void SetDefaultParams()
        {
AvailableWoodSpecies
WoodSpeciesId
CommercialGrades
CommercialGradeId
SizeClasses
SizeClassId
WoodMemberType

        }

        bool RefreshView;



        #region Display parameters



        private void FetchList(string ResourceFileName, string FilterCriteriaString, string ShapeGapString = null)
        {
            if (FilterCriteriaString != null && ResourceFileName != null)
            {

                if (AvailableWoodSpecies ==null)
                {
                    AvailableWoodSpecies = new ObservableCollection<string>();
                }
                else
                {
                    AvailableWoodSpecies.Clear();
                }
                

                //Replace "_" and "I" in the filter criteria
                string FilterCriteria1 = FilterCriteriaString.Replace("_", "-");
                string FilterCriteria2 = FilterCriteria1.Replace("I", "/");
                string FilterCriteria3 = FilterCriteria2.Replace("z", ".");
                string FilterCriteria = FilterCriteria3.Replace("Angle", "");

                string Gap = null;

                if (ShapeGapString != null)
                {

                    string Gap1 = ShapeGapString.Replace("_", "-");
                    string Gap2 = Gap1.Replace("I", "/");
                    string Gap3 = Gap2.Replace("z", ".");
                    Gap = Gap3.Replace("Angle", "");
                }



                //string UriString = string.Format("pack://application:,,,/Resources/{0}.txt", ResourceFileName);
                //StreamResourceInfo sri = Application.GetResourceStream(new Uri(UriString));

                string resourceName = string.Format("WosadDynamoUI.Resources.{0}.txt", ResourceFileName);
                var assembly = Assembly.GetExecutingAssembly();
   
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    string line;
                    //using (TextReader tr = new StreamReader(sri.Stream))
                    using (TextReader tr = new StreamReader(stream))
                    {
                        List<string> AllShapes = new List<string>();
                        while ((line = tr.ReadLine()) != null)
                        {
                            //AvailableWoodSpecies.Add(line);
                            AllShapes.Add(line);
                        }

                        if (FilterCriteria != null)
                        {
                            if (Gap == null) //no shape gap
                            {
                                if (FilterCriteria.Contains("Pipe"))
                                {
                                    var FilteredList = AllShapes.Where(sh =>
                                    {
                                        if (sh.Contains(FilterCriteria))
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    ).ToList();
                                    foreach (var s in FilteredList)
                                    {
                                        AvailableWoodSpecies.Add(s);
                                    }
                                }
                                else
                                {

                                    var FilteredList = AllShapes.Where(sh =>
                                    {
                                        string[] subsStr = sh.Split(new string[] { "X" }, StringSplitOptions.None);
                                        if (subsStr[0] == FilterCriteria)
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                        //sh.Contains(FilterCriteria)
                                    }
                                         ).ToList();
                                    foreach (var s in FilteredList)
                                    {
                                        AvailableWoodSpecies.Add(s);
                                    }
                                }
                            }
                            else //if gap is defined
                            {
                                var FilteredListWithGap = AllShapes.Where(sh =>
                                {
                                    string[] subsStr = sh.Split(new string[] { "X" }, StringSplitOptions.None);
                                    if (subsStr[0] == FilterCriteria)
                                    {
                                        if (subsStr.Length == 3) //no gap is defined
                                        {
                                            return false;
                                        }
                                        else
                                        {
                                            if (subsStr.Length == 4)
                                            {
                                                string GapStr = "";
                                                if (subsStr[3].Contains("SLBB") || subsStr[3].Contains("LLBB"))
                                                {
                                                    GapStr = subsStr[3].Substring(0, subsStr[3].Length - 4);
                                                }
                                                else
                                                {
                                                    GapStr = subsStr[3];
                                                }
                                                if (GapStr == Gap)
                                                {
                                                    return true;
                                                }
                                                else
                                                {
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        return false;
                                    }
                                    //sh.Contains(FilterCriteria)
                                }
                                ).ToList();
                                foreach (var s in FilteredListWithGap)
                                {
                                    AvailableWoodSpecies.Add(s);
                                }
                            }
                        }
                        else
                        {
                            foreach (var s in AllShapes)
                            {
                                AvailableWoodSpecies.Add(s);
                            }
                        }
                    }
                }
            }
        }

        #region AvailableWoodSpecies Property
        private ObservableCollection<string> _AvailableWoodSpecies;
        public ObservableCollection<string> AvailableWoodSpecies
        {
            get { return AvailableWoodSpecies; }
            set
            {
                _AvailableWoodSpecies = value;
                RaisePropertyChanged("AvailableWoodSpecies");
            }
        }
        #endregion


        #region CommercialGrades Property
        private ObservableCollection<string> _CommercialGrades;
        public ObservableCollection<string> CommercialGrades
        {
            get { return CommercialGrades; }
            set
            {
                _CommercialGrades = value;
                RaisePropertyChanged("CommercialGrades");
            }
        }
        #endregion

        #region SizeClasses Property
        private ObservableCollection<string> _SizeClasses;
        public ObservableCollection<string> SizeClasses
        {
            get { return SizeClasses; }
            set
            {
                _SizeClasses = value;
                RaisePropertyChanged("SizeClasses");
            }
        }
        #endregion

        void UpdateView()
        {
            if (RefreshView == true)
            {


                ClearAllAvailableData();
                //TODO search
            }
        }

        private void ClearAllAvailableData()
        {



        }



        #endregion

        #region Serialization

        /// <summary>
        ///Saves property values to be retained when opening the node     
        /// </summary>
        protected override void SerializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.SerializeCore(nodeElement, context);
            
            nodeElement.SetAttribute("ReportEntry",ReportEntry);
            nodeElement.SetAttribute("CatalogShapeType",CatalogShapeType);
            nodeElement.SetAttribute("ShapeTypeSteel",ShapeTypeSteel);
            nodeElement.SetAttribute("IShapeType",IShapeType);
            nodeElement.SetAttribute("CShapeType",CShapeType);
            nodeElement.SetAttribute("TShapeType",TShapeType);
            nodeElement.SetAttribute("CHSType",CHSType);
            nodeElement.SetAttribute("LDoubleShapeType",LDoubleShapeType);
            
            nodeElement.SetAttribute("AnchorRodType",AnchorRodType);

            nodeElement.SetAttribute("WShapeGroup", WShapeGroup);
            nodeElement.SetAttribute("SShapeGroup", SShapeGroup);
            nodeElement.SetAttribute("MShapeGroup", MShapeGroup);
            nodeElement.SetAttribute("CShapeGroup", CShapeGroup);
            nodeElement.SetAttribute("MCShapeGroup", MCShapeGroup);
            nodeElement.SetAttribute("WTShapeGroup", WTShapeGroup);
            nodeElement.SetAttribute("STShapeGroup", STShapeGroup);
            nodeElement.SetAttribute("LShapeGroup", LShapeGroup);
            nodeElement.SetAttribute("LDoubleEqualGroup", LDoubleEqualGroup);
            nodeElement.SetAttribute("LDoubleLLBBGroup", LDoubleLLBBGroup);
            nodeElement.SetAttribute("LDoubleSLBBGroup", LDoubleSLBBGroup);
            nodeElement.SetAttribute("RHSShapeGroup", RHSShapeGroup);
            nodeElement.SetAttribute("CHSShapeGroup", CHSShapeGroup);
            nodeElement.SetAttribute("PipeGroup", PipeGroup);
            nodeElement.SetAttribute("LDoubleGapType", LDoubleGapType);

            nodeElement.SetAttribute("SteelShapeId", SteelShapeId);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
        
            var CatalogShapeType_attrib = nodeElement.Attributes["CatalogShapeType"]; if (CatalogShapeType_attrib != null) { CatalogShapeType = CatalogShapeType_attrib.Value; }
            var ShapeTypeSteel_attrib = nodeElement.Attributes["ShapeTypeSteel"]; if (ShapeTypeSteel_attrib != null) { ShapeTypeSteel = ShapeTypeSteel_attrib.Value; }
            var IShapeType_attrib = nodeElement.Attributes["IShapeType"]; if (IShapeType_attrib != null) { IShapeType = IShapeType_attrib.Value; }
            var CShapeType_attrib = nodeElement.Attributes["CShapeType"]; if (CShapeType_attrib != null) { CShapeType = CShapeType_attrib.Value; }
            var TShapeType_attrib = nodeElement.Attributes["TShapeType"]; if (TShapeType_attrib != null) { TShapeType = TShapeType_attrib.Value; }
            var CHSType_attrib = nodeElement.Attributes["CHSType"]; if (CHSType_attrib != null) { CHSType = CHSType_attrib.Value; }
            var LDoubleShapeType_attrib = nodeElement.Attributes["LDoubleShapeType"]; if (LDoubleShapeType_attrib != null) { LDoubleShapeType = LDoubleShapeType_attrib.Value; }
            var WShapeGroup_attrib = nodeElement.Attributes["WShapeGroup"]; if (WShapeGroup_attrib != null) { WShapeGroup = WShapeGroup_attrib.Value; }
            var AnchorRodType_attrib = nodeElement.Attributes["AnchorRodType"]; if (AnchorRodType_attrib != null) { AnchorRodType = AnchorRodType_attrib.Value; }

            

            var SShapeGroup_attrib = nodeElement.Attributes["SShapeGroup"]; if (SShapeGroup_attrib != null)                     { SShapeGroup           = SShapeGroup_attrib.Value; }
            var MShapeGroup_attrib = nodeElement.Attributes["MShapeGroup"]; if (MShapeGroup_attrib != null)                     { MShapeGroup           = MShapeGroup_attrib.Value; }
            var CShapeGroup_attrib = nodeElement.Attributes["CShapeGroup"]; if (CShapeGroup_attrib != null)                     { CShapeGroup           = CShapeGroup_attrib.Value; }
            var MCShapeGroup_attrib = nodeElement.Attributes["MCShapeGroup"]; if (MCShapeGroup_attrib != null)                  { MCShapeGroup          = MCShapeGroup_attrib.Value; }
            var WTShapeGroup_attrib = nodeElement.Attributes["WTShapeGroup"]; if (WTShapeGroup_attrib != null)                  { WTShapeGroup          = WTShapeGroup_attrib.Value; }
            var STShapeGroup_attrib = nodeElement.Attributes["STShapeGroup"]; if (STShapeGroup_attrib != null)                  { STShapeGroup          = STShapeGroup_attrib.Value; }
            var LShapeGroup_attrib = nodeElement.Attributes["LShapeGroup"]; if (LShapeGroup_attrib != null)                     { LShapeGroup           = LShapeGroup_attrib.Value; }
            var LDoubleEqualGroup_attrib = nodeElement.Attributes["LDoubleEqualGroup"]; if (LDoubleEqualGroup_attrib != null)   { LDoubleEqualGroup     = LDoubleEqualGroup_attrib.Value; }
            var LDoubleLLBBGroup_attrib = nodeElement.Attributes["LDoubleLLBBGroup"]; if (LDoubleLLBBGroup_attrib != null)      { LDoubleLLBBGroup      = LDoubleLLBBGroup_attrib.Value; }
            var LDoubleSLBBGroup_attrib = nodeElement.Attributes["LDoubleSLBBGroup"]; if (LDoubleSLBBGroup_attrib != null)      { LDoubleSLBBGroup      = LDoubleSLBBGroup_attrib.Value; }
            var RHSShapeGroup_attrib = nodeElement.Attributes["RHSShapeGroup"]; if (RHSShapeGroup_attrib != null)               { RHSShapeGroup         = RHSShapeGroup_attrib.Value; }
            var CHSShapeGroup_attrib = nodeElement.Attributes["CHSShapeGroup"]; if (CHSShapeGroup_attrib != null)               { CHSShapeGroup         = CHSShapeGroup_attrib.Value; }
            var PipeGroup_attrib = nodeElement.Attributes["PipeGroup"]; if (PipeGroup_attrib != null)                           { PipeGroup             = PipeGroup_attrib.Value; }
            var LDoubleGapType_attrib = nodeElement.Attributes["LDoubleGapType"]; if (LDoubleGapType_attrib != null)            { LDoubleGapType        = LDoubleGapType_attrib.Value; }


            var SteelShapeId_attrib = nodeElement.Attributes["SteelShapeId"]; if (SteelShapeId_attrib != null) { SteelShapeId = SteelShapeId_attrib.Value; }

        }



        #endregion


        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class AiscShapeSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<AiscShapeSelection>
        {
            public void CustomizeView(AiscShapeSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                AiscShapeSelectionView control = new AiscShapeSelectionView();
                control.DataContext = model;
                
               
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }

        }
    }
}
