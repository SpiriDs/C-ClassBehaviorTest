namespace Elephants
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
            this.ButtonLloyd = new System.Windows.Forms.Button();
            this.ButtonLucinda = new System.Windows.Forms.Button();
            this.ButtonSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLloyd
            // 
            this.ButtonLloyd.Location = new System.Drawing.Point(153, 51);
            this.ButtonLloyd.Name = "ButtonLloyd";
            this.ButtonLloyd.Size = new System.Drawing.Size(75, 23);
            this.ButtonLloyd.TabIndex = 0;
            this.ButtonLloyd.Text = "Lloyd";
            this.ButtonLloyd.UseVisualStyleBackColor = true;
            this.ButtonLloyd.Click += new System.EventHandler(this.ButtonLloyd_Click);
            // 
            // ButtonLucinda
            // 
            this.ButtonLucinda.Location = new System.Drawing.Point(153, 113);
            this.ButtonLucinda.Name = "ButtonLucinda";
            this.ButtonLucinda.Size = new System.Drawing.Size(75, 23);
            this.ButtonLucinda.TabIndex = 1;
            this.ButtonLucinda.Text = "Lucinda";
            this.ButtonLucinda.UseVisualStyleBackColor = true;
            this.ButtonLucinda.Click += new System.EventHandler(this.ButtonLucinda_Click);
            // 
            // ButtonSwap
            // 
            this.ButtonSwap.Location = new System.Drawing.Point(153, 176);
            this.ButtonSwap.Name = "ButtonSwap";
            this.ButtonSwap.Size = new System.Drawing.Size(75, 23);
            this.ButtonSwap.TabIndex = 2;
            this.ButtonSwap.Text = "Swap!";
            this.ButtonSwap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 300);
            this.Controls.Add(this.ButtonSwap);
            this.Controls.Add(this.ButtonLucinda);
            this.Controls.Add(this.ButtonLloyd);
            this.Name = "Form1";
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLloyd;
        private System.Windows.Forms.Button ButtonLucinda;
        private System.Windows.Forms.Button ButtonSwap;
    }
}

