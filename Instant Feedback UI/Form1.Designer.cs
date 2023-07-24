namespace Instant_Feedback_UI
{
    partial class Form1
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.colPriceListDetailId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceListId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeasuringUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStkMaxBasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceWithVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVATId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVATPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinPriceWithVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxPriceWithVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeStamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsFocus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityServerModeSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPriceListDetailId,
            this.colSiteId,
            this.colPriceListId,
            this.colItemId,
            this.colMeasuringUnitId,
            this.colPrice,
            this.colStkMaxBasePrice,
            this.colValidFrom,
            this.colParentItemId,
            this.colUserId,
            this.colLastUpdate,
            this.colValidTo,
            this.colInactive,
            this.colCurrencyId,
            this.colPriceWithVAT,
            this.colVATId,
            this.colVATPercent,
            this.colDelta,
            this.colAddPercent,
            this.colMinPrice,
            this.colMaxPrice,
            this.colMinPriceWithVAT,
            this.colMaxPriceWithVAT,
            this.colTimeStamp,
            this.colIsFocus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_FarmexpertERP_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select top 100000 * from dbo.PriceListDetail";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "ValidFrom ASC";
            this.entityServerModeSource1.ElementType = typeof(Instant_Feedback_UI.PriceListDetail);
            this.entityServerModeSource1.KeyExpression = "PriceListDetailId";
            // 
            // colPriceListDetailId
            // 
            this.colPriceListDetailId.FieldName = "PriceListDetailId";
            this.colPriceListDetailId.Name = "colPriceListDetailId";
            this.colPriceListDetailId.Visible = true;
            this.colPriceListDetailId.VisibleIndex = 0;
            // 
            // colSiteId
            // 
            this.colSiteId.FieldName = "SiteId";
            this.colSiteId.Name = "colSiteId";
            this.colSiteId.Visible = true;
            this.colSiteId.VisibleIndex = 1;
            // 
            // colPriceListId
            // 
            this.colPriceListId.FieldName = "PriceListId";
            this.colPriceListId.Name = "colPriceListId";
            this.colPriceListId.Visible = true;
            this.colPriceListId.VisibleIndex = 2;
            // 
            // colItemId
            // 
            this.colItemId.FieldName = "ItemId";
            this.colItemId.Name = "colItemId";
            this.colItemId.Visible = true;
            this.colItemId.VisibleIndex = 3;
            // 
            // colMeasuringUnitId
            // 
            this.colMeasuringUnitId.FieldName = "MeasuringUnitId";
            this.colMeasuringUnitId.Name = "colMeasuringUnitId";
            this.colMeasuringUnitId.Visible = true;
            this.colMeasuringUnitId.VisibleIndex = 4;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 5;
            // 
            // colStkMaxBasePrice
            // 
            this.colStkMaxBasePrice.FieldName = "StkMaxBasePrice";
            this.colStkMaxBasePrice.Name = "colStkMaxBasePrice";
            this.colStkMaxBasePrice.Visible = true;
            this.colStkMaxBasePrice.VisibleIndex = 6;
            // 
            // colValidFrom
            // 
            this.colValidFrom.FieldName = "ValidFrom";
            this.colValidFrom.Name = "colValidFrom";
            this.colValidFrom.Visible = true;
            this.colValidFrom.VisibleIndex = 7;
            // 
            // colParentItemId
            // 
            this.colParentItemId.FieldName = "ParentItemId";
            this.colParentItemId.Name = "colParentItemId";
            this.colParentItemId.Visible = true;
            this.colParentItemId.VisibleIndex = 8;
            // 
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            this.colUserId.Visible = true;
            this.colUserId.VisibleIndex = 9;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 10;
            // 
            // colValidTo
            // 
            this.colValidTo.FieldName = "ValidTo";
            this.colValidTo.Name = "colValidTo";
            this.colValidTo.Visible = true;
            this.colValidTo.VisibleIndex = 11;
            // 
            // colInactive
            // 
            this.colInactive.FieldName = "Inactive";
            this.colInactive.Name = "colInactive";
            this.colInactive.Visible = true;
            this.colInactive.VisibleIndex = 12;
            // 
            // colCurrencyId
            // 
            this.colCurrencyId.FieldName = "CurrencyId";
            this.colCurrencyId.Name = "colCurrencyId";
            this.colCurrencyId.Visible = true;
            this.colCurrencyId.VisibleIndex = 13;
            // 
            // colPriceWithVAT
            // 
            this.colPriceWithVAT.FieldName = "PriceWithVAT";
            this.colPriceWithVAT.Name = "colPriceWithVAT";
            this.colPriceWithVAT.Visible = true;
            this.colPriceWithVAT.VisibleIndex = 14;
            // 
            // colVATId
            // 
            this.colVATId.FieldName = "VATId";
            this.colVATId.Name = "colVATId";
            this.colVATId.Visible = true;
            this.colVATId.VisibleIndex = 15;
            // 
            // colVATPercent
            // 
            this.colVATPercent.FieldName = "VATPercent";
            this.colVATPercent.Name = "colVATPercent";
            this.colVATPercent.Visible = true;
            this.colVATPercent.VisibleIndex = 16;
            // 
            // colDelta
            // 
            this.colDelta.FieldName = "Delta";
            this.colDelta.Name = "colDelta";
            this.colDelta.Visible = true;
            this.colDelta.VisibleIndex = 17;
            // 
            // colAddPercent
            // 
            this.colAddPercent.FieldName = "AddPercent";
            this.colAddPercent.Name = "colAddPercent";
            this.colAddPercent.Visible = true;
            this.colAddPercent.VisibleIndex = 18;
            // 
            // colMinPrice
            // 
            this.colMinPrice.FieldName = "MinPrice";
            this.colMinPrice.Name = "colMinPrice";
            this.colMinPrice.Visible = true;
            this.colMinPrice.VisibleIndex = 19;
            // 
            // colMaxPrice
            // 
            this.colMaxPrice.FieldName = "MaxPrice";
            this.colMaxPrice.Name = "colMaxPrice";
            this.colMaxPrice.Visible = true;
            this.colMaxPrice.VisibleIndex = 20;
            // 
            // colMinPriceWithVAT
            // 
            this.colMinPriceWithVAT.FieldName = "MinPriceWithVAT";
            this.colMinPriceWithVAT.Name = "colMinPriceWithVAT";
            this.colMinPriceWithVAT.Visible = true;
            this.colMinPriceWithVAT.VisibleIndex = 21;
            // 
            // colMaxPriceWithVAT
            // 
            this.colMaxPriceWithVAT.FieldName = "MaxPriceWithVAT";
            this.colMaxPriceWithVAT.Name = "colMaxPriceWithVAT";
            this.colMaxPriceWithVAT.Visible = true;
            this.colMaxPriceWithVAT.VisibleIndex = 22;
            // 
            // colTimeStamp
            // 
            this.colTimeStamp.FieldName = "TimeStamp";
            this.colTimeStamp.Name = "colTimeStamp";
            this.colTimeStamp.Visible = true;
            this.colTimeStamp.VisibleIndex = 23;
            // 
            // colIsFocus
            // 
            this.colIsFocus.FieldName = "IsFocus";
            this.colIsFocus.Name = "colIsFocus";
            this.colIsFocus.Visible = true;
            this.colIsFocus.VisibleIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceListDetailId;
        private DevExpress.XtraGrid.Columns.GridColumn colSiteId;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceListId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colMeasuringUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colStkMaxBasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colValidFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colParentItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colValidTo;
        private DevExpress.XtraGrid.Columns.GridColumn colInactive;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceWithVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colVATId;
        private DevExpress.XtraGrid.Columns.GridColumn colVATPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colDelta;
        private DevExpress.XtraGrid.Columns.GridColumn colAddPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colMinPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colMinPriceWithVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxPriceWithVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeStamp;
        private DevExpress.XtraGrid.Columns.GridColumn colIsFocus;
    }
}

