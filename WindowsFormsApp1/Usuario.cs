using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Usuario
    {
        string nombre;
        int puntaje;
        public Usuario(string miNombre, int mipuntaje)
        {
            nombre = miNombre;
            puntaje = mipuntaje;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetPuntaje()
        {
            return puntaje;
        }
    }
}
