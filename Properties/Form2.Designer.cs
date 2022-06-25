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
            this.DATE = new System.Windows.Forms.DateTimePicker();
            this.ShowAll_PBOX = new System.Windows.Forms.PictureBox();
            this.FilterRecord_PBOX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowAll_PBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterRecord_PBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // DATE
            // 
            this.DATE.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE.Location = new System.Drawing.Point(543, 325);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(80, 23);
            this.DATE.TabIndex = 2;
            // 
            // ShowAll_PBOX
            // 
            this.ShowAll_PBOX.Image = global::Contact_Tracing_App.Properties.Resources.CLICK_HERE1;
            this.ShowAll_PBOX.Location = new System.Drawing.Point(418, 143);
            this.ShowAll_PBOX.Name = "ShowAll_PBOX";
            this.ShowAll_PBOX.Size = new System.Drawing.Size(322, 96);
            this.ShowAll_PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowAll_PBOX.TabIndex = 4;
            this.ShowAll_PBOX.TabStop = false;
            this.ShowAll_PBOX.Click += new System.EventHandler(this.ShowAll_PBOX_Click);
            // 
            // FilterRecord_PBOX
            // 
            this.FilterRecord_PBOX.Image = global::Contact_Tracing_App.Properties.Resources.CLICK_HERE1;
            this.FilterRecord_PBOX.Location = new System.Drawing.Point(463, 364);
            this.FilterRecord_PBOX.Name = "FilterRecord_PBOX";
            this.FilterRecord_PBOX.Size = new System.Drawing.Size(229, 64);
            this.FilterRecord_PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FilterRecord_PBOX.TabIndex = 5;
            this.FilterRecord_PBOX.TabStop = false;
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.ADMIN_Background1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilterRecord_PBOX);
            this.Controls.Add(this.ShowAll_PBOX);
            this.Controls.Add(this.DATE);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            ((System.ComponentModel.ISupportInitialize)(this.ShowAll_PBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterRecord_PBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DateTimePicker DATE;
        private PictureBox ShowAll_PBOX;
        private PictureBox FilterRecord_PBOX;
    }
}