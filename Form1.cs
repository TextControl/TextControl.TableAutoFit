using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TXTextControl;

namespace tx_table_autofit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.Tables.Add();
        }

        private void tableToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (textControl1.Tables.GetItem() != null)
                autoFitToolStripMenuItem.Enabled = true;
            else
                autoFitToolStripMenuItem.Enabled = false;
        }

        private void autoFitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.Tables.GetItem().AutoSize(textControl1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textControl1.Load("tables.rtf", StreamType.RichTextFormat);
        }

        private void autoSizeToPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.Tables.GetItem().SpreadToPage(textControl1);
        }

        private void combineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.Tables.GetItem().SpreadToPage(textControl1);
            textControl1.Tables.GetItem().AutoSize(textControl1);
        }
    }
}
