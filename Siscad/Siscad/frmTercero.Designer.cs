namespace Siscad
{
    partial class frmTercero
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNombreFormulario = new System.Windows.Forms.Label();
            this.dataGridViewPrincipal = new System.Windows.Forms.DataGridView();
            this.dSSiscad = new Siscad.DSSiscad();
            this.terceroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terceroTableAdapter = new Siscad.DSSiscadTableAdapters.terceroTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTerceroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreComercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAlternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOcupacionPerfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoSangreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitioWebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esEmpleadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esClienteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esProveedorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esEpsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esAfpDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esArlDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esCcfDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esOtroDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsableIvaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vigenteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSiscad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFormEditar
            // 
            this.buttonFormEditar.Click += new System.EventHandler(this.buttonFormEditar_Click);
            // 
            // labelNombreFormulario
            // 
            this.labelNombreFormulario.AutoSize = true;
            this.labelNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreFormulario.ForeColor = System.Drawing.Color.DarkGray;
            this.labelNombreFormulario.Location = new System.Drawing.Point(12, 9);
            this.labelNombreFormulario.Name = "labelNombreFormulario";
            this.labelNombreFormulario.Size = new System.Drawing.Size(130, 25);
            this.labelNombreFormulario.TabIndex = 14;
            this.labelNombreFormulario.Text = "TERCEROS";
            // 
            // dataGridViewPrincipal
            // 
            this.dataGridViewPrincipal.AllowUserToAddRows = false;
            this.dataGridViewPrincipal.AllowUserToDeleteRows = false;
            this.dataGridViewPrincipal.AllowUserToOrderColumns = true;
            this.dataGridViewPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrincipal.AutoGenerateColumns = false;
            this.dataGridViewPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrincipal.ColumnHeadersHeight = 30;
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idTerceroDataGridViewTextBoxColumn,
            this.dvDataGridViewTextBoxColumn,
            this.idTipoDocumentoDataGridViewTextBoxColumn,
            this.idPersonaDataGridViewTextBoxColumn,
            this.nombre1DataGridViewTextBoxColumn,
            this.nombre2DataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn,
            this.razonSocialDataGridViewTextBoxColumn,
            this.nombreComercialDataGridViewTextBoxColumn,
            this.codigoAlternoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.idOcupacionPerfilDataGridViewTextBoxColumn,
            this.idSexoDataGridViewTextBoxColumn,
            this.tipoSangreDataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.telefono3DataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.idDepartamentoDataGridViewTextBoxColumn,
            this.idMunicipioDataGridViewTextBoxColumn,
            this.idEstadoCivilDataGridViewTextBoxColumn,
            this.sitioWebDataGridViewTextBoxColumn,
            this.esEmpleadoDataGridViewCheckBoxColumn,
            this.esClienteDataGridViewCheckBoxColumn,
            this.esProveedorDataGridViewCheckBoxColumn,
            this.esEpsDataGridViewCheckBoxColumn,
            this.esAfpDataGridViewCheckBoxColumn,
            this.esArlDataGridViewCheckBoxColumn,
            this.esCcfDataGridViewCheckBoxColumn,
            this.esOtroDataGridViewCheckBoxColumn,
            this.imagenDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn,
            this.responsableIvaDataGridViewCheckBoxColumn,
            this.vigenteDataGridViewCheckBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn});
            this.dataGridViewPrincipal.DataSource = this.terceroBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPrincipal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPrincipal.EnableHeadersVisualStyles = false;
            this.dataGridViewPrincipal.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.ReadOnly = true;
            this.dataGridViewPrincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(726, 360);
            this.dataGridViewPrincipal.TabIndex = 84;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 38;
            // 
            // idTerceroDataGridViewTextBoxColumn
            // 
            this.idTerceroDataGridViewTextBoxColumn.DataPropertyName = "idTercero";
            this.idTerceroDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.idTerceroDataGridViewTextBoxColumn.Name = "idTerceroDataGridViewTextBoxColumn";
            this.idTerceroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTerceroDataGridViewTextBoxColumn.Width = 85;
            // 
            // dvDataGridViewTextBoxColumn
            // 
            this.dvDataGridViewTextBoxColumn.DataPropertyName = "dv";
            this.dvDataGridViewTextBoxColumn.HeaderText = "dv";
            this.dvDataGridViewTextBoxColumn.Name = "dvDataGridViewTextBoxColumn";
            this.dvDataGridViewTextBoxColumn.ReadOnly = true;
            this.dvDataGridViewTextBoxColumn.Visible = false;
            this.dvDataGridViewTextBoxColumn.Width = 42;
            // 
            // idTipoDocumentoDataGridViewTextBoxColumn
            // 
            this.idTipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "idTipoDocumento";
            this.idTipoDocumentoDataGridViewTextBoxColumn.HeaderText = "idTipoDocumento";
            this.idTipoDocumentoDataGridViewTextBoxColumn.Name = "idTipoDocumentoDataGridViewTextBoxColumn";
            this.idTipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoDocumentoDataGridViewTextBoxColumn.Visible = false;
            this.idTipoDocumentoDataGridViewTextBoxColumn.Width = 114;
            // 
            // idPersonaDataGridViewTextBoxColumn
            // 
            this.idPersonaDataGridViewTextBoxColumn.DataPropertyName = "idPersona";
            this.idPersonaDataGridViewTextBoxColumn.HeaderText = "idPersona";
            this.idPersonaDataGridViewTextBoxColumn.Name = "idPersonaDataGridViewTextBoxColumn";
            this.idPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonaDataGridViewTextBoxColumn.Visible = false;
            this.idPersonaDataGridViewTextBoxColumn.Width = 77;
            // 
            // nombre1DataGridViewTextBoxColumn
            // 
            this.nombre1DataGridViewTextBoxColumn.DataPropertyName = "nombre1";
            this.nombre1DataGridViewTextBoxColumn.HeaderText = "nombre1";
            this.nombre1DataGridViewTextBoxColumn.Name = "nombre1DataGridViewTextBoxColumn";
            this.nombre1DataGridViewTextBoxColumn.ReadOnly = true;
            this.nombre1DataGridViewTextBoxColumn.Visible = false;
            this.nombre1DataGridViewTextBoxColumn.Width = 71;
            // 
            // nombre2DataGridViewTextBoxColumn
            // 
            this.nombre2DataGridViewTextBoxColumn.DataPropertyName = "nombre2";
            this.nombre2DataGridViewTextBoxColumn.HeaderText = "nombre2";
            this.nombre2DataGridViewTextBoxColumn.Name = "nombre2DataGridViewTextBoxColumn";
            this.nombre2DataGridViewTextBoxColumn.ReadOnly = true;
            this.nombre2DataGridViewTextBoxColumn.Visible = false;
            this.nombre2DataGridViewTextBoxColumn.Width = 71;
            // 
            // apellido1DataGridViewTextBoxColumn
            // 
            this.apellido1DataGridViewTextBoxColumn.DataPropertyName = "apellido1";
            this.apellido1DataGridViewTextBoxColumn.HeaderText = "apellido1";
            this.apellido1DataGridViewTextBoxColumn.Name = "apellido1DataGridViewTextBoxColumn";
            this.apellido1DataGridViewTextBoxColumn.ReadOnly = true;
            this.apellido1DataGridViewTextBoxColumn.Visible = false;
            this.apellido1DataGridViewTextBoxColumn.Width = 72;
            // 
            // apellido2DataGridViewTextBoxColumn
            // 
            this.apellido2DataGridViewTextBoxColumn.DataPropertyName = "apellido2";
            this.apellido2DataGridViewTextBoxColumn.HeaderText = "apellido2";
            this.apellido2DataGridViewTextBoxColumn.Name = "apellido2DataGridViewTextBoxColumn";
            this.apellido2DataGridViewTextBoxColumn.ReadOnly = true;
            this.apellido2DataGridViewTextBoxColumn.Visible = false;
            this.apellido2DataGridViewTextBoxColumn.Width = 72;
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "razonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "Nombre completo";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razonSocialDataGridViewTextBoxColumn.Width = 103;
            // 
            // nombreComercialDataGridViewTextBoxColumn
            // 
            this.nombreComercialDataGridViewTextBoxColumn.DataPropertyName = "nombreComercial";
            this.nombreComercialDataGridViewTextBoxColumn.HeaderText = "Nombre comercial";
            this.nombreComercialDataGridViewTextBoxColumn.Name = "nombreComercialDataGridViewTextBoxColumn";
            this.nombreComercialDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreComercialDataGridViewTextBoxColumn.Width = 105;
            // 
            // codigoAlternoDataGridViewTextBoxColumn
            // 
            this.codigoAlternoDataGridViewTextBoxColumn.DataPropertyName = "codigoAlterno";
            this.codigoAlternoDataGridViewTextBoxColumn.HeaderText = "codigoAlterno";
            this.codigoAlternoDataGridViewTextBoxColumn.Name = "codigoAlternoDataGridViewTextBoxColumn";
            this.codigoAlternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoAlternoDataGridViewTextBoxColumn.Visible = false;
            this.codigoAlternoDataGridViewTextBoxColumn.Width = 95;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNacimientoDataGridViewTextBoxColumn.Visible = false;
            this.fechaNacimientoDataGridViewTextBoxColumn.Width = 110;
            // 
            // idOcupacionPerfilDataGridViewTextBoxColumn
            // 
            this.idOcupacionPerfilDataGridViewTextBoxColumn.DataPropertyName = "idOcupacionPerfil";
            this.idOcupacionPerfilDataGridViewTextBoxColumn.HeaderText = "Perfil";
            this.idOcupacionPerfilDataGridViewTextBoxColumn.Name = "idOcupacionPerfilDataGridViewTextBoxColumn";
            this.idOcupacionPerfilDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOcupacionPerfilDataGridViewTextBoxColumn.Width = 53;
            // 
            // idSexoDataGridViewTextBoxColumn
            // 
            this.idSexoDataGridViewTextBoxColumn.DataPropertyName = "idSexo";
            this.idSexoDataGridViewTextBoxColumn.HeaderText = "idSexo";
            this.idSexoDataGridViewTextBoxColumn.Name = "idSexoDataGridViewTextBoxColumn";
            this.idSexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSexoDataGridViewTextBoxColumn.Visible = false;
            this.idSexoDataGridViewTextBoxColumn.Width = 62;
            // 
            // tipoSangreDataGridViewTextBoxColumn
            // 
            this.tipoSangreDataGridViewTextBoxColumn.DataPropertyName = "tipoSangre";
            this.tipoSangreDataGridViewTextBoxColumn.HeaderText = "tipoSangre";
            this.tipoSangreDataGridViewTextBoxColumn.Name = "tipoSangreDataGridViewTextBoxColumn";
            this.tipoSangreDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoSangreDataGridViewTextBoxColumn.Visible = false;
            this.tipoSangreDataGridViewTextBoxColumn.Width = 81;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            this.telefono1DataGridViewTextBoxColumn.DataPropertyName = "telefono1";
            this.telefono1DataGridViewTextBoxColumn.HeaderText = "Teléfono1";
            this.telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            this.telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefono1DataGridViewTextBoxColumn.Width = 78;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            this.telefono2DataGridViewTextBoxColumn.DataPropertyName = "telefono2";
            this.telefono2DataGridViewTextBoxColumn.HeaderText = "telefono2";
            this.telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            this.telefono2DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefono2DataGridViewTextBoxColumn.Visible = false;
            this.telefono2DataGridViewTextBoxColumn.Width = 74;
            // 
            // telefono3DataGridViewTextBoxColumn
            // 
            this.telefono3DataGridViewTextBoxColumn.DataPropertyName = "telefono3";
            this.telefono3DataGridViewTextBoxColumn.HeaderText = "telefono3";
            this.telefono3DataGridViewTextBoxColumn.Name = "telefono3DataGridViewTextBoxColumn";
            this.telefono3DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefono3DataGridViewTextBoxColumn.Visible = false;
            this.telefono3DataGridViewTextBoxColumn.Width = 74;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            this.faxDataGridViewTextBoxColumn.Visible = false;
            this.faxDataGridViewTextBoxColumn.Width = 44;
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "correoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "correoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            this.correoElectronicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoElectronicoDataGridViewTextBoxColumn.Visible = false;
            this.correoElectronicoDataGridViewTextBoxColumn.Width = 113;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            this.direccionDataGridViewTextBoxColumn.Width = 73;
            // 
            // idDepartamentoDataGridViewTextBoxColumn
            // 
            this.idDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "idDepartamento";
            this.idDepartamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.idDepartamentoDataGridViewTextBoxColumn.Name = "idDepartamentoDataGridViewTextBoxColumn";
            this.idDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDepartamentoDataGridViewTextBoxColumn.Width = 97;
            // 
            // idMunicipioDataGridViewTextBoxColumn
            // 
            this.idMunicipioDataGridViewTextBoxColumn.DataPropertyName = "idMunicipio";
            this.idMunicipioDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.idMunicipioDataGridViewTextBoxColumn.Name = "idMunicipioDataGridViewTextBoxColumn";
            this.idMunicipioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMunicipioDataGridViewTextBoxColumn.Width = 75;
            // 
            // idEstadoCivilDataGridViewTextBoxColumn
            // 
            this.idEstadoCivilDataGridViewTextBoxColumn.DataPropertyName = "idEstadoCivil";
            this.idEstadoCivilDataGridViewTextBoxColumn.HeaderText = "idEstadoCivil";
            this.idEstadoCivilDataGridViewTextBoxColumn.Name = "idEstadoCivilDataGridViewTextBoxColumn";
            this.idEstadoCivilDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEstadoCivilDataGridViewTextBoxColumn.Visible = false;
            this.idEstadoCivilDataGridViewTextBoxColumn.Width = 90;
            // 
            // sitioWebDataGridViewTextBoxColumn
            // 
            this.sitioWebDataGridViewTextBoxColumn.DataPropertyName = "sitioWeb";
            this.sitioWebDataGridViewTextBoxColumn.HeaderText = "sitioWeb";
            this.sitioWebDataGridViewTextBoxColumn.Name = "sitioWebDataGridViewTextBoxColumn";
            this.sitioWebDataGridViewTextBoxColumn.ReadOnly = true;
            this.sitioWebDataGridViewTextBoxColumn.Visible = false;
            this.sitioWebDataGridViewTextBoxColumn.Width = 71;
            // 
            // esEmpleadoDataGridViewCheckBoxColumn
            // 
            this.esEmpleadoDataGridViewCheckBoxColumn.DataPropertyName = "esEmpleado";
            this.esEmpleadoDataGridViewCheckBoxColumn.HeaderText = "esEmpleado";
            this.esEmpleadoDataGridViewCheckBoxColumn.Name = "esEmpleadoDataGridViewCheckBoxColumn";
            this.esEmpleadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.esEmpleadoDataGridViewCheckBoxColumn.Visible = false;
            this.esEmpleadoDataGridViewCheckBoxColumn.Width = 69;
            // 
            // esClienteDataGridViewCheckBoxColumn
            // 
            this.esClienteDataGridViewCheckBoxColumn.DataPropertyName = "esCliente";
            this.esClienteDataGridViewCheckBoxColumn.HeaderText = "esCliente";
            this.esClienteDataGridViewCheckBoxColumn.Name = "esClienteDataGridViewCheckBoxColumn";
            this.esClienteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.esClienteDataGridViewCheckBoxColumn.Visible = false;
            this.esClienteDataGridViewCheckBoxColumn.Width = 54;
            // 
            // esProveedorDataGridViewCheckBoxColumn
            // 
            this.esProveedorDataGridViewCheckBoxColumn.DataPropertyName = "esProveedor";
            this.esProveedorDataGridViewCheckBoxColumn.HeaderText = "esProveedor";
            this.esProveedorDataGridViewCheckBoxColumn.Name = "esProveedorDataGridViewCheckBoxColumn";
            this.esProveedorDataGridViewCheckBoxColumn.ReadOnly = true;
            this.esProveedorDataGridViewCheckBoxColumn.Visible = false;
            this.esProveedorDataGridViewCheckBoxColumn.Width = 71;
            // 
            // esEpsDataGridViewCheckBoxColumn
            // 
            this.esEpsDataGridViewCheckBoxColumn.DataPropertyName = "esEps";
            this.esEpsDataGridViewCheckBoxColumn.HeaderText = "esEps";
            this.esEpsDataGridViewCheckBoxColumn.Name = "esEpsDataGridViewCheckBoxColumn";
            this.esEpsDataGridViewCheckBoxColumn.ReadOnly = true;
            this.esEpsDataGridViewCheckBoxColumn.Visible = false;
            this.esEpsDataGridViewCheckBoxColumn.Width = 40;
            // 
            // esAfpDataGridViewCheckBoxColumn
            // 
            this.esAfpDataGridViewCheckBoxColumn.DataPropertyName = "esAfp";
            this.esAfpDataGridViewCheckBoxColumn.HeaderText = "esAfp";
            this.esAfpDataGridViewCheckBoxColumn.Name = "esAfpDataGridViewCheckBoxColumn";
            this.esAfpDataGridViewCheckBoxColumn.ReadOnly = true;
            this.esAfpDataGridViewCheckBoxColumn.Visible = false;
            this.esAfpDataGridViewCheckBoxColumn.Width = 38;
            // 
            // esArlDataGridViewCheckBoxColumn
            // 
            this.esArlDataGridViewCheckBoxColumn.DataPropertyName = "esArl";
            this.esArlDataGridViewCheckBoxColumn.HeaderText = "esArl";
            this.esArlDataGridViewCheckBoxColumn.Name = "esArlDataGridViewCheckBoxColumn";
            this.esArlDataGridViewCheckBoxColumn.ReadOnly = true;
            this.esArlDataGridViewCheckBoxColumn.Visible = false;
            this.esArlDataGridViewCheckBoxColumn.Width = 34;
            // 
            // esCcfDataGridViewCheckBoxColumn
            // 
            this.esCcfDataGridViewCheckBoxColumn.DataPropertyName = "esCcf";
            this.esCcfDataGridViewCheckBoxColumn.HeaderText = "esCcf";
            this.esCcfDataGridViewCheckBoxColumn.Name = "esCcfDataGridViewCheckBoxColumn";
            this.esCcfDataGridViewCheckBoxColumn.ReadOnly = true;
            this.esCcfDataGridViewCheckBoxColumn.Visible = false;
            this.esCcfDataGridViewCheckBoxColumn.Width = 38;
            // 
            // esOtroDataGridViewCheckBoxColumn
            // 
            this.esOtroDataGridViewCheckBoxColumn.DataPropertyName = "esOtro";
            this.esOtroDataGridViewCheckBoxColumn.HeaderText = "esOtro";
            this.esOtroDataGridViewCheckBoxColumn.Name = "esOtroDataGridViewCheckBoxColumn";
            this.esOtroDataGridViewCheckBoxColumn.ReadOnly = true;
            this.esOtroDataGridViewCheckBoxColumn.Visible = false;
            this.esOtroDataGridViewCheckBoxColumn.Width = 42;
            // 
            // imagenDataGridViewTextBoxColumn
            // 
            this.imagenDataGridViewTextBoxColumn.DataPropertyName = "imagen";
            this.imagenDataGridViewTextBoxColumn.HeaderText = "imagen";
            this.imagenDataGridViewTextBoxColumn.Name = "imagenDataGridViewTextBoxColumn";
            this.imagenDataGridViewTextBoxColumn.ReadOnly = true;
            this.imagenDataGridViewTextBoxColumn.Visible = false;
            this.imagenDataGridViewTextBoxColumn.Width = 64;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            this.notasDataGridViewTextBoxColumn.Visible = false;
            this.notasDataGridViewTextBoxColumn.Width = 56;
            // 
            // responsableIvaDataGridViewCheckBoxColumn
            // 
            this.responsableIvaDataGridViewCheckBoxColumn.DataPropertyName = "responsableIva";
            this.responsableIvaDataGridViewCheckBoxColumn.HeaderText = "Responsable Iva";
            this.responsableIvaDataGridViewCheckBoxColumn.Name = "responsableIvaDataGridViewCheckBoxColumn";
            this.responsableIvaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.responsableIvaDataGridViewCheckBoxColumn.Width = 82;
            // 
            // vigenteDataGridViewCheckBoxColumn
            // 
            this.vigenteDataGridViewCheckBoxColumn.DataPropertyName = "vigente";
            this.vigenteDataGridViewCheckBoxColumn.HeaderText = "Vigente";
            this.vigenteDataGridViewCheckBoxColumn.Name = "vigenteDataGridViewCheckBoxColumn";
            this.vigenteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.vigenteDataGridViewCheckBoxColumn.Width = 47;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Visible = false;
            this.idUsuarioDataGridViewTextBoxColumn.Width = 74;
            // 
            // frmTercero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.dataGridViewPrincipal);
            this.Controls.Add(this.labelNombreFormulario);
            this.Name = "frmTercero";
            this.Text = "frmTercero";
            this.Load += new System.EventHandler(this.frmTercero_Load);
            this.Controls.SetChildIndex(this.labelNombreFormulario, 0);
            this.Controls.SetChildIndex(this.buttonFormCerrar, 0);
            this.Controls.SetChildIndex(this.buttonFormCancelar, 0);
            this.Controls.SetChildIndex(this.buttonFormGuardar, 0);
            this.Controls.SetChildIndex(this.buttonFormBuscar, 0);
            this.Controls.SetChildIndex(this.buttonFormNuevo, 0);
            this.Controls.SetChildIndex(this.buttonFormEditar, 0);
            this.Controls.SetChildIndex(this.buttonFormBorrar, 0);
            this.Controls.SetChildIndex(this.buttonPrimerRegistro, 0);
            this.Controls.SetChildIndex(this.buttonAnteriorRegistro, 0);
            this.Controls.SetChildIndex(this.buttonSiguienteRegistro, 0);
            this.Controls.SetChildIndex(this.buttonUltimoRegistro, 0);
            this.Controls.SetChildIndex(this.dataGridViewPrincipal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSiscad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNombreFormulario;
        public System.Windows.Forms.DataGridView dataGridViewPrincipal;
        private DSSiscad dSSiscad;
        private System.Windows.Forms.BindingSource terceroBindingSource;
        private DSSiscadTableAdapters.terceroTableAdapter terceroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTerceroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAlternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOcupacionPerfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSangreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitioWebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esEmpleadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esClienteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esProveedorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esEpsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esAfpDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esArlDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esCcfDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esOtroDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn responsableIvaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vigenteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
    }
}