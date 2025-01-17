namespace is_takip_proje.Formlar
{
    partial class FrmDepartmanİstatistikleri
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.tblDepartmanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbİsTakipDataSet = new is_takip_proje.DbİsTakipDataSet();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dbİsTakipDataSet1 = new is_takip_proje.DbİsTakipDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblDepartmanlarTableAdapter = new is_takip_proje.DbİsTakipDataSetTableAdapters.TblDepartmanlarTableAdapter();
            this.tblDepartmanlarTableAdapter1 = new is_takip_proje.DbİsTakipDataSetTableAdapters.TblDepartmanlarTableAdapter();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbİsTakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbİsTakipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDepartmanlarBindingSource
            // 
            this.tblDepartmanlarBindingSource.DataMember = "TblDepartmanlar";
            this.tblDepartmanlarBindingSource.DataSource = this.dbİsTakipDataSet;
            // 
            // dbİsTakipDataSet
            // 
            this.dbİsTakipDataSet.DataSetName = "DbİsTakipDataSet";
            this.dbİsTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "TblDepartmanlar";
            this.gridControl1.DataSource = this.dbİsTakipDataSet1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gridControl1.Location = new System.Drawing.Point(19, 15);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(556, 682);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dbİsTakipDataSet1
            // 
            this.dbİsTakipDataSet1.DataSetName = "DbİsTakipDataSet";
            this.dbİsTakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAd});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1250;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 39;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 146;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 39;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 1;
            this.colAd.Width = 146;
            // 
            // tblDepartmanlarTableAdapter
            // 
            this.tblDepartmanlarTableAdapter.ClearBeforeFill = true;
            // 
            // tblDepartmanlarTableAdapter1
            // 
            this.tblDepartmanlarTableAdapter1.ClearBeforeFill = true;
            // 
            // chartControl1
            // 
            simpleDiagram3D1.RotationMatrixSerializable = "0.945607803602005;0.304192901930041;-0.115293365734524;0;-0.32504536187432;0.8977" +
    "7448747769;-0.297231361666614;0;0.0130917718819038;0.318539868854085;0.947819053" +
    "121136;0;0;0;0;1";
            this.chartControl1.Diagram = simpleDiagram3D1;
            this.chartControl1.Location = new System.Drawing.Point(614, 44);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.SeriesID = 5;
            series1.View = pie3DSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(559, 504);
            this.chartControl1.TabIndex = 2;
            // 
            // FrmDepartmanİstatistikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 571);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmDepartmanİstatistikleri";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbİsTakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbİsTakipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DbİsTakipDataSet dbİsTakipDataSet;
        private System.Windows.Forms.BindingSource tblDepartmanlarBindingSource;
        private DbİsTakipDataSetTableAdapters.TblDepartmanlarTableAdapter tblDepartmanlarTableAdapter;
        private DbİsTakipDataSet dbİsTakipDataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DbİsTakipDataSetTableAdapters.TblDepartmanlarTableAdapter tblDepartmanlarTableAdapter1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}