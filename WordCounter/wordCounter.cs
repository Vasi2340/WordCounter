using System;
using System.Windows.Forms;

namespace WordCounter
{
    public partial class wordCounter : Form
    {

        public wordCounter()
        {
            InitializeComponent();

            // Setting initial values for radio buttons
            rbtnAscending.Checked = true;
            rbtnWords.Checked = true;
        }

        // Button clicking 
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            wordCountingTools.openAndLoad(listView1);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            wordCountingTools.save(listView1);
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            wordCountingTools.saveAs(listView1);
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            wordCountingTools.sortWords(rbtnCount.Checked, rbtnAscending.Checked, listView1);
        }

        // Setting tooltip messages
        private void BtnBrowse_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Look for wanted file", btnBrowse);
        }


        private void BtnSave_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Saves file as shown in the list", btnSave);
        }

        private void BtnSaveAs_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Save in a different location", btnSaveAs);
        }

        // Managing radio buttons
        private void RbtnWords_Click(object sender, EventArgs e)
        {
            rbtnWords.Checked = true;
            rbtnCount.Checked = false;
        }

        private void RbtnCount_Click(object sender, EventArgs e)
        {
            rbtnCount.Checked = true;
            rbtnWords.Checked = false;
        }

        private void RbtnAscending_Click(object sender, EventArgs e)
        {
            rbtnAscending.Checked = true;
            rbtnDescending.Checked = false;
        }

        private void RbtnDescending_Click(object sender, EventArgs e)
        {
            rbtnDescending.Checked = true;
            rbtnAscending.Checked = false;
        }


    }
}
