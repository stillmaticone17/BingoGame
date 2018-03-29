using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Power_Bingo
{
    partial class main
    {
        /// Required designer variable.
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcomeToBingo = new System.Windows.Forms.Label();
            this.lblEnterYourName = new System.Windows.Forms.Label();
            this.txtEnterYourName = new System.Windows.Forms.TextBox();
            this.lblReadyToPlay = new System.Windows.Forms.Label();
            this.btnReadyToPlayYes = new System.Windows.Forms.Button();
            this.btnReadyToPlayNo = new System.Windows.Forms.Button();
            this.lblInstructionsText = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtCalledNumber = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.pnlBingo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblWelcomeToBingo
            // 
            this.lblWelcomeToBingo.AutoSize = true;
            this.lblWelcomeToBingo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeToBingo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWelcomeToBingo.Location = new System.Drawing.Point(26, 18);
            this.lblWelcomeToBingo.Name = "lblWelcomeToBingo";
            this.lblWelcomeToBingo.Size = new System.Drawing.Size(221, 26);
            this.lblWelcomeToBingo.TabIndex = 0;
            this.lblWelcomeToBingo.Text = "Welcome to BINGO!";
            // 
            // lblEnterYourName
            // 
            this.lblEnterYourName.AutoSize = true;
            this.lblEnterYourName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterYourName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnterYourName.Location = new System.Drawing.Point(282, 27);
            this.lblEnterYourName.Name = "lblEnterYourName";
            this.lblEnterYourName.Size = new System.Drawing.Size(114, 17);
            this.lblEnterYourName.TabIndex = 2;
            this.lblEnterYourName.Text = "Enter Your Name:";
            // 
            // txtEnterYourName
            // 
            this.txtEnterYourName.AcceptsTab = true;
            this.txtEnterYourName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterYourName.Location = new System.Drawing.Point(402, 26);
            this.txtEnterYourName.Name = "txtEnterYourName";
            this.txtEnterYourName.Size = new System.Drawing.Size(100, 24);
            this.txtEnterYourName.TabIndex = 0;
            // 
            // lblReadyToPlay
            // 
            this.lblReadyToPlay.AutoSize = true;
            this.lblReadyToPlay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyToPlay.ForeColor = System.Drawing.Color.Lime;
            this.lblReadyToPlay.Location = new System.Drawing.Point(34, 80);
            this.lblReadyToPlay.Name = "lblReadyToPlay";
            this.lblReadyToPlay.Size = new System.Drawing.Size(178, 20);
            this.lblReadyToPlay.TabIndex = 4;
            this.lblReadyToPlay.Text = "Ready to Play BINGO?";
            // 
            // btnReadyToPlayYes
            // 
            this.btnReadyToPlayYes.BackColor = SystemColors.ActiveCaptionText;
            this.btnReadyToPlayYes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadyToPlayYes.ForeColor = Color.Lime;
            this.btnReadyToPlayYes.Location = new Point(241, 77);
            this.btnReadyToPlayYes.Name = "btnReadyToPlayYes";
            this.btnReadyToPlayYes.Size = new Size(75, 32);
            this.btnReadyToPlayYes.TabIndex = 5;
            this.btnReadyToPlayYes.Text = "Yes :)";
            this.btnReadyToPlayYes.UseVisualStyleBackColor = false;
            this.btnReadyToPlayYes.Click += new System.EventHandler(this.btnReadyToPlayYes_Click);
            // 
            // btnReadyToPlayNo
            // 
            this.btnReadyToPlayNo.BackColor = SystemColors.ActiveCaptionText;
            this.btnReadyToPlayNo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.btnReadyToPlayNo.ForeColor = Color.Red;
            this.btnReadyToPlayNo.Location = new Point(386, 77);
            this.btnReadyToPlayNo.Name = "btnReadyToPlayNo";
            this.btnReadyToPlayNo.Size = new Size(75, 32);
            this.btnReadyToPlayNo.TabIndex = 6;
            this.btnReadyToPlayNo.Text = "No :(";
            this.btnReadyToPlayNo.UseVisualStyleBackColor = false;
            this.btnReadyToPlayNo.Click += new EventHandler(this.btnReadyToPlayNo_Click);
            // 
            // lblInstructionsText
            // 
            this.lblInstructionsText.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionsText.ForeColor = SystemColors.ControlLightLight;
            this.lblInstructionsText.Location = new Point(47, 162);
            this.lblInstructionsText.Name = "lblInstructionsText";
            this.lblInstructionsText.Size = new Size(407, 98);
            this.lblInstructionsText.TabIndex = 7;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = SystemColors.Control;
            this.lblInstructions.Location = new Point(26, 132);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new Size(104, 20);
            this.lblInstructions.TabIndex = 8;
            this.lblInstructions.Text = "Instructions:";
            // 
            // txtCalledNumber
            // 
            this.txtCalledNumber.Font = new Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalledNumber.Location = new Point(703, 257);
            this.txtCalledNumber.Name = "txtCalledNumber";
            this.txtCalledNumber.ReadOnly = true;
            this.txtCalledNumber.Size = new Size(83, 53);
            this.txtCalledNumber.TabIndex = 9;
            this.txtCalledNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDontHave
            // 
            this.btnDontHave.BackColor = SystemColors.ActiveCaptionText;
            this.btnDontHave.Font = new Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDontHave.ForeColor = Color.Red;
            this.btnDontHave.Location = new Point(689, 316);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new Size(117, 39);
            this.btnDontHave.TabIndex = 10;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = false;
            this.btnDontHave.Click += new EventHandler(this.btnDontHave_Click_1);
            // 
            // pnlBingo
            // 
            this.pnlBingo.Location = new System.Drawing.Point(30, 204);
            this.pnlBingo.Name = "pnlBingo";
            this.pnlBingo.Size = new System.Drawing.Size(599, 533);
            this.pnlBingo.TabIndex = 11;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(895, 874);
            this.Controls.Add(this.pnlBingo);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtCalledNumber);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblInstructionsText);
            this.Controls.Add(this.btnReadyToPlayNo);
            this.Controls.Add(this.btnReadyToPlayYes);
            this.Controls.Add(this.lblReadyToPlay);
            this.Controls.Add(this.txtEnterYourName);
            this.Controls.Add(this.lblEnterYourName);
            this.Controls.Add(this.lblWelcomeToBingo);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "main";
            this.Text = "BINGO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeToBingo;
        private System.Windows.Forms.Label lblEnterYourName;
        private System.Windows.Forms.TextBox txtEnterYourName;
        private System.Windows.Forms.Label lblReadyToPlay;
        private System.Windows.Forms.Button btnReadyToPlayYes;
        private System.Windows.Forms.Button btnReadyToPlayNo;
        private System.Windows.Forms.Label lblInstructionsText;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtCalledNumber;
        private System.Windows.Forms.Button btnDontHave;
        private Panel pnlBingo;
    }
}

