namespace Siscad
{
    partial class pruebaDeCodigo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dSSiscad = new Siscad.DSSiscad();
            this.terceroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terceroTableAdapter = new Siscad.DSSiscadTableAdapters.terceroTableAdapter();
            this.tableAdapterManager = new Siscad.DSSiscadTableAdapters.TableAdapterManager();
            this.tipoDocumentoTableAdapter = new Siscad.DSSiscadTableAdapters.tipoDocumentoTableAdapter();
            this.tipoPersonaTableAdapter = new Siscad.DSSiscadTableAdapters.tipoPersonaTableAdapter();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSSiscad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUltimoRegistro
            // 
            this.buttonUltimoRegistro.Location = new System.Drawing.Point(210, 565);
            // 
            // buttonSiguienteRegistro
            // 
            this.buttonSiguienteRegistro.Location = new System.Drawing.Point(144, 565);
            // 
            // buttonAnteriorRegistro
            // 
            this.buttonAnteriorRegistro.Location = new System.Drawing.Point(78, 565);
            // 
            // buttonPrimerRegistro
            // 
            this.buttonPrimerRegistro.Location = new System.Drawing.Point(12, 565);
            // 
            // buttonFormBorrar
            // 
            this.buttonFormBorrar.Location = new System.Drawing.Point(486, 565);
            // 
            // buttonFormEditar
            // 
            this.buttonFormEditar.Location = new System.Drawing.Point(420, 565);
            // 
            // buttonFormNuevo
            // 
            this.buttonFormNuevo.Location = new System.Drawing.Point(354, 565);
            // 
            // buttonFormBuscar
            // 
            this.buttonFormBuscar.Location = new System.Drawing.Point(552, 565);
            // 
            // buttonFormGuardar
            // 
            this.buttonFormGuardar.Location = new System.Drawing.Point(618, 565);
            // 
            // buttonFormCancelar
            // 
            this.buttonFormCancelar.Location = new System.Drawing.Point(684, 565);
            // 
            // buttonFormCerrar
            // 
            this.buttonFormCerrar.Location = new System.Drawing.Point(750, 565);
            // 
            // dSSiscad
            // 
            this.dSSiscad.DataSetName = "DSSiscad";
            this.dSSiscad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // terceroBindingSource
            // 
            this.terceroBindingSource.DataMember = "tercero";
            this.terceroBindingSource.DataSource = this.dSSiscad;
            // 
            // terceroTableAdapter
            // 
            this.terceroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accidentalidadTableAdapter = null;
            this.tableAdapterManager.actividadPendienteTableAdapter = null;
            this.tableAdapterManager.afiliacionesTableAdapter = null;
            this.tableAdapterManager.agenteLesionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.barraTableAdapter = null;
            this.tableAdapterManager.barrioSectorTableAdapter = null;
            this.tableAdapterManager.bodegaProductoTableAdapter = null;
            this.tableAdapterManager.bodegaTableAdapter = null;
            this.tableAdapterManager.claseImpuestoTableAdapter = null;
            this.tableAdapterManager.comprasDetalleTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.conceptoCarteraTableAdapter = null;
            this.tableAdapterManager.conceptoNominaTableAdapter = null;
            this.tableAdapterManager.contactoTableAdapter = null;
            this.tableAdapterManager.controlNominaTableAdapter = null;
            this.tableAdapterManager.cuentasBancariasTableAdapter = null;
            this.tableAdapterManager.cuentasPorCobrarTableAdapter = null;
            this.tableAdapterManager.cursosComplementariosTableAdapter = null;
            this.tableAdapterManager.datosEmpresaTableAdapter = null;
            this.tableAdapterManager.deduccionNominaTableAdapter = null;
            this.tableAdapterManager.departamentoProductoTableAdapter = null;
            this.tableAdapterManager.departamentoTableAdapter = null;
            this.tableAdapterManager.detalleNominaTableAdapter = null;
            this.tableAdapterManager.devolucionComprasDetalleTableAdapter = null;
            this.tableAdapterManager.devolucionComprasTableAdapter = null;
            this.tableAdapterManager.devolucionVentasDetalleTableAdapter = null;
            this.tableAdapterManager.devolucionVentasTableAdapter = null;
            this.tableAdapterManager.diagnosticosTableAdapter = null;
            this.tableAdapterManager.diaSemanaTableAdapter = null;
            this.tableAdapterManager.documentosTerceroTableAdapter = null;
            this.tableAdapterManager.estadoCivilTableAdapter = null;
            this.tableAdapterManager.examenMedicoTableAdapter = null;
            this.tableAdapterManager.grupoDiagnosticoTableAdapter = null;
            this.tableAdapterManager.impuestoTableAdapter = null;
            this.tableAdapterManager.kardexTableAdapter = null;
            this.tableAdapterManager.mecanismoAccidenteTableAdapter = null;
            this.tableAdapterManager.motivoOtroSiTableAdapter = null;
            this.tableAdapterManager.municipioTableAdapter = null;
            this.tableAdapterManager.novedadLaboralTableAdapter = null;
            this.tableAdapterManager.objetivoExamenMedicoTableAdapter = null;
            this.tableAdapterManager.ocupacionesTableAdapter = null;
            this.tableAdapterManager.otroSiContratoTableAdapter = null;
            this.tableAdapterManager.paisTableAdapter = null;
            this.tableAdapterManager.parteCuerpoTableAdapter = null;
            this.tableAdapterManager.periodoPagoTableAdapter = null;
            this.tableAdapterManager.permisoRolTableAdapter = null;
            this.tableAdapterManager.preliquidacionDetalleTableAdapter = null;
            this.tableAdapterManager.preliquidacionEncabezadoTableAdapter = null;
            this.tableAdapterManager.productoTableAdapter = null;
            this.tableAdapterManager.rolTableAdapter = null;
            this.tableAdapterManager.salidasDetalleTableAdapter = null;
            this.tableAdapterManager.salidasTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.smmlvTableAdapter = null;
            this.tableAdapterManager.subtipoCotizanteTableAdapter = null;
            this.tableAdapterManager.sucursalTableAdapter = null;
            this.tableAdapterManager.terceroTableAdapter = this.terceroTableAdapter;
            this.tableAdapterManager.tipoAccidenteTableAdapter = null;
            this.tableAdapterManager.tipoCertificadoTableAdapter = null;
            this.tableAdapterManager.tipoContratoTableAdapter = null;
            this.tableAdapterManager.tipoCotizanteTableAdapter = null;
            this.tableAdapterManager.tipoCuentaBancoTableAdapter = null;
            this.tableAdapterManager.tipoDocumentoTableAdapter = this.tipoDocumentoTableAdapter;
            this.tableAdapterManager.tipoLesionTableAdapter = null;
            this.tableAdapterManager.tipoPersonaTableAdapter = this.tipoPersonaTableAdapter;
            this.tableAdapterManager.tipoSangreTableAdapter = null;
            this.tableAdapterManager.trasladosDetalleTableAdapter = null;
            this.tableAdapterManager.trasladosTableAdapter = null;
            this.tableAdapterManager.unidadMedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Siscad.DSSiscadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.ventasDetalleTableAdapter = null;
            this.tableAdapterManager.ventasDetalleTmpTableAdapter = null;
            this.tableAdapterManager.ventasTableAdapter = null;
            this.tableAdapterManager.vinculacionTableAdapter = null;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoPersonaTableAdapter
            // 
            this.tipoPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "tipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSSiscad;
            // 
            // tipoPersonaBindingSource
            // 
            this.tipoPersonaBindingSource.DataMember = "tipoPersona";
            this.tipoPersonaBindingSource.DataSource = this.dSSiscad;
            // 
            // pruebaDeCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 637);
            this.Name = "pruebaDeCodigo";
            this.Text = "pruebaDeCodigo";
            this.Load += new System.EventHandler(this.pruebaDeCodigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSSiscad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSSiscad dSSiscad;
        private System.Windows.Forms.BindingSource terceroBindingSource;
        private DSSiscadTableAdapters.terceroTableAdapter terceroTableAdapter;
        private DSSiscadTableAdapters.TableAdapterManager tableAdapterManager;
        private DSSiscadTableAdapters.tipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DSSiscadTableAdapters.tipoPersonaTableAdapter tipoPersonaTableAdapter;
        private System.Windows.Forms.BindingSource tipoPersonaBindingSource;
    }
}