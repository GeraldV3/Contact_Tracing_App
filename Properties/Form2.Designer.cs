namespace Contact_Tracing_App.Properties
{
    partial class ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN));
            this.DATE_VIEW = new System.Windows.Forms.DateTimePicker();
            this.ShowAll_PBOX = new System.Windows.Forms.PictureBox();
            this.FilterRecord_PBOX = new System.Windows.Forms.PictureBox();
            this.Covid19_BOX = new System.Windows.Forms.PictureBox();
            this.COVID_BOX = new System.Windows.Forms.TextBox();
            this.YesNo_LBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowAll_PBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterRecord_PBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // DATE_VIEW
            // 
            this.DATE_VIEW.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DATE_VIEW.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DATE_VIEW.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_VIEW.Location = new System.Drawing.Point(443, 211);
            this.DATE_VIEW.Name = "DATE_VIEW";
            this.DATE_VIEW.Size = new System.Drawing.Size(148, 35);
            this.DATE_VIEW.TabIndex = 2;
            // 
            // ShowAll_PBOX
            // 
            this.ShowAll_PBOX.Image = global::Contact_Tracing_App.Properties.Resources.CLICK_HERE3;
            this.ShowAll_PBOX.Location = new System.Drawing.Point(401, 100);
            this.ShowAll_PBOX.Name = "ShowAll_PBOX";
            this.ShowAll_PBOX.Size = new System.Drawing.Size(241, 59);
            this.ShowAll_PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowAll_PBOX.TabIndex = 4;
            this.ShowAll_PBOX.TabStop = false;
            this.ShowAll_PBOX.Click += new System.EventHandler(this.ShowAll_PBOX_Click);
            // 
            // FilterRecord_PBOX
            // 
            this.FilterRecord_PBOX.Image = global::Contact_Tracing_App.Properties.Resources.CLICK_HERE3;
            this.FilterRecord_PBOX.Location = new System.Drawing.Point(401, 252);
            this.FilterRecord_PBOX.Name = "FilterRecord_PBOX";
            this.FilterRecord_PBOX.Size = new System.Drawing.Size(241, 59);
            this.FilterRecord_PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FilterRecord_PBOX.TabIndex = 5;
            this.FilterRecord_PBOX.TabStop = false;
            this.FilterRecord_PBOX.Click += new System.EventHandler(this.FilterRecord_PBOX_Click);
            // 
            // Covid19_BOX
            // 
            this.Covid19_BOX.Image = global::Contact_Tracing_App.Properties.Resources.CLICK_HERE3;
            this.Covid19_BOX.Location = new System.Drawing.Point(401, 414);
            this.Covid19_BOX.Name = "Covid19_BOX";
            this.Covid19_BOX.Size = new System.Drawing.Size(241, 59);
            this.Covid19_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Covid19_BOX.TabIndex = 6;
            this.Covid19_BOX.TabStop = false;
            this.Covid19_BOX.Click += new System.EventHandler(this.Covid19_BOX_Click);
            // 
            // COVID_BOX
            // 
            this.COVID_BOX.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.COVID_BOX.Location = new System.Drawing.Point(401, 379);
            this.COVID_BOX.Name = "COVID_BOX";
            this.COVID_BOX.Size = new System.Drawing.Size(241, 30);
            this.COVID_BOX.TabIndex = 67;
            this.COVID_BOX.Click += new System.EventHandler(this.COVID_BOX_Click);
            this.COVID_BOX.Enter += new System.EventHandler(this.COVID_BOX_Enter);
            this.COVID_BOX.Leave += new System.EventHandler(this.COVID_BOX_Leave);
            // 
            // YesNo_LBL
            // 
            this.YesNo_LBL.AutoSize = true;
            this.YesNo_LBL.BackColor = System.Drawing.Color.AliceBlue;
            this.YesNo_LBL.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YesNo_LBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YesNo_LBL.Location = new System.Drawing.Point(402, 382);
            this.YesNo_LBL.Name = "YesNo_LBL";
            this.YesNo_LBL.Size = new System.Drawing.Size(153, 22);
            this.YesNo_LBL.TabIndex = 68;
            this.YesNo_LBL.Text = "Positive/Negative";
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.ADMIN_Background7;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.YesNo_LBL);
            this.Controls.Add(this.COVID_BOX);
            this.Controls.Add(this.Covid19_BOX);
            this.Controls.Add(this.FilterRecord_PBOX);
            this.Controls.Add(this.ShowAll_PBOX);
            this.Controls.Add(this.DATE_VIEW);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            ((System.ComponentModel.ISupportInitialize)(this.ShowAll_PBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterRecord_PBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker DATE_VIEW;
        private PictureBox ShowAll_PBOX;
        private PictureBox FilterRecord_PBOX;
        private PictureBox Covid19_BOX;
        private TextBox COVID_BOX;
        private Label YesNo_LBL;
    }
}