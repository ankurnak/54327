﻿namespace EquationSolver
{
    partial class FormJordan
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
            this.text = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jordan = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(448, 152);
            this.text.Margin = new System.Windows.Forms.Padding(4);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(231, 28);
            this.text.TabIndex = 189;
            this.text.Text = "text";
            this.text.UseVisualStyleBackColor = true;
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(2, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 69);
            this.panel2.TabIndex = 188;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 69);
            this.panel1.TabIndex = 187;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(586, 281);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(93, 30);
            this.cancel.TabIndex = 186;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 185;
            this.label5.Text = "result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 184;
            this.label4.Text = "d";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 183;
            this.label3.Text = "c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 182;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 181;
            this.label1.Text = "a";
            // 
            // jordan
            // 
            this.jordan.Location = new System.Drawing.Point(448, 281);
            this.jordan.Margin = new System.Windows.Forms.Padding(4);
            this.jordan.Name = "jordan";
            this.jordan.Size = new System.Drawing.Size(100, 28);
            this.jordan.TabIndex = 180;
            this.jordan.Text = "jordan";
            this.jordan.UseVisualStyleBackColor = true;
            this.jordan.Click += new System.EventHandler(this.jordan_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(534, 218);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(132, 22);
            this.resultTextBox.TabIndex = 179;
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(216, 305);
            this.dTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(132, 22);
            this.dTextBox.TabIndex = 178;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(216, 255);
            this.cTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(132, 22);
            this.cTextBox.TabIndex = 177;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(216, 190);
            this.bTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(132, 22);
            this.bTextBox.TabIndex = 176;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(216, 132);
            this.aTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(132, 22);
            this.aTextBox.TabIndex = 175;
            // 
            // FormJordan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jordan);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.dTextBox);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Name = "FormJordan";
            this.Text = "FormJordan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button jordan;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox aTextBox;
    }
}