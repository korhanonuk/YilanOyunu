﻿namespace Snake
{
    partial class EasyForm
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
            this.pbGameArea = new System.Windows.Forms.PictureBox();
            this.lblScore = new DevExpress.XtraEditors.LabelControl();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGameArea
            // 
            this.pbGameArea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbGameArea.Location = new System.Drawing.Point(12, 12);
            this.pbGameArea.Name = "pbGameArea";
            this.pbGameArea.Size = new System.Drawing.Size(400, 400);
            this.pbGameArea.TabIndex = 0;
            this.pbGameArea.TabStop = false;
            this.pbGameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameArea_Paint);
            // 
            // lblScore
            // 
            this.lblScore.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblScore.Location = new System.Drawing.Point(418, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(82, 19);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Skorunuz:";
            // 
            // lblGameOver
            // 
            this.lblGameOver.Location = new System.Drawing.Point(418, 95);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(63, 13);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "labelControl1";
            this.lblGameOver.Visible = false;
            // 
            // EasyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 482);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGameArea);
            this.Name = "EasyForm";
            this.Text = "Zorluk Seviyesi = Kolay";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EasyForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EasyForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameArea;
        private DevExpress.XtraEditors.LabelControl lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private DevExpress.XtraEditors.LabelControl lblGameOver;
    }
}