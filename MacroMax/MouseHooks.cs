using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardLibrary;

namespace MacroMax
{
    class MouseHooks
    {
        MouseHook mouseHook = new MouseHook();
       // private bool recordMouse = false;
       // private bool recordMouseMove = false;

        private void mouseHooks(object sender, EventArgs e)
        {

            mouseHook.MouseDown += mouseHook_MouseDown;
            mouseHook.MouseUp += mouseHook_MouseUp;
            mouseHook.MouseWheel += mouseHook_MouseWheel;
            mouseHook.MouseMove += mouseHook_MouseMove;
        }

        
        void mouseHook_MouseMove(object sender, MouseEventArgs e)
        {/*
            if (recording && recordMouse && recordMouseMove)
            {
                int time = Environment.TickCount - lastTime;
                keyBinds.ElementAt(boundListBox.SelectedIndex).macroList.Add(new Macro(EventType.MOUSEMOVE, e.Location, time));
                lastTime = Environment.TickCount;
                macroListBox.Items.Add(time + " ticks");
                macroListBox.Items.Add(e.Button.ToString() + " MouseMove");
            }
          * */
        }

        void mouseHook_MouseWheel(object sender, MouseEventArgs e)
        {/*
            if (recording && recordMouse)
            {
                int time = Environment.TickCount - lastTime;
                keyBinds.ElementAt(boundListBox.SelectedIndex).macroList.Add(new Macro(EventType.MOUSEWHEEL, (int)e.Delta, time));
                lastTime = Environment.TickCount;
                macroListBox.Items.Add(time + " ticks");
                macroListBox.Items.Add(e.Button.ToString() + " MouseWheel");
            }

            if (running)
            {

                for (int i = 0; i < keyBinds.Count; i++)
                {
                    if (keyBinds.ElementAt(i).checkMacro(e.Button, EventType.MOUSEWHEEL))
                    {
                        keyBinds.ElementAt(i).run(EventType.MOUSEWHEEL);
                        break;
                    }
                }

            }*/
        }

        void mouseHook_MouseUp(object sender, MouseEventArgs e)
        {/*
            if (recording && recordMouse)
            {
                int time = Environment.TickCount - lastTime;
                keyBinds.ElementAt(boundListBox.SelectedIndex).macroList.Add(new Macro(EventType.MOUSEUP, (int)e.Button, time));
                lastTime = Environment.TickCount;
                macroListBox.Items.Add(time + " ticks");
                macroListBox.Items.Add(e.Button.ToString() + " MouseUp");
            }

            if (running)
            {

                for (int i = 0; i < keyBinds.Count; i++)
                {
                    if (keyBinds.ElementAt(i).checkMacro(e.Button, EventType.MOUSEUP))
                    {
                        keyBinds.ElementAt(i).run(EventType.MOUSEUP);
                        break;
                    }
                }

            }*/
        }

        void mouseHook_MouseDown(object sender, MouseEventArgs e)
        {/*
            if (recording && recordMouse)
            {
                int time = Environment.TickCount - lastTime;
                keyBinds.ElementAt(boundListBox.SelectedIndex).macroList.Add(new Macro(EventType.MOUSEDOWN, (int)e.Button, time));
                lastTime = Environment.TickCount;
                macroListBox.Items.Add(time + " ticks");
                macroListBox.Items.Add(e.Button.ToString() + " MouseDown");
            }

            if (running)
            {

                for (int i = 0; i < keyBinds.Count; i++)
                {
                    if (keyBinds.ElementAt(i).checkMacro(e.Button, EventType.MOUSEDOWN))
                    {

                        keyBinds.ElementAt(i).run(EventType.MOUSEDOWN);
                        break;
                    }
                }

            }*/
        }

         
    }
}
