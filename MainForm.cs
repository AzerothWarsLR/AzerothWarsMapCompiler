using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace AzerothWarsMapCompiler
{
  public partial class MainForm : Form
  {
    private MapCompilationPackage SelectedPackage
    {
      get
      {
        return ChooseCompilationComboBox.SelectedItem as MapCompilationPackage;
      }
    }

    private bool ButtonsEnabled {
      set {
        ExportObjectsButton.Enabled = value;
        TestMapButton.Enabled = value;
        PublishMapButton.Enabled = value;
        PublishTestButton.Enabled = value;
      } 
    }

    private readonly MapCompiler _mapCompiler;

    public MainForm(MapCompilationPackage[] mapCompilationPackages, MapCompiler mapCompiler)
    {
      _mapCompiler = mapCompiler;
      InitializeComponent();
      ChooseCompilationComboBox.DisplayMember = "PackageName";
      ChooseCompilationComboBox.Items.AddRange(mapCompilationPackages);
    }

    private void TestMapButton_Click(object sender, EventArgs e)
    {
      ButtonsEnabled = false;
      _mapCompiler.CompileMap(SelectedPackage, true, false);
      ButtonsEnabled = true;
    }

    private void PublishMapButton_Click(object sender, EventArgs e)
    {
      ButtonsEnabled = false;
      _mapCompiler.CompileMap(SelectedPackage, false, true);
      ButtonsEnabled = true;
    }

    private void ExportObjectsButton_Click(object sender, EventArgs e)
    {
      ButtonsEnabled = false;
      _mapCompiler.ExportObjects(SelectedPackage);
      ButtonsEnabled = true;
    }

    private void ImportObjectsButton_Click(object sender, EventArgs e)
    {
      ButtonsEnabled = false;
      _mapCompiler.ImportObjects(SelectedPackage);
      ButtonsEnabled = true;
    }

    private void PublishTestMapButton_Click(object sender, EventArgs e)
    {
      ButtonsEnabled = false;
      _mapCompiler.CompileMap(SelectedPackage, true, true);
      ButtonsEnabled = true;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void ChooseCompilationComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      ButtonsEnabled = ChooseCompilationComboBox.SelectedItem != null;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void FindWarcraftDirectoryMenuItem_Click(object sender, EventArgs e)
    {
      var openFileDialog = new OpenFileDialog
      {
        Filter = "executables (*.exe)|*.exe"
      };
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          Properties.Settings.Default.Warcraft3FilePath = openFileDialog.FileName;
        }
        catch (SecurityException ex)
        {
          MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
          $"Details:\n\n{ex.StackTrace}");
        }
      }
    }
  }
}
