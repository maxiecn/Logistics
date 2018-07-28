namespace LogisticsClient
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.MenuItem_Setting = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItem_ChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItem_Logout = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItem_Quit = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_User = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_Auth = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_GoodsType = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_TransComp = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_Fee = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_ReceiveGoods = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_SendGoods = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_EditReceive = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_Search = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Menu_Input = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_Output = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_Trans = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_EditTrans = new DevExpress.XtraBars.BarButtonItem();
            this.btnReturn = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItem_ExportToStock = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItem_ExportToKM = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_Import = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_BillQuery = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItem_StoreInfo = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_ReceiveMoney = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_BackToStock = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_BackToStore = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_ImportTransfer = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_CountMoney = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItem_PayResult = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_ExportQuery = new DevExpress.XtraBars.BarButtonItem();
            this.Menu_ClearTrans = new DevExpress.XtraBars.BarButtonItem();
            this.rPManage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgManage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPReceive = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgGoods = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPStock = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgStock = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpTrans = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgTrans = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPQuery = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rgQuery = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.Menu_ExportStockOut = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.MenuItem_Logout,
            this.MenuItem_Setting,
            this.MenuItem_Quit,
            this.Menu_User,
            this.Menu_Auth,
            this.Menu_GoodsType,
            this.Menu_TransComp,
            this.Menu_Fee,
            this.Menu_ReceiveGoods,
            this.Menu_SendGoods,
            this.Menu_EditReceive,
            this.Menu_Search,
            this.Menu_Input,
            this.Menu_Output,
            this.Menu_Trans,
            this.Menu_EditTrans,
            this.btnReturn,
            this.MenuItem_ExportToStock,
            this.MenuItem_ExportToKM,
            this.Menu_Import,
            this.Menu_BillQuery,
            this.MenuItem_StoreInfo,
            this.Menu_ReceiveMoney,
            this.Menu_BackToStock,
            this.Menu_BackToStore,
            this.Menu_ImportTransfer,
            this.Menu_CountMoney,
            this.MenuItem_ChangePassword,
            this.MenuItem_PayResult,
            this.Menu_ExportQuery,
            this.Menu_ClearTrans,
            this.Menu_ExportStockOut});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 38;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.Menu_Search);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rPManage,
            this.rPReceive,
            this.rPStock,
            this.rpTrans,
            this.rPQuery});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemButtonEdit2});
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(982, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.SelectedPageChanged += new System.EventHandler(this.ribbon_SelectedPageChanged);
            // 
            // appMenu
            // 
            this.appMenu.ItemLinks.Add(this.MenuItem_Setting);
            this.appMenu.ItemLinks.Add(this.MenuItem_ChangePassword);
            this.appMenu.ItemLinks.Add(this.MenuItem_Logout);
            this.appMenu.ItemLinks.Add(this.MenuItem_Quit);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbon;
            // 
            // MenuItem_Setting
            // 
            this.MenuItem_Setting.Caption = "设置";
            this.MenuItem_Setting.Glyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_Setting.Glyph")));
            this.MenuItem_Setting.Id = 3;
            this.MenuItem_Setting.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_Setting.LargeGlyph")));
            this.MenuItem_Setting.Name = "MenuItem_Setting";
            this.MenuItem_Setting.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // MenuItem_ChangePassword
            // 
            this.MenuItem_ChangePassword.Caption = "修改密码";
            this.MenuItem_ChangePassword.Glyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_ChangePassword.Glyph")));
            this.MenuItem_ChangePassword.Id = 32;
            this.MenuItem_ChangePassword.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_ChangePassword.LargeGlyph")));
            this.MenuItem_ChangePassword.Name = "MenuItem_ChangePassword";
            this.MenuItem_ChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItem_ChangePassword_ItemClick);
            // 
            // MenuItem_Logout
            // 
            this.MenuItem_Logout.Caption = "注销";
            this.MenuItem_Logout.Glyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_Logout.Glyph")));
            this.MenuItem_Logout.Id = 1;
            this.MenuItem_Logout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_Logout.LargeGlyph")));
            this.MenuItem_Logout.Name = "MenuItem_Logout";
            this.MenuItem_Logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItem_Logout_ItemClick);
            // 
            // MenuItem_Quit
            // 
            this.MenuItem_Quit.Caption = "退出";
            this.MenuItem_Quit.Glyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_Quit.Glyph")));
            this.MenuItem_Quit.Id = 12;
            this.MenuItem_Quit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_Quit.LargeGlyph")));
            this.MenuItem_Quit.Name = "MenuItem_Quit";
            // 
            // Menu_User
            // 
            this.Menu_User.Caption = "用户管理";
            this.Menu_User.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_User.Glyph")));
            this.Menu_User.Id = 1;
            this.Menu_User.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_User.LargeGlyph")));
            this.Menu_User.Name = "Menu_User";
            this.Menu_User.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_User_ItemClick);
            // 
            // Menu_Auth
            // 
            this.Menu_Auth.Caption = "权限管理";
            this.Menu_Auth.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_Auth.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_Auth.Glyph")));
            this.Menu_Auth.Id = 2;
            this.Menu_Auth.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_Auth.LargeGlyph")));
            this.Menu_Auth.Name = "Menu_Auth";
            this.Menu_Auth.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_Auth_ItemClick);
            // 
            // Menu_GoodsType
            // 
            this.Menu_GoodsType.Caption = "货物类型";
            this.Menu_GoodsType.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_GoodsType.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_GoodsType.Glyph")));
            this.Menu_GoodsType.Id = 3;
            this.Menu_GoodsType.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_GoodsType.LargeGlyph")));
            this.Menu_GoodsType.Name = "Menu_GoodsType";
            this.Menu_GoodsType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_GoodsType_ItemClick);
            // 
            // Menu_TransComp
            // 
            this.Menu_TransComp.Caption = "快递公司设置";
            this.Menu_TransComp.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_TransComp.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_TransComp.Glyph")));
            this.Menu_TransComp.Id = 4;
            this.Menu_TransComp.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_TransComp.LargeGlyph")));
            this.Menu_TransComp.Name = "Menu_TransComp";
            this.Menu_TransComp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_TransComp_ItemClick);
            // 
            // Menu_Fee
            // 
            this.Menu_Fee.Caption = "收费标准";
            this.Menu_Fee.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_Fee.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_Fee.Glyph")));
            this.Menu_Fee.Id = 5;
            this.Menu_Fee.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_Fee.LargeGlyph")));
            this.Menu_Fee.Name = "Menu_Fee";
            this.Menu_Fee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_Fee_ItemClick);
            // 
            // Menu_ReceiveGoods
            // 
            this.Menu_ReceiveGoods.Caption = "添加收货";
            this.Menu_ReceiveGoods.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_ReceiveGoods.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_ReceiveGoods.Glyph")));
            this.Menu_ReceiveGoods.Id = 8;
            this.Menu_ReceiveGoods.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_ReceiveGoods.LargeGlyph")));
            this.Menu_ReceiveGoods.Name = "Menu_ReceiveGoods";
            this.Menu_ReceiveGoods.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_ReceiveGoods_ItemClick);
            // 
            // Menu_SendGoods
            // 
            this.Menu_SendGoods.Caption = "添加发货";
            this.Menu_SendGoods.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_SendGoods.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_SendGoods.Glyph")));
            this.Menu_SendGoods.Id = 9;
            this.Menu_SendGoods.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_SendGoods.LargeGlyph")));
            this.Menu_SendGoods.Name = "Menu_SendGoods";
            this.Menu_SendGoods.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_SendGoods_ItemClick);
            // 
            // Menu_EditReceive
            // 
            this.Menu_EditReceive.Caption = "编辑收货";
            this.Menu_EditReceive.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_EditReceive.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_EditReceive.Glyph")));
            this.Menu_EditReceive.Id = 10;
            this.Menu_EditReceive.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_EditReceive.LargeGlyph")));
            this.Menu_EditReceive.Name = "Menu_EditReceive";
            this.Menu_EditReceive.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_EditReceive_ItemClick);
            // 
            // Menu_Search
            // 
            this.Menu_Search.Caption = "搜索";
            this.Menu_Search.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_Search.Edit = this.repositoryItemButtonEdit1;
            this.Menu_Search.Id = 11;
            this.Menu_Search.Name = "Menu_Search";
            this.Menu_Search.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu_Search.Width = 200;
            this.Menu_Search.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_Search_ItemClick);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // Menu_Input
            // 
            this.Menu_Input.Caption = "入库记录";
            this.Menu_Input.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_Input.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_Input.Glyph")));
            this.Menu_Input.Id = 12;
            this.Menu_Input.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_Input.LargeGlyph")));
            this.Menu_Input.Name = "Menu_Input";
            this.Menu_Input.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_Input_ItemClick);
            // 
            // Menu_Output
            // 
            this.Menu_Output.Caption = "发往昆明";
            this.Menu_Output.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_Output.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_Output.Glyph")));
            this.Menu_Output.Id = 13;
            this.Menu_Output.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_Output.LargeGlyph")));
            this.Menu_Output.Name = "Menu_Output";
            this.Menu_Output.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_Output_ItemClick);
            // 
            // Menu_Trans
            // 
            this.Menu_Trans.Caption = "转运信息";
            this.Menu_Trans.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_Trans.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_Trans.Glyph")));
            this.Menu_Trans.Id = 14;
            this.Menu_Trans.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_Trans.LargeGlyph")));
            this.Menu_Trans.Name = "Menu_Trans";
            this.Menu_Trans.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_Trans_ItemClick);
            // 
            // Menu_EditTrans
            // 
            this.Menu_EditTrans.Caption = "编辑转运信息";
            this.Menu_EditTrans.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_EditTrans.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_EditTrans.Glyph")));
            this.Menu_EditTrans.Id = 15;
            this.Menu_EditTrans.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_EditTrans.LargeGlyph")));
            this.Menu_EditTrans.Name = "Menu_EditTrans";
            this.Menu_EditTrans.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu_EditTrans.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_EditTrans_ItemClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Caption = "  退货  ";
            this.btnReturn.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnReturn.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReturn.Glyph")));
            this.btnReturn.Id = 16;
            this.btnReturn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnReturn.LargeGlyph")));
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReturn_ItemClick);
            // 
            // MenuItem_ExportToStock
            // 
            this.MenuItem_ExportToStock.Caption = "导出出货单";
            this.MenuItem_ExportToStock.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.MenuItem_ExportToStock.Glyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_ExportToStock.Glyph")));
            this.MenuItem_ExportToStock.Id = 22;
            this.MenuItem_ExportToStock.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_ExportToStock.LargeGlyph")));
            this.MenuItem_ExportToStock.Name = "MenuItem_ExportToStock";
            this.MenuItem_ExportToStock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.MenuItem_ExportToStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItem_ExportToStock_ItemClick);
            // 
            // MenuItem_ExportToKM
            // 
            this.MenuItem_ExportToKM.Caption = "导出转运单";
            this.MenuItem_ExportToKM.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.MenuItem_ExportToKM.Glyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_ExportToKM.Glyph")));
            this.MenuItem_ExportToKM.Id = 23;
            this.MenuItem_ExportToKM.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_ExportToKM.LargeGlyph")));
            this.MenuItem_ExportToKM.Name = "MenuItem_ExportToKM";
            this.MenuItem_ExportToKM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItem_ExportToKM_ItemClick);
            // 
            // Menu_Import
            // 
            this.Menu_Import.Caption = "导入运单";
            this.Menu_Import.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_Import.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_Import.Glyph")));
            this.Menu_Import.Id = 24;
            this.Menu_Import.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_Import.LargeGlyph")));
            this.Menu_Import.Name = "Menu_Import";
            this.Menu_Import.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_Import_ItemClick);
            // 
            // Menu_BillQuery
            // 
            this.Menu_BillQuery.Caption = "单据查询";
            this.Menu_BillQuery.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_BillQuery.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_BillQuery.Glyph")));
            this.Menu_BillQuery.Id = 25;
            this.Menu_BillQuery.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_BillQuery.LargeGlyph")));
            this.Menu_BillQuery.Name = "Menu_BillQuery";
            this.Menu_BillQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_BillQuery_ItemClick);
            // 
            // MenuItem_StoreInfo
            // 
            this.MenuItem_StoreInfo.Caption = "店面管理";
            this.MenuItem_StoreInfo.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.MenuItem_StoreInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_StoreInfo.Glyph")));
            this.MenuItem_StoreInfo.Id = 26;
            this.MenuItem_StoreInfo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_StoreInfo.LargeGlyph")));
            this.MenuItem_StoreInfo.Name = "MenuItem_StoreInfo";
            this.MenuItem_StoreInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItem_StoreInfo_ItemClick);
            // 
            // Menu_ReceiveMoney
            // 
            this.Menu_ReceiveMoney.Caption = "汇款登记";
            this.Menu_ReceiveMoney.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_ReceiveMoney.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_ReceiveMoney.Glyph")));
            this.Menu_ReceiveMoney.Id = 27;
            this.Menu_ReceiveMoney.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_ReceiveMoney.LargeGlyph")));
            this.Menu_ReceiveMoney.Name = "Menu_ReceiveMoney";
            this.Menu_ReceiveMoney.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_ReceiveMoney_ItemClick);
            // 
            // Menu_BackToStock
            // 
            this.Menu_BackToStock.Caption = "退回仓库";
            this.Menu_BackToStock.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_BackToStock.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_BackToStock.Glyph")));
            this.Menu_BackToStock.Id = 28;
            this.Menu_BackToStock.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_BackToStock.LargeGlyph")));
            this.Menu_BackToStock.Name = "Menu_BackToStock";
            this.Menu_BackToStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_BackToStore_ItemClick);
            // 
            // Menu_BackToStore
            // 
            this.Menu_BackToStore.Caption = "退回门店";
            this.Menu_BackToStore.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_BackToStore.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_BackToStore.Glyph")));
            this.Menu_BackToStore.Id = 29;
            this.Menu_BackToStore.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_BackToStore.LargeGlyph")));
            this.Menu_BackToStore.Name = "Menu_BackToStore";
            this.Menu_BackToStore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_BackToStore_ItemClick_1);
            // 
            // Menu_ImportTransfer
            // 
            this.Menu_ImportTransfer.Caption = "导入转运信息";
            this.Menu_ImportTransfer.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_ImportTransfer.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_ImportTransfer.Glyph")));
            this.Menu_ImportTransfer.Id = 30;
            this.Menu_ImportTransfer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_ImportTransfer.LargeGlyph")));
            this.Menu_ImportTransfer.Name = "Menu_ImportTransfer";
            this.Menu_ImportTransfer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_ImportTransfer_ItemClick);
            // 
            // Menu_CountMoney
            // 
            this.Menu_CountMoney.Caption = "营收统计";
            this.Menu_CountMoney.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_CountMoney.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_CountMoney.Glyph")));
            this.Menu_CountMoney.Id = 31;
            this.Menu_CountMoney.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_CountMoney.LargeGlyph")));
            this.Menu_CountMoney.Name = "Menu_CountMoney";
            this.Menu_CountMoney.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_CountMoney_ItemClick);
            // 
            // MenuItem_PayResult
            // 
            this.MenuItem_PayResult.Caption = "汇款审核";
            this.MenuItem_PayResult.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.MenuItem_PayResult.Glyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_PayResult.Glyph")));
            this.MenuItem_PayResult.Id = 33;
            this.MenuItem_PayResult.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("MenuItem_PayResult.LargeGlyph")));
            this.MenuItem_PayResult.Name = "MenuItem_PayResult";
            this.MenuItem_PayResult.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItem_PayResult_ItemClick);
            // 
            // Menu_ExportQuery
            // 
            this.Menu_ExportQuery.Caption = "导出结果";
            this.Menu_ExportQuery.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_ExportQuery.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_ExportQuery.Glyph")));
            this.Menu_ExportQuery.Id = 35;
            this.Menu_ExportQuery.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_ExportQuery.LargeGlyph")));
            this.Menu_ExportQuery.Name = "Menu_ExportQuery";
            this.Menu_ExportQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_ExportQuery_ItemClick);
            // 
            // Menu_ClearTrans
            // 
            this.Menu_ClearTrans.Caption = "清空转运信息";
            this.Menu_ClearTrans.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_ClearTrans.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_ClearTrans.Glyph")));
            this.Menu_ClearTrans.Id = 36;
            this.Menu_ClearTrans.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_ClearTrans.LargeGlyph")));
            this.Menu_ClearTrans.Name = "Menu_ClearTrans";
            this.Menu_ClearTrans.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_ClearTrans_ItemClick);
            // 
            // rPManage
            // 
            this.rPManage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgManage});
            this.rPManage.Name = "rPManage";
            this.rPManage.Text = "管理工具";
            // 
            // rpgManage
            // 
            this.rpgManage.ItemLinks.Add(this.Menu_User);
            this.rpgManage.ItemLinks.Add(this.Menu_Auth);
            this.rpgManage.ItemLinks.Add(this.Menu_TransComp);
            this.rpgManage.ItemLinks.Add(this.Menu_GoodsType);
            this.rpgManage.ItemLinks.Add(this.Menu_Fee);
            this.rpgManage.ItemLinks.Add(this.MenuItem_StoreInfo);
            this.rpgManage.Name = "rpgManage";
            this.rpgManage.Text = "基础信息管理";
            // 
            // rPReceive
            // 
            this.rPReceive.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgGoods});
            this.rPReceive.Name = "rPReceive";
            this.rPReceive.Text = "收货门店";
            // 
            // rpgGoods
            // 
            this.rpgGoods.ItemLinks.Add(this.Menu_ReceiveGoods);
            this.rpgGoods.ItemLinks.Add(this.btnReturn);
            this.rpgGoods.ItemLinks.Add(this.Menu_EditReceive);
            this.rpgGoods.ItemLinks.Add(this.Menu_SendGoods);
            this.rpgGoods.ItemLinks.Add(this.Menu_Import);
            this.rpgGoods.ItemLinks.Add(this.MenuItem_ExportToStock);
            this.rpgGoods.ItemLinks.Add(this.Menu_ReceiveMoney);
            this.rpgGoods.Name = "rpgGoods";
            this.rpgGoods.Text = "收发货物管理";
            // 
            // rPStock
            // 
            this.rPStock.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgStock});
            this.rPStock.Name = "rPStock";
            this.rPStock.Text = "仓库管理";
            // 
            // rpgStock
            // 
            this.rpgStock.ItemLinks.Add(this.Menu_Input);
            this.rpgStock.ItemLinks.Add(this.Menu_Output);
            this.rpgStock.ItemLinks.Add(this.MenuItem_ExportToKM);
            this.rpgStock.ItemLinks.Add(this.Menu_BackToStore);
            this.rpgStock.ItemLinks.Add(this.Menu_ExportStockOut);
            this.rpgStock.Name = "rpgStock";
            this.rpgStock.Text = "仓库管理";
            // 
            // rpTrans
            // 
            this.rpTrans.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgTrans});
            this.rpTrans.Name = "rpTrans";
            this.rpTrans.Text = "转运管理";
            // 
            // rpgTrans
            // 
            this.rpgTrans.ItemLinks.Add(this.Menu_Trans);
            this.rpgTrans.ItemLinks.Add(this.Menu_EditTrans);
            this.rpgTrans.ItemLinks.Add(this.Menu_BackToStock);
            this.rpgTrans.ItemLinks.Add(this.Menu_ImportTransfer);
            this.rpgTrans.ItemLinks.Add(this.Menu_ClearTrans);
            this.rpgTrans.Name = "rpgTrans";
            this.rpgTrans.Text = "转运信息管理";
            // 
            // rPQuery
            // 
            this.rPQuery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rgQuery});
            this.rPQuery.Name = "rPQuery";
            this.rPQuery.Text = "查询统计";
            // 
            // rgQuery
            // 
            this.rgQuery.ItemLinks.Add(this.Menu_BillQuery);
            this.rgQuery.ItemLinks.Add(this.Menu_CountMoney);
            this.rgQuery.ItemLinks.Add(this.MenuItem_PayResult);
            this.rgQuery.ItemLinks.Add(this.Menu_ExportQuery);
            this.rgQuery.Name = "rgQuery";
            this.rgQuery.Text = "查询统计";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 590);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(982, 31);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 147);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(982, 443);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // Menu_ExportStockOut
            // 
            this.Menu_ExportStockOut.Caption = "导出出货单";
            this.Menu_ExportStockOut.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.Menu_ExportStockOut.Glyph = ((System.Drawing.Image)(resources.GetObject("Menu_ExportStockOut.Glyph")));
            this.Menu_ExportStockOut.Id = 37;
            this.Menu_ExportStockOut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Menu_ExportStockOut.LargeGlyph")));
            this.Menu_ExportStockOut.Name = "Menu_ExportStockOut";
            this.Menu_ExportStockOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Menu_ExportStockOut_ItemClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 621);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPManage;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.BarButtonItem MenuItem_Setting;
        private DevExpress.XtraBars.BarButtonItem MenuItem_Logout;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPReceive;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPStock;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpTrans;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPQuery;
        private DevExpress.XtraBars.BarButtonItem MenuItem_Quit;
        private DevExpress.XtraBars.BarButtonItem Menu_User;
        private DevExpress.XtraBars.BarButtonItem Menu_Auth;
        private DevExpress.XtraBars.BarButtonItem Menu_GoodsType;
        private DevExpress.XtraBars.BarButtonItem Menu_TransComp;
        private DevExpress.XtraBars.BarButtonItem Menu_Fee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgManage;
        private DevExpress.XtraBars.BarButtonItem Menu_ReceiveGoods;
        private DevExpress.XtraBars.BarButtonItem Menu_SendGoods;
        private DevExpress.XtraBars.BarButtonItem Menu_EditReceive;
        private DevExpress.XtraBars.BarEditItem Menu_Search;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.Panel pnlContent;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGoods;
        private DevExpress.XtraBars.BarButtonItem Menu_Input;
        private DevExpress.XtraBars.BarButtonItem Menu_Output;
        private DevExpress.XtraBars.BarButtonItem Menu_Trans;
        private DevExpress.XtraBars.BarButtonItem Menu_EditTrans;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgStock;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTrans;
        private DevExpress.XtraBars.BarButtonItem btnReturn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rgQuery;
        private DevExpress.XtraBars.BarButtonItem MenuItem_ExportToStock;
        private DevExpress.XtraBars.BarButtonItem MenuItem_ExportToKM;
        private DevExpress.XtraBars.BarButtonItem Menu_Import;
        private DevExpress.XtraBars.BarButtonItem Menu_BillQuery;
        private DevExpress.XtraBars.BarButtonItem MenuItem_StoreInfo;
        private DevExpress.XtraBars.BarButtonItem Menu_ReceiveMoney;
        private DevExpress.XtraBars.BarButtonItem Menu_BackToStock;
        private DevExpress.XtraBars.BarButtonItem Menu_BackToStore;
        private DevExpress.XtraBars.BarButtonItem Menu_ImportTransfer;
        private DevExpress.XtraBars.BarButtonItem Menu_CountMoney;
        private DevExpress.XtraBars.BarButtonItem MenuItem_ChangePassword;
        private DevExpress.XtraBars.BarButtonItem MenuItem_PayResult;
        private DevExpress.XtraBars.BarButtonItem Menu_ExportQuery;
        private DevExpress.XtraBars.BarButtonItem Menu_ClearTrans;
        private DevExpress.XtraBars.BarButtonItem Menu_ExportStockOut;
    }
}