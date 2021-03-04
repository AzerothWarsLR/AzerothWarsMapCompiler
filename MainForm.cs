using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        ImportObjectsButton.Enabled = value;
        TestMapButton.Enabled = value;
        PublishMapButton.Enabled = value;
      } 
    }

    private MapCompiler _mapCompiler;

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
      
    }

    private void ImportObjectsButton_Click(object sender, EventArgs e)
    {

    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void ChooseCompilationComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      ButtonsEnabled = ChooseCompilationComboBox.SelectedItem != null;
    }
  }
}
