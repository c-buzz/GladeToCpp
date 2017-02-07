using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Xml;
using System.IO;
using GladeConstructor.Parser;
using GladeConstructor.CodeBuild;

namespace GladeConstructor
{

    public partial class MainForm : Form
    {
        GladeParser gladeParser;

        public MainForm()
        {
            InitializeComponent();
            Storage.LoadConfigurationDocument();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gladeFileOpen.ShowDialog() == DialogResult.OK)
            {
                string FileName = gladeFileOpen.FileName;
                gladeParser = new GladeParser(FileName);   
            }

        }
        
        private void ClassFileDirectoryChooseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserClass.ShowDialog() == DialogResult.OK)
            {
                string Path = folderBrowserClass.SelectedPath;
            }
        }

        private void openToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (gladeFileOpen.ShowDialog() == DialogResult.OK)
            {
                OpenGladeFile(gladeFileOpen.FileName);
            }
        }

        private void BuildCodeButton_Click(object sender, EventArgs e)
        {
            BuildCode Code = new BuildCode();
            Code.Process();
        }

        private void OpenGladeFile(string FileName)
        {
            gladeParser = new GladeParser(FileName);
            Storage.Parser = gladeParser;
            GuiManager.dockPanel = MainDockPanel;
            var WidgetForm = GuiManager.CreateWindowPanel(Storage.Parser.FormBindingSources, FileName);
            WidgetForm.Show(MainDockPanel, DockState.Document);
        }
    }
}
