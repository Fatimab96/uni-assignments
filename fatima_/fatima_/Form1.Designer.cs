namespace fatima_
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
            this.btnevenodd = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnevenodd
            // 
            this.btnevenodd.Location = new System.Drawing.Point(313, 83);
            this.btnevenodd.Name = "btnevenodd";
            this.btnevenodd.Size = new System.Drawing.Size(75, 23);
            this.btnevenodd.TabIndex = 0;
            this.btnevenodd.Text = "evenodd";
            this.btnevenodd.UseVisualStyleBackColor = true;
            this.btnevenodd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(134, 83);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnevenodd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnevenodd;
        private System.Windows.Forms.TextBox txtnum;
    }
}

