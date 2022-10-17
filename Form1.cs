using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace widowsKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("MSPaint");
            comboBox1.Items.Add("Notepad");

            this.IsMdiContainer = true;

            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem file = new ToolStripMenuItem("File");
            ToolStripMenuItem open = new ToolStripMenuItem("Open");
            file.DropDownItems.Add(open);
            ToolStripMenuItem save = new ToolStripMenuItem("Save");
            file.DropDownItems.Add(save);
            ToolStripMenuItem exit = new ToolStripMenuItem("Exit");
            file.DropDownItems.Add(exit);
            ((ToolStripDropDownMenu)(file.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(file.DropDown)).ShowCheckMargin = true;

            ToolStripMenuItem edit = new ToolStripMenuItem("Edit");
            ToolStripMenuItem text = new ToolStripMenuItem("Text");
            edit.DropDownItems.Add(text);
            ToolStripMenuItem font = new ToolStripMenuItem("Font");
            edit.DropDownItems.Add(font);
            ToolStripMenuItem options = new ToolStripMenuItem("Options");
            edit.DropDownItems.Add(options);
            ((ToolStripDropDownMenu)(edit.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(edit.DropDown)).ShowCheckMargin = true;

            ToolStripMenuItem view = new ToolStripMenuItem("View");
            ToolStripMenuItem msg = new ToolStripMenuItem("Message");
            view.DropDownItems.Add(msg);
            ((ToolStripDropDownMenu)(view.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(view.DropDown)).ShowCheckMargin = true;

            ToolStripMenuItem help = new ToolStripMenuItem("Help");
            ToolStripMenuItem about = new ToolStripMenuItem("About");
            help.DropDownItems.Add(about);
            ((ToolStripDropDownMenu)(help.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(help.DropDown)).ShowCheckMargin = true;

            ms.MdiWindowListItem = file;
            ms.MdiWindowListItem = edit;
            ms.MdiWindowListItem = view;
            ms.MdiWindowListItem = help;

            ms.Items.Add(file);
            ms.Items.Add(edit);
            ms.Items.Add(view);
            ms.Items.Add(help);

            this.Controls.Add(ms);
        }

        void windowNewMenu_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.MdiParent = this;
            f.Text = "Form - " + this.MdiChildren.Length.ToString();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = checkBox1.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gettext = comboBox1.SelectedItem.ToString();
            System.Diagnostics.Process.Start(gettext);

            textBox1.Text = comboBox1.Text;
            if(comboBox1.Text == "MSPaint")
            {
                textBox2.Text = ("This program is used for makeing graphic pictures.");
            }

            if(comboBox1.Text == "Notepad")
            {
                textBox2.Text = ("This program is used for making textual files.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
            textBox2.Clear();
        }
    }
}
