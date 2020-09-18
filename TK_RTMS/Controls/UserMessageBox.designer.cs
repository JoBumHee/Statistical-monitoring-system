﻿namespace TK_RTMS.Controls
{
    partial class UserMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMessageBox));
            this.uiLab_Msg = new System.Windows.Forms.Label();
            this.uiBtn_Ok = new System.Windows.Forms.Button();
            this.uiBtn_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiLab_Msg
            // 
            this.uiLab_Msg.AutoSize = true;
            this.uiLab_Msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLab_Msg.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Msg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.uiLab_Msg.Location = new System.Drawing.Point(12, 9);
            this.uiLab_Msg.Name = "uiLab_Msg";
            this.uiLab_Msg.Size = new System.Drawing.Size(126, 15);
            this.uiLab_Msg.TabIndex = 0;
            this.uiLab_Msg.Text = "Complete Save Excel";
            // 
            // uiBtn_Ok
            // 
            this.uiBtn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtn_Ok.ForeColor = System.Drawing.Color.Blue;
            this.uiBtn_Ok.Location = new System.Drawing.Point(12, 33);
            this.uiBtn_Ok.Name = "uiBtn_Ok";
            this.uiBtn_Ok.Size = new System.Drawing.Size(75, 32);
            this.uiBtn_Ok.TabIndex = 1;
            this.uiBtn_Ok.Text = "Confirm";
            this.uiBtn_Ok.UseVisualStyleBackColor = true;
            // 
            // uiBtn_Open
            // 
            this.uiBtn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtn_Open.ForeColor = System.Drawing.Color.Green;
            this.uiBtn_Open.Location = new System.Drawing.Point(93, 33);
            this.uiBtn_Open.Name = "uiBtn_Open";
            this.uiBtn_Open.Size = new System.Drawing.Size(75, 32);
            this.uiBtn_Open.TabIndex = 1;
            this.uiBtn_Open.Text = "File Open";
            this.uiBtn_Open.UseVisualStyleBackColor = true;
            // 
            // UserMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 68);
            this.Controls.Add(this.uiBtn_Open);
            this.Controls.Add(this.uiBtn_Ok);
            this.Controls.Add(this.uiLab_Msg);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMessageBox";
            this.Text = "Inform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiLab_Msg;
        private System.Windows.Forms.Button uiBtn_Ok;
        private System.Windows.Forms.Button uiBtn_Open;
    }
}