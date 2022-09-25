using System;
using System.Windows.Forms;
using AzerothWarsMapCompiler.Settings;

namespace AzerothWarsMapCompiler;

public partial class MainForm : Form
{
  private readonly PublishSettings _publishSettings;
  private readonly PathSettings _pathSettings;
  private readonly MapCompiler _mapCompiler;

  public MainForm(PublishSettings publishSettings, PathSettings pathSettings, MapCompiler mapCompiler)
  {
    _publishSettings = publishSettings;
    _pathSettings = pathSettings;
    _mapCompiler = mapCompiler;
    InitializeComponent();
  }

  private void TestMapButton_Click(object sender, EventArgs e)
  {
    _mapCompiler.CompileMap(_pathSettings, _publishSettings, true);
  }

  private void PublishTestMapButton_Click(object sender, EventArgs e)
  {
    _mapCompiler.CompileMap(_pathSettings, _publishSettings, true, true);
  }

  private void MainForm_Load(object sender, EventArgs e)
  {
  }
}