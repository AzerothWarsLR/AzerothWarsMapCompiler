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
      this.ChooseCompilationPackagePanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // TestMapButton
      // 
      this.TestMapButton.Enabled = false;
      this.TestMapButton.Location = new System.Drawing.Point(12, 88);
      this.TestMapButton.Name = "TestMapButton";
      this.TestMapButton.Size = new System.Drawing.Size(96, 23);
      this.TestMapButton.TabIndex = 9;
      this.TestMapButton.Text = "Test map";
      this.TestMapButton.UseVisualStyleBackColor = true;
      this.TestMapButton.Click += new System.EventHandler(this.TestMapButton_Click);
      // 
      // PublishMapButton
      // 
      this.PublishMapButton.Enabled = false;
      this.PublishMapButton.Location = new System.Drawing.Point(114, 88);
      this.PublishMapButton.Name = "PublishMapButton";
      this.PublishMapButton.Size = new System.Drawing.Size(96, 23);
      this.PublishMapButton.TabIndex = 10;
      this.PublishMapButton.Text = "Publish map";
      this.PublishMapButton.UseVisualStyleBackColor = true;
      this.PublishMapButton.Click += new System.EventHandler(this.PublishMapButton_Click);
      // 
      // ImportObjectsButton
      // 
      this.ImportObjectsButton.Enabled = false;
      this.ImportObjectsButton.Location = new System.Drawing.Point(12, 117);
      this.ImportObjectsButton.Name = "ImportObjectsButton";
      this.ImportObjectsButton.Size = new System.Drawing.Size(96, 23);
      this.ImportObjectsButton.TabIndex = 11;
      this.ImportObjectsButton.Text = "Import objects";
      this.ImportObjectsButton.UseVisualStyleBackColor = true;
      this.ImportObjectsButton.Click += new System.EventHandler(this.ImportObjectsButton_Click);
      // 
      // ExportObjectsButton
      // 
      this.ExportObjectsButton.Enabled = false;
      this.ExportObjectsButton.Location = new System.Drawing.Point(114, 117);
      this.ExportObjectsButton.Name = "ExportObjectsButton";
      this.ExportObjectsButton.Size = new System.Drawing.Size(96, 23);
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
      this.ChooseCompilationPackagePanel.Size = new System.Drawing.Size(198, 52);
      this.ChooseCompilationPackagePanel.TabIndex = 13;
      // 
      // ChooseCompilationComboBox
      // 
      this.ChooseCompilationComboBox.Dock = System.Windows.Forms.DockStyle.Top;
      this.ChooseCompilationComboBox.FormattingEnabled = true;
      this.ChooseCompilationComboBox.Location = new System.Drawing.Point(0, 15);
      this.ChooseCompilationComboBox.Name = "ChooseCompilationComboBox";
      this.ChooseCompilationComboBox.Size = new System.Drawing.Size(198, 23);
      this.ChooseCompilationComboBox.TabIndex = 8;
      this.ChooseCompilationComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseCompilationComboBox_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(198, 15);
      this.label1.TabIndex = 12;
      this.label1.Text = "Choose compilation package";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(223, 164);
      this.Controls.Add(this.ChooseCompilationPackagePanel);
      this.Controls.Add(this.ExportObjectsButton);
      this.Controls.Add(this.ImportObjectsButton);
      this.Controls.Add(this.PublishMapButton);
      this.Controls.Add(this.TestMapButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Text = "Azeroth Wars Build Tools";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ChooseCompilationPackagePanel.ResumeLayout(false);
      this.ResumeLayout(false);

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
  }
}