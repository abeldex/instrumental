namespace Instrumental_Desktop
{
    partial class Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.cmbBrigadas = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.brigadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentalDataSet = new Instrumental_Desktop.InstrumentalDataSet();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtGrupo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtCuenta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgAlumnos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.alcuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bricodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.alumnoTableAdapter();
            this.brigadaTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.brigadaTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Campo Requerido.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Campo Requerido.");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Campo Requerido.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brigadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reflectionImage1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.ForeColor = System.Drawing.Color.Black;
            this.reflectionImage1.Image = global::Instrumental_Desktop.Properties.Resources._1379301425_Student_id_64;
            this.reflectionImage1.Location = new System.Drawing.Point(480, -1);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(111, 102);
            this.reflectionImage1.TabIndex = 17;
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reflectionLabel1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Black;
            this.reflectionLabel1.Location = new System.Drawing.Point(198, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(293, 70);
            this.reflectionLabel1.TabIndex = 16;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Administración de </i><font color=\"Orange\">ALUMNOS</font></" +
    "font></b>";
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnSalir);
            this.groupPanel1.Controls.Add(this.btnActualizar);
            this.groupPanel1.Controls.Add(this.btnAgregar);
            this.groupPanel1.Controls.Add(this.cmbBrigadas);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txtTelefono);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txtGrupo);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txtNombre);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtCuenta);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(7, 65);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(774, 167);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 18;
            this.groupPanel1.Text = "Agregar Alumnos";
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalir.Location = new System.Drawing.Point(532, 81);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 26);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnActualizar.Location = new System.Drawing.Point(532, 49);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 26);
            this.btnActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Ac&tualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Location = new System.Drawing.Point(532, 16);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbBrigadas
            // 
            this.cmbBrigadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBrigadas.DataSource = this.brigadaBindingSource;
            this.cmbBrigadas.DisplayMember = "bri_codigo";
            this.cmbBrigadas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBrigadas.FocusHighlightColor = System.Drawing.Color.Moccasin;
            this.cmbBrigadas.ForeColor = System.Drawing.Color.Black;
            this.cmbBrigadas.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbBrigadas, true);
            this.cmbBrigadas.ItemHeight = 16;
            this.cmbBrigadas.Location = new System.Drawing.Point(242, 109);
            this.cmbBrigadas.Name = "cmbBrigadas";
            this.cmbBrigadas.Size = new System.Drawing.Size(253, 22);
            this.cmbBrigadas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbBrigadas.TabIndex = 5;
            this.cmbBrigadas.ValueMember = "bri_codigo";
            this.cmbBrigadas.SelectedIndexChanged += new System.EventHandler(this.cmbBrigadas_SelectedIndexChanged);
            // 
            // brigadaBindingSource
            // 
            this.brigadaBindingSource.DataMember = "brigada";
            this.brigadaBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // instrumentalDataSet
            // 
            this.instrumentalDataSet.DataSetName = "InstrumentalDataSet";
            this.instrumentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(169, 109);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(67, 23);
            this.labelX5.TabIndex = 22;
            this.labelX5.Text = "Brigada:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTelefono.Border.Class = "TextBoxBorder";
            this.txtTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.FocusHighlightColor = System.Drawing.Color.Moccasin;
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtTelefono, true);
            this.txtTelefono.Location = new System.Drawing.Point(242, 79);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(254, 22);
            this.txtTelefono.TabIndex = 4;
            this.superValidator1.SetValidator1(this.txtTelefono, this.requiredFieldValidator1);
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(169, 78);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(67, 23);
            this.labelX4.TabIndex = 20;
            this.labelX4.Text = "Telefono:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrupo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtGrupo.Border.Class = "TextBoxBorder";
            this.txtGrupo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupo.FocusHighlightColor = System.Drawing.Color.Moccasin;
            this.txtGrupo.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtGrupo, true);
            this.txtGrupo.Location = new System.Drawing.Point(389, 19);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(107, 22);
            this.txtGrupo.TabIndex = 2;
            this.superValidator1.SetValidator1(this.txtGrupo, this.requiredFieldValidator2);
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(347, 18);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(67, 23);
            this.labelX3.TabIndex = 18;
            this.labelX3.Text = "Grupo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNombre.Border.Class = "TextBoxBorder";
            this.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.FocusHighlightColor = System.Drawing.Color.Moccasin;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtNombre, true);
            this.txtNombre.Location = new System.Drawing.Point(242, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 22);
            this.txtNombre.TabIndex = 3;
            this.superValidator1.SetValidator1(this.txtNombre, this.requiredFieldValidator3);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(169, 48);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(67, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Nombre:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCuenta.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCuenta.Border.Class = "TextBoxBorder";
            this.txtCuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuenta.FocusHighlightColor = System.Drawing.Color.Moccasin;
            this.txtCuenta.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtCuenta, true);
            this.txtCuenta.Location = new System.Drawing.Point(242, 20);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(87, 22);
            this.txtCuenta.TabIndex = 1;
            this.superValidator1.SetValidator1(this.txtCuenta, this.requiredFieldValidator1);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(169, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 23);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "No. Cuenta:";
            // 
            // dgAlumnos
            // 
            this.dgAlumnos.AllowUserToOrderColumns = true;
            this.dgAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAlumnos.AutoGenerateColumns = false;
            this.dgAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alcuentaDataGridViewTextBoxColumn,
            this.alnombreDataGridViewTextBoxColumn,
            this.altelefonoDataGridViewTextBoxColumn,
            this.algrupoDataGridViewTextBoxColumn,
            this.bricodigoDataGridViewTextBoxColumn});
            this.dgAlumnos.DataSource = this.alumnoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAlumnos.EnableHeadersVisualStyles = false;
            this.dgAlumnos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgAlumnos.Location = new System.Drawing.Point(7, 223);
            this.dgAlumnos.Name = "dgAlumnos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAlumnos.Size = new System.Drawing.Size(774, 238);
            this.dgAlumnos.TabIndex = 19;
            // 
            // alcuentaDataGridViewTextBoxColumn
            // 
            this.alcuentaDataGridViewTextBoxColumn.DataPropertyName = "al_cuenta";
            this.alcuentaDataGridViewTextBoxColumn.HeaderText = "NO. CUENTA";
            this.alcuentaDataGridViewTextBoxColumn.Name = "alcuentaDataGridViewTextBoxColumn";
            // 
            // alnombreDataGridViewTextBoxColumn
            // 
            this.alnombreDataGridViewTextBoxColumn.DataPropertyName = "al_nombre";
            this.alnombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.alnombreDataGridViewTextBoxColumn.Name = "alnombreDataGridViewTextBoxColumn";
            // 
            // altelefonoDataGridViewTextBoxColumn
            // 
            this.altelefonoDataGridViewTextBoxColumn.DataPropertyName = "al_telefono";
            this.altelefonoDataGridViewTextBoxColumn.HeaderText = "CELULAR";
            this.altelefonoDataGridViewTextBoxColumn.Name = "altelefonoDataGridViewTextBoxColumn";
            // 
            // algrupoDataGridViewTextBoxColumn
            // 
            this.algrupoDataGridViewTextBoxColumn.DataPropertyName = "al_grupo";
            this.algrupoDataGridViewTextBoxColumn.HeaderText = "GRUPO";
            this.algrupoDataGridViewTextBoxColumn.Name = "algrupoDataGridViewTextBoxColumn";
            // 
            // bricodigoDataGridViewTextBoxColumn
            // 
            this.bricodigoDataGridViewTextBoxColumn.DataPropertyName = "bri_codigo";
            this.bricodigoDataGridViewTextBoxColumn.HeaderText = "BRIGADA";
            this.bricodigoDataGridViewTextBoxColumn.Name = "bricodigoDataGridViewTextBoxColumn";
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "alumno";
            this.alumnoBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // brigadaTableAdapter
            // 
            this.brigadaTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.BackColor = System.Drawing.Color.White;
            this.fillByToolStrip.ForeColor = System.Drawing.Color.Black;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(784, 25);
            this.fillByToolStrip.TabIndex = 20;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Visible = false;
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // superValidator1
            // 
            this.superValidator1.CancelValidatingOnControl = false;
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Campo Requerido.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Campo Requerido.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Campo Requerido.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            this.highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Orange;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dgAlumnos);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.reflectionImage1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Alumnos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alumnos_FormClosing);
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brigadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbBrigadas;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTelefono;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGrupo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCuenta;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.ButtonX btnActualizar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgAlumnos;
        private InstrumentalDataSet instrumentalDataSet;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private InstrumentalDataSetTableAdapters.alumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn algrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bricodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource brigadaBindingSource;
        private InstrumentalDataSetTableAdapters.brigadaTableAdapter brigadaTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
    }
}