#region ● Namespace declaration

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Web.Services.Protocols;

using Microsoft.Practices.CompositeUI.SmartParts;

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

using Bizentro.AppFramework.UI.Common;
using Bizentro.AppFramework.UI.Controls;
using Bizentro.AppFramework.UI.Module;
using Bizentro.AppFramework.UI.Variables;
using Bizentro.AppFramework.UI.Common.Exceptions;

#endregion

namespace Bizentro.App.UI.HR.H2099QA1_VN1144
{
    [SmartPart]
    public partial class ModuleViewer : ViewBase
    {

        #region ▶ 1. Declaration part

        #region ■ 1.1 Program information
        /// <TemplateVersion>0.0.1.0</TemplateVersion>
        /// <NameSpace>①namespace</NameSpace>
        /// <Module>②module name</Module>
        /// <Class>③class name</Class>
        /// <Desc>④
        ///   This part describe the summary information about class 
        /// </Desc>
        /// <History>⑤
        ///   <FirstCreated>
        ///     <history name="creator" Date="created date">Make …</history>
        ///   </FirstCreated>
        ///   <Lastmodified>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///   </Lastmodified>
        /// </History>
        /// <Remarks>⑥
        ///   <remark name="modifier"  Date="modified date">… </remark>
        ///   <remark name="modifier"  Date="modified date">… </remark>
        /// </Remarks>

        #endregion

        #region ■ 1.2. Class global constants (common)

        #endregion

        #region ■ 1.3. Class global variables (common)

        #endregion

        #region ■ 1.4 Class global constants (grid)


        #endregion

        #region ■ 1.5 Class global variables (grid)

        // change your code
        //private wsMyBizFL.TypedDataSet cstdsTypedDataSet = new wsMyBizFL.TypedDataSet();

        #endregion

        #endregion

        #region ▶ 2. Initialization part

        #region ■ 2.1 Constructor(common)

        public ModuleViewer()
        {
            InitializeComponent();
        }

        #endregion

        #region ■ 2.2 Form_Load(common)

        protected override void Form_Load()
        {
            //uniBase.UData.SetWorkingDataSet(this.cstdsTypedDataSet);
            uniBase.UCommon.SetViewType(enumDef.ViewType.T02_Multi);

            uniBase.UCommon.LoadInfTB19029(enumDef.FormType.Input, enumDef.ModuleInformation.Common);  // Load company numeric format. I: Input Program, *: All Module
            this.LoadCustomInfTB19029();                                                   // Load custoqm numeric format
        }

        protected override void Form_Load_Completed()
        {
            //ControlName.Focus();                // Set focus
            //uniBase.UCommon.SetToolBarMulti(enumDef.ToolBitMulti.DeleteRow, false);
        }

        #endregion

        #region ■ 2.3 Initializatize local global variables

        protected override void InitLocalVariables()
        {
            // init Dataset Row : change your code
            //dsAnyName.Clear();
        }

        #endregion

        #region ■ 2.4 Set local global default variables

        protected override void SetLocalDefaultValue()
        {
            // Assign default value to controls
            return;
        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData)

        protected override void GatheringComboData()
        {
            // Example: Set ComboBox List (Column Name, Select, From, Where)
            //uniBase.UData.ComboMajorAdd("TaxPolicy", "B0004");
            //uniBase.UData.ComboCustomAdd("MSG_TYPE", "MINOR_CD , MINOR_NM ", "B_MINOR", "MAJOR_CD='A1001'");
        }
        #endregion

        #region ■ 2.6 Define user defined numeric info

        public void LoadCustomInfTB19029()
        {

            #region User Define Numeric Format Data Setting  ☆
            //base.viewTB19029.ggUserDefined6.DecPoint = 0;
            //base.viewTB19029.ggUserDefined6.Integeral = 15;
            #endregion
        }

        #endregion

        #endregion

        #region ▶ 3. Grid method part

        #region ■ 3.1 Initialize Grid (InitSpreadSheet)

