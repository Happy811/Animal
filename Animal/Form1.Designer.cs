﻿namespace Animal
{
    partial class Form1
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
            this.DogPicture = new System.Windows.Forms.PictureBox();
            this.TurtlePicture = new System.Windows.Forms.PictureBox();
            this.RabbitPicture = new System.Windows.Forms.PictureBox();
            this.CatPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurtlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RabbitPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DogPicture
            // 
            this.DogPicture.Image = global::Animal.Resource1.Dog;
            this.DogPicture.Location = new System.Drawing.Point(12, 12);
            this.DogPicture.Name = "DogPicture";
            this.DogPicture.Size = new System.Drawing.Size(100, 50);
            this.DogPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogPicture.TabIndex = 0;
            this.DogPicture.TabStop = false;
            // 
            // TurtlePicture
            // 
            this.TurtlePicture.Image = global::Animal.Resource1.Turtle;
            this.TurtlePicture.Location = new System.Drawing.Point(12, 236);
            this.TurtlePicture.Name = "TurtlePicture";
            this.TurtlePicture.Size = new System.Drawing.Size(100, 50);
            this.TurtlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TurtlePicture.TabIndex = 1;
            this.TurtlePicture.TabStop = false;
            // 
            // RabbitPicture
            // 
            this.RabbitPicture.Image = global::Animal.Resource1.Rabbit;
            this.RabbitPicture.Location = new System.Drawing.Point(12, 159);
            this.RabbitPicture.Name = "RabbitPicture";
            this.RabbitPicture.Size = new System.Drawing.Size(100, 50);
            this.RabbitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RabbitPicture.TabIndex = 2;
            this.RabbitPicture.TabStop = false;
            // 
            // CatPicture
            // 
            this.CatPicture.Image = global::Animal.Resource1.Cat;
            this.CatPicture.Location = new System.Drawing.Point(12, 82);
            this.CatPicture.Name = "CatPicture";
            this.CatPicture.Size = new System.Drawing.Size(100, 50);
            this.CatPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CatPicture.TabIndex = 3;
            this.CatPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CatPicture);
            this.Controls.Add(this.RabbitPicture);
            this.Controls.Add(this.TurtlePicture);
            this.Controls.Add(this.DogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurtlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RabbitPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DogPicture;
        private System.Windows.Forms.PictureBox TurtlePicture;
        private System.Windows.Forms.PictureBox RabbitPicture;
        private System.Windows.Forms.PictureBox CatPicture;
        private System.Windows.Forms.Button button1;
    }
}

