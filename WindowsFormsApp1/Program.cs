using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Registro nuevaBD;
            if (File.Exists("../../Serialized.txt"))
            {
                BinaryFormatter bin = new BinaryFormatter();
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Read);
                nuevaBD = (Registro)bin.Deserialize(stream);
                stream.Close();
            }
            else
            {
                nuevaBD = new Registro();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(nuevaBD));
        }
    }
}
