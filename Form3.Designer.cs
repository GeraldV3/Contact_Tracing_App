namespace Contact_Tracing_App
{
    partial class CovidPositive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CovidPositive));
            this.INFO_BOX3 = new System.Windows.Forms.RichTextBox();
            this.DATA_BTN3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // INFO_BOX3
            // 
            this.INFO_BOX3.BackColor = System.Drawing.Color.White;
            this.INFO_BOX3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INFO_BOX3.ForeColor = System.Drawing.Color.Black;
            this.INFO_BOX3.Location = new System.Drawing.Point(38, 79);
            this.INFO_BOX3.Name = "INFO_BOX3";
            this.INFO_BOX3.Size = new System.Drawing.Size(264, 392);
            this.INFO_BOX3.TabIndex = 6;
            this.INFO_BOX3.Text = "";
            // 
            // DATA_BTN3
            // 
            this.DATA_BTN3.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.NewClick;
            this.DATA_BTN3.Location = new System.Drawing.Point(104, 12);
            this.DATA_BTN3.Name = "DATA_BTN3";
            this.DATA_BTN3.Size = new System.Drawing.Size(128, 53);
            this.DATA_BTN3.TabIndex = 5;
            this.DATA_BTN3.UseVisualStyleBackColor = true;
            this.DATA_BTN3.Click += new System.EventHandler(this.DATA_BTN3_Click);
            // 
            // CovidPositive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.ALLDATA1;
            this.ClientSize = new System.Drawing.Size(341, 498);
            this.Controls.Add(this.INFO_BOX3);
            this.Controls.Add(this.DATA_BTN3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CovidPositive";
            this.Text = "CovidPositive";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox INFO_BOX3;
        private Button DATA_BTN3;
    }
}