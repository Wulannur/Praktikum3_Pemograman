﻿using System;

namespace P4_3_1204007
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelHuruf = new System.Windows.Forms.Label();
            this.labelAngka = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAngka1 = new System.Windows.Forms.Label();
            this.labelAngka2 = new System.Windows.Forms.Label();
            this.tbHuruf = new System.Windows.Forms.TextBox();
            this.tbAngka = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAngka1 = new System.Windows.Forms.TextBox();
            this.tbAngka2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(24, 44);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(93, 13);
            this.labelHuruf.TabIndex = 0;
            this.labelHuruf.Text = "Huruf                   :";
            this.labelHuruf.Leave += new System.EventHandler(this.label1_Leave);
            // 
            // labelAngka
            // 
            this.labelAngka.AutoSize = true;
            this.labelAngka.Location = new System.Drawing.Point(24, 69);
            this.labelAngka.Name = "labelAngka";
            this.labelAngka.Size = new System.Drawing.Size(92, 13);
            this.labelAngka.TabIndex = 1;
            this.labelAngka.Text = "Angka                 :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(24, 97);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(92, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email                   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Angka 1> Angka 2";
            // 
            // labelAngka1
            // 
            this.labelAngka1.AutoSize = true;
            this.labelAngka1.Location = new System.Drawing.Point(24, 169);
            this.labelAngka1.Name = "labelAngka1";
            this.labelAngka1.Size = new System.Drawing.Size(89, 13);
            this.labelAngka1.TabIndex = 4;
            this.labelAngka1.Text = "Angka 1             :";
            // 
            // labelAngka2
            // 
            this.labelAngka2.AutoSize = true;
            this.labelAngka2.Location = new System.Drawing.Point(24, 197);
            this.labelAngka2.Name = "labelAngka2";
            this.labelAngka2.Size = new System.Drawing.Size(89, 13);
            this.labelAngka2.TabIndex = 5;
            this.labelAngka2.Text = "Angka 2             :";
            // 
            // tbHuruf
            // 
            this.tbHuruf.Location = new System.Drawing.Point(147, 41);
            this.tbHuruf.Name = "tbHuruf";
            this.tbHuruf.Size = new System.Drawing.Size(100, 20);
            this.tbHuruf.TabIndex = 6;
            // 
            // tbAngka
            // 
            this.tbAngka.Location = new System.Drawing.Point(147, 66);
            this.tbAngka.Name = "tbAngka";
            this.tbAngka.Size = new System.Drawing.Size(100, 20);
            this.tbAngka.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(147, 90);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 8;
            // 
            // tbAngka1
            // 
            this.tbAngka1.Location = new System.Drawing.Point(147, 166);
            this.tbAngka1.Name = "tbAngka1";
            this.tbAngka1.Size = new System.Drawing.Size(100, 20);
            this.tbAngka1.TabIndex = 10;
            // 
            // tbAngka2
            // 
            this.tbAngka2.Location = new System.Drawing.Point(147, 190);
            this.tbAngka2.Name = "tbAngka2";
            this.tbAngka2.Size = new System.Drawing.Size(100, 20);
            this.tbAngka2.TabIndex = 11;
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbAngka2);
            this.Controls.Add(this.tbAngka1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAngka);
            this.Controls.Add(this.tbHuruf);
            this.Controls.Add(this.labelAngka2);
            this.Controls.Add(this.labelAngka1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAngka);
            this.Controls.Add(this.labelHuruf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Leave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.Label labelAngka;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAngka1;
        private System.Windows.Forms.Label labelAngka2;
        private System.Windows.Forms.TextBox tbHuruf;
        private System.Windows.Forms.TextBox tbAngka;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAngka1;
        private System.Windows.Forms.TextBox tbAngka2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

