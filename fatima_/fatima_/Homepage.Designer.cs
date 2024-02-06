namespace fatima_
{
    partial class Homepage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gcdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenoddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perimeterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.eXITToolStripMenuItem,
            this.shapesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gcdToolStripMenuItem,
            this.fiboToolStripMenuItem,
            this.evenoddToolStripMenuItem,
            this.lCMToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "program";
            // 
            // gcdToolStripMenuItem
            // 
            this.gcdToolStripMenuItem.Name = "gcdToolStripMenuItem";
            this.gcdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gcdToolStripMenuItem.Text = "gcd";
            this.gcdToolStripMenuItem.Click += new System.EventHandler(this.gcdToolStripMenuItem_Click);
            // 
            // fiboToolStripMenuItem
            // 
            this.fiboToolStripMenuItem.Name = "fiboToolStripMenuItem";
            this.fiboToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fiboToolStripMenuItem.Text = "Fibo";
            // 
            // evenoddToolStripMenuItem
            // 
            this.evenoddToolStripMenuItem.Name = "evenoddToolStripMenuItem";
            this.evenoddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.evenoddToolStripMenuItem.Text = "evenodd";
            // 
            // lCMToolStripMenuItem
            // 
            this.lCMToolStripMenuItem.Name = "lCMToolStripMenuItem";
            this.lCMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lCMToolStripMenuItem.Text = "LCM";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaToolStripMenuItem,
            this.perimeterToolStripMenuItem});
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.shapesToolStripMenuItem.Text = "Shapes ";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // perimeterToolStripMenuItem
            // 
            this.perimeterToolStripMenuItem.Name = "perimeterToolStripMenuItem";
            this.perimeterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perimeterToolStripMenuItem.Text = "Perimeter";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gcdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenoddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perimeterToolStripMenuItem;
    }
}