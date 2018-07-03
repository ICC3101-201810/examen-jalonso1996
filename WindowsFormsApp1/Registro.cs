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
    public class Registro
    {
        List<Usuario> listaUsuarios = new List<Usuario>();

        public List<Usuario> GetListaUsuarios()
        {
            return listaUsuarios;
        }

        public void AgregarUsuario(Usuario u)
        {
            listaUsuarios.Add(u);
        }
    }
}
