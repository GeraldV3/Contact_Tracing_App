﻿namespace Contact_Tracing_App.Properties
{
    partial class FilterDateInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterDateInfo));
            this.DATA_BTN = new System.Windows.Forms.Button();
            this.INFO_BOX2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DATA_BTN
            // 
            this.DATA_BTN.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.NewClick;
            this.DATA_BTN.Location = new System.Drawing.Point(107, 12);
            this.DATA_BTN.Name = "DATA_BTN";
            this.DATA_BTN.Size = new System.Drawing.Size(128, 53);
            this.DATA_BTN.TabIndex = 2;
            this.DATA_BTN.UseVisualStyleBackColor = true;
            this.DATA_BTN.Click += new System.EventHandler(this.DATA_BTN_Click);
            // 
            // INFO_BOX2
            // 
            this.INFO_BOX2.Location = new System.Drawing.Point(39, 80);
            this.INFO_BOX2.Name = "INFO_BOX2";
            this.INFO_BOX2.Size = new System.Drawing.Size(264, 392);
            this.INFO_BOX2.TabIndex = 3;
            this.INFO_BOX2.Text = "";
            // 
            // FilterDateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.ALLDATA1;
            this.ClientSize = new System.Drawing.Size(341, 498);
            this.Controls.Add(this.INFO_BOX2);
            this.Controls.Add(this.DATA_BTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilterDateInfo";
            this.Text = "Information";
            this.ResumeLayout(false);

        }

        #endregion

        private Button DATA_BTN;
        private RichTextBox INFO_BOX2;
    }
}