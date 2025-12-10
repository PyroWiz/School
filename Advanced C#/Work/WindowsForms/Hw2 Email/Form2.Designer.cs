namespace Hw2_Email
{
    partial class Form2
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
            this.Continue = new System.Windows.Forms.Label();
            this.FromBox = new System.Windows.Forms.TextBox();
            this.ToBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Continue
            // 
            this.Continue.AutoSize = true;
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(315, 62);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(175, 29);
            this.Continue.TabIndex = 0;
            this.Continue.Text = "Continue Here";
            // 
            // FromBox
            // 
            this.FromBox.Location = new System.Drawing.Point(268, 133);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(280, 22);
            this.FromBox.TabIndex = 2;
            this.FromBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ToBox
            // 
            this.ToBox.Location = new System.Drawing.Point(268, 174);
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(280, 22);
            this.ToBox.TabIndex = 3;
            this.ToBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(602, 257);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(113, 42);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(186, 138);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(38, 16);
            this.FromLabel.TabIndex = 5;
            this.FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(186, 180);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(24, 16);
            this.ToLabel.TabIndex = 6;
            this.ToLabel.Text = "To";
            this.ToLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(268, 219);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(280, 22);
            this.PassBox.TabIndex = 8;
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(189, 224);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(38, 16);
            this.Pass.TabIndex = 9;
            this.Pass.Text = "Pass";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.ToBox);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.Continue);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Continue;
        private System.Windows.Forms.TextBox FromBox;
        private System.Windows.Forms.TextBox ToBox;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label Pass;
    }
}