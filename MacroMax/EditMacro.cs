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
    public partial class EditMacro : Form
    {
        public Keys key;
        public EventType eventType = EventType.NONE;
        public int time = 10;
        public Macro macro;
        private bool complete = false;

        public EditMacro(Macro editable)
        {
            InitializeComponent();
            macro = editable;
            key = (Keys)macro.theMacroEvent;
            eventType = macro.theMacro;
            time = macro.timeBeforeEvent;
        }

        public EditMacro()
        {
            InitializeComponent();

        }

        private void checkComplete()
        { 
        if((key != Keys.None) && (eventType != EventType.NONE) && (time >0))
            {
                macro = new Macro(eventType,(int)key,time);
            complete = true; 
            }

        if (complete)
            { OKButton.Enabled = true; }

        }

        private void EditMacro_Load(object sender, EventArgs e)
        {
            if (macro != null)
            {
                 Keys tempkey = (Keys)macro.theMacroEvent;
                timeMaskedTextBox.Text = macro.timeBeforeEvent.ToString();
                keyTextBox.Text = tempkey.ToString();

                int theEventType = 0;

                switch(macro.theMacro)
                {
                    case EventType.KEYDOWN:
                        theEventType = 0;
                        break;
                    case EventType.KEYUP:
                        theEventType = 1;
                        break;
                    case EventType.MOUSEDOWN:
                        theEventType = 2;
                        break;
                    case EventType.MOUSEUP:
                        theEventType = 3;
                        break;
                    default:
                        theEventType = 0;
                        break;
                }

                typeListBox.SelectedIndex = theEventType;
            }
            checkComplete();
        }

        private void keyTextBox_Click(object sender, EventArgs e)
        {
            eventHookForm bindForm = new eventHookForm();
            DialogResult result = bindForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                key = bindForm.key.KeyCode;
                eventType = bindForm.keyEvent;
                typeListBox.SelectedItem = eventType.ToString();
                keyTextBox.Text = key.ToString();
            }
            checkComplete();
        }

        private void typeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeListBox.SelectedIndex)
            {
                case 0:
                    eventType = EventType.KEYDOWN;
                    break;
                case 1:
                    eventType = EventType.KEYUP;
                    break;
                case 2:
                    eventType = EventType.MOUSEDOWN;
                    break;
                case 3:
                    eventType = EventType.MOUSEUP;
                    break;
                default:
                    eventType = EventType.KEYDOWN;
                    break;
            }
            checkComplete();
        }

        private void timeMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if(timeMaskedTextBox.Text != "")
            time = int.Parse(timeMaskedTextBox.Text);
            checkComplete();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(complete)
            this.DialogResult = DialogResult.OK;
        }








    }//end of EditMacro Class
}//end of namespace
