﻿
namespace Finaaal
{
    partial class trex
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
            this.scoreText = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.rex = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rex)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(0, 3);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(126, 33);
            this.scoreText.TabIndex = 9;
            this.scoreText.Text = "Score: 0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Finaaal.Properties.Resources.obstacle_1;
            this.pictureBox4.Location = new System.Drawing.Point(172, 245);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Finaaal.Properties.Resources.obstacle_2;
            this.pictureBox3.Location = new System.Drawing.Point(332, 258);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
//            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.floor.Location = new System.Drawing.Point(1, 291);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(383, 64);
            this.floor.TabIndex = 5;
            this.floor.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            // 
            // rex
            // 
            this.rex.Image = global::Finaaal.Properties.Resources.running;
            this.rex.Location = new System.Drawing.Point(12, 248);
            this.rex.Name = "rex";
            this.rex.Size = new System.Drawing.Size(40, 43);
            this.rex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rex.TabIndex = 10;
            this.rex.TabStop = false;
            // 
            // trex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 359);
            this.Controls.Add(this.rex);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.floor);
            this.Name = "trex";
            this.Text = "trex";
//            this.Load += new System.EventHandler(this.trex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox rex;
    }
}