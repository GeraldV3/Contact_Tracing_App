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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Diagnosed_BOX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowAll_PBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterRecord_PBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Contact_Tracing_App.Properties.Resources.CLICK_HERE3;
            this.pictureBox1.Location = new System.Drawing.Point(401, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Diagnosed_BOX
            // 
            this.Diagnosed_BOX.Location = new System.Drawing.Point(443, 385);
            this.Diagnosed_BOX.Name = "Diagnosed_BOX";
            this.Diagnosed_BOX.Size = new System.Drawing.Size(148, 23);
            this.Diagnosed_BOX.TabIndex = 7;
            this.Diagnosed_BOX.Enter += new System.EventHandler(this.Diagnosed_BOX_Enter);
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.ADMIN_Background7;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.Diagnosed_BOX);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FilterRecord_PBOX);
            this.Controls.Add(this.ShowAll_PBOX);
            this.Controls.Add(this.DATE_VIEW);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            ((System.ComponentModel.ISupportInitialize)(this.ShowAll_PBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterRecord_PBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker DATE_VIEW;
        private PictureBox ShowAll_PBOX;
        private PictureBox FilterRecord_PBOX;
        private PictureBox pictureBox1;
        private TextBox Diagnosed_BOX;
    }
}