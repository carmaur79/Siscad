namespace Siscad
{
    partial class frmUsuario
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
            System.Windows.Forms.Label codigoUsuarioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label idRolLabel;
            System.Windows.Forms.Label ultimoIngresoLabel;
            System.Windows.Forms.Label fechaModificacionClaveLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label labelEstado;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label identificacionLabel;
            this.panelSubContenedor = new System.Windows.Forms.Panel();
            this.labelInformacionAcceso = new System.Windows.Forms.Label();
            this.labelInformacionUsuario = new System.Windows.Forms.Label();
            this.confirmarClaveTextBox = new System.Windows.Forms.TextBox();
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
            this.confirmarClaveLabel = new System.Windows.Forms.Label();
            this.labelCerrarVentana = new System.Windows.Forms.Label();
            this.codigoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSiscad = new Siscad.DSSiscad();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.buttonCerrarVentana = new System.Windows.Forms.Button();
            this.idRolComboBox = new System.Windows.Forms.ComboBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxEstado = new System.Windows.Forms.GroupBox();
            this.radioButtonInactivo = new System.Windows.Forms.RadioButton();
            this.radioButtonActivo = new System.Windows.Forms.RadioButton();
            this.fechaModificacionClaveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.ultimoIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.panelSubMenuSuperior = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.usuarioTableAdapter = new Siscad.DSSiscadTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new Siscad.DSSiscadTableAdapters.TableAdapterManager();
            this.labelRecuperacionClave = new System.Windows.Forms.Label();
            this.labelOtraInformacion = new System.Windows.Forms.Label();
            this.identificacionTextBox = new System.Windows.Forms.TextBox();
            this.secRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secRolTableAdapter = new Siscad.DSSiscadTableAdapters.secRolTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoUsuarioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            idRolLabel = new System.Windows.Forms.Label();
            ultimoIngresoLabel = new System.Windows.Forms.Label();
            fechaModificacionClaveLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            labelEstado = new System.Windows.Forms.Label();
            identificacionLabel = new System.Windows.Forms.Label();
            this.panelSubContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSiscad)).BeginInit();
            this.groupBoxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.panelSubMenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secRolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoUsuarioLabel
            // 
            codigoUsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            codigoUsuarioLabel.AutoSize = true;
            codigoUsuarioLabel.ForeColor = System.Drawing.SystemColors.Control;
            codigoUsuarioLabel.Location = new System.Drawing.Point(84, 370);
            codigoUsuarioLabel.Name = "codigoUsuarioLabel";
            codigoUsuarioLabel.Size = new System.Drawing.Size(53, 13);
            codigoUsuarioLabel.TabIndex = 12;
            codigoUsuarioLabel.Text = "Usuario *:";
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.SystemColors.Control;
            nombreLabel.Location = new System.Drawing.Point(83, 228);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(54, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre *:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            apellidoLabel.AutoSize = true;
            apellidoLabel.ForeColor = System.Drawing.SystemColors.Control;
            apellidoLabel.Location = new System.Drawing.Point(78, 262);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(59, 13);
            apellidoLabel.TabIndex = 9;
            apellidoLabel.Text = "Apellidos *:";
            // 
            // claveLabel
            // 
            claveLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            claveLabel.AutoSize = true;
            claveLabel.ForeColor = System.Drawing.SystemColors.Control;
            claveLabel.Location = new System.Drawing.Point(93, 406);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(44, 13);
            claveLabel.TabIndex = 14;
            claveLabel.Text = "Clave *:";
            // 
            // idRolLabel
            // 
            idRolLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            idRolLabel.AutoSize = true;
            idRolLabel.ForeColor = System.Drawing.SystemColors.Control;
            idRolLabel.Location = new System.Drawing.Point(104, 475);
            idRolLabel.Name = "idRolLabel";
            idRolLabel.Size = new System.Drawing.Size(33, 13);
            idRolLabel.TabIndex = 18;
            idRolLabel.Text = "Rol *:";
            // 
            // ultimoIngresoLabel
            // 
            ultimoIngresoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ultimoIngresoLabel.AutoSize = true;
            ultimoIngresoLabel.ForeColor = System.Drawing.SystemColors.Control;
            ultimoIngresoLabel.Location = new System.Drawing.Point(61, 696);
            ultimoIngresoLabel.Name = "ultimoIngresoLabel";
            ultimoIngresoLabel.Size = new System.Drawing.Size(76, 13);
            ultimoIngresoLabel.TabIndex = 24;
            ultimoIngresoLabel.Text = "Último ingreso:";
            // 
            // fechaModificacionClaveLabel
            // 
            fechaModificacionClaveLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            fechaModificacionClaveLabel.AutoSize = true;
            fechaModificacionClaveLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaModificacionClaveLabel.Location = new System.Drawing.Point(17, 727);
            fechaModificacionClaveLabel.Name = "fechaModificacionClaveLabel";
            fechaModificacionClaveLabel.Size = new System.Drawing.Size(120, 13);
            fechaModificacionClaveLabel.TabIndex = 26;
            fechaModificacionClaveLabel.Text = "Último cambio de clave:";
            // 
            // correoLabel
            // 
            correoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            correoLabel.AutoSize = true;
            correoLabel.ForeColor = System.Drawing.SystemColors.Control;
            correoLabel.Location = new System.Drawing.Point(96, 585);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 21;
            correoLabel.Text = "Correo:";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new System.Drawing.Point(16, 20);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new System.Drawing.Size(75, 13);
            labelEstado.TabIndex = 0;
            labelEstado.Text = "Estado actual:";
            // 
            // panelSubContenedor
            // 
            this.panelSubContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.panelSubContenedor.Controls.Add(identificacionLabel);
            this.panelSubContenedor.Controls.Add(this.identificacionTextBox);
            this.panelSubContenedor.Controls.Add(this.labelOtraInformacion);
            this.panelSubContenedor.Controls.Add(this.labelRecuperacionClave);
            this.panelSubContenedor.Controls.Add(this.labelInformacionAcceso);
            this.panelSubContenedor.Controls.Add(this.labelInformacionUsuario);
            this.panelSubContenedor.Controls.Add(this.confirmarClaveTextBox);
            this.panelSubContenedor.Controls.Add(this.bindingNavigator);
            this.panelSubContenedor.Controls.Add(this.confirmarClaveLabel);
            this.panelSubContenedor.Controls.Add(this.labelCerrarVentana);
            this.panelSubContenedor.Controls.Add(correoLabel);
            this.panelSubContenedor.Controls.Add(this.codigoUsuarioTextBox);
            this.panelSubContenedor.Controls.Add(this.correoTextBox);
            this.panelSubContenedor.Controls.Add(codigoUsuarioLabel);
            this.panelSubContenedor.Controls.Add(this.claveTextBox);
            this.panelSubContenedor.Controls.Add(claveLabel);
            this.panelSubContenedor.Controls.Add(this.buttonCerrarVentana);
            this.panelSubContenedor.Controls.Add(idRolLabel);
            this.panelSubContenedor.Controls.Add(this.idRolComboBox);
            this.panelSubContenedor.Controls.Add(this.nombreTextBox);
            this.panelSubContenedor.Controls.Add(this.groupBoxEstado);
            this.panelSubContenedor.Controls.Add(fechaModificacionClaveLabel);
            this.panelSubContenedor.Controls.Add(nombreLabel);
            this.panelSubContenedor.Controls.Add(this.fechaModificacionClaveDateTimePicker);
            this.panelSubContenedor.Controls.Add(this.apellidoTextBox);
            this.panelSubContenedor.Controls.Add(ultimoIngresoLabel);
            this.panelSubContenedor.Controls.Add(apellidoLabel);
            this.panelSubContenedor.Controls.Add(this.ultimoIngresoDateTimePicker);
            this.panelSubContenedor.Controls.Add(this.usuarioDataGridView);
            this.panelSubContenedor.Controls.Add(this.panelSubMenuSuperior);
            this.panelSubContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubContenedor.ForeColor = System.Drawing.SystemColors.Control;
            this.panelSubContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelSubContenedor.Name = "panelSubContenedor";
            this.panelSubContenedor.Size = new System.Drawing.Size(1008, 800);
            this.panelSubContenedor.TabIndex = 0;
            // 
            // labelInformacionAcceso
            // 
            this.labelInformacionAcceso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInformacionAcceso.AutoSize = true;
            this.labelInformacionAcceso.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformacionAcceso.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInformacionAcceso.Location = new System.Drawing.Point(103, 314);
            this.labelInformacionAcceso.Name = "labelInformacionAcceso";
            this.labelInformacionAcceso.Size = new System.Drawing.Size(185, 22);
            this.labelInformacionAcceso.TabIndex = 11;
            this.labelInformacionAcceso.Text = "Información de Acceso";
            // 
            // labelInformacionUsuario
            // 
            this.labelInformacionUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInformacionUsuario.AutoSize = true;
            this.labelInformacionUsuario.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformacionUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInformacionUsuario.Location = new System.Drawing.Point(103, 143);
            this.labelInformacionUsuario.Name = "labelInformacionUsuario";
            this.labelInformacionUsuario.Size = new System.Drawing.Size(201, 22);
            this.labelInformacionUsuario.TabIndex = 4;
            this.labelInformacionUsuario.Text = "Información del Usuario";
            // 
            // confirmarClaveTextBox
            // 
            this.confirmarClaveTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmarClaveTextBox.Location = new System.Drawing.Point(143, 437);
            this.confirmarClaveTextBox.Name = "confirmarClaveTextBox";
            this.confirmarClaveTextBox.PasswordChar = '*';
            this.confirmarClaveTextBox.Size = new System.Drawing.Size(250, 20);
            this.confirmarClaveTextBox.TabIndex = 17;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bindingNavigator.BindingSource = this.usuarioBindingSource;
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
            this.bindingNavigator.Location = new System.Drawing.Point(276, 43);
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
            // 
            // confirmarClaveLabel
            // 
            this.confirmarClaveLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmarClaveLabel.AutoSize = true;
            this.confirmarClaveLabel.Location = new System.Drawing.Point(47, 440);
            this.confirmarClaveLabel.Name = "confirmarClaveLabel";
            this.confirmarClaveLabel.Size = new System.Drawing.Size(90, 13);
            this.confirmarClaveLabel.TabIndex = 16;
            this.confirmarClaveLabel.Text = "Confirmar clave *:";
            // 
            // labelCerrarVentana
            // 
            this.labelCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCerrarVentana.AutoSize = true;
            this.labelCerrarVentana.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCerrarVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCerrarVentana.ForeColor = System.Drawing.Color.Gray;
            this.labelCerrarVentana.Location = new System.Drawing.Point(882, 89);
            this.labelCerrarVentana.Name = "labelCerrarVentana";
            this.labelCerrarVentana.Size = new System.Drawing.Size(87, 15);
            this.labelCerrarVentana.TabIndex = 3;
            this.labelCerrarVentana.Text = "Cerrar ventana";
            this.labelCerrarVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCerrarVentana.Visible = false;
            // 
            // codigoUsuarioTextBox
            // 
            this.codigoUsuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codigoUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "codigoUsuario", true));
            this.codigoUsuarioTextBox.Location = new System.Drawing.Point(143, 367);
            this.codigoUsuarioTextBox.Name = "codigoUsuarioTextBox";
            this.codigoUsuarioTextBox.Size = new System.Drawing.Size(250, 20);
            this.codigoUsuarioTextBox.TabIndex = 13;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.dSSiscad;
            // 
            // dSSiscad
            // 
            this.dSSiscad.DataSetName = "DSSiscad";
            this.dSSiscad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // correoTextBox
            // 
            this.correoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(143, 582);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(250, 20);
            this.correoTextBox.TabIndex = 22;
            // 
            // claveTextBox
            // 
            this.claveTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(143, 403);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(250, 20);
            this.claveTextBox.TabIndex = 15;
            // 
            // buttonCerrarVentana
            // 
            this.buttonCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.buttonCerrarVentana.Image = global::Siscad.Properties.Resources.salir;
            this.buttonCerrarVentana.Location = new System.Drawing.Point(956, 46);
            this.buttonCerrarVentana.Name = "buttonCerrarVentana";
            this.buttonCerrarVentana.Size = new System.Drawing.Size(40, 40);
            this.buttonCerrarVentana.TabIndex = 2;
            this.buttonCerrarVentana.UseVisualStyleBackColor = false;
            this.buttonCerrarVentana.Click += new System.EventHandler(this.buttonCerrarVentana_Click);
            // 
            // idRolComboBox
            // 
            this.idRolComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idRolComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idRolComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idRolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioBindingSource, "idRol", true));
            this.idRolComboBox.DataSource = this.secRolBindingSource;
            this.idRolComboBox.DisplayMember = "descripcion";
            this.idRolComboBox.FormattingEnabled = true;
            this.idRolComboBox.Location = new System.Drawing.Point(143, 472);
            this.idRolComboBox.Name = "idRolComboBox";
            this.idRolComboBox.Size = new System.Drawing.Size(250, 21);
            this.idRolComboBox.TabIndex = 19;
            this.idRolComboBox.ValueMember = "idRol";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(143, 225);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(250, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // groupBoxEstado
            // 
            this.groupBoxEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxEstado.Controls.Add(labelEstado);
            this.groupBoxEstado.Controls.Add(this.radioButtonInactivo);
            this.groupBoxEstado.Controls.Add(this.radioButtonActivo);
            this.groupBoxEstado.Location = new System.Drawing.Point(642, 127);
            this.groupBoxEstado.Name = "groupBoxEstado";
            this.groupBoxEstado.Size = new System.Drawing.Size(251, 50);
            this.groupBoxEstado.TabIndex = 28;
            this.groupBoxEstado.TabStop = false;
            // 
            // radioButtonInactivo
            // 
            this.radioButtonInactivo.AutoSize = true;
            this.radioButtonInactivo.Location = new System.Drawing.Point(167, 18);
            this.radioButtonInactivo.Name = "radioButtonInactivo";
            this.radioButtonInactivo.Size = new System.Drawing.Size(63, 17);
            this.radioButtonInactivo.TabIndex = 2;
            this.radioButtonInactivo.TabStop = true;
            this.radioButtonInactivo.Text = "Inactivo";
            this.radioButtonInactivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonActivo
            // 
            this.radioButtonActivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.usuarioBindingSource, "estado", true));
            this.radioButtonActivo.Location = new System.Drawing.Point(97, 14);
            this.radioButtonActivo.Name = "radioButtonActivo";
            this.radioButtonActivo.Size = new System.Drawing.Size(64, 24);
            this.radioButtonActivo.TabIndex = 1;
            this.radioButtonActivo.TabStop = true;
            this.radioButtonActivo.Text = "Activo";
            this.radioButtonActivo.UseVisualStyleBackColor = true;
            // 
            // fechaModificacionClaveDateTimePicker
            // 
            this.fechaModificacionClaveDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fechaModificacionClaveDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource, "fechaModificacionClave", true));
            this.fechaModificacionClaveDateTimePicker.Location = new System.Drawing.Point(143, 724);
            this.fechaModificacionClaveDateTimePicker.Name = "fechaModificacionClaveDateTimePicker";
            this.fechaModificacionClaveDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.fechaModificacionClaveDateTimePicker.TabIndex = 27;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(143, 259);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(250, 20);
            this.apellidoTextBox.TabIndex = 10;
            // 
            // ultimoIngresoDateTimePicker
            // 
            this.ultimoIngresoDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ultimoIngresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource, "ultimoIngreso", true));
            this.ultimoIngresoDateTimePicker.Location = new System.Drawing.Point(143, 692);
            this.ultimoIngresoDateTimePicker.Name = "ultimoIngresoDateTimePicker";
            this.ultimoIngresoDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.ultimoIngresoDateTimePicker.TabIndex = 25;
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.usuarioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarioDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usuarioDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.usuarioDataGridView.ColumnHeadersHeight = 30;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuarioDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.usuarioDataGridView.EnableHeadersVisualStyles = false;
            this.usuarioDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.usuarioDataGridView.Location = new System.Drawing.Point(534, 192);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarioDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.usuarioDataGridView.RowHeadersVisible = false;
            this.usuarioDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.usuarioDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.usuarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarioDataGridView.Size = new System.Drawing.Size(550, 550);
            this.usuarioDataGridView.TabIndex = 29;
            // 
            // panelSubMenuSuperior
            // 
            this.panelSubMenuSuperior.BackColor = System.Drawing.SystemColors.Control;
            this.panelSubMenuSuperior.Controls.Add(this.labelTitulo);
            this.panelSubMenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSubMenuSuperior.Name = "panelSubMenuSuperior";
            this.panelSubMenuSuperior.Size = new System.Drawing.Size(1008, 40);
            this.panelSubMenuSuperior.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.labelTitulo.Location = new System.Drawing.Point(3, 3);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(228, 33);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Gestión de Usuarios";
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.datosEmpresaTableAdapter = null;
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
            this.tableAdapterManager.usuarioTableAdapter = this.usuarioTableAdapter;
            this.tableAdapterManager.ventasDetalleTableAdapter = null;
            this.tableAdapterManager.ventasTableAdapter = null;
            this.tableAdapterManager.vinculacionTableAdapter = null;
            // 
            // labelRecuperacionClave
            // 
            this.labelRecuperacionClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRecuperacionClave.AutoSize = true;
            this.labelRecuperacionClave.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecuperacionClave.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRecuperacionClave.Location = new System.Drawing.Point(103, 530);
            this.labelRecuperacionClave.Name = "labelRecuperacionClave";
            this.labelRecuperacionClave.Size = new System.Drawing.Size(184, 22);
            this.labelRecuperacionClave.TabIndex = 20;
            this.labelRecuperacionClave.Text = "Recuperación de Clave";
            // 
            // labelOtraInformacion
            // 
            this.labelOtraInformacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOtraInformacion.AutoSize = true;
            this.labelOtraInformacion.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtraInformacion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelOtraInformacion.Location = new System.Drawing.Point(103, 637);
            this.labelOtraInformacion.Name = "labelOtraInformacion";
            this.labelOtraInformacion.Size = new System.Drawing.Size(145, 22);
            this.labelOtraInformacion.TabIndex = 23;
            this.labelOtraInformacion.Text = "Otra Información";
            // 
            // identificacionLabel
            // 
            identificacionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            identificacionLabel.AutoSize = true;
            identificacionLabel.Location = new System.Drawing.Point(57, 194);
            identificacionLabel.Name = "identificacionLabel";
            identificacionLabel.Size = new System.Drawing.Size(80, 13);
            identificacionLabel.TabIndex = 5;
            identificacionLabel.Text = "Identificación *:";
            // 
            // identificacionTextBox
            // 
            this.identificacionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.identificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "identificacion", true));
            this.identificacionTextBox.Location = new System.Drawing.Point(143, 191);
            this.identificacionTextBox.Name = "identificacionTextBox";
            this.identificacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.identificacionTextBox.TabIndex = 6;
            // 
            // secRolBindingSource
            // 
            this.secRolBindingSource.DataMember = "secRol";
            this.secRolBindingSource.DataSource = this.dSSiscad;
            // 
            // secRolTableAdapter
            // 
            this.secRolTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "idUsuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codigoUsuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "clave";
            this.dataGridViewTextBoxColumn5.HeaderText = "clave";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idRol";
            this.dataGridViewTextBoxColumn6.HeaderText = "idRol";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ultimoIngreso";
            this.dataGridViewTextBoxColumn7.HeaderText = "ultimoIngreso";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "horaUltimoIngreso";
            this.dataGridViewTextBoxColumn8.HeaderText = "horaUltimoIngreso";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fechaModificacionClave";
            this.dataGridViewTextBoxColumn9.HeaderText = "fechaModificacionClave";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "correo";
            this.dataGridViewTextBoxColumn10.HeaderText = "correo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "adicional1";
            this.dataGridViewTextBoxColumn11.HeaderText = "adicional1";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "adicional2";
            this.dataGridViewTextBoxColumn12.HeaderText = "adicional2";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "adicional3";
            this.dataGridViewTextBoxColumn13.HeaderText = "adicional3";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "idUsuarioCreador";
            this.dataGridViewTextBoxColumn14.HeaderText = "idUsuarioCreador";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 800);
            this.Controls.Add(this.panelSubContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.panelSubContenedor.ResumeLayout(false);
            this.panelSubContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSiscad)).EndInit();
            this.groupBoxEstado.ResumeLayout(false);
            this.groupBoxEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.panelSubMenuSuperior.ResumeLayout(false);
            this.panelSubMenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secRolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSubContenedor;
        private System.Windows.Forms.Panel panelSubMenuSuperior;
        private System.Windows.Forms.Label labelTitulo;
        private DSSiscad dSSiscad;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DSSiscadTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private DSSiscadTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.DateTimePicker fechaModificacionClaveDateTimePicker;
        private System.Windows.Forms.DateTimePicker ultimoIngresoDateTimePicker;
        private System.Windows.Forms.ComboBox idRolComboBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox codigoUsuarioTextBox;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.TextBox confirmarClaveTextBox;
        private System.Windows.Forms.Label confirmarClaveLabel;
        private System.Windows.Forms.GroupBox groupBoxEstado;
        private System.Windows.Forms.RadioButton radioButtonInactivo;
        private System.Windows.Forms.RadioButton radioButtonActivo;
        private System.Windows.Forms.Label labelCerrarVentana;
        private System.Windows.Forms.Button buttonCerrarVentana;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.Label labelInformacionAcceso;
        private System.Windows.Forms.Label labelInformacionUsuario;
        private System.Windows.Forms.Label labelRecuperacionClave;
        private System.Windows.Forms.Label labelOtraInformacion;
        private System.Windows.Forms.TextBox identificacionTextBox;
        private System.Windows.Forms.BindingSource secRolBindingSource;
        private DSSiscadTableAdapters.secRolTableAdapter secRolTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}