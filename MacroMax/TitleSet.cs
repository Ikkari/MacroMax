using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroMax
{
    public partial class TitleSet : Form
    {

       public string title = "New Binding";
        List<string> titleList;
        public BindType bindType = BindType.REBIND;


       public TitleSet(List<string> bindList)
        {
            InitializeComponent();
            titleList = bindList;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            title = titleTextBox.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            checkAndSend();
                
        }

        private void titleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { checkAndSend(); }
        }

        private void checkAndSend()
        { 
        
        if (titleList.Contains(title))
                {
                    MessageBox.Show("Title has already been chosen. Please try another title.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                this.DialogResult = DialogResult.OK;
        
        }

        private void reBindRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (reBindRadioButton.Checked)
                bindType = BindType.REBIND;

            if (macroRadioButton.Checked)
                bindType = BindType.MACRO;

            if (toggleRadioButton.Checked)
                bindType = BindType.TOGGLE;
        }
    }
}
