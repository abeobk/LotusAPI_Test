
namespace LotusAPI_Test {
    partial class FormScannerTest {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.flatPanel1 = new Abeo.Controls.FlatPanel();
            this.bt_ClearDisplay = new Abeo.Controls.Roundable.RoundButton();
            this.bt_Scan = new Abeo.Controls.Roundable.RoundButton();
            this.bt_Connect = new Abeo.Controls.Roundable.RoundButton();
            this.pcv = new LotusAPI.Controls.PointcloudView();
            this.lv = new LotusAPI.Controls.LogView();
            this.bt_Save = new Abeo.Controls.Roundable.RoundButton();
            this.flatPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcv)).BeginInit();
            this.SuspendLayout();
            // 
            // flatPanel1
            // 
            this.flatPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flatPanel1.Controls.Add(this.bt_Save);
            this.flatPanel1.Controls.Add(this.bt_ClearDisplay);
            this.flatPanel1.Controls.Add(this.bt_Scan);
            this.flatPanel1.Controls.Add(this.bt_Connect);
            this.flatPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatPanel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatPanel1.Location = new System.Drawing.Point(0, 0);
            this.flatPanel1.Name = "flatPanel1";
            this.flatPanel1.Size = new System.Drawing.Size(1097, 45);
            this.flatPanel1.TabIndex = 0;
            // 
            // bt_ClearDisplay
            // 
            this.bt_ClearDisplay.BackColor = System.Drawing.Color.Transparent;
            this.bt_ClearDisplay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_ClearDisplay.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.bt_ClearDisplay.BorderRadius = 3;
            this.bt_ClearDisplay.BorderThickness = 1;
            this.bt_ClearDisplay.Checked = false;
            this.bt_ClearDisplay.CheckEnable = false;
            this.bt_ClearDisplay.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_ClearDisplay.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_ClearDisplay.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_ClearDisplay.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_ClearDisplay.ControlToBringToFront = null;
            this.bt_ClearDisplay.DebugMode = false;
            this.bt_ClearDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_ClearDisplay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_ClearDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_ClearDisplay.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_ClearDisplay.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_ClearDisplay.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_ClearDisplay.Icon = null;
            this.bt_ClearDisplay.IconPortion = 0.3F;
            this.bt_ClearDisplay.IconSize = 24;
            this.bt_ClearDisplay.IconVisible = false;
            this.bt_ClearDisplay.Image = null;
            this.bt_ClearDisplay.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_ClearDisplay.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_ClearDisplay.IsExclusive = false;
            this.bt_ClearDisplay.Location = new System.Drawing.Point(957, 0);
            this.bt_ClearDisplay.Margin = new System.Windows.Forms.Padding(8);
            this.bt_ClearDisplay.Name = "bt_ClearDisplay";
            this.bt_ClearDisplay.Size = new System.Drawing.Size(140, 45);
            this.bt_ClearDisplay.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_ClearDisplay.TabIndex = 3;
            this.bt_ClearDisplay.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_ClearDisplay.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.bt_ClearDisplay.TagOffset = 5;
            this.bt_ClearDisplay.TagVisible = false;
            this.bt_ClearDisplay.TagWidth = 5;
            this.bt_ClearDisplay.Text = "Clear display";
            this.bt_ClearDisplay.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_ClearDisplay.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ClearDisplay.Click += new System.EventHandler(this.bt_ClearDisplay_Click);
            // 
            // bt_Scan
            // 
            this.bt_Scan.BackColor = System.Drawing.Color.Transparent;
            this.bt_Scan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_Scan.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.bt_Scan.BorderRadius = 3;
            this.bt_Scan.BorderThickness = 1;
            this.bt_Scan.Checked = false;
            this.bt_Scan.CheckEnable = false;
            this.bt_Scan.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Scan.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_Scan.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Scan.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_Scan.ControlToBringToFront = null;
            this.bt_Scan.DebugMode = false;
            this.bt_Scan.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Scan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_Scan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Scan.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Scan.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Scan.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Scan.Icon = null;
            this.bt_Scan.IconPortion = 0.3F;
            this.bt_Scan.IconSize = 24;
            this.bt_Scan.IconVisible = false;
            this.bt_Scan.Image = null;
            this.bt_Scan.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_Scan.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_Scan.IsExclusive = false;
            this.bt_Scan.Location = new System.Drawing.Point(110, 0);
            this.bt_Scan.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Scan.Name = "bt_Scan";
            this.bt_Scan.Size = new System.Drawing.Size(85, 45);
            this.bt_Scan.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_Scan.TabIndex = 1;
            this.bt_Scan.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_Scan.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.bt_Scan.TagOffset = 5;
            this.bt_Scan.TagVisible = false;
            this.bt_Scan.TagWidth = 5;
            this.bt_Scan.Text = "Scan";
            this.bt_Scan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_Scan.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Scan.Click += new System.EventHandler(this.bt_Scan_Click);
            // 
            // bt_Connect
            // 
            this.bt_Connect.BackColor = System.Drawing.Color.Transparent;
            this.bt_Connect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_Connect.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.bt_Connect.BorderRadius = 3;
            this.bt_Connect.BorderThickness = 1;
            this.bt_Connect.Checked = false;
            this.bt_Connect.CheckEnable = false;
            this.bt_Connect.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Connect.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.bt_Connect.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Connect.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_Connect.ControlToBringToFront = null;
            this.bt_Connect.DebugMode = false;
            this.bt_Connect.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Connect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Connect.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Connect.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Connect.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Connect.Icon = null;
            this.bt_Connect.IconPortion = 0.3F;
            this.bt_Connect.IconSize = 24;
            this.bt_Connect.IconVisible = false;
            this.bt_Connect.Image = null;
            this.bt_Connect.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_Connect.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_Connect.IsExclusive = false;
            this.bt_Connect.Location = new System.Drawing.Point(0, 0);
            this.bt_Connect.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(110, 45);
            this.bt_Connect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_Connect.TabIndex = 0;
            this.bt_Connect.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_Connect.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.bt_Connect.TagOffset = 5;
            this.bt_Connect.TagVisible = false;
            this.bt_Connect.TagWidth = 5;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_Connect.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // pcv
            // 
            this.pcv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcv.DrawFPS = false;
            this.pcv.FontDebug = new System.Drawing.Font("Consolas", 12F);
            this.pcv.GLBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.pcv.Location = new System.Drawing.Point(0, 45);
            this.pcv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcv.Name = "pcv";
            this.pcv.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.pcv.RenderContextType = SharpGL.RenderContextType.FBO;
            this.pcv.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.pcv.Size = new System.Drawing.Size(1097, 519);
            this.pcv.TabIndex = 1;
            // 
            // lv
            // 
            this.lv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv.ColorDateTime = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.lv.ColorDebug = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.lv.ColorError = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.lv.ColorFatal = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.lv.ColorInfo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.lv.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lv.ColorSuccess = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lv.ColorTrace = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.lv.ColorWarning = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.lv.DateTimeFormat = LotusAPI.Controls.LogDateTimeFormat.Time;
            this.lv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv.Font = new System.Drawing.Font("Consolas", 9F);
            this.lv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lv.LineBuffer = 1000;
            this.lv.Location = new System.Drawing.Point(0, 564);
            this.lv.Name = "lv";
            this.lv.ReadOnly = true;
            this.lv.ShowDateTime = true;
            this.lv.Size = new System.Drawing.Size(1097, 262);
            this.lv.TabIndex = 2;
            this.lv.Text = "";
            this.lv.UpdateInterval = 100;
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.Transparent;
            this.bt_Save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_Save.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.bt_Save.BorderRadius = 3;
            this.bt_Save.BorderThickness = 1;
            this.bt_Save.Checked = false;
            this.bt_Save.CheckEnable = false;
            this.bt_Save.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Save.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_Save.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Save.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_Save.ControlToBringToFront = null;
            this.bt_Save.DebugMode = false;
            this.bt_Save.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Save.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Save.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Save.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Save.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_Save.Icon = null;
            this.bt_Save.IconPortion = 0.3F;
            this.bt_Save.IconSize = 24;
            this.bt_Save.IconVisible = false;
            this.bt_Save.Image = null;
            this.bt_Save.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_Save.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_Save.IsExclusive = false;
            this.bt_Save.Location = new System.Drawing.Point(195, 0);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(85, 45);
            this.bt_Save.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_Save.TabIndex = 4;
            this.bt_Save.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_Save.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.bt_Save.TagOffset = 5;
            this.bt_Save.TagVisible = false;
            this.bt_Save.TagWidth = 5;
            this.bt_Save.Text = "Save";
            this.bt_Save.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_Save.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // FormScannerTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1097, 826);
            this.Controls.Add(this.pcv);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.flatPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormScannerTest";
            this.Text = "Form1";
            this.flatPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Abeo.Controls.FlatPanel flatPanel1;
        private Abeo.Controls.Roundable.RoundButton bt_Connect;
        private LotusAPI.Controls.PointcloudView pcv;
        private LotusAPI.Controls.LogView lv;
        private Abeo.Controls.Roundable.RoundButton bt_Scan;
        private Abeo.Controls.Roundable.RoundButton bt_ClearDisplay;
        private Abeo.Controls.Roundable.RoundButton bt_Save;
    }
}

