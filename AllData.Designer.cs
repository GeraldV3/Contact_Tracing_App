﻿namespace Contact_Tracing_App
{
    partial class AllData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllData));
            this.INFO_BOX = new System.Windows.Forms.RichTextBox();
            this.DATA_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // INFO_BOX
            // 
            this.INFO_BOX.Location = new System.Drawing.Point(38, 78);
            this.INFO_BOX.Name = "INFO_BOX";
            this.INFO_BOX.Size = new System.Drawing.Size(264, 393);
            this.INFO_BOX.TabIndex = 0;
            this.INFO_BOX.Text = "";
            // 
            // DATA_BTN
            // 
            this.DATA_BTN.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.NewClick;
            this.DATA_BTN.Location = new System.Drawing.Point(107, 9);
            this.DATA_BTN.Name = "DATA_BTN";
            this.DATA_BTN.Size = new System.Drawing.Size(128, 53);
            this.DATA_BTN.TabIndex = 1;
            this.DATA_BTN.UseVisualStyleBackColor = true;
            this.DATA_BTN.Click += new System.EventHandler(this.DATA_BTN_Click);
            // 
            // AllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.ALLDATA1;
            this.ClientSize = new System.Drawing.Size(326, 527);
            this.Controls.Add(this.DATA_BTN);
            this.Controls.Add(this.INFO_BOX);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllData";
            this.Text = "AllData";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox INFO_BOX;
        private Button DATA_BTN;
    }
}