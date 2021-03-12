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
      this.PublishMapButton = new System.Windows.Forms.Button();
      this.ImportObjectsButton = new System.Windows.Forms.Button();
      this.ExportObjectsButton = new System.Windows.Forms.Button();
      this.ChooseCompilationPackagePanel = new System.Windows.Forms.Panel();
      this.ChooseCompilationComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.FindWarcraftDirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
      // PublishMapButton
      // 
      this.PublishMapButton.Enabled = false;
      this.PublishMapButton.Location = new System.Drawing.Point(128, 88);
      this.PublishMapButton.Name = "PublishMapButton";
      this.PublishMapButton.Size = new System.Drawing.Size(110, 34);
      this.PublishMapButton.TabIndex = 10;
      this.PublishMapButton.Text = "Publish map";
      this.PublishMapButton.UseVisualStyleBackColor = true;
      this.PublishMapButton.Click += new System.EventHandler(this.PublishMapButton_Click);
      // 
      // ImportObjectsButton
      // 
      this.ImportObjectsButton.Enabled = false;
      this.ImportObjectsButton.Location = new System.Drawing.Point(12, 168);
      this.ImportObjectsButton.Name = "ImportObjectsButton";
      this.ImportObjectsButton.Size = new System.Drawing.Size(110, 34);
      this.ImportObjectsButton.TabIndex = 11;
      this.ImportObjectsButton.Text = "Import objects";
      this.ImportObjectsButton.UseVisualStyleBackColor = true;
      this.ImportObjectsButton.Click += new System.EventHandler(this.ImportObjectsButton_Click);
      // 
      // ExportObjectsButton
      // 
      this.ExportObjectsButton.Enabled = false;
      this.ExportObjectsButton.Location = new System.Drawing.Point(128, 168);
      this.ExportObjectsButton.Name = "ExportObjectsButton";
      this.ExportObjectsButton.Size = new System.Drawing.Size(110, 34);
      this.ExportObjectsButton.TabIndex = 11;
      this.ExportObjectsButton.Text = "Export objects";
      this.ExportObjectsButton.UseVisualStyleBackColor = true;
      this.ExportObjectsButton.Click += new System.EventHandler(this.ExportObjectsButton_Click);
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
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip2.Location = new System.Drawing.Point(0, 0);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(251, 24);
      this.menuStrip2.TabIndex = 14;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindWarcraftDirectoryMenuItem,
            this.exitToolStripMenuItem});
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
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      // 
      // PublishTestButton
      // 
      this.PublishTestButton.Enabled = false;
      this.PublishTestButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PublishTestButton.Location = new System.Drawing.Point(128, 128);
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
      this.ClientSize = new System.Drawing.Size(251, 215);
      this.Controls.Add(this.PublishTestButton);
      this.Controls.Add(this.ChooseCompilationPackagePanel);
      this.Controls.Add(this.ExportObjectsButton);
      this.Controls.Add(this.ImportObjectsButton);
      this.Controls.Add(this.PublishMapButton);
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
    private System.Windows.Forms.Button PublishMapButton;
    private System.Windows.Forms.Button ExportObjectsButtons;
    private System.Windows.Forms.Button ImportObjectsButton;
    private System.Windows.Forms.Panel ChooseCompilationPackagePanel;
    private System.Windows.Forms.ComboBox ChooseCompilationComboBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button ExportObjectsButton;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem FindWarcraftDirectoryMenuItem;
    private System.Windows.Forms.Button PublishTestButton;
  }
}