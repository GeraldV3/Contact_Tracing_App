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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_Generator));
            this.Generate_BTN = new System.Windows.Forms.PictureBox();
            this.QR_PIC = new System.Windows.Forms.PictureBox();
            this.QRcode_Txt = new System.Windows.Forms.RichTextBox();
            this.GenerateBTN = new System.Windows.Forms.PictureBox();
            this.QRPIC = new System.Windows.Forms.PictureBox();
            this.QR_TXT = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Generate_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QR_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRPIC)).BeginInit();
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
            // QRcode_Txt
            // 
            this.QRcode_Txt.Location = new System.Drawing.Point(0, 0);
            this.QRcode_Txt.Name = "QRcode_Txt";
            this.QRcode_Txt.Size = new System.Drawing.Size(100, 96);
            this.QRcode_Txt.TabIndex = 0;
            this.QRcode_Txt.Text = "";
            // 
            // GenerateBTN
            // 
            this.GenerateBTN.Image = global::Contact_Tracing_App.Properties.Resources.Generate;
            this.GenerateBTN.Location = new System.Drawing.Point(346, 669);
            this.GenerateBTN.Name = "GenerateBTN";
            this.GenerateBTN.Size = new System.Drawing.Size(162, 44);
            this.GenerateBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GenerateBTN.TabIndex = 0;
            this.GenerateBTN.TabStop = false;
            this.GenerateBTN.Click += new System.EventHandler(this.GenerateBTN_Click);
            // 
            // QRPIC
            // 
            this.QRPIC.BackColor = System.Drawing.Color.Transparent;
            this.QRPIC.Location = new System.Drawing.Point(51, 162);
            this.QRPIC.Name = "QRPIC";
            this.QRPIC.Size = new System.Drawing.Size(430, 332);
            this.QRPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRPIC.TabIndex = 1;
            this.QRPIC.TabStop = false;
            // 
            // QR_TXT
            // 
            this.QR_TXT.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.QR_TXT.Location = new System.Drawing.Point(51, 572);
            this.QR_TXT.Name = "QR_TXT";
            this.QR_TXT.Size = new System.Drawing.Size(440, 66);
            this.QR_TXT.TabIndex = 2;
            this.QR_TXT.Text = "";
            // 
            // QR_Generator
            // 
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.QRGeneratorBG10;
            this.ClientSize = new System.Drawing.Size(520, 725);
            this.Controls.Add(this.QR_TXT);
            this.Controls.Add(this.QRPIC);
            this.Controls.Add(this.GenerateBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QR_Generator";
            ((System.ComponentModel.ISupportInitialize)(this.Generate_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QR_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRPIC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Generate_BTN;
        private PictureBox QR_PIC;
        private RichTextBox QRcode_Txt;
        private PictureBox GenerateBTN;
        private PictureBox QRPIC;
        private RichTextBox QR_TXT;
    }
}