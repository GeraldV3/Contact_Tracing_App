namespace Contact_Tracing_App
{
    partial class Resgistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resgistration));
            this.Resgister_BTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Resgister_BTN)).BeginInit();
            this.SuspendLayout();
            // 
            // Resgister_BTN
            // 
            this.Resgister_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Resgister_BTN.Image = global::Contact_Tracing_App.Properties.Resources.Click;
            this.Resgister_BTN.Location = new System.Drawing.Point(50, 226);
            this.Resgister_BTN.Name = "Resgister_BTN";
            this.Resgister_BTN.Size = new System.Drawing.Size(300, 80);
            this.Resgister_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resgister_BTN.TabIndex = 0;
            this.Resgister_BTN.TabStop = false;
            this.Resgister_BTN.Click += new System.EventHandler(this.Resgister_BTN_Click_1);
            // 
            // Resgistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(404, 511);
            this.Controls.Add(this.Resgister_BTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resgistration";
            this.Text = "Resgistration";
            ((System.ComponentModel.ISupportInitialize)(this.Resgister_BTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Resgister_BTN;
    }
}