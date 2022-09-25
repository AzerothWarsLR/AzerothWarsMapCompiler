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
            this.PublishTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestMapButton
            // 
            this.TestMapButton.Location = new System.Drawing.Point(12, 12);
            this.TestMapButton.Name = "TestMapButton";
            this.TestMapButton.Size = new System.Drawing.Size(110, 34);
            this.TestMapButton.TabIndex = 9;
            this.TestMapButton.Text = "Test map";
            this.TestMapButton.UseVisualStyleBackColor = true;
            this.TestMapButton.Click += new System.EventHandler(this.TestMapButton_Click);
            // 
            // PublishTestButton
            // 
            this.PublishTestButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublishTestButton.Location = new System.Drawing.Point(128, 12);
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
            this.ClientSize = new System.Drawing.Size(251, 55);
            this.Controls.Add(this.PublishTestButton);
            this.Controls.Add(this.TestMapButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Azeroth Wars Build Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button TestMapButton;
    private System.Windows.Forms.Button PublishTestButton;
  }
}