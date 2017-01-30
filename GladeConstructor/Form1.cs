using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

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
                GladeFileNameTextbox.Text = FileName;
                gladeParser = new GtkParser(FileName);
                GUIManage();
                GtkWindowGroupBox.Enabled = true;
                ObjectsGroupBox.Enabled = true;
            }
            //BindingObject obj = new BindingObject("id", "type", "nic", false);
            //bindingSource1.Add(obj);
            //ObjectsDataGrid.DataSource = ;

        }

        private void GUIManage()
        {
            // Fill the listbox with the GtkWindows
            GtkWindowListBox.DataSource = gladeParser.GtkWindowsId;
            //bindingSource1.
        }

        private void GtkWindowListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
            ClassNameTextBox.Text = (string) GtkWindowListBox.SelectedItem;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ONLY FOR DEBUG
            gladeParser = new GtkParser(@"C:\Users\Buzz\workspace\ChessWorkspace\Chess\Debug\Glade\glade.glade");
            GUIManage();
            GtkWindowGroupBox.Enabled = true;
            ObjectsGroupBox.Enabled = true;
            GtkWindowListBox.SelectedIndex = 2;
        
        }

        private void UpdateGrid()
        {
            if (HideNonIdObjectCheckBox.Checked)
            {
                ObjectsDataGrid.DataSource = gladeParser.ObjectBindingSourcesWithoutEmptyId[GtkWindowListBox.SelectedIndex];
            }
            else
            {
                ObjectsDataGrid.DataSource = gladeParser.ObjectBindingSources[GtkWindowListBox.SelectedIndex];
            }
        }

        private void ClassFileDirectoryChooseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserClass.ShowDialog() == DialogResult.OK)
            {
                string Path = folderBrowserClass.SelectedPath;
                DirectoryClassFilesTextBox.Text = Path;
            }
        }

        private void CreateClassFilesButton_Click(object sender, EventArgs e)
        {
            int bindingSrcId = GtkWindowListBox.SelectedIndex;
            string classname = ClassNameTextBox.Text;
            string path = DirectoryClassFilesTextBox.Text;
            CreateClassFiles createclassfiles = new CreateClassFiles(classname, path, gladeParser, bindingSrcId);
            createclassfiles.WriteClassFiles();
        }
    }
}
