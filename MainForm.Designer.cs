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
      this.ChooseCompilationPackagePanel = new System.Windows.Forms.Panel();
      this.ChooseCompilationComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.FindWarcraftDirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.PublishTestButton = new System.Windows.Forms.Button();
      this.ChooseCompilationPackagePanel.SuspendLayout();
      this.menuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // TestMapButton
      // 
      this.TestMapButton.Enabled = false;
      this.TestMapButton.Location = new System.Drawing.Point(12, 88);
      this.TestMapButton.Name = "TestMapButton";
      this.TestMapButton.Size = new System.Drawing.Size(110, 34);
      this.TestMapButton.TabIndex = 9;
      this.TestMapButton.Text = "Test map";
      this.TestMapButton.UseVisualStyleBackColor = true;
      this.TestMapButton.Click += new System.EventHandler(this.TestMapButton_Click);
      // 
      // ChooseCompilationPackagePanel
      // 
      this.ChooseCompilationPackagePanel.Controls.Add(this.ChooseCompilationComboBox);
      this.ChooseCompilationPackagePanel.Controls.Add(this.label1);
      this.ChooseCompilationPackagePanel.Location = new System.Drawing.Point(12, 30);
      this.ChooseCompilationPackagePanel.Name = "ChooseCompilationPackagePanel";
      this.ChooseCompilationPackagePanel.Size = new System.Drawing.Size(226, 52);
      this.ChooseCompilationPackagePanel.TabIndex = 13;
      // 
      // ChooseCompilationComboBox
      // 
      this.ChooseCompilationComboBox.Dock = System.Windows.Forms.DockStyle.Top;
      this.ChooseCompilationComboBox.FormattingEnabled = true;
      this.ChooseCompilationComboBox.Location = new System.Drawing.Point(0, 15);
      this.ChooseCompilationComboBox.Name = "ChooseCompilationComboBox";
      this.ChooseCompilationComboBox.Size = new System.Drawing.Size(226, 23);
      this.ChooseCompilationComboBox.TabIndex = 8;
      this.ChooseCompilationComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseCompilationComboBox_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(226, 15);
      this.label1.TabIndex = 12;
      this.label1.Text = "Choose compilation package";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
      this.FindWarcraftDirectoryMenuItem.Size = new System.Drawing.Size(177, 22);
      this.FindWarcraftDirectoryMenuItem.Text = "Set Warcraft III path";
      this.FindWarcraftDirectoryMenuItem.Click += new System.EventHandler(this.FindWarcraftDirectoryMenuItem_Click);
      // 
      // PublishTestButton
      // 
      this.PublishTestButton.Enabled = false;
      this.PublishTestButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PublishTestButton.Location = new System.Drawing.Point(128, 88);
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
      this.ClientSize = new System.Drawing.Size(251, 139);
      this.Controls.Add(this.PublishTestButton);
      this.Controls.Add(this.ChooseCompilationPackagePanel);
      this.Controls.Add(this.TestMapButton);
      this.Controls.Add(this.menuStrip2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip2;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Text = "Azeroth Wars Build Tools";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ChooseCompilationPackagePanel.ResumeLayout(false);
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button TestMapButton;
    private System.Windows.Forms.Panel ChooseCompilationPackagePanel;
    private System.Windows.Forms.ComboBox ChooseCompilationComboBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem FindWarcraftDirectoryMenuItem;
    private System.Windows.Forms.Button PublishTestButton;
  }
}