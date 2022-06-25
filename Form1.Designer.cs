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
            this.AccesstoMain_BTN = new System.Windows.Forms.Button();
            this.Username_TxtBOX = new System.Windows.Forms.TextBox();
            this.Password_TxtBOX = new System.Windows.Forms.TextBox();
            this.Login_BOX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Resgister_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // Resgister_BTN
            // 
            this.Resgister_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Resgister_BTN.Image = global::Contact_Tracing_App.Properties.Resources.Click;
            this.Resgister_BTN.Location = new System.Drawing.Point(51, 208);
            this.Resgister_BTN.Name = "Resgister_BTN";
            this.Resgister_BTN.Size = new System.Drawing.Size(300, 80);
            this.Resgister_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resgister_BTN.TabIndex = 0;
            this.Resgister_BTN.TabStop = false;
            this.Resgister_BTN.Click += new System.EventHandler(this.Resgister_BTN_Click_1);
            // 
            // AccesstoMain_BTN
            // 
            this.AccesstoMain_BTN.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.ADMIN;
            this.AccesstoMain_BTN.Location = new System.Drawing.Point(123, 473);
            this.AccesstoMain_BTN.Name = "AccesstoMain_BTN";
            this.AccesstoMain_BTN.Size = new System.Drawing.Size(132, 38);
            this.AccesstoMain_BTN.TabIndex = 1;
            this.AccesstoMain_BTN.UseVisualStyleBackColor = true;
            this.AccesstoMain_BTN.Click += new System.EventHandler(this.AccesstoMain_BTN_Click);
            // 
            // Username_TxtBOX
            // 
            this.Username_TxtBOX.BackColor = System.Drawing.Color.White;
            this.Username_TxtBOX.Location = new System.Drawing.Point(119, 398);
            this.Username_TxtBOX.Name = "Username_TxtBOX";
            this.Username_TxtBOX.Size = new System.Drawing.Size(145, 23);
            this.Username_TxtBOX.TabIndex = 2;
            this.Username_TxtBOX.Text = "Username";
            this.Username_TxtBOX.Enter += new System.EventHandler(this.Username_TxtBOX_Enter);
            this.Username_TxtBOX.Leave += new System.EventHandler(this.Username_TxtBOX_Leave);
            // 
            // Password_TxtBOX
            // 
            this.Password_TxtBOX.BackColor = System.Drawing.Color.White;
            this.Password_TxtBOX.Location = new System.Drawing.Point(119, 440);
            this.Password_TxtBOX.Name = "Password_TxtBOX";
            this.Password_TxtBOX.Size = new System.Drawing.Size(145, 23);
            this.Password_TxtBOX.TabIndex = 3;
            this.Password_TxtBOX.Text = "Password";
            this.Password_TxtBOX.Enter += new System.EventHandler(this.Password_TxtBOX_Enter);
            this.Password_TxtBOX.Leave += new System.EventHandler(this.Password_TxtBOX_Leave);
            // 
            // Login_BOX
            // 
            this.Login_BOX.Image = global::Contact_Tracing_App.Properties.Resources.Login;
            this.Login_BOX.Location = new System.Drawing.Point(151, 344);
            this.Login_BOX.Name = "Login_BOX";
            this.Login_BOX.Size = new System.Drawing.Size(88, 42);
            this.Login_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login_BOX.TabIndex = 4;
            this.Login_BOX.TabStop = false;
            // 
            // Resgistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(404, 511);
            this.Controls.Add(this.Login_BOX);
            this.Controls.Add(this.Password_TxtBOX);
            this.Controls.Add(this.Username_TxtBOX);
            this.Controls.Add(this.AccesstoMain_BTN);
            this.Controls.Add(this.Resgister_BTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resgistration";
            this.Text = "Resgistration";
            ((System.ComponentModel.ISupportInitialize)(this.Resgister_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Resgister_BTN;
        private Button AccesstoMain_BTN;
        private TextBox Username_TxtBOX;
        private TextBox Password_TxtBOX;
        private PictureBox Login_BOX;
    }
}