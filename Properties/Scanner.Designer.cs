namespace Contact_Tracing_App.Properties
{
    partial class Scanner_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scanner_Form));
            this.Start_BTN = new System.Windows.Forms.Button();
            this.Camera_Device = new System.Windows.Forms.ComboBox();
            this.Webcam_PIC = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Reader_BTN = new System.Windows.Forms.Button();
            this.Info_BOX = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Webcam_PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_BTN
            // 
            this.Start_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Start_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_BTN.ForeColor = System.Drawing.Color.Transparent;
            this.Start_BTN.Image = global::Contact_Tracing_App.Properties.Resources.Start;
            this.Start_BTN.Location = new System.Drawing.Point(14, 616);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(194, 53);
            this.Start_BTN.TabIndex = 0;
            this.Start_BTN.UseVisualStyleBackColor = false;
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // Camera_Device
            // 
            this.Camera_Device.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Camera_Device.FormattingEnabled = true;
            this.Camera_Device.Location = new System.Drawing.Point(180, 118);
            this.Camera_Device.Name = "Camera_Device";
            this.Camera_Device.Size = new System.Drawing.Size(253, 23);
            this.Camera_Device.TabIndex = 2;
            // 
            // Webcam_PIC
            // 
            this.Webcam_PIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Webcam_PIC.Location = new System.Drawing.Point(38, 197);
            this.Webcam_PIC.Name = "Webcam_PIC";
            this.Webcam_PIC.Size = new System.Drawing.Size(382, 257);
            this.Webcam_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Webcam_PIC.TabIndex = 3;
            this.Webcam_PIC.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Reader_BTN
            // 
            this.Reader_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Reader_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reader_BTN.ForeColor = System.Drawing.Color.Transparent;
            this.Reader_BTN.Image = global::Contact_Tracing_App.Properties.Resources.Read;
            this.Reader_BTN.Location = new System.Drawing.Point(255, 616);
            this.Reader_BTN.Name = "Reader_BTN";
            this.Reader_BTN.Size = new System.Drawing.Size(184, 53);
            this.Reader_BTN.TabIndex = 5;
            this.Reader_BTN.UseVisualStyleBackColor = false;
            this.Reader_BTN.Click += new System.EventHandler(this.Reader_BTN_Click);
            // 
            // Info_BOX
            // 
            this.Info_BOX.Location = new System.Drawing.Point(44, 541);
            this.Info_BOX.Name = "Info_BOX";
            this.Info_BOX.Size = new System.Drawing.Size(395, 48);
            this.Info_BOX.TabIndex = 6;
            this.Info_BOX.Text = "";
            // 
            // Scanner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.Scan1;
            this.ClientSize = new System.Drawing.Size(465, 674);
            this.Controls.Add(this.Info_BOX);
            this.Controls.Add(this.Reader_BTN);
            this.Controls.Add(this.Webcam_PIC);
            this.Controls.Add(this.Camera_Device);
            this.Controls.Add(this.Start_BTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scanner_Form";
            this.Text = "QR SCANNER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scanner_Form_FormClosing);
            this.Load += new System.EventHandler(this.Scanner_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Webcam_PIC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Start_BTN;
        private ComboBox Camera_Device;
        private PictureBox Webcam_PIC;
        private System.Windows.Forms.Timer Timer;
        private Button Reader_BTN;
        private RichTextBox Info_BOX;
    }
}