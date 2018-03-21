using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MacroMax
{
    class saveLoad
    {

        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        private FileStream input;
        List<BindSave> save = new List<BindSave>();


        public void saveBindings(List<Binding> binds)
        {



            SaveFileDialog fileChooser = new SaveFileDialog();
            fileChooser.CheckFileExists = false;
            fileChooser.DefaultExt = "max";
            DialogResult result = fileChooser.ShowDialog();

            if(result == DialogResult.Cancel)
                return;

            string fileName = fileChooser.FileName;

            if (fileName == "" || fileName == null)
                MessageBox.Show("Invalid file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                    foreach (Binding theBind in binds)
                    {
                        save.Add(new BindSave(theBind.macroList,theBind.key, theBind.mouseKey, theBind.secondKey, theBind.secMouseKey,
                            theBind.startType, theBind.secondaryType, theBind.bindType, theBind.eventType, theBind.title, theBind.toggleThis,
                            theBind.useThisBinding));
                    }

                    foreach (BindSave bind in save)
                    {
                        formatter.Serialize(output, bind);
                    }
                }
                catch(IOException)
                { MessageBox.Show("Error opening file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch(SerializationException e)
               { MessageBox.Show("Error writing to file." + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch(FormatException)
                { MessageBox.Show("Invalid format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            if (output != null)
            {
                try
                {
                    output.Close();
                }
                catch (IOException)
                { MessageBox.Show("Cannot close the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

            
        }

        public List<Binding> loadBindings(string file)
        {
            List<Binding> binds = new List<Binding>();

            input = new FileStream(file,FileMode.Open, FileAccess.Read);

            try
            {
                while (true)
                {
                    BindSave bind = (BindSave)formatter.Deserialize(input);

                    if (bind.bindType == BindType.TOGGLE)
                        binds.Add(new toggle(bind.title, bind.eventType, bind.key, bind.mouseKey, bind.secondKey,
                            bind.secMouseKey, bind.macroList, bind.startType, bind.secondaryType,
                            bind.useThisBinding));

                    if (bind.bindType == BindType.REBIND)
                        binds.Add(new Mimic(bind.title, bind.eventType, bind.key, bind.mouseKey, bind.secondKey,
                            bind.secMouseKey, bind.macroList, bind.startType, bind.secondaryType, bind.toggleThis,
                            bind.useThisBinding));

                    if (bind.bindType == BindType.MACRO)
                        binds.Add(new MacroBind(bind.title, bind.eventType, bind.key, bind.mouseKey, bind.secondKey,
                            bind.secMouseKey, bind.macroList, bind.startType, bind.secondaryType, bind.toggleThis,
                            bind.useThisBinding));
                }
                    
            }
            catch (SerializationException)
            {
                input.Close();
            }

            return binds;
        }
    }
}
