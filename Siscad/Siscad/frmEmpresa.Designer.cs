namespace Siscad
{
    partial class frmEmpresa
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
            System.Windows.Forms.Label numeroDocumentoLabel;
            System.Windows.Forms.Label dvLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label nombreComercialLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label idDepartamentoLabel;
            System.Windows.Forms.Label idMunicipioLabel;
            System.Windows.Forms.Label telefono1Label;
            System.Windows.Forms.Label idTerceroArlLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label sitioWebLabel;
            System.Windows.Forms.Label idTerceroRepresentanteLabel;
            System.Windows.Forms.Label fechaConstitucionLabel;
            System.Windows.Forms.Label resolucionFacturacionLabel;
            System.Windows.Forms.Label fechaResolucionFacturacionLabel;
            System.Windows.Forms.Label vigenciaResolucionLabel;
            System.Windows.Forms.Label matriculaMercantilLabel;
            System.Windows.Forms.Label escrituraConstitucionLabel;
            System.Windows.Forms.Label facturaAutorizadaDesdeLabel;
            System.Windows.Forms.Label facturaAutorizadaHastaLabel;
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelSubMenuSuperior = new System.Windows.Forms.Panel();
            this.panelSubContenedor = new System.Windows.Forms.Panel();
            this.facturaAutorizadaHastaTextBox = new System.Windows.Forms.TextBox();
            this.datosEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSiscad = new Siscad.DSSiscad();
            this.facturaAutorizadaDesdeTextBox = new System.Windows.Forms.TextBox();
            this.escrituraConstitucionTextBox = new System.Windows.Forms.TextBox();
            this.matriculaMercantilTextBox = new System.Windows.Forms.TextBox();
            this.labelResolucionFacturacion = new System.Windows.Forms.Label();
            this.labelOtrosDatos = new System.Windows.Forms.Label();
            this.labelContacto = new System.Windows.Forms.Label();
            this.vigenciaResolucionTextBox = new System.Windows.Forms.TextBox();
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.numeroDocumentoTextBox = new System.Windows.Forms.TextBox();
            this.fechaResolucionFacturacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.resolucionFacturacionTextBox = new System.Windows.Forms.TextBox();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.fechaConstitucionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelCerrarVentana = new System.Windows.Forms.Label();
            this.idTerceroRepresentanteComboBox = new System.Windows.Forms.ComboBox();
            this.terceroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreComercialTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.idTerceroArlComboBox = new System.Windows.Forms.ComboBox();
            this.sitioWebTextBox = new System.Windows.Forms.TextBox();
            this.idDepartamentoComboBox = new System.Windows.Forms.ComboBox();
            this.secDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.idMunicipioComboBox = new System.Windows.Forms.ComboBox();
            this.secMunicipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefono1TextBox = new System.Windows.Forms.TextBox();
            this.telefono2TextBox = new System.Windows.Forms.TextBox();
            this.dvTextBox = new System.Windows.Forms.TextBox();
            this.buttonCerrarVentana = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.logoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.datosEmpresaTableAdapter = new Siscad.DSSiscadTableAdapters.datosEmpresaTableAdapter();
            this.tableAdapterManager = new Siscad.DSSiscadTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.secDepartamentoTableAdapter = new Siscad.DSSiscadTableAdapters.secDepartamentoTableAdapter();
            this.secMunicipioTableAdapter = new Siscad.DSSiscadTableAdapters.secMunicipioTableAdapter();
            this.terceroTableAdapter = new Siscad.DSSiscadTableAdapters.terceroTableAdapter();
            numeroDocumentoLabel = new System.Windows.Forms.Label();
            dvLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            nombreComercialLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            idDepartamentoLabel = new System.Windows.Forms.Label();
            idMunicipioLabel = new System.Windows.Forms.Label();
            telefono1Label = new System.Windows.Forms.Label();
            idTerceroArlLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            sitioWebLabel = new System.Windows.Forms.Label();
            idTerceroRepresentanteLabel = new System.Windows.Forms.Label();
            fechaConstitucionLabel = new System.Windows.Forms.Label();
            resolucionFacturacionLabel = new System.Windows.Forms.Label();
            fechaResolucionFacturacionLabel = new System.Windows.Forms.Label();
            vigenciaResolucionLabel = new System.Windows.Forms.Label();
            matriculaMercantilLabel = new System.Windows.Forms.Label();
            escrituraConstitucionLabel = new System.Windows.Forms.Label();
            facturaAutorizadaDesdeLabel = new System.Windows.Forms.Label();
            facturaAutorizadaHastaLabel = new System.Windows.Forms.Label();
            this.panelSubMenuSuperior.SuspendLayout();
            this.panelSubContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSiscad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secDepartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secMunicipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroDocumentoLabel
            // 
            numeroDocumentoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            numeroDocumentoLabel.AutoSize = true;
            numeroDocumentoLabel.ForeColor = System.Drawing.SystemColors.Control;
            numeroDocumentoLabel.Location = new System.Drawing.Point(114, 279);
            numeroDocumentoLabel.Name = "numeroDocumentoLabel";
            numeroDocumentoLabel.Size = new System.Drawing.Size(30, 13);
            numeroDocumentoLabel.TabIndex = 5;
            numeroDocumentoLabel.Text = "Nit *:";
            // 
            // dvLabel
            // 
            dvLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dvLabel.AutoSize = true;
            dvLabel.ForeColor = System.Drawing.SystemColors.Control;
            dvLabel.Location = new System.Drawing.Point(301, 280);
            dvLabel.Name = "dvLabel";
            dvLabel.Size = new System.Drawing.Size(10, 13);
            dvLabel.TabIndex = 7;
            dvLabel.Text = "-";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.ForeColor = System.Drawing.SystemColors.Control;
            razonSocialLabel.Location = new System.Drawing.Point(66, 312);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(78, 13);
            razonSocialLabel.TabIndex = 9;
            razonSocialLabel.Text = "Razón social *:";
            // 
            // nombreComercialLabel
            // 
            nombreComercialLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nombreComercialLabel.AutoSize = true;
            nombreComercialLabel.ForeColor = System.Drawing.SystemColors.Control;
            nombreComercialLabel.Location = new System.Drawing.Point(49, 345);
            nombreComercialLabel.Name = "nombreComercialLabel";
            nombreComercialLabel.Size = new System.Drawing.Size(95, 13);
            nombreComercialLabel.TabIndex = 11;
            nombreComercialLabel.Text = "Nombre comercial:";
            // 
            // direccionLabel
            // 
            direccionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            direccionLabel.AutoSize = true;
            direccionLabel.ForeColor = System.Drawing.SystemColors.Control;
            direccionLabel.Location = new System.Drawing.Point(89, 443);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 14;
            direccionLabel.Text = "Dirección:";
            // 
            // idDepartamentoLabel
            // 
            idDepartamentoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            idDepartamentoLabel.AutoSize = true;
            idDepartamentoLabel.ForeColor = System.Drawing.SystemColors.Control;
            idDepartamentoLabel.Location = new System.Drawing.Point(67, 476);
            idDepartamentoLabel.Name = "idDepartamentoLabel";
            idDepartamentoLabel.Size = new System.Drawing.Size(77, 13);
            idDepartamentoLabel.TabIndex = 16;
            idDepartamentoLabel.Text = "Departamento:";
            // 
            // idMunicipioLabel
            // 
            idMunicipioLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            idMunicipioLabel.AutoSize = true;
            idMunicipioLabel.ForeColor = System.Drawing.SystemColors.Control;
            idMunicipioLabel.Location = new System.Drawing.Point(89, 510);
            idMunicipioLabel.Name = "idMunicipioLabel";
            idMunicipioLabel.Size = new System.Drawing.Size(55, 13);
            idMunicipioLabel.TabIndex = 18;
            idMunicipioLabel.Text = "Municipio:";
            // 
            // telefono1Label
            // 
            telefono1Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            telefono1Label.AutoSize = true;
            telefono1Label.ForeColor = System.Drawing.SystemColors.Control;
            telefono1Label.Location = new System.Drawing.Point(87, 610);
            telefono1Label.Name = "telefono1Label";
            telefono1Label.Size = new System.Drawing.Size(57, 13);
            telefono1Label.TabIndex = 21;
            telefono1Label.Text = "Teléfonos:";
            // 
            // idTerceroArlLabel
            // 
            idTerceroArlLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            idTerceroArlLabel.AutoSize = true;
            idTerceroArlLabel.ForeColor = System.Drawing.SystemColors.Control;
            idTerceroArlLabel.Location = new System.Drawing.Point(684, 397);
            idTerceroArlLabel.Name = "idTerceroArlLabel";
            idTerceroArlLabel.Size = new System.Drawing.Size(22, 13);
            idTerceroArlLabel.TabIndex = 31;
            idTerceroArlLabel.Text = "Arl:";
            // 
            // correoLabel
            // 
            correoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            correoLabel.AutoSize = true;
            correoLabel.ForeColor = System.Drawing.SystemColors.Control;
            correoLabel.Location = new System.Drawing.Point(103, 646);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 24;
            correoLabel.Text = "Correo:";
            // 
            // sitioWebLabel
            // 
            sitioWebLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            sitioWebLabel.AutoSize = true;
            sitioWebLabel.ForeColor = System.Drawing.SystemColors.Control;
            sitioWebLabel.Location = new System.Drawing.Point(91, 684);
            sitioWebLabel.Name = "sitioWebLabel";
            sitioWebLabel.Size = new System.Drawing.Size(53, 13);
            sitioWebLabel.TabIndex = 26;
            sitioWebLabel.Text = "Sitio web:";
            // 
            // idTerceroRepresentanteLabel
            // 
            idTerceroRepresentanteLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            idTerceroRepresentanteLabel.AutoSize = true;
            idTerceroRepresentanteLabel.ForeColor = System.Drawing.SystemColors.Control;
            idTerceroRepresentanteLabel.Location = new System.Drawing.Point(601, 434);
            idTerceroRepresentanteLabel.Name = "idTerceroRepresentanteLabel";
            idTerceroRepresentanteLabel.Size = new System.Drawing.Size(105, 13);
            idTerceroRepresentanteLabel.TabIndex = 33;
            idTerceroRepresentanteLabel.Text = "Representante legal:";
            // 
            // fechaConstitucionLabel
            // 
            fechaConstitucionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            fechaConstitucionLabel.AutoSize = true;
            fechaConstitucionLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaConstitucionLabel.Location = new System.Drawing.Point(591, 474);
            fechaConstitucionLabel.Name = "fechaConstitucionLabel";
            fechaConstitucionLabel.Size = new System.Drawing.Size(115, 13);
            fechaConstitucionLabel.TabIndex = 35;
            fechaConstitucionLabel.Text = "Fecha de constitución:";
            // 
            // resolucionFacturacionLabel
            // 
            resolucionFacturacionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            resolucionFacturacionLabel.AutoSize = true;
            resolucionFacturacionLabel.ForeColor = System.Drawing.SystemColors.Control;
            resolucionFacturacionLabel.Location = new System.Drawing.Point(695, 613);
            resolucionFacturacionLabel.Name = "resolucionFacturacionLabel";
            resolucionFacturacionLabel.Size = new System.Drawing.Size(78, 13);
            resolucionFacturacionLabel.TabIndex = 42;
            resolucionFacturacionLabel.Text = "Resolución Nº:";
            // 
            // fechaResolucionFacturacionLabel
            // 
            fechaResolucionFacturacionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            fechaResolucionFacturacionLabel.AutoSize = true;
            fechaResolucionFacturacionLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaResolucionFacturacionLabel.Location = new System.Drawing.Point(667, 650);
            fechaResolucionFacturacionLabel.Name = "fechaResolucionFacturacionLabel";
            fechaResolucionFacturacionLabel.Size = new System.Drawing.Size(106, 13);
            fechaResolucionFacturacionLabel.TabIndex = 44;
            fechaResolucionFacturacionLabel.Text = "Fecha de resolución:";
            // 
            // vigenciaResolucionLabel
            // 
            vigenciaResolucionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            vigenciaResolucionLabel.AutoSize = true;
            vigenciaResolucionLabel.ForeColor = System.Drawing.SystemColors.Control;
            vigenciaResolucionLabel.Location = new System.Drawing.Point(883, 648);
            vigenciaResolucionLabel.Name = "vigenciaResolucionLabel";
            vigenciaResolucionLabel.Size = new System.Drawing.Size(90, 13);
            vigenciaResolucionLabel.TabIndex = 46;
            vigenciaResolucionLabel.Text = "Vigencia en días:";
            // 
            // matriculaMercantilLabel
            // 
            matriculaMercantilLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            matriculaMercantilLabel.AutoSize = true;
            matriculaMercantilLabel.ForeColor = System.Drawing.SystemColors.Control;
            matriculaMercantilLabel.Location = new System.Drawing.Point(606, 508);
            matriculaMercantilLabel.Name = "matriculaMercantilLabel";
            matriculaMercantilLabel.Size = new System.Drawing.Size(100, 13);
            matriculaMercantilLabel.TabIndex = 37;
            matriculaMercantilLabel.Text = "Matrícula mercantil:";
            // 
            // escrituraConstitucionLabel
            // 
            escrituraConstitucionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            escrituraConstitucionLabel.AutoSize = true;
            escrituraConstitucionLabel.ForeColor = System.Drawing.SystemColors.Control;
            escrituraConstitucionLabel.Location = new System.Drawing.Point(890, 508);
            escrituraConstitucionLabel.Name = "escrituraConstitucionLabel";
            escrituraConstitucionLabel.Size = new System.Drawing.Size(66, 13);
            escrituraConstitucionLabel.TabIndex = 39;
            escrituraConstitucionLabel.Text = "Escritura Nº:";
            // 
            // facturaAutorizadaDesdeLabel
            // 
            facturaAutorizadaDesdeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            facturaAutorizadaDesdeLabel.AutoSize = true;
            facturaAutorizadaDesdeLabel.ForeColor = System.Drawing.SystemColors.Control;
            facturaAutorizadaDesdeLabel.Location = new System.Drawing.Point(633, 684);
            facturaAutorizadaDesdeLabel.Name = "facturaAutorizadaDesdeLabel";
            facturaAutorizadaDesdeLabel.Size = new System.Drawing.Size(140, 13);
            facturaAutorizadaDesdeLabel.TabIndex = 48;
            facturaAutorizadaDesdeLabel.Text = "Facturas autorizadas desde:";
            // 
            // facturaAutorizadaHastaLabel
            // 
            facturaAutorizadaHastaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            facturaAutorizadaHastaLabel.AutoSize = true;
            facturaAutorizadaHastaLabel.ForeColor = System.Drawing.SystemColors.Control;
            facturaAutorizadaHastaLabel.Location = new System.Drawing.Point(885, 684);
            facturaAutorizadaHastaLabel.Name = "facturaAutorizadaHastaLabel";
            facturaAutorizadaHastaLabel.Size = new System.Drawing.Size(38, 13);
            facturaAutorizadaHastaLabel.TabIndex = 50;
            facturaAutorizadaHastaLabel.Text = "Hasta:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.labelTitulo.Location = new System.Drawing.Point(3, 3);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(296, 33);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Información de la Empresa";
            // 
            // panelSubMenuSuperior
            // 
            this.panelSubMenuSuperior.BackColor = System.Drawing.SystemColors.Control;
            this.panelSubMenuSuperior.Controls.Add(this.labelTitulo);
            this.panelSubMenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSubMenuSuperior.Name = "panelSubMenuSuperior";
            this.panelSubMenuSuperior.Size = new System.Drawing.Size(1096, 40);
            this.panelSubMenuSuperior.TabIndex = 0;
            // 
            // panelSubContenedor
            // 
            this.panelSubContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSubContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.panelSubContenedor.Controls.Add(facturaAutorizadaHastaLabel);
            this.panelSubContenedor.Controls.Add(this.facturaAutorizadaHastaTextBox);
            this.panelSubContenedor.Controls.Add(facturaAutorizadaDesdeLabel);
            this.panelSubContenedor.Controls.Add(this.facturaAutorizadaDesdeTextBox);
            this.panelSubContenedor.Controls.Add(escrituraConstitucionLabel);
            this.panelSubContenedor.Controls.Add(this.escrituraConstitucionTextBox);
            this.panelSubContenedor.Controls.Add(matriculaMercantilLabel);
            this.panelSubContenedor.Controls.Add(this.matriculaMercantilTextBox);
            this.panelSubContenedor.Controls.Add(this.labelResolucionFacturacion);
            this.panelSubContenedor.Controls.Add(this.labelOtrosDatos);
            this.panelSubContenedor.Controls.Add(vigenciaResolucionLabel);
            this.panelSubContenedor.Controls.Add(this.labelContacto);
            this.panelSubContenedor.Controls.Add(this.vigenciaResolucionTextBox);
            this.panelSubContenedor.Controls.Add(this.labelUbicacion);
            this.panelSubContenedor.Controls.Add(fechaResolucionFacturacionLabel);
            this.panelSubContenedor.Controls.Add(this.numeroDocumentoTextBox);
            this.panelSubContenedor.Controls.Add(this.fechaResolucionFacturacionDateTimePicker);
            this.panelSubContenedor.Controls.Add(this.labelIdentificacion);
            this.panelSubContenedor.Controls.Add(resolucionFacturacionLabel);
            this.panelSubContenedor.Controls.Add(numeroDocumentoLabel);
            this.panelSubContenedor.Controls.Add(this.resolucionFacturacionTextBox);
            this.panelSubContenedor.Controls.Add(this.buttonLogo);
            this.panelSubContenedor.Controls.Add(fechaConstitucionLabel);
            this.panelSubContenedor.Controls.Add(this.razonSocialTextBox);
            this.panelSubContenedor.Controls.Add(this.fechaConstitucionDateTimePicker);
            this.panelSubContenedor.Controls.Add(idTerceroRepresentanteLabel);
            this.panelSubContenedor.Controls.Add(this.labelCerrarVentana);
            this.panelSubContenedor.Controls.Add(this.idTerceroRepresentanteComboBox);
            this.panelSubContenedor.Controls.Add(this.nombreComercialTextBox);
            this.panelSubContenedor.Controls.Add(idTerceroArlLabel);
            this.panelSubContenedor.Controls.Add(this.direccionTextBox);
            this.panelSubContenedor.Controls.Add(this.idTerceroArlComboBox);
            this.panelSubContenedor.Controls.Add(sitioWebLabel);
            this.panelSubContenedor.Controls.Add(razonSocialLabel);
            this.panelSubContenedor.Controls.Add(this.sitioWebTextBox);
            this.panelSubContenedor.Controls.Add(this.idDepartamentoComboBox);
            this.panelSubContenedor.Controls.Add(correoLabel);
            this.panelSubContenedor.Controls.Add(direccionLabel);
            this.panelSubContenedor.Controls.Add(this.correoTextBox);
            this.panelSubContenedor.Controls.Add(this.idMunicipioComboBox);
            this.panelSubContenedor.Controls.Add(this.telefono1TextBox);
            this.panelSubContenedor.Controls.Add(idDepartamentoLabel);
            this.panelSubContenedor.Controls.Add(this.telefono2TextBox);
            this.panelSubContenedor.Controls.Add(telefono1Label);
            this.panelSubContenedor.Controls.Add(idMunicipioLabel);
            this.panelSubContenedor.Controls.Add(nombreComercialLabel);
            this.panelSubContenedor.Controls.Add(this.dvTextBox);
            this.panelSubContenedor.Controls.Add(this.buttonCerrarVentana);
            this.panelSubContenedor.Controls.Add(this.pictureBoxLogo);
            this.panelSubContenedor.Controls.Add(dvLabel);
            this.panelSubContenedor.Controls.Add(this.logoTextBox);
            this.panelSubContenedor.Controls.Add(this.bindingNavigator);
            this.panelSubContenedor.Controls.Add(this.panelSubMenuSuperior);
            this.panelSubContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelSubContenedor.Name = "panelSubContenedor";
            this.panelSubContenedor.Size = new System.Drawing.Size(1096, 800);
            this.panelSubContenedor.TabIndex = 0;
            // 
            // facturaAutorizadaHastaTextBox
            // 
            this.facturaAutorizadaHastaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facturaAutorizadaHastaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "facturaAutorizadaHasta", true));
            this.facturaAutorizadaHastaTextBox.Location = new System.Drawing.Point(929, 681);
            this.facturaAutorizadaHastaTextBox.Name = "facturaAutorizadaHastaTextBox";
            this.facturaAutorizadaHastaTextBox.Size = new System.Drawing.Size(100, 20);
            this.facturaAutorizadaHastaTextBox.TabIndex = 51;
            // 
            // datosEmpresaBindingSource
            // 
            this.datosEmpresaBindingSource.DataMember = "datosEmpresa";
            this.datosEmpresaBindingSource.DataSource = this.dSSiscad;
            // 
            // dSSiscad
            // 
            this.dSSiscad.DataSetName = "DSSiscad";
            this.dSSiscad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaAutorizadaDesdeTextBox
            // 
            this.facturaAutorizadaDesdeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facturaAutorizadaDesdeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "facturaAutorizadaDesde", true));
            this.facturaAutorizadaDesdeTextBox.Location = new System.Drawing.Point(779, 681);
            this.facturaAutorizadaDesdeTextBox.Name = "facturaAutorizadaDesdeTextBox";
            this.facturaAutorizadaDesdeTextBox.Size = new System.Drawing.Size(100, 20);
            this.facturaAutorizadaDesdeTextBox.TabIndex = 49;
            // 
            // escrituraConstitucionTextBox
            // 
            this.escrituraConstitucionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.escrituraConstitucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "escrituraConstitucion", true));
            this.escrituraConstitucionTextBox.Location = new System.Drawing.Point(962, 505);
            this.escrituraConstitucionTextBox.Name = "escrituraConstitucionTextBox";
            this.escrituraConstitucionTextBox.Size = new System.Drawing.Size(100, 20);
            this.escrituraConstitucionTextBox.TabIndex = 40;
            // 
            // matriculaMercantilTextBox
            // 
            this.matriculaMercantilTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.matriculaMercantilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "matriculaMercantil", true));
            this.matriculaMercantilTextBox.Location = new System.Drawing.Point(712, 505);
            this.matriculaMercantilTextBox.Name = "matriculaMercantilTextBox";
            this.matriculaMercantilTextBox.Size = new System.Drawing.Size(150, 20);
            this.matriculaMercantilTextBox.TabIndex = 38;
            // 
            // labelResolucionFacturacion
            // 
            this.labelResolucionFacturacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelResolucionFacturacion.AutoSize = true;
            this.labelResolucionFacturacion.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolucionFacturacion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResolucionFacturacion.Location = new System.Drawing.Point(677, 565);
            this.labelResolucionFacturacion.Name = "labelResolucionFacturacion";
            this.labelResolucionFacturacion.Size = new System.Drawing.Size(211, 22);
            this.labelResolucionFacturacion.TabIndex = 41;
            this.labelResolucionFacturacion.Text = "Resolución de facturación";
            // 
            // labelOtrosDatos
            // 
            this.labelOtrosDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOtrosDatos.AutoSize = true;
            this.labelOtrosDatos.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtrosDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.labelOtrosDatos.Location = new System.Drawing.Point(661, 356);
            this.labelOtrosDatos.Name = "labelOtrosDatos";
            this.labelOtrosDatos.Size = new System.Drawing.Size(98, 22);
            this.labelOtrosDatos.TabIndex = 30;
            this.labelOtrosDatos.Text = "Otros datos";
            // 
            // labelContacto
            // 
            this.labelContacto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelContacto.AutoSize = true;
            this.labelContacto.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContacto.ForeColor = System.Drawing.SystemColors.Control;
            this.labelContacto.Location = new System.Drawing.Point(87, 567);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(80, 22);
            this.labelContacto.TabIndex = 20;
            this.labelContacto.Text = "Contacto";
            // 
            // vigenciaResolucionTextBox
            // 
            this.vigenciaResolucionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vigenciaResolucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "vigenciaResolucion", true));
            this.vigenciaResolucionTextBox.Location = new System.Drawing.Point(979, 644);
            this.vigenciaResolucionTextBox.Name = "vigenciaResolucionTextBox";
            this.vigenciaResolucionTextBox.ReadOnly = true;
            this.vigenciaResolucionTextBox.Size = new System.Drawing.Size(50, 20);
            this.vigenciaResolucionTextBox.TabIndex = 47;
            this.vigenciaResolucionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbicacion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUbicacion.Location = new System.Drawing.Point(87, 396);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(90, 22);
            this.labelUbicacion.TabIndex = 13;
            this.labelUbicacion.Text = "Ubicación";
            // 
            // numeroDocumentoTextBox
            // 
            this.numeroDocumentoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numeroDocumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "numeroDocumento", true));
            this.numeroDocumentoTextBox.Location = new System.Drawing.Point(150, 276);
            this.numeroDocumentoTextBox.Name = "numeroDocumentoTextBox";
            this.numeroDocumentoTextBox.ReadOnly = true;
            this.numeroDocumentoTextBox.Size = new System.Drawing.Size(150, 20);
            this.numeroDocumentoTextBox.TabIndex = 6;
            this.numeroDocumentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fechaResolucionFacturacionDateTimePicker
            // 
            this.fechaResolucionFacturacionDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fechaResolucionFacturacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datosEmpresaBindingSource, "fechaResolucionFacturacion", true));
            this.fechaResolucionFacturacionDateTimePicker.Enabled = false;
            this.fechaResolucionFacturacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaResolucionFacturacionDateTimePicker.Location = new System.Drawing.Point(779, 644);
            this.fechaResolucionFacturacionDateTimePicker.Name = "fechaResolucionFacturacionDateTimePicker";
            this.fechaResolucionFacturacionDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaResolucionFacturacionDateTimePicker.TabIndex = 45;
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentificacion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIdentificacion.Location = new System.Drawing.Point(87, 230);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(120, 22);
            this.labelIdentificacion.TabIndex = 4;
            this.labelIdentificacion.Text = "Identificación";
            // 
            // resolucionFacturacionTextBox
            // 
            this.resolucionFacturacionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resolucionFacturacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "resolucionFacturacion", true));
            this.resolucionFacturacionTextBox.Location = new System.Drawing.Point(779, 610);
            this.resolucionFacturacionTextBox.Name = "resolucionFacturacionTextBox";
            this.resolucionFacturacionTextBox.ReadOnly = true;
            this.resolucionFacturacionTextBox.Size = new System.Drawing.Size(250, 20);
            this.resolucionFacturacionTextBox.TabIndex = 43;
            // 
            // buttonLogo
            // 
            this.buttonLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogo.Location = new System.Drawing.Point(831, 148);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(75, 23);
            this.buttonLogo.TabIndex = 28;
            this.buttonLogo.Text = "Logo...";
            this.buttonLogo.UseVisualStyleBackColor = true;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "razonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(150, 309);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.ReadOnly = true;
            this.razonSocialTextBox.Size = new System.Drawing.Size(400, 20);
            this.razonSocialTextBox.TabIndex = 10;
            // 
            // fechaConstitucionDateTimePicker
            // 
            this.fechaConstitucionDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fechaConstitucionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datosEmpresaBindingSource, "fechaConstitucion", true));
            this.fechaConstitucionDateTimePicker.Enabled = false;
            this.fechaConstitucionDateTimePicker.Location = new System.Drawing.Point(712, 468);
            this.fechaConstitucionDateTimePicker.Name = "fechaConstitucionDateTimePicker";
            this.fechaConstitucionDateTimePicker.Size = new System.Drawing.Size(350, 20);
            this.fechaConstitucionDateTimePicker.TabIndex = 36;
            // 
            // labelCerrarVentana
            // 
            this.labelCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCerrarVentana.AutoSize = true;
            this.labelCerrarVentana.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCerrarVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCerrarVentana.ForeColor = System.Drawing.Color.Gray;
            this.labelCerrarVentana.Location = new System.Drawing.Point(979, 86);
            this.labelCerrarVentana.Name = "labelCerrarVentana";
            this.labelCerrarVentana.Size = new System.Drawing.Size(87, 15);
            this.labelCerrarVentana.TabIndex = 3;
            this.labelCerrarVentana.Text = "Cerrar ventana";
            this.labelCerrarVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCerrarVentana.Visible = false;
            // 
            // idTerceroRepresentanteComboBox
            // 
            this.idTerceroRepresentanteComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idTerceroRepresentanteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idTerceroRepresentanteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idTerceroRepresentanteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.datosEmpresaBindingSource, "idTerceroRepresentante", true));
            this.idTerceroRepresentanteComboBox.DataSource = this.terceroBindingSource;
            this.idTerceroRepresentanteComboBox.DisplayMember = "razonSocial";
            this.idTerceroRepresentanteComboBox.Enabled = false;
            this.idTerceroRepresentanteComboBox.FormattingEnabled = true;
            this.idTerceroRepresentanteComboBox.Location = new System.Drawing.Point(712, 431);
            this.idTerceroRepresentanteComboBox.Name = "idTerceroRepresentanteComboBox";
            this.idTerceroRepresentanteComboBox.Size = new System.Drawing.Size(350, 21);
            this.idTerceroRepresentanteComboBox.TabIndex = 34;
            this.idTerceroRepresentanteComboBox.ValueMember = "idTercero";
            // 
            // terceroBindingSource
            // 
            this.terceroBindingSource.DataMember = "tercero";
            this.terceroBindingSource.DataSource = this.dSSiscad;
            // 
            // nombreComercialTextBox
            // 
            this.nombreComercialTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nombreComercialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "nombreComercial", true));
            this.nombreComercialTextBox.Location = new System.Drawing.Point(150, 342);
            this.nombreComercialTextBox.Name = "nombreComercialTextBox";
            this.nombreComercialTextBox.ReadOnly = true;
            this.nombreComercialTextBox.Size = new System.Drawing.Size(400, 20);
            this.nombreComercialTextBox.TabIndex = 12;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(150, 440);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.ReadOnly = true;
            this.direccionTextBox.Size = new System.Drawing.Size(400, 20);
            this.direccionTextBox.TabIndex = 15;
            // 
            // idTerceroArlComboBox
            // 
            this.idTerceroArlComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idTerceroArlComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idTerceroArlComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idTerceroArlComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.datosEmpresaBindingSource, "idTerceroArl", true));
            this.idTerceroArlComboBox.DataSource = this.terceroBindingSource;
            this.idTerceroArlComboBox.DisplayMember = "razonSocial";
            this.idTerceroArlComboBox.Enabled = false;
            this.idTerceroArlComboBox.FormattingEnabled = true;
            this.idTerceroArlComboBox.Location = new System.Drawing.Point(712, 394);
            this.idTerceroArlComboBox.Name = "idTerceroArlComboBox";
            this.idTerceroArlComboBox.Size = new System.Drawing.Size(350, 21);
            this.idTerceroArlComboBox.TabIndex = 32;
            this.idTerceroArlComboBox.ValueMember = "idTercero";
            // 
            // sitioWebTextBox
            // 
            this.sitioWebTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sitioWebTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "sitioWeb", true));
            this.sitioWebTextBox.Location = new System.Drawing.Point(150, 681);
            this.sitioWebTextBox.Name = "sitioWebTextBox";
            this.sitioWebTextBox.ReadOnly = true;
            this.sitioWebTextBox.Size = new System.Drawing.Size(400, 20);
            this.sitioWebTextBox.TabIndex = 27;
            // 
            // idDepartamentoComboBox
            // 
            this.idDepartamentoComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idDepartamentoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idDepartamentoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idDepartamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.datosEmpresaBindingSource, "idDepartamento", true));
            this.idDepartamentoComboBox.DataSource = this.secDepartamentoBindingSource;
            this.idDepartamentoComboBox.DisplayMember = "departamento";
            this.idDepartamentoComboBox.Enabled = false;
            this.idDepartamentoComboBox.FormattingEnabled = true;
            this.idDepartamentoComboBox.Location = new System.Drawing.Point(150, 473);
            this.idDepartamentoComboBox.Name = "idDepartamentoComboBox";
            this.idDepartamentoComboBox.Size = new System.Drawing.Size(400, 21);
            this.idDepartamentoComboBox.TabIndex = 17;
            this.idDepartamentoComboBox.ValueMember = "idDepartamento";
            // 
            // secDepartamentoBindingSource
            // 
            this.secDepartamentoBindingSource.DataMember = "secDepartamento";
            this.secDepartamentoBindingSource.DataSource = this.dSSiscad;
            // 
            // correoTextBox
            // 
            this.correoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(150, 644);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.ReadOnly = true;
            this.correoTextBox.Size = new System.Drawing.Size(400, 20);
            this.correoTextBox.TabIndex = 25;
            // 
            // idMunicipioComboBox
            // 
            this.idMunicipioComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idMunicipioComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idMunicipioComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idMunicipioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.datosEmpresaBindingSource, "idMunicipio", true));
            this.idMunicipioComboBox.DataSource = this.secMunicipioBindingSource;
            this.idMunicipioComboBox.DisplayMember = "municipio";
            this.idMunicipioComboBox.Enabled = false;
            this.idMunicipioComboBox.FormattingEnabled = true;
            this.idMunicipioComboBox.Location = new System.Drawing.Point(150, 507);
            this.idMunicipioComboBox.Name = "idMunicipioComboBox";
            this.idMunicipioComboBox.Size = new System.Drawing.Size(400, 21);
            this.idMunicipioComboBox.TabIndex = 19;
            this.idMunicipioComboBox.ValueMember = "idMunicipio";
            // 
            // secMunicipioBindingSource
            // 
            this.secMunicipioBindingSource.DataMember = "secMunicipio";
            this.secMunicipioBindingSource.DataSource = this.dSSiscad;
            // 
            // telefono1TextBox
            // 
            this.telefono1TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.telefono1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "telefono1", true));
            this.telefono1TextBox.Location = new System.Drawing.Point(150, 607);
            this.telefono1TextBox.Name = "telefono1TextBox";
            this.telefono1TextBox.ReadOnly = true;
            this.telefono1TextBox.Size = new System.Drawing.Size(150, 20);
            this.telefono1TextBox.TabIndex = 22;
            // 
            // telefono2TextBox
            // 
            this.telefono2TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.telefono2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "telefono2", true));
            this.telefono2TextBox.Location = new System.Drawing.Point(306, 607);
            this.telefono2TextBox.Name = "telefono2TextBox";
            this.telefono2TextBox.ReadOnly = true;
            this.telefono2TextBox.Size = new System.Drawing.Size(150, 20);
            this.telefono2TextBox.TabIndex = 23;
            // 
            // dvTextBox
            // 
            this.dvTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "dv", true));
            this.dvTextBox.Location = new System.Drawing.Point(312, 276);
            this.dvTextBox.Name = "dvTextBox";
            this.dvTextBox.ReadOnly = true;
            this.dvTextBox.Size = new System.Drawing.Size(20, 20);
            this.dvTextBox.TabIndex = 8;
            this.dvTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCerrarVentana
            // 
            this.buttonCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.buttonCerrarVentana.Image = global::Siscad.Properties.Resources.salir;
            this.buttonCerrarVentana.Location = new System.Drawing.Point(1053, 43);
            this.buttonCerrarVentana.Name = "buttonCerrarVentana";
            this.buttonCerrarVentana.Size = new System.Drawing.Size(40, 40);
            this.buttonCerrarVentana.TabIndex = 2;
            this.buttonCerrarVentana.UseVisualStyleBackColor = false;
            this.buttonCerrarVentana.Click += new System.EventHandler(this.buttonCerrarVentana_Click);
            this.buttonCerrarVentana.MouseLeave += new System.EventHandler(this.buttonCerrarVentana_MouseLeave);
            this.buttonCerrarVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonCerrarVentana_MouseMove);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.Location = new System.Drawing.Point(752, 177);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(233, 146);
            this.pictureBoxLogo.TabIndex = 39;
            this.pictureBoxLogo.TabStop = false;
            // 
            // logoTextBox
            // 
            this.logoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpresaBindingSource, "logo", true));
            this.logoTextBox.Location = new System.Drawing.Point(912, 150);
            this.logoTextBox.Name = "logoTextBox";
            this.logoTextBox.ReadOnly = true;
            this.logoTextBox.Size = new System.Drawing.Size(32, 20);
            this.logoTextBox.TabIndex = 29;
            this.logoTextBox.Visible = false;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bindingNavigator.BindingSource = this.datosEmpresaBindingSource;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorCancelItem,
            this.bindingNavigatorSaveItem});
            this.bindingNavigator.Location = new System.Drawing.Point(310, 42);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(454, 43);
            this.bindingNavigator.TabIndex = 1;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Siscad.Properties.Resources.nuevo;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 40);
            this.bindingNavigatorAddNewItem.Text = "Nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 40);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::Siscad.Properties.Resources.borrar;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 40);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::Siscad.Properties.Resources.primerRegistro;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Primer registro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::Siscad.Properties.Resources.anteriorRegistro;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMovePreviousItem.Text = "Anterior registro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::Siscad.Properties.Resources.siguienteRegistro;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveNextItem.Text = "Siguiente registro";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::Siscad.Properties.Resources.ultimoRegistro;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveLastItem.Text = "Último registro";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditItem.Image = global::Siscad.Properties.Resources.editar;
            this.bindingNavigatorEditItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(36, 40);
            this.bindingNavigatorEditItem.Text = "Modificar";
            // 
            // bindingNavigatorCancelItem
            // 
            this.bindingNavigatorCancelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancelItem.Enabled = false;
            this.bindingNavigatorCancelItem.Image = global::Siscad.Properties.Resources.cancelar;
            this.bindingNavigatorCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancelItem.Name = "bindingNavigatorCancelItem";
            this.bindingNavigatorCancelItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorCancelItem.Text = "Cancelar";
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorSaveItem.Image = global::Siscad.Properties.Resources.guardar;
            this.bindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 40);
            this.bindingNavigatorSaveItem.Text = "Guardar";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.datosEmpresaBindingNavigatorSaveItem_Click);
            // 
            // datosEmpresaTableAdapter
            // 
            this.datosEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.actividadPendienteTableAdapter = null;
            this.tableAdapterManager.afiliacionesTableAdapter = null;
            this.tableAdapterManager.antecedenteSaludFamiliarTableAdapter = null;
            this.tableAdapterManager.antecedenteSaludPatologicoTableAdapter = null;
            this.tableAdapterManager.antecedenteSaludQuirurgicoTableAdapter = null;
            this.tableAdapterManager.antecedenteSaludTraumaticoTableAdapter = null;
            this.tableAdapterManager.areaEmpresaTableAdapter = null;
            this.tableAdapterManager.asistenciaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.barraTableAdapter = null;
            this.tableAdapterManager.bodegaProductoTableAdapter = null;
            this.tableAdapterManager.bodegaTableAdapter = null;
            this.tableAdapterManager.categoriaProductoTableAdapter = null;
            this.tableAdapterManager.centroTrabajoTableAdapter = null;
            this.tableAdapterManager.colorTableAdapter = null;
            this.tableAdapterManager.comprasDetalleTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.conceptoCarteraTableAdapter = null;
            this.tableAdapterManager.conceptoNominaTableAdapter = null;
            this.tableAdapterManager.contactoCentroTrabajoTableAdapter = null;
            this.tableAdapterManager.contactoTerceroTableAdapter = null;
            this.tableAdapterManager.controlNominaTableAdapter = null;
            this.tableAdapterManager.cuentaBancariaTableAdapter = null;
            this.tableAdapterManager.cuentasPorCobrarTableAdapter = null;
            this.tableAdapterManager.cursosComplementariosTableAdapter = null;
            this.tableAdapterManager.datosEmpresaTableAdapter = this.datosEmpresaTableAdapter;
            this.tableAdapterManager.deduccionNominaTableAdapter = null;
            this.tableAdapterManager.departamentoProductoTableAdapter = null;
            this.tableAdapterManager.devengadoNominaTableAdapter = null;
            this.tableAdapterManager.devolucionComprasDetalleTableAdapter = null;
            this.tableAdapterManager.devolucionComprasTableAdapter = null;
            this.tableAdapterManager.devolucionVentasDetalleTableAdapter = null;
            this.tableAdapterManager.devolucionVentasTableAdapter = null;
            this.tableAdapterManager.disponibilidadMenuTableAdapter = null;
            this.tableAdapterManager.documentoTerceroTableAdapter = null;
            this.tableAdapterManager.examenMedicoTableAdapter = null;
            this.tableAdapterManager.huellaDigitalTableAdapter = null;
            this.tableAdapterManager.impuestoTableAdapter = null;
            this.tableAdapterManager.justificacionInasistenciaTableAdapter = null;
            this.tableAdapterManager.kardexTableAdapter = null;
            this.tableAdapterManager.listaResponsabilidadTableAdapter = null;
            this.tableAdapterManager.manualFuncionesTableAdapter = null;
            this.tableAdapterManager.marcaTableAdapter = null;
            this.tableAdapterManager.minutaContratoDetalleTableAdapter = null;
            this.tableAdapterManager.minutaContratoTableAdapter = null;
            this.tableAdapterManager.novedadLaboralTableAdapter = null;
            this.tableAdapterManager.otroSiContratoTableAdapter = null;
            this.tableAdapterManager.permisoRolTableAdapter = null;
            this.tableAdapterManager.preliquidacionDetalleTableAdapter = null;
            this.tableAdapterManager.preliquidacionEncabezadoTableAdapter = null;
            this.tableAdapterManager.prendaVestuarioTableAdapter = null;
            this.tableAdapterManager.preseleccionPersonalTableAdapter = null;
            this.tableAdapterManager.productoTableAdapter = null;
            this.tableAdapterManager.salidasDetalleTableAdapter = null;
            this.tableAdapterManager.salidasTableAdapter = null;
            this.tableAdapterManager.secActoInseguroTableAdapter = null;
            this.tableAdapterManager.secAgenteLesionTableAdapter = null;
            this.tableAdapterManager.secBarrioVeredaTableAdapter = null;
            this.tableAdapterManager.secClaseImpuestoTableAdapter = null;
            this.tableAdapterManager.secClasificacionRiesgoTableAdapter = null;
            this.tableAdapterManager.secComunaTableAdapter = null;
            this.tableAdapterManager.secCondicionAmbientalPeligrosaTableAdapter = null;
            this.tableAdapterManager.secDepartamentoTableAdapter = null;
            this.tableAdapterManager.secDiagnosticoTableAdapter = null;
            this.tableAdapterManager.secDiaSemanaTableAdapter = null;
            this.tableAdapterManager.secEstadoCivilTableAdapter = null;
            this.tableAdapterManager.secFormaPagoTableAdapter = null;
            this.tableAdapterManager.secGrupoDiagnosticoTableAdapter = null;
            this.tableAdapterManager.secIndiceMasaCorporalTableAdapter = null;
            this.tableAdapterManager.secJornadaEstablecidaTableAdapter = null;
            this.tableAdapterManager.secJornadaLaboralTableAdapter = null;
            this.tableAdapterManager.secLocalizacionAccidenteTableAdapter = null;
            this.tableAdapterManager.secMesTableAdapter = null;
            this.tableAdapterManager.secModalidadTrabajoTableAdapter = null;
            this.tableAdapterManager.secMotivoOtroSiTableAdapter = null;
            this.tableAdapterManager.secMunicipioTableAdapter = null;
            this.tableAdapterManager.secNaturalezaLesionTableAdapter = null;
            this.tableAdapterManager.secNivelEducativoTableAdapter = null;
            this.tableAdapterManager.secOcupacionTableAdapter = null;
            this.tableAdapterManager.secPaisTableAdapter = null;
            this.tableAdapterManager.secPeriodoTiempoTableAdapter = null;
            this.tableAdapterManager.secPlazoUnidadTableAdapter = null;
            this.tableAdapterManager.secPresentacionProductoTableAdapter = null;
            this.tableAdapterManager.secRegionGeograficaTableAdapter = null;
            this.tableAdapterManager.secRegionMunicipalTableAdapter = null;
            this.tableAdapterManager.secResponsabilidadTributariaTableAdapter = null;
            this.tableAdapterManager.secResultadoMedicoTableAdapter = null;
            this.tableAdapterManager.secRolTableAdapter = null;
            this.tableAdapterManager.secSexoTableAdapter = null;
            this.tableAdapterManager.secSubRegionTableAdapter = null;
            this.tableAdapterManager.secSubtipoCotizanteTableAdapter = null;
            this.tableAdapterManager.secTenenciaViviendaTableAdapter = null;
            this.tableAdapterManager.secTensionArterialTableAdapter = null;
            this.tableAdapterManager.secTipoAusenciaTableAdapter = null;
            this.tableAdapterManager.secTipoCargoTableAdapter = null;
            this.tableAdapterManager.secTipoContratoTableAdapter = null;
            this.tableAdapterManager.secTipoCotizanteTableAdapter = null;
            this.tableAdapterManager.secTipoCuentaBancoTableAdapter = null;
            this.tableAdapterManager.secTipoDocumentoTableAdapter = null;
            this.tableAdapterManager.secTipoExamenMedicoTableAdapter = null;
            this.tableAdapterManager.secTipoPersonaTableAdapter = null;
            this.tableAdapterManager.secTipoSangreTableAdapter = null;
            this.tableAdapterManager.secUnidadMedidaTableAdapter = null;
            this.tableAdapterManager.secUsoTiempoLibreTableAdapter = null;
            this.tableAdapterManager.smmlvTableAdapter = null;
            this.tableAdapterManager.sucursalTableAdapter = null;
            this.tableAdapterManager.tallaTableAdapter = null;
            this.tableAdapterManager.terceroTableAdapter = null;
            this.tableAdapterManager.tipoCertificadoTableAdapter = null;
            this.tableAdapterManager.trasladoProductoDetalleTableAdapter = null;
            this.tableAdapterManager.trasladoProductoTableAdapter = null;
            this.tableAdapterManager.turnoLaboralTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Siscad.DSSiscadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.ventasDetalleTableAdapter = null;
            this.tableAdapterManager.ventasTableAdapter = null;
            this.tableAdapterManager.vinculacionTableAdapter = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // secDepartamentoTableAdapter
            // 
            this.secDepartamentoTableAdapter.ClearBeforeFill = true;
            // 
            // secMunicipioTableAdapter
            // 
            this.secMunicipioTableAdapter.ClearBeforeFill = true;
            // 
            // terceroTableAdapter
            // 
            this.terceroTableAdapter.ClearBeforeFill = true;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 800);
            this.Controls.Add(this.panelSubContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.panelSubMenuSuperior.ResumeLayout(false);
            this.panelSubMenuSuperior.PerformLayout();
            this.panelSubContenedor.ResumeLayout(false);
            this.panelSubContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSiscad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secDepartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secMunicipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelSubMenuSuperior;
        private System.Windows.Forms.Panel panelSubContenedor;
        private System.Windows.Forms.BindingSource datosEmpresaBindingSource;
        private DSSiscadTableAdapters.datosEmpresaTableAdapter datosEmpresaTableAdapter;
        private DSSiscadTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dvTextBox;
        private System.Windows.Forms.TextBox numeroDocumentoTextBox;
        private System.Windows.Forms.DateTimePicker fechaResolucionFacturacionDateTimePicker;
        private System.Windows.Forms.TextBox resolucionFacturacionTextBox;
        private System.Windows.Forms.DateTimePicker fechaConstitucionDateTimePicker;
        private System.Windows.Forms.ComboBox idTerceroRepresentanteComboBox;
        private System.Windows.Forms.TextBox sitioWebTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.ComboBox idTerceroArlComboBox;
        private System.Windows.Forms.TextBox telefono2TextBox;
        private System.Windows.Forms.TextBox telefono1TextBox;
        private System.Windows.Forms.ComboBox idMunicipioComboBox;
        private System.Windows.Forms.ComboBox idDepartamentoComboBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox logoTextBox;
        private System.Windows.Forms.TextBox nombreComercialTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.TextBox vigenciaResolucionTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonCerrarVentana;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelCerrarVentana;
        private DSSiscad dSSiscad;
        private System.Windows.Forms.BindingSource secDepartamentoBindingSource;
        private DSSiscadTableAdapters.secDepartamentoTableAdapter secDepartamentoTableAdapter;
        private System.Windows.Forms.BindingSource secMunicipioBindingSource;
        private DSSiscadTableAdapters.secMunicipioTableAdapter secMunicipioTableAdapter;
        private System.Windows.Forms.BindingSource terceroBindingSource;
        private DSSiscadTableAdapters.terceroTableAdapter terceroTableAdapter;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.Button buttonLogo;
        private System.Windows.Forms.Label labelResolucionFacturacion;
        private System.Windows.Forms.Label labelOtrosDatos;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelUbicacion;
        private System.Windows.Forms.TextBox facturaAutorizadaHastaTextBox;
        private System.Windows.Forms.TextBox facturaAutorizadaDesdeTextBox;
        private System.Windows.Forms.TextBox escrituraConstitucionTextBox;
        private System.Windows.Forms.TextBox matriculaMercantilTextBox;
    }
}