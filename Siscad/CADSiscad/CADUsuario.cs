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
        public int idUsuario { get; set; }
        public string codigoUsuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string clave { get; set; }
        public int idRol { get; set; }
        public DateTime ultimoIngreso { get; set; }
        public DateTime horaUltimoIngreso { get; set; }
        public DateTime fechaModificacionClave { get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }
        public string adicional1 { get; set; }
        public string adicional2 { get; set; }
        public string adicional3 { get; set; }
        public int idUsuarioCreador { get; set; }


        private static usuarioTableAdapter adaptador = new usuarioTableAdapter();

        public static bool ValidarUsuario(string codigoUsuario, string clave)
        {
            if (adaptador.ValidaUsuario(codigoUsuario, clave) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ExisteUsuario(string codigoUsuario)
        {
            if (adaptador.ExisteUsuario(codigoUsuario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool EstadoUsuario(string codigoUsuario, bool estado)
        {
            if (adaptador.EstadoUsuario(codigoUsuario, estado) == null)
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
            miUsuario.codigoUsuario = miRegistro.codigoUsuario;
            miUsuario.nombre = miRegistro.nombre;
            miUsuario.apellido = miRegistro.apellido;
            miUsuario.clave = miRegistro.clave;
            miUsuario.idRol = miRegistro.idRol;
            miUsuario.ultimoIngreso = miRegistro.ultimoIngreso;
            miUsuario.horaUltimoIngreso = miRegistro.horaUltimoIngreso;
            miUsuario.fechaModificacionClave = miRegistro.fechaModificacionClave;
            miUsuario.correo = miRegistro.correo;
            miUsuario.estado = Convert.ToBoolean(miRegistro.estado);
            miUsuario.adicional1 = miRegistro.adicional1;
            miUsuario.adicional2 = miRegistro.adicional2;
            miUsuario.adicional3 = miRegistro.adicional3;
            miUsuario.idUsuarioCreador = miRegistro.idUsuarioCreador;
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
