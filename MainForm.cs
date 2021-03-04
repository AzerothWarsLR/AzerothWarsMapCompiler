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

    private JassHelper JassHelperWrapper { get; }

    public MainForm(MapCompilationPackage[] mapCompilationPackages, JassHelper jassHelperWrapper)
    {
      JassHelperWrapper = jassHelperWrapper;
      InitializeComponent();
      ChooseCompilationComboBox.DisplayMember = "Name";
      ChooseCompilationComboBox.Items.AddRange(mapCompilationPackages);
    }

    private void TestMapButton_Click(object sender, EventArgs e)
    {
      ButtonsEnabled = false;
      SelectedPackage.Compile(JassHelperWrapper, @"E:\Users\Zak\Documents\YakaryBovineMaps\AzerothWarsLR\buildTools\temp\" + "TestMapTest.w3x", true);
      ButtonsEnabled = true;
    }

    private void PublishMapButton_Click(object sender, EventArgs e)
    {
      ButtonsEnabled = false;
      SelectedPackage.Compile(JassHelperWrapper, @"E:\Users\Zak\Documents\YakaryBovineMaps\AzerothWarsLR\buildTools\temp\" + "PublishMapTest.w3x", true);
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
