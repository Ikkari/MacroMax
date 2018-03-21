using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouseKeyboardLibrary;

namespace MacroMax
{
    class MacroBind : Binding
    {

        System.Timers.Timer tickTimer = new System.Timers.Timer(); //timer for the macro

        private int macroNumber = 0; //the macro position

        public MacroBind(string theTitle) : base (theTitle)
        {
            bindType = BindType.MACRO;
            tickTimer.Elapsed += tickTimer_Elapsed;
        }

        public MacroBind(string p, EventType eventType, int p_2, int p_3, int p_4, int p_5, List<Macro> list, InputType inputType, InputType inputType_2,bool p_6, bool p_7)
            : base(p)
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
            toggleThis = p_6;
            useThisBinding = p_7;

            bindType = BindType.MACRO;
            tickTimer.Elapsed += tickTimer_Elapsed;
            isToggled = false;
    }

         public override void run(EventType aEvent)
        {
                if (!isToggled)
                {
                    if (macroList.Count > 0)
                        macroNumber = 0;

            tickTimer.Enabled = true;
            isToggled = true;

            if (macroList.ElementAt(macroNumber).timeBeforeEvent <= 0)
                tickTimer.Interval = 1;
            else
                tickTimer.Interval = macroList.ElementAt(macroNumber).timeBeforeEvent;

            tickTimer.Start();
                }
            

            /*
            if (e.KeyData == stopKey.KeyData && aEvent == stopEvent)
            {
             tickTimer.Stop();
            busy = false;  
            }
            */
        }


        void tickTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            EventType currentEvent = macroList.ElementAt(macroNumber).theMacro;


            if (currentEvent == EventType.KEYDOWN)
            {
                
                KeyboardSimulator.KeyDown((Keys)macroList.ElementAt(macroNumber).theMacroEvent);
            }


            if (currentEvent == EventType.KEYUP)
            {
                
                KeyboardSimulator.KeyUp((Keys)macroList.ElementAt(macroNumber).theMacroEvent);
            }


            if (currentEvent == EventType.MOUSEDOWN)
            {
                
                MouseSimulator.MouseDown((MouseButtons)macroList.ElementAt(macroNumber).theMacroEvent);
            }

            if (currentEvent == EventType.MOUSEUP)
            {
               
                MouseSimulator.MouseUp((MouseButtons)macroList.ElementAt(macroNumber).theMacroEvent);
            }

            if (currentEvent == EventType.MOUSEMOVE)
            {
                
                MouseSimulator.X = macroList.ElementAt(macroNumber).location.X;
                MouseSimulator.Y = macroList.ElementAt(macroNumber).location.Y;
            }

            if (currentEvent == EventType.MOUSEWHEEL)
            {
                MouseSimulator.MouseWheel(macroList.ElementAt(macroNumber).theMacroEvent);
            }

            macroNumber++;
            if (macroNumber >= macroList.Count)
            {
                tickTimer.Stop();
                isToggled = false;
            }
            else
            {
                if (macroList.ElementAt(macroNumber).timeBeforeEvent <= 0)
                    tickTimer.Interval = 1;
                else
                    tickTimer.Interval = macroList.ElementAt(macroNumber).timeBeforeEvent;
            }

        }


    }
}
