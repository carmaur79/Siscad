using CADSiscad.DSCADSiscadTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADSiscad
{
    public class CADEmpresa
    {
        public int idConsecutivo { get; set; }
        public int idEmpresa { get; set; }
        public string dv { get; set; }
        public string razonSocial { get; set; }
        public string nombreComercial { get; set; }
        public string logo { get; set; }
        public string direccion { get; set; }
        public string idDepartamento { get; set; }
        public string idMunicipio { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string idTerceroArl { get; set; }
        public string correo { get; set; }
        public string sitioWeb { get; set; }
        public string idTerceroRepresentante { get; set; }
        public DateTime fechaConstitucion { get; set; }
        public string resolucionFacturacion { get; set; }
        public DateTime fechaResolucionFacturacion { get; set; }
        public string idUsuario { get; set; }


        private static datosEmpresaTableAdapter adaptador = new datosEmpresaTableAdapter();

        public static CADEmpresa GetEmpresa(int idEmpresa)
        {
            CADEmpresa miEmpresa = null;

            DSCADSiscad.datosEmpresaDataTable miTabla = adaptador.GetEmpresa(idEmpresa);
            if (miTabla.Rows.Count == 0) return miEmpresa;
            DSCADSiscad.datosEmpresaRow miRegistro = (DSCADSiscad.datosEmpresaRow)miTabla.Rows[0];
            miEmpresa = new CADEmpresa();
            miEmpresa.idConsecutivo = miRegistro.idConsecutivo;
            miEmpresa.idEmpresa = miRegistro.idEmpresa;
            miEmpresa.dv = miRegistro.dv;
            miEmpresa.razonSocial = miRegistro.razonSocial;
            miEmpresa.nombreComercial = miRegistro.nombreComercial;
            miEmpresa.direccion = miRegistro.direccion;
            miEmpresa.idMunicipio = miRegistro.idMunicipio;
            miEmpresa.telefono1 = miRegistro.telefono1;
            miEmpresa.telefono2 = miRegistro.telefono2;
            miEmpresa.idTerceroArl = miRegistro.idTerceroArl;
            miEmpresa.correo = miRegistro.correo;
            miEmpresa.sitioWeb = miRegistro.sitioWeb;
            miEmpresa.idTerceroRepresentante = miRegistro.idTerceroRepresentante;
            miEmpresa.idDepartamento = miRegistro.idDepartamento;
            miEmpresa.fechaConstitucion = miRegistro.fechaConstitucion;
            //miEmpresa.logo = miRegistro.logo.ToString();
            miEmpresa.resolucionFacturacion = miRegistro.resolucionFacturacion;
            miEmpresa.fechaResolucionFacturacion = miRegistro.fechaResolucionFacturacion;
            miEmpresa.idUsuario = miRegistro.idUsuario;
            return miEmpresa;
        }

        public static bool ExisteEmpresa(int idEmpresa)
        {
            if (adaptador.ExisteEmpresa(idEmpresa) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
