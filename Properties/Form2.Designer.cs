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
            this.ClickHere_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickHere_BTN
            // 
            this.ClickHere_BTN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClickHere_BTN.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.CLICK_HERE1;
            this.ClickHere_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClickHere_BTN.Location = new System.Drawing.Point(351, 234);
            this.ClickHere_BTN.Name = "ClickHere_BTN";
            this.ClickHere_BTN.Size = new System.Drawing.Size(378, 140);
            this.ClickHere_BTN.TabIndex = 1;
            this.ClickHere_BTN.UseVisualStyleBackColor = false;
            this.ClickHere_BTN.Click += new System.EventHandler(this.ClickHere_BTN_Click);
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.ADMIN_Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClickHere_BTN);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ClickHere_BTN;
    }
}