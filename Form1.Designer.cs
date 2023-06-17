namespace EquationSolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.gauss = new System.Windows.Forms.Button();
            this.jordan = new System.Windows.Forms.Button();
            this.thomas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.gauss);
            this.panelMenu.Controls.Add(this.jordan);
            this.panelMenu.Controls.Add(this.thomas);
            this.panelMenu.Location = new System.Drawing.Point(24, 325);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1008, 178);
            this.panelMenu.TabIndex = 20;
            // 
            // gauss
            // 
            this.gauss.Location = new System.Drawing.Point(3, 2);
            this.gauss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gauss.Name = "gauss";
            this.gauss.Size = new System.Drawing.Size(988, 41);
            this.gauss.TabIndex = 1;
            this.gauss.Text = "gauss";
            this.gauss.UseVisualStyleBackColor = true;
            this.gauss.Click += new System.EventHandler(this.gauss_Click);
            // 
            // jordan
            // 
            this.jordan.Location = new System.Drawing.Point(3, 47);
            this.jordan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jordan.Name = "jordan";
            this.jordan.Size = new System.Drawing.Size(988, 46);
            this.jordan.TabIndex = 2;
            this.jordan.Text = "jordan";
            this.jordan.UseVisualStyleBackColor = true;
            this.jordan.Click += new System.EventHandler(this.jordan_Click);
            // 
            // thomas
            // 
            this.thomas.Location = new System.Drawing.Point(3, 97);
            this.thomas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thomas.Name = "thomas";
            this.thomas.Size = new System.Drawing.Size(988, 46);
            this.thomas.TabIndex = 3;
            this.thomas.Text = "thomas";
            this.thomas.UseVisualStyleBackColor = true;
            this.thomas.Click += new System.EventHandler(this.thomas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Location = new System.Drawing.Point(12, 11);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(397, 210);
            this.panelLogo.TabIndex = 19;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.textBox1);
            this.panelTitle.Location = new System.Drawing.Point(412, 11);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(592, 210);
            this.panelTitle.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 22);
            this.textBox1.TabIndex = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 543);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Button gauss;
        private System.Windows.Forms.Button jordan;
        private System.Windows.Forms.Button thomas;
        private System.Windows.Forms.FlowLayoutPanel panelLogo;
        private System.Windows.Forms.FlowLayoutPanel panelTitle;
        private System.Windows.Forms.TextBox textBox1;
    }
}

