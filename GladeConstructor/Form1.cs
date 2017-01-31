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
                GUIManage();
                
            }
            //BindingObject obj = new BindingObject("id", "type", "nic", false);
            //bindingSource1.Add(obj);
            //ObjectsDataGrid.DataSource = ;

        }

        private void GUIManage()
        {
            // Fill the listbox with the GtkWindows
            //GtkWindowListBox.DataSource = gladeParser.GtkWindowsId;
            //bindingSource1.
        }

        private void GtkWindowListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
            //ClassNameTextBox.Text = (string) GtkWindowListBox.SelectedItem;
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
            /*gladeParser = new GtkParser(@"C:\Users\Buzz\workspace\ChessWorkspace\Chess\Debug\Glade\glade.glade");
            GUIManage();
            GtkWindowGroupBox.Enabled = true;
            ObjectsGroupBox.Enabled = true;*/
            //GtkWindowListBox.SelectedIndex = 2;
        
        }

        private void UpdateGrid()
        {
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
            int bindingSrcId = 2; // GtkWindowListBox.SelectedIndex;
            string classname = ""; //ClassNameTextBox.Text;
            string path = DirectoryClassFilesTextBox.Text;
            CreateClassFiles createclassfiles = new CreateClassFiles(classname, path, gladeParser, bindingSrcId);
            createclassfiles.WriteClassFiles();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (gladeFileOpen.ShowDialog() == DialogResult.OK)
            {
                string FileName = gladeFileOpen.FileName;
                gladeParser = new GtkParser(FileName);
                // Gui Management
                FormGridView.DataSource = gladeParser.FormBindingSources;
                //
                
            }
        }

        private void FormGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selected_row = FormGridView.SelectedRows[0].Index;
            //MessageBox.Show(selected_row.ToString());
        }

        private void FormGridView_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = FormGridView.CurrentRow.Index;
            //MessageBox.Show(selected_row.ToString());
            BindingForm bindingForm = (BindingForm) gladeParser.FormBindingSources[selected_row];
            ObjectsDataGrid.DataSource = bindingForm.Widgets;
        }
    }
}
