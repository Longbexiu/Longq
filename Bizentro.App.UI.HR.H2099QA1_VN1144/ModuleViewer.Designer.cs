﻿using Bizentro.AppFramework.UI.Module;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.ObjectBuilder;

namespace Bizentro.App.UI.HR.H2099QA1_VN1144
{

    public class ModuleInitializer : Bizentro.AppFramework.UI.Module.Module
    {
        [InjectionConstructor]
        public ModuleInitializer([ServiceDependency] WorkItem rootWorkItem)
            : base(rootWorkItem) { }

        protected override void RegisterModureViewer()
        {
            base.AddModule<ModuleViewer>();
        }
    }

    partial class ModuleViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            this.uniTBL_OuterMost = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainData = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniGrid1 = new Bizentro.AppFramework.UI.Controls.uniGrid(this.components);
            this.uniTBL_MainCondition = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainReference = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainBatch = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_OuterMost.SuspendLayout();
            this.uniTBL_MainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // uniLabel_Path
            // 
            this.uniLabel_Path.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.PathInfo;
            this.uniLabel_Path.Size = new System.Drawing.Size(500, 14);
            // 
            // uniTBL_OuterMost
            // 
            this.uniTBL_OuterMost.AutoFit = false;
            this.uniTBL_OuterMost.AutoFitColumnCount = 4;
            this.uniTBL_OuterMost.AutoFitRowCount = 4;
            this.uniTBL_OuterMost.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_OuterMost.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_OuterMost.ColumnCount = 1;
            this.uniTBL_OuterMost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainData, 0, 4);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainCondition, 0, 2);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainReference, 0, 0);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainBatch, 0, 6);
            this.uniTBL_OuterMost.DefaultRowSize = 23;
            this.uniTBL_OuterMost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_OuterMost.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_OuterMost.HEIGHT_TYPE_00_REFERENCE = 21F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_01 = 6F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_01_CONDITION = 38F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_02 = 9F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_03_BOTTOM = 28F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_04 = 1F;
            this.uniTBL_OuterMost.Location = new System.Drawing.Point(1, 13);
            this.uniTBL_OuterMost.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_OuterMost.Name = "uniTBL_OuterMost";
            this.uniTBL_OuterMost.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_OuterMost.RowCount = 8;
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.uniTBL_OuterMost.Size = new System.Drawing.Size(875, 566);
            this.uniTBL_OuterMost.SizeTD5 = 14F;
            this.uniTBL_OuterMost.SizeTD6 = 36F;
            this.uniTBL_OuterMost.TabIndex = 0;
            this.uniTBL_OuterMost.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniTBL_MainData
            // 
            this.uniTBL_MainData.AutoFit = false;
            this.uniTBL_MainData.AutoFitColumnCount = 4;
            this.uniTBL_MainData.AutoFitRowCount = 4;
            this.uniTBL_MainData.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainData.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainData.ColumnCount = 1;
            this.uniTBL_MainData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainData.Controls.Add(this.uniGrid1, 0, 0);
            this.uniTBL_MainData.DefaultRowSize = 23;
            this.uniTBL_MainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainData.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainData.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainData.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainData.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainData.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainData.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainData.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainData.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainData.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainData.Location = new System.Drawing.Point(0, 74);
            this.uniTBL_MainData.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainData.Name = "uniTBL_MainData";
            this.uniTBL_MainData.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Data;
            this.uniTBL_MainData.RowCount = 1;
            this.uniTBL_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainData.Size = new System.Drawing.Size(875, 460);
            this.uniTBL_MainData.SizeTD5 = 14F;
            this.uniTBL_MainData.SizeTD6 = 36F;
            this.uniTBL_MainData.TabIndex = 0;
            this.uniTBL_MainData.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniGrid1
            // 
            this.uniGrid1.AddEmptyRow = false;
            this.uniGrid1.DirectPaste = false;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.uniGrid1.DisplayLayout.Appearance = appearance1;
            this.uniGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.uniGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.uniGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.uniGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.uniGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uniGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            this.uniGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.uniGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.uniGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.CardAreaAppearance = appearance6;
            appearance7.BorderColor = System.Drawing.Color.Silver;
            appearance7.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.uniGrid1.DisplayLayout.Override.CellAppearance = appearance7;
            this.uniGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.uniGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance8.BackColor = System.Drawing.SystemColors.Control;
            appearance8.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance8.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance8.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance8;
            appearance9.TextHAlignAsString = "Left";
            this.uniGrid1.DisplayLayout.Override.HeaderAppearance = appearance9;
            this.uniGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.uniGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            appearance10.BorderColor = System.Drawing.Color.Silver;
            this.uniGrid1.DisplayLayout.Override.RowAppearance = appearance10;
            this.uniGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uniGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance11;
            this.uniGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uniGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uniGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniGrid1.EnableContextMenu = true;
            this.uniGrid1.EnableGridFilterMenu = false;
            this.uniGrid1.EnableGridInfoContextMenu = true;
            this.uniGrid1.ExceptInExcel = false;
            this.uniGrid1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniGrid1.gComNumDec = Bizentro.AppFramework.UI.Variables.enumDef.ComDec.Decimal;
            this.uniGrid1.GridStyle = Bizentro.AppFramework.UI.Variables.enumDef.GridStyle.Master;
            this.uniGrid1.Location = new System.Drawing.Point(0, 0);
            this.uniGrid1.Margin = new System.Windows.Forms.Padding(0);
            this.uniGrid1.Name = "uniGrid1";
            this.uniGrid1.OutlookGroupBy = Bizentro.AppFramework.UI.Variables.enumDef.IsOutlookGroupBy.No;
            this.uniGrid1.PopupDeleteMenuVisible = true;
            this.uniGrid1.PopupInsertMenuVisible = true;
            this.uniGrid1.PopupUndoMenuVisible = true;
            this.uniGrid1.Search = Bizentro.AppFramework.UI.Variables.enumDef.IsSearch.Yes;
            this.uniGrid1.ShowHeaderCheck = true;
            this.uniGrid1.Size = new System.Drawing.Size(875, 460);
            this.uniGrid1.StyleSetName = "uniGrid_Query";
            this.uniGrid1.TabIndex = 0;
            this.uniGrid1.Text = "uniGrid1";
            this.uniGrid1.UseDynamicFormat = false;
            this.uniGrid1.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.uniGrid1_InitializeLayout);
            // 
            // uniTBL_MainCondition
            // 
            this.uniTBL_MainCondition.AutoFit = false;
            this.uniTBL_MainCondition.AutoFitColumnCount = 4;
            this.uniTBL_MainCondition.AutoFitRowCount = 4;
            this.uniTBL_MainCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.uniTBL_MainCondition.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainCondition.ColumnCount = 4;
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.uniTBL_MainCondition.DefaultRowSize = 23;
            this.uniTBL_MainCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainCondition.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainCondition.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainCondition.Location = new System.Drawing.Point(0, 27);
            this.uniTBL_MainCondition.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainCondition.Name = "uniTBL_MainCondition";
            this.uniTBL_MainCondition.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.uniTBL_MainCondition.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Condition;
            this.uniTBL_MainCondition.RowCount = 1;
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainCondition.Size = new System.Drawing.Size(875, 38);
            this.uniTBL_MainCondition.SizeTD5 = 14F;
            this.uniTBL_MainCondition.SizeTD6 = 36F;
            this.uniTBL_MainCondition.TabIndex = 1;
            this.uniTBL_MainCondition.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniTBL_MainReference
            // 
            this.uniTBL_MainReference.AutoFit = false;
            this.uniTBL_MainReference.AutoFitColumnCount = 4;
            this.uniTBL_MainReference.AutoFitRowCount = 4;
            this.uniTBL_MainReference.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainReference.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainReference.ColumnCount = 3;
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainReference.DefaultRowSize = 23;
            this.uniTBL_MainReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainReference.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainReference.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainReference.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainReference.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainReference.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainReference.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainReference.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainReference.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainReference.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainReference.Location = new System.Drawing.Point(0, 0);
            this.uniTBL_MainReference.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainReference.Name = "uniTBL_MainReference";
            this.uniTBL_MainReference.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_MainReference.RowCount = 1;
            this.uniTBL_MainReference.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainReference.Size = new System.Drawing.Size(875, 21);
            this.uniTBL_MainReference.SizeTD5 = 14F;
            this.uniTBL_MainReference.SizeTD6 = 36F;
            this.uniTBL_MainReference.TabIndex = 2;
            this.uniTBL_MainReference.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniTBL_MainBatch
            // 
            this.uniTBL_MainBatch.AutoFit = false;
            this.uniTBL_MainBatch.AutoFitColumnCount = 4;
            this.uniTBL_MainBatch.AutoFitRowCount = 4;
            this.uniTBL_MainBatch.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainBatch.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainBatch.ColumnCount = 5;
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.DefaultRowSize = 23;
            this.uniTBL_MainBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainBatch.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainBatch.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainBatch.Location = new System.Drawing.Point(0, 537);
            this.uniTBL_MainBatch.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainBatch.Name = "uniTBL_MainBatch";
            this.uniTBL_MainBatch.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_MainBatch.RowCount = 1;
            this.uniTBL_MainBatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainBatch.Size = new System.Drawing.Size(875, 28);
            this.uniTBL_MainBatch.SizeTD5 = 14F;
            this.uniTBL_MainBatch.SizeTD6 = 36F;
            this.uniTBL_MainBatch.TabIndex = 3;
            this.uniTBL_MainBatch.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // ModuleViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uniTBL_OuterMost);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "ModuleViewer";
            this.Size = new System.Drawing.Size(887, 592);
            this.Controls.SetChildIndex(this.uniTBL_OuterMost, 0);
            this.Controls.SetChildIndex(this.uniLabel_Path, 0);
            this.uniTBL_OuterMost.ResumeLayout(false);
            this.uniTBL_MainData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uniGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_OuterMost;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainData;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainCondition;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainReference;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainBatch;
        private Bizentro.AppFramework.UI.Controls.uniGrid uniGrid1;

    }
}
