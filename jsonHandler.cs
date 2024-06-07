using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;



namespace TextToSpeech
{
  
    public class jsonHandler
    {
      
        public void savetoJson(string text, string Name)
        {
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            using (FileStream fs = new FileStream($"{Name}_{timestamp}.json", FileMode.Create))
            {
                byte[] data = Encoding.UTF8.GetBytes(text);
                fs.Write(data, 0, data.Length);
            }
        }

        public void openjson(TextBox text)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

           
            Nullable<bool> result = openFileDlg.ShowDialog();
            if (result == true)
            {
                // Open document 
                string filename = openFileDlg.FileName;
                using (StreamReader sr = new StreamReader(filename))
                {
                    string Text = sr.ReadToEnd();
                    text.Text = Text;
                }
            }
        }

    }

   
 
}
