using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePetitCafe.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            var nuevoUsuario1 = new Usuario();
            nuevoUsuario1.Nombre = "Dayana";
            nuevoUsuario1.Contrasena = Encriptar.CodificarContrasena("patito123");

            contexto.Usuarios.Add(nuevoUsuario);
            contexto.Usuarios.Add(nuevoUsuario1);
            base.Seed(contexto);
        }
    }
}