        private void InitSpreadSheet()
        {
            #region ■■ 3.1.1 Pre-setting grid information

            //wsMyBizFL.TypedDataSet.TableName uniGridTB1 = dsAnyName.TableName; 

            //CheckEditorDataFilter chkFilter = new CheckEditorDataFilter("1", "0");
            //this.uniGrid1.SSSetEdit(uniGridTB1.co_colColumn.ColumnName, "Code", 150, enumDef.FieldType.Primary, enumDef.CharCase.Upper, false, enumDef.HAlign.Left, 10);
            //this.uniGrid1.SSSetEdit(uniGridTB1.nm_colColumn.ColumnName, "Name", 250, enumDef.FieldType.NotNull, enumDef.CharCase.Default, false, enumDef.HAlign.Left, 100);
            //this.uniGrid1.SSSetEdit(uniGridTB1.pop_colColumn.ColumnName, "Pop Code", 120, enumDef.FieldType.Default, enumDef.CharCase.Upper, true, enumDef.HAlign.Left, 10);
            //this.uniGrid1.SSSetEdit(uniGridTB1.pop_nm_colColumn.ColumnName, "Pop Name", 150, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Left);
            //this.uniGrid1.SSSetCheck(uniGridTB1.chk_colColumn.ColumnName, "Check", 100, enumDef.FieldType.Default, chkFilter, "", enumDef.HAlign.Center, enumDef.HAlign.Center);
            //this.uniGrid1.SSSetCombo(uniGridTB1.cmb_colColumn.ColumnName, "Combo", 100, this.viewDataSet.Tables["MSG_TYPE"], enumDef.FieldType.Default, enumDef.HAlign.Center, false, true);
            //this.uniGrid1.SSSetDate(uniGridTB1.date_colColumn.ColumnName, "Date", 150, enumDef.FieldType.NotNull, CommonVariable.gDateFormat, enumDef.HAlign.Center);
            //this.uniGrid1.SSSetFloat(uniGridTB1.numeric_colColumn.ColumnName, "Numeric", 150, viewTB19029.ggAmtOfMoney, enumDef.FieldType.NotNull, enumDef.HAlign.Right, false, enumDef.PosZero.Default, int.MinValue, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.co_colColumn.ColumnName, "Code", 150, enumDef.FieldType.Primary, enumDef.CharCase.Upper, false, enumDef.HAlign.Left, 10);
            #endregion

            #region ■■ 3.1.2 Formatting grid information

            //this.uniGrid1.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

            #endregion

            #region ■■ 3.1.3 Setting etc grid

            // Hidden Column Setting
            //this.uniGrid1.SSSetColHidden(uniGridTB1.cmb_colColumn.ColumnName);

            #endregion
        }
        #endregion

        #region ■ 3.2 InitData

        private void InitData()
        {
            // TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
            // SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
            // 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.
        }

        #endregion

        #region ■ 3.3 SetSpreadColor

        private void SetSpreadColor(int pvStartRow, int pvEndRow)
        {
            // TO-DO: InsertRow후 그리드 컬러 변경
            //uniGrid1.SSSetProtected(gridCol.LastNum, pvStartRow, pvEndRow);
        }
        #endregion

        #region ■ 3.4 InitControlBinding
        protected override void InitControlBinding()
        {
            // Grid binding with global dataset variable.
            this.InitSpreadSheet();
            //this.uniGrid1.uniGridSetDataBinding(this.cstdsTypedDataSet.IESaveDT);
        }
        #endregion

        #endregion

        #region ▶ 4. Toolbar method part

        #region ■ 4.1 Common Fnction group

        #region ■■ 4.1.1 OnFncQuery(old:FncQuery)

        protected override bool OnFncQuery()
        {
            //TO-DO : code business oriented logic

            return DBQuery();
        }

        #endregion

        #region ■■ 4.1.2 OnFncSave(old:FncSave)

        protected override bool OnFncSave()
        {
            //TO-DO : code business oriented logic

            return DBSave();
        }

        #endregion

        #endregion

        #region ■ 4.2 Single Fnction group

        #region ■■ 4.2.1 OnFncNew(old:FncNew)

        protected override bool OnFncNew()
        {

            //TO-DO : code business oriented logic

            return true;
        }

        #endregion

        #region ■■ 4.2.2 OnFncDelete(old:FncDelete)

        protected override bool OnFncDelete()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.3 OnFncCopy(old:FncCopy)

        protected override bool OnFncCopy()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.4 OnFncFirst(No implementation)

        #endregion

        #region ■■ 4.2.5 OnFncPrev(old:FncPrev)

        protected override bool OnFncPrev()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.6 OnFncNext(old:FncNext)

        protected override bool OnFncNext()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.7 OnFncLast(No implementation)

        #endregion

        #endregion

        #region ■ 4.3 Grid Fnction group

        #region ■■ 4.3.1 OnFncInsertRow(old:FncInsertRow)
        protected override bool OnFncInsertRow()
        {
            //TO-DO : code business oriented logic
            //if (this.uniGrid1.ActiveRow != null)
            //{
            //    this.uniGrid1.ActiveRow.Cells["DATE_COL"].Value = uniBase.UDate.GetDBServerDateTime();
            //}
            return true;
        }
        #endregion

        #region ■■ 4.3.2 OnFncDeleteRow(old:FncDeleteRow)
        protected override bool OnFncDeleteRow()
        {
            //TO-DO : code business oriented logic
            return true;
        }
        #endregion

        #region ■■ 4.3.3 OnFncCancel(old:FncCancel)
        protected override bool OnFncCancel()
        {
            //TO-DO : code business oriented logic
            return true;
        }
        #endregion

        #region ■■ 4.3.4 OnFncCopyRow(old:FncCopy)
        protected override bool OnFncCopyRow()
        {
            //TO-DO : code business oriented logic
            return true;
        }
        #endregion

        #endregion

        #region ■ 4.4 Db function group

        #region ■■ 4.4.1 DBQuery(Common)

        private bool DBQuery()
        {
            //wsMyBizFL.TypedDataSet iqtdsTypedDataSet = new wsMyBizFL.TypedDataSet();
            //wsMyBizFL.TypedDataSet iqtdsICondition = new wsMyBizFL.TypedDataSet();

            try
            {
                //wsMyBizFL.TypedDataSet.IConditionRow row = iqtdsICondition.ICondition.NewIConditionRow();
                //row.code_col = this.pop.CodeValue;
                //iqtdsICondition.ICondition.Rows.Add(row);

                //using (wsMyBizFL.Service iwsMyBizFL = (wsMyBizFL.Service)uniBase.UConfig.SetWebServiceProxyEnv(new wsMyBizFL.Service()))
                //{
                //    iqtdsTypedDataSet = iwsMyBizFL.LookUpWebMethod(CommonVariable.gStrGlobalCollection, iqtdsICondition);
                //    uniBase.UData.MergeDataSet(cstdsTypedDataSet, iqtdsTypedDataSet, false, MissingSchemaAction.Ignore);
                //}
            }
            catch (Exception ex)
            {
                bool reThrow = ExceptionControler.AutoProcessException(ex);
                if (reThrow)
                    throw;
                return false;
            }
            finally
            {
                //if (iqtdsTypedDataSet != null) iqtdsTypedDataSet.Dispose();
                //if (iqtdsICondition != null) iqtdsICondition.Dispose();
            }

            return true;
        }

        #endregion

        #region ■■ 4.4.2 DBDelete(Single)

        private bool DBDelete()
        {
            //TO-DO : code business oriented logic

            return true;
        }

        #endregion

        #region ■■ 4.4.3 DBSave(Common)

        private bool DBSave()
        {
            //TO-DO : code business oriented logic
            this.uniGrid1.UpdateData();

            //wsMyBizFL.TypedDataSet isettdsTypedDataSet = new wsMyBizFL.TypedDataSet();

            try
            {
                //wsMyBizFL.TypedDataSet.IESaveDTDataTable igettdtTypedDataSet =
                //    (wsMyBizFL.TypedDataSet.IESaveDTDataTable)this.cstdsTypedDataSet.IESaveDT.GetChanges();

                //using (wsMyBizFL.Service iwsMyBizFL = (wsMyBizFL.Service)uniBase.UConfig.SetWebServiceProxyEnv(new wsMyBizFL.Service()))
                //{
                //    isettdsTypedDataSet.IESaveDT.Merge(igettdtTypedDataSet, false, MissingSchemaAction.Ignore);
                //    iwsMyBizFL.SaveWebMethod(CommonVariable.gStrGlobalCollection, isettdsTypedDataSet);
                //}
            }
            catch (Exception ex)
            {
                bool reThrow = ExceptionControler.AutoProcessException(ex);
                if (reThrow)
                    throw;
                return false;
            }
            finally
            {
                //if (isettdsTypedDataSet != null) isettdsTypedDataSet.Dispose();
            }


            return true;

        }

        #endregion

        #endregion

        #endregion

        #region ▶ 5. Event method part

        #region ■ 5.1 Single control event implementation group

        #endregion

        #region ■ 5.2 Grid   control event implementation group

        #region ■■ 5.2.1 ButtonClicked >>> ClickCellButton
        /// <summary>
        /// Cell 내의 버튼을 클릭했을때의 일련작업들을 수행합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniGrid1_ClickCellButton(object sender, CellEventArgs e)
        {
        }
        #endregion ■■ ButtonClicked >>> ClickCellButton

        #region ■■ 5.2.2 Change >>> CellChange
        /// <summary>
        /// fpSpread의 Change 이벤트는 UltraGrid의 BeforeExitEditMode 또는 AfterExitEditMode 이벤트로 대체됩니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniGrid1_BeforeExitEditMode(object sender, Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs e)
        {
        }

        private void uniGrid1_AfterExitEditMode(object sender, EventArgs e)
        {

        }
        #endregion ■■ Change >>> CellChange

        #region ■■ 5.2.3 Click >>> AfterCellActivate | AfterRowActivate | AfterSelectChange
        private void uniGrid1_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
        }

        private void uniGrid1_AfterCellActivate(object sender, EventArgs e)
        {
        }

        private void uniGrid1_AfterRowActivate(object sender, EventArgs e)
        {
        }
        #endregion ■■ Click >>> AfterSelectChange

        #region ■■ 5.2.4 ComboSelChange >>> CellListSelect
        /// <summary>
        /// Cell 내의 콤보박스의 Item을 선택 변경했을때 이벤트가 발생합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniGrid1_CellListSelect(object sender, CellEventArgs e)
        {
        }
        #endregion ■■ ComboSelChange >>> CellListSelect

        #region ■■ 5.2.5 DblClick >>> DoubleClickCell
        /// <summary>
        /// fpSpread의 DblClick이벤트는 UltraGrid의 DoubleClickCell이벤트로 변경 하실 수 있습니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniGrid1_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
        }
        #endregion ■■ DblClick >>> DoubleClickCell

        #region ■■ 5.2.6 MouseDown >>> MouseDown
        /// <summary>
        /// 마우스 우측 버튼 클릭시 Context메뉴를 보여주는 일련의 작업들을 이 이벤트에서 수행합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniGrid1_MouseDown(object sender, MouseEventArgs e)
        {
        }
        #endregion ■■ MouseDown >>> MouseDown

        #region ■■ 5.2.7 ScriptLeaveCell >>> BeforeCellDeactivate
        /// <summary>
        /// fpSpread의 ScripLeaveCell 이벤트는 UltraGrid의 
        /// BeforeCellDeactivate 이벤트와 AfterCellActivate 이벤트를 겸해서 사용합니다.
        /// BeforeCellDeactivate    : 기존Cell에서 새로운 Cell로 이동하기 전에 기존Cell위치에서 처리 할 일련의 작업들을 기술합니다.
        /// AfterCellActivate       : 새로운 Cell로 이동해서 처리할 일련의 작업들을 기술합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniGrid1_BeforeCellDeactivate(object sender, CancelEventArgs e)
        {
        }
        #endregion ■■ ScriptLeaveCell >>> BeforeCellDeactivate

        #endregion

        #region ■ 5.3 TAB    control event implementation group
        #endregion

        #endregion

        #region ▶ 6. Popup method part

        #region ■ 6.1 Common popup implementation group

        #endregion

        #region ■ 6.2 User-defined popup implementation group

        private void OpenNumberingType(string iWhere)
        {
            #region ▶▶▶ 10.1.2.1 Popup Constructors
            //CommonPopup cp = new CommonUtil.CommonPopup(PopupType.AutoNumbering);

            //string[] arrRet = cp.showModalDialog(InputParam1);

            #endregion

            #region ▶▶▶ 10.1.2.2 Setting Returned Data

            //if (iWhere) 
            //{
            //    txtMinor.value = arrRet[0];
            //    txtMinorNm.value = arrRet[1];
            //}
            //else
            //{
            //    uniGrid1.Rows[uniGrid1.ActiveRow][gridCol.NumberingCd].value = arrRet[0];
            //    uniGrid1.Rows[uniGrid1.ActiveRow][gridCol.NumberingNm].value = arrRet[1];

            //    if (arrRet[2].Length > 0) 
            //        uniGrid1.Rows[uniGrid1.ActiveRow][gridCol.MaxLen].value = arrRet[2];
            //    else
            //        uniGrid1.Rows[uniGrid1.ActiveRow][gridCol.MaxLen].value = "18";

            //    uniGrid1.Rows[uniGrid1.ActiveRow][gridCol.PrefixCd].value = arrRet[0];

            //}

            #endregion

            //CommonVariable.lgBlnFlgChgValue = true;  // 사용자 액션 발생 알림
        }


        #endregion

        #endregion

        #region ▶ 7. User-defined method part

        #region ■ 7.1 User-defined function group

        #endregion

        #endregion

        private void uniGrid1_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {

        }
    }
}