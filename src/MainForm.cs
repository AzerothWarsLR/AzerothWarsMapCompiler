using System;
using System.Security;
using System.Windows.Forms;
using AzerothWarsMapCompiler.Properties;

namespace AzerothWarsMapCompiler;

public partial class MainForm : Form
{
  private readonly PublishSettings _publishSettings;
  private readonly MapCompiler _mapCompiler;

  public MainForm(PublishSettings publishSettings, MapCompiler mapCompiler)
  {
    _publishSettings = publishSettings;
    _mapCompiler = mapCompiler;
    InitializeComponent();
  }

  private void TestMapButton_Click(object sender, EventArgs e)
  {
    _mapCompiler.CompileMap(_publishSettings, true);
  }

  private void PublishTestMapButton_Click(object sender, EventArgs e)
  {
    _mapCompiler.CompileMap(_publishSettings, true, true);
  }

  private void MainForm_Load(object sender, EventArgs e)
  {
  }

  private void FindWarcraftDirectoryMenuItem_Click(object sender, EventArgs e)
  {
    var openFileDialog = new OpenFileDialog
    {
      Filter = @"executables (*.exe)|*.exe"
    };
    if (openFileDialog.ShowDialog() != DialogResult.OK) return;
    try
    {
      Settings.Default.Warcraft3FilePath = openFileDialog.FileName;
    }
    catch (SecurityException ex)
    {
      MessageBox.Show($@"Security error.

Error message: {ex.Message}

Details:

{ex.StackTrace}");
    }
  }
}