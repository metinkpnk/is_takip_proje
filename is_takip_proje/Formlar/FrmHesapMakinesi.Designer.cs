namespace is_takip_proje.Formlar
{
    partial class FrmHesapMakinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHesapMakinesi));
            this.digitalGaugeDisplay1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge9 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalGaugeDisplay = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBöl = new DevExpress.XtraEditors.SimpleButton();
            this.btnEşittir = new DevExpress.XtraEditors.SimpleButton();
            this.btn0 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSıfırla = new DevExpress.XtraEditors.SimpleButton();
            this.btnÇarp = new DevExpress.XtraEditors.SimpleButton();
            this.btn9 = new DevExpress.XtraEditors.SimpleButton();
            this.btn8 = new DevExpress.XtraEditors.SimpleButton();
            this.btn7 = new DevExpress.XtraEditors.SimpleButton();
            this.btnÇıkart = new DevExpress.XtraEditors.SimpleButton();
            this.btn6 = new DevExpress.XtraEditors.SimpleButton();
            this.btn5 = new DevExpress.XtraEditors.SimpleButton();
            this.btn4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnTopla = new DevExpress.XtraEditors.SimpleButton();
            this.btn3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGaugeDisplay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // digitalGaugeDisplay1
            // 
            this.digitalGaugeDisplay1.AutoLayout = false;
            this.digitalGaugeDisplay1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge9});
            this.digitalGaugeDisplay1.Location = new System.Drawing.Point(63, 35);
            this.digitalGaugeDisplay1.Name = "digitalGaugeDisplay1";
            this.digitalGaugeDisplay1.Size = new System.Drawing.Size(314, 104);
            this.digitalGaugeDisplay1.TabIndex = 0;
            // 
            // digitalGauge9
            // 
            this.digitalGauge9.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F3B030");
            this.digitalGauge9.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#343A49");
            this.digitalGauge9.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalGaugeDisplay});
            this.digitalGauge9.Bounds = new System.Drawing.Rectangle(13, 15, 296, 79);
            this.digitalGauge9.DigitCount = 5;
            this.digitalGauge9.Name = "digitalGauge9";
            this.digitalGauge9.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.digitalGauge9.Text = "00,000";
            // 
            // digitalGaugeDisplay
            // 
            this.digitalGaugeDisplay.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(265.8125F, 99.9625F);
            this.digitalGaugeDisplay.Name = "digitalBackgroundLayerComponent1";
            this.digitalGaugeDisplay.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style24;
            this.digitalGaugeDisplay.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalGaugeDisplay.ZOrder = 1000;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnBöl, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEşittir, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSıfırla, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnÇarp, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnÇıkart, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTopla, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 159);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 235);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnBöl
            // 
            this.btnBöl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBöl.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBöl.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBöl.ImageOptions.SvgImage")));
            this.btnBöl.Location = new System.Drawing.Point(276, 188);
            this.btnBöl.Name = "btnBöl";
            this.btnBöl.Size = new System.Drawing.Size(87, 44);
            this.btnBöl.TabIndex = 15;
            this.btnBöl.Tag = "/";
            this.btnBöl.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnEşittir
            // 
            this.btnEşittir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEşittir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnEşittir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEşittir.ImageOptions.SvgImage")));
            this.btnEşittir.Location = new System.Drawing.Point(185, 188);
            this.btnEşittir.Name = "btnEşittir";
            this.btnEşittir.Size = new System.Drawing.Size(85, 44);
            this.btnEşittir.TabIndex = 14;
            this.btnEşittir.Tag = "=";
            this.btnEşittir.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn0.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn0.ImageOptions.SvgImage")));
            this.btn0.Location = new System.Drawing.Point(94, 188);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(85, 44);
            this.btn0.TabIndex = 13;
            this.btn0.Tag = "1";
            this.btn0.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSıfırla.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSıfırla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSıfırla.ImageOptions.SvgImage")));
            this.btnSıfırla.Location = new System.Drawing.Point(3, 188);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(85, 44);
            this.btnSıfırla.TabIndex = 12;
            this.btnSıfırla.Tag = "C";
            this.btnSıfırla.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnÇarp
            // 
            this.btnÇarp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnÇarp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnÇarp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnÇarp.ImageOptions.SvgImage")));
            this.btnÇarp.Location = new System.Drawing.Point(276, 129);
            this.btnÇarp.Name = "btnÇarp";
            this.btnÇarp.Size = new System.Drawing.Size(87, 53);
            this.btnÇarp.TabIndex = 11;
            this.btnÇarp.Tag = "*";
            this.btnÇarp.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn9.ImageOptions.SvgImage")));
            this.btn9.Location = new System.Drawing.Point(185, 129);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(85, 53);
            this.btn9.TabIndex = 10;
            this.btn9.Tag = "9";
            this.btn9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn8.ImageOptions.SvgImage")));
            this.btn8.Location = new System.Drawing.Point(94, 129);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(85, 53);
            this.btn8.TabIndex = 9;
            this.btn8.Tag = "8";
            this.btn8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn7.ImageOptions.SvgImage")));
            this.btn7.Location = new System.Drawing.Point(3, 129);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 53);
            this.btn7.TabIndex = 8;
            this.btn7.Tag = "7";
            this.btn7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnÇıkart
            // 
            this.btnÇıkart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnÇıkart.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnÇıkart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnÇıkart.ImageOptions.SvgImage")));
            this.btnÇıkart.Location = new System.Drawing.Point(276, 66);
            this.btnÇıkart.Name = "btnÇıkart";
            this.btnÇıkart.Size = new System.Drawing.Size(87, 57);
            this.btnÇıkart.TabIndex = 7;
            this.btnÇıkart.Tag = "-";
            this.btnÇıkart.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn6.ImageOptions.SvgImage")));
            this.btn6.Location = new System.Drawing.Point(185, 66);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 57);
            this.btn6.TabIndex = 6;
            this.btn6.Tag = "6";
            this.btn6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn5.ImageOptions.SvgImage")));
            this.btn5.Location = new System.Drawing.Point(94, 66);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 57);
            this.btn5.TabIndex = 5;
            this.btn5.Tag = "5";
            this.btn5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn4.ImageOptions.SvgImage")));
            this.btn4.Location = new System.Drawing.Point(3, 66);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 57);
            this.btn4.TabIndex = 4;
            this.btn4.Tag = "4";
            this.btn4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTopla.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnTopla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTopla.ImageOptions.SvgImage")));
            this.btnTopla.Location = new System.Drawing.Point(276, 3);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(87, 57);
            this.btnTopla.TabIndex = 3;
            this.btnTopla.Tag = "+";
            this.btnTopla.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn3.ImageOptions.SvgImage")));
            this.btn3.Location = new System.Drawing.Point(185, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 57);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "3";
            this.btn3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn2.ImageOptions.SvgImage")));
            this.btn2.Location = new System.Drawing.Point(94, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 57);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "2";
            this.btn2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn1
            // 
            this.btn1.Appearance.Font = new System.Drawing.Font("Bernard MT Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Appearance.Options.UseFont = true;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn1.ImageOptions.SvgImage")));
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btn1.Size = new System.Drawing.Size(85, 57);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "1";
            this.btn1.Click += new System.EventHandler(this.Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // FrmHesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.digitalGaugeDisplay1);
            this.Name = "FrmHesapMakinesi";
            this.Text = "HesapMakinesi";
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGaugeDisplay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl digitalGaugeDisplay1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge9;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalGaugeDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn3;
        private DevExpress.XtraEditors.SimpleButton btn2;
        private DevExpress.XtraEditors.SimpleButton btn1;
        private DevExpress.XtraEditors.SimpleButton btnBöl;
        private DevExpress.XtraEditors.SimpleButton btnEşittir;
        private DevExpress.XtraEditors.SimpleButton btn0;
        private DevExpress.XtraEditors.SimpleButton btnSıfırla;
        private DevExpress.XtraEditors.SimpleButton btnÇarp;
        private DevExpress.XtraEditors.SimpleButton btn9;
        private DevExpress.XtraEditors.SimpleButton btn8;
        private DevExpress.XtraEditors.SimpleButton btn7;
        private DevExpress.XtraEditors.SimpleButton btnÇıkart;
        private DevExpress.XtraEditors.SimpleButton btn6;
        private DevExpress.XtraEditors.SimpleButton btn5;
        private DevExpress.XtraEditors.SimpleButton btn4;
        private DevExpress.XtraEditors.SimpleButton btnTopla;
        private System.Windows.Forms.Label label1;
    }
}