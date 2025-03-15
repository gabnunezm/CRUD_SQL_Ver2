using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();

        // Método para mostrar los usuarios
        public DataTable MostrarUsuarios()
        {
            return objetoCD.Mostrar();
        }

        // Método para insertar usuario
        public void InsertarUsuario(string nombre, string usuario, string password, string tipo_usuario)
        {
            objetoCD.Insertar(nombre, usuario, password, tipo_usuario);
        }

        // Método para editar usuario
        public void EditarUsuario(string id_usuario, string nombre, string usuario, string password, string tipo_usuario)
        {
            objetoCD.Editar(Convert.ToInt32(id_usuario), nombre, usuario, password, tipo_usuario);
        }

        // Método para eliminar usuario
        public void EliminarUsuario(string id_usuario)
        {
            objetoCD.Eliminar(Convert.ToInt32(id_usuario));
        }
    }
}
