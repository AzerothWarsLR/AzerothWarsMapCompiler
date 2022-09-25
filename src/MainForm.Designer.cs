namespace AzerothWarsMapCompiler
{
  partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TestMapButton = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindWarcraftDirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PublishTestButton = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestMapButton
            // 
            this.TestMapButton.Location = new System.Drawing.Point(12, 39);
            this.TestMapButton.Name = "TestMapButton";
            this.TestMapButton.Size = new System.Drawing.Size(110, 34);
            this.TestMapButton.TabIndex = 9;
            this.TestMapButton.Text = "Test map";
            this.TestMapButton.UseVisualStyleBackColor = true;
            this.TestMapButton.Click += new System.EventHandler(this.TestMapButton_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(251, 24);
            this.menuStrip2.TabIndex = 14;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindWarcraftDirectoryMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // FindWarcraftDirectoryMenuItem
            // 
            this.FindWarcraftDirectoryMenuItem.Name = "FindWarcraftDirectoryMenuItem";
            this.FindWarcraftDirectoryMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FindWarcraftDirectoryMenuItem.Text = "Set Warcraft III path";
            this.FindWarcraftDirectoryMenuItem.Click += new System.EventHandler(this.FindWarcraftDirectoryMenuItem_Click);
            // 
            // PublishTestButton
            // 
            this.PublishTestButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublishTestButton.Location = new System.Drawing.Point(128, 39);
            this.PublishTestButton.Name = "PublishTestButton";
            this.PublishTestButton.Size = new System.Drawing.Size(110, 34);
            this.PublishTestButton.TabIndex = 9;
            this.PublishTestButton.Text = "Publish and Test Map";
            this.PublishTestButton.UseVisualStyleBackColor = true;
            this.PublishTestButton.Click += new System.EventHandler(this.PublishTestMapButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 86);
            this.Controls.Add(this.PublishTestButton);
            this.Controls.Add(this.TestMapButton);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Azeroth Wars Build Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button TestMapButton;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem FindWarcraftDirectoryMenuItem;
    private System.Windows.Forms.Button PublishTestButton;
  }
}