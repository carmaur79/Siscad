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
        public int idEmpresa { get; set; }
        public int numeroDocumento { get; set; }
        public string dv { get; set; }
        public string razonSocial { get; set; }
        public string nombreComercial { get; set; }
        public string logo { get; set; }
        public string direccion { get; set; }
        public int idDepartamento { get; set; }
        public int idMunicipio { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public int idTerceroArl { get; set; }
        public string correo { get; set; }
        public string sitioWeb { get; set; }
        public int idTerceroRepresentante { get; set; }
        public DateTime fechaConstitucion { get; set; }
        public string resolucionFacturacion { get; set; }
        public DateTime fechaResolucionFacturacion { get; set; }
        public int vigenciaResolucion { get; set; }
        public string adicional1 { get; set; }
        public int idUsuario { get; set; }


        private static datosEmpresaTableAdapter adaptador = new datosEmpresaTableAdapter();

        public static CADEmpresa GetEmpresa(int numeroDocumento)
        {
            CADEmpresa miEmpresa = null;

            DSCADSiscad.datosEmpresaDataTable miTabla = adaptador.GetEmpresa(numeroDocumento);
            if (miTabla.Rows.Count == 0) return miEmpresa;
            DSCADSiscad.datosEmpresaRow miRegistro = (DSCADSiscad.datosEmpresaRow)miTabla.Rows[0];
            miEmpresa = new CADEmpresa();
            miEmpresa.idEmpresa = miRegistro.idEmpresa;
            miEmpresa.numeroDocumento = miRegistro.numeroDocumento;
            miEmpresa.dv = miRegistro.dv;
            miEmpresa.razonSocial = miRegistro.razonSocial;
            miEmpresa.nombreComercial = miRegistro.nombreComercial;
            miEmpresa.logo = miRegistro.logo;
            miEmpresa.direccion = miRegistro.direccion;
            miEmpresa.idDepartamento = miRegistro.idDepartamento;
            miEmpresa.idMunicipio = miRegistro.idMunicipio;
            miEmpresa.telefono1 = miRegistro.telefono1;
            miEmpresa.telefono2 = miRegistro.telefono2;
            miEmpresa.idTerceroArl = miRegistro.idTerceroArl;
            miEmpresa.correo = miRegistro.correo;
            miEmpresa.sitioWeb = miRegistro.sitioWeb;
            miEmpresa.idTerceroRepresentante = miRegistro.idTerceroRepresentante;
            miEmpresa.fechaConstitucion = miRegistro.fechaConstitucion;
            miEmpresa.resolucionFacturacion = miRegistro.resolucionFacturacion;
            miEmpresa.fechaResolucionFacturacion = miRegistro.fechaResolucionFacturacion;
            miEmpresa.vigenciaResolucion = miRegistro.vigenciaResolucion;
            miEmpresa.adicional1 = miRegistro.adicional1;
            miEmpresa.idUsuario = miRegistro.idUsuario;
            return miEmpresa;
        }

        public static bool ValidaExisteEmpresa(int numeroDocumento)
        {
            if (adaptador.ValidaExisteEmpresa(numeroDocumento) == null)
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
