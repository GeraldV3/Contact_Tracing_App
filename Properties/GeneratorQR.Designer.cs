namespace Contact_Tracing_App.Properties
{
    partial class QR_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_Generator));
            this.Generate_BTN = new System.Windows.Forms.PictureBox();
            this.QR_PIC = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.QRcode_Txt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Generate_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QR_PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // Generate_BTN
            // 
            this.Generate_BTN.Image = global::Contact_Tracing_App.Properties.Resources.Generate;
            this.Generate_BTN.Location = new System.Drawing.Point(323, 662);
            this.Generate_BTN.Name = "Generate_BTN";
            this.Generate_BTN.Size = new System.Drawing.Size(169, 39);
            this.Generate_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Generate_BTN.TabIndex = 0;
            this.Generate_BTN.TabStop = false;
            this.Generate_BTN.Click += new System.EventHandler(this.Generate_BTN_Click);
            // 
            // QR_PIC
            // 
            this.QR_PIC.BackColor = System.Drawing.Color.Transparent;
            this.QR_PIC.Location = new System.Drawing.Point(65, 169);
            this.QR_PIC.Name = "QR_PIC";
            this.QR_PIC.Size = new System.Drawing.Size(396, 319);
            this.QR_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QR_PIC.TabIndex = 1;
            this.QR_PIC.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // QRcode_Txt
            // 
            this.QRcode_Txt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.QRcode_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QRcode_Txt.ForeColor = System.Drawing.Color.Black;
            this.QRcode_Txt.Location = new System.Drawing.Point(53, 574);
            this.QRcode_Txt.Name = "QRcode_Txt";
            this.QRcode_Txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.QRcode_Txt.Size = new System.Drawing.Size(439, 63);
            this.QRcode_Txt.TabIndex = 5;
            this.QRcode_Txt.Text = "";
            // 
            // QR_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.QRGeneratorBG7;
            this.ClientSize = new System.Drawing.Size(520, 713);
            this.Controls.Add(this.QRcode_Txt);
            this.Controls.Add(this.QR_PIC);
            this.Controls.Add(this.Generate_BTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QR_Generator";
            this.Text = "QRCODE";
            ((System.ComponentModel.ISupportInitialize)(this.Generate_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QR_PIC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Generate_BTN;
        private PictureBox QR_PIC;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox QRcode_Txt;
    }
}