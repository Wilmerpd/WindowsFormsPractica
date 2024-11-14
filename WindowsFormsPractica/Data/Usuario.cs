using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsPractica.Modelo;

namespace WindowsFormsPractica.Data
{
    public class Usuario
    {
        List<UsuarioModel> Lista = new List<UsuarioModel>();
        //Guardar los usuarios
        public void Guardar(UsuarioModel model)
        {
            Lista.Add(model);
        }
        //Consulta todos los usuarios
        public List<UsuarioModel> Consultar()
        {
            return Lista;
        }

    }
}
