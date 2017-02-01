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
using GladeConstructor.GladeParser;

namespace GladeConstructor
{

    public partial class MainForm : Form
    {
        GtkParser gladeParser;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gladeFileOpen.ShowDialog() == DialogResult.OK)
            {
                string FileName = gladeFileOpen.FileName;
                gladeParser = new GtkParser(FileName);   
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
                string FileName = gladeFileOpen.FileName;
                gladeParser = new GtkParser(FileName);
                GuiManager.Parser = gladeParser;
                GuiManager.dockPanel = this.dockPanel1;
                var WidgetForm = GuiManager.CreateWindowPanel(gladeParser.FormBindingSources);
                WidgetForm.Show(dockPanel1, DockState.Document);
            }
        }


    }
}
