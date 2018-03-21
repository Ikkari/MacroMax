using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MouseKeyboardLibrary;
using System.Threading;
using System.Windows.Forms;

namespace MacroMax
{
    class toggle : Binding
    {

        public toggle(string title)
            : base(title)
        {
            bindType = BindType.TOGGLE;
            toggleThis = true;
            isToggled = false;
        }

        public toggle(string p, EventType eventType, int p_2, int p_3, int p_4, int p_5, List<Macro> list, InputType inputType, InputType inputType_2, bool p_7)
            :base(p)
        {
            title = p;
            this.eventType = eventType;
            key = (Keys)p_2;
            mouseKey = (MouseButtons)p_3;
            secondKey = (Keys)p_4;
            secMouseKey = (MouseButtons)p_5;
            macroList = list;
            startType = inputType;
            secondaryType = inputType_2;
            useThisBinding = p_7;
            bindType = BindType.TOGGLE;
            toggleThis = true;
            isToggled = false;
        }

       

        public override void run(EventType aEvent)
        {

            if (isToggled)
            {

                KeyboardSimulator.KeyUp(key);
            }
            else
            {
                KeyboardSimulator.KeyDown(key);
            }

            isToggled = isToggled ? false : true;
            
        }



    }
}
