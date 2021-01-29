﻿namespace FaceDetectionAnRecognition
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.StartDetectionAndRecognition = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(12, 12);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(443, 315);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            // 
            // StartDetectionAndRecognition
            // 
            this.StartDetectionAndRecognition.Location = new System.Drawing.Point(506, 32);
            this.StartDetectionAndRecognition.Name = "StartDetectionAndRecognition";
            this.StartDetectionAndRecognition.Size = new System.Drawing.Size(109, 35);
            this.StartDetectionAndRecognition.TabIndex = 3;
            this.StartDetectionAndRecognition.Text = "Start Detection And Recognition";
            this.StartDetectionAndRecognition.UseVisualStyleBackColor = true;
            this.StartDetectionAndRecognition.Click += new System.EventHandler(this.StartDetectionAndRecognition_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(506, 212);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 44);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Face";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(515, 116);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.StartDetectionAndRecognition);
            this.Controls.Add(this.cameraBox);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button StartDetectionAndRecognition;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
    }
}

