using CADSiscad.DSCADSiscadTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADSiscad
{
    public class CADUsuario
    {
        public string idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string clave { get; set; }
        public int idRol { get; set; }
        public DateTime ultimoIngreso { get; set; }
        public DateTime horaUltimoIngreso { get; set; }
        public DateTime fechaModificacionClave { get; set; }
        public string correo { get; set; }
        public string estado { get; set; }


        private static usuarioTableAdapter adaptador = new usuarioTableAdapter();

        public static bool ValidarUsuario(string idUsuario, string clave)
        {
            if (adaptador.ValidaUsuario(idUsuario, clave) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ExisteUsuario(string idUsuario)
        {
            if (adaptador.ExisteUsuario(idUsuario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool EstadoUsuario(string idUsuario, string estado)
        {
            if (adaptador.EstadoUsuario(idUsuario, estado) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static CADUsuario GetUsuario(string idUsuario)
        {
            CADUsuario miUsuario = null;
            DSCADSiscad.usuarioDataTable miTabla = adaptador.GetUsuario(idUsuario);
            if (miTabla.Rows.Count == 0) return miUsuario;
            DSCADSiscad.usuarioRow miRegistro = (DSCADSiscad.usuarioRow)miTabla.Rows[0];
            miUsuario = new CADUsuario();
            miUsuario.idUsuario = miRegistro.idUsuario;
            miUsuario.nombre = miRegistro.nombre;
            miUsuario.apellido = miRegistro.apellido;
            miUsuario.clave = miRegistro.clave;
            miUsuario.idRol = miRegistro.idRol;
            miUsuario.ultimoIngreso = miRegistro.ultimoIngreso;
            miUsuario.horaUltimoIngreso = miRegistro.horaUltimoIngreso;
            miUsuario.fechaModificacionClave = miRegistro.fechaModificacionClave;
            miUsuario.correo = miRegistro.correo;
            miUsuario.estado = miRegistro.estado;
            return miUsuario;
        }

        //public static void CambioClave(string clave, string idUsuario)
        //{
        //    adaptador.CambioClave(idUsuario, clave, DateTime.Now);
        //}

        //public static void UpdateUltimoIngreso(string idUsuario)
        //{
        //    adaptador.UpdateUltimoIngreso(DateTime.Now, idUsuario);
        //}

        //public static void UpdateCierreSesion(string idUsuario)
        //{
        //    adaptador.UpdateCierreSesion(DateTime.Now, idUsuario);
        //}
        //public static bool RolTieneUsuario(string idRol)
        //{
        //    //if (adaptador.RolTieneUsuario(idRol) == null)
        //    //{
        //    //    return false;
        //    //}
        //    //return true;
        //}
    }
}
