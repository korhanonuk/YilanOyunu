namespace Snake
{
    partial class frmStartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartMenu));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.WM = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WM)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(196, 297);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(227, 73);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Oyunu Başlat";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEasy.Location = new System.Drawing.Point(277, 157);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(65, 24);
            this.rbEasy.TabIndex = 1;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Kolay";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMedium.Location = new System.Drawing.Point(265, 196);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(89, 24);
            this.rbMedium.TabIndex = 4;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Standart";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbHard.Location = new System.Drawing.Point(284, 235);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(51, 24);
            this.rbHard.TabIndex = 5;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Zor";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // pbGame
            // 
            this.pbGame.Image = global::Snake.Properties.Resources.txNajMo;
            this.pbGame.Location = new System.Drawing.Point(87, 30);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(445, 106);
            this.pbGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGame.TabIndex = 7;
            this.pbGame.TabStop = false;
            // 
            // WM
            // 
            this.WM.Enabled = true;
            this.WM.Location = new System.Drawing.Point(37, 422);
            this.WM.Name = "WM";
            this.WM.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WM.OcxState")));
            this.WM.Size = new System.Drawing.Size(75, 23);
            this.WM.TabIndex = 8;
            this.WM.Visible = false;
            // 
            // frmStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 457);
            this.Controls.Add(this.WM);
            this.Controls.Add(this.pbGame);
            this.Controls.Add(this.rbHard);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbEasy);
            this.Controls.Add(this.simpleButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStartMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStartMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.PictureBox pbGame;
        private AxWMPLib.AxWindowsMediaPlayer WM;
    }
}

