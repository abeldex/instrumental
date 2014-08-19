namespace Instrumental_Desktop
{
    partial class Equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipos));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtSerie = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCantidad = new DevComponents.Editors.IntegerInput();
            this.cmbCategoria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.equipotipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentalDataSet = new Instrumental_Desktop.InstrumentalDataSet();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.dgEquipos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.eqserieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eqnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eqstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerequiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtener_equiposTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.obtener_equiposTableAdapter();
            this.equipoTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.equipoTableAdapter();
            this.equipo_tipoTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.equipo_tipoTableAdapter();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Este campo es requerido.");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Este campo es requerido.");
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Este campo es requerido.");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Este campo es requerido.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipotipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerequiposBindingSource)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.labelX1.Location = new System.Drawing.Point(181, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 16);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Categoria:";
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
            this.labelX2.Location = new System.Drawing.Point(181, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(93, 16);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Nombre:";
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
            this.labelX3.Location = new System.Drawing.Point(179, 32);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(93, 16);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Numero de Serie:";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
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
            this.labelX4.Location = new System.Drawing.Point(181, 90);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(93, 16);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Cantidad:";
            // 
            // txtSerie
            // 
            this.txtSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSerie.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSerie.Border.Class = "TextBoxBorder";
            this.txtSerie.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSerie.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtSerie, true);
            this.txtSerie.Location = new System.Drawing.Point(287, 35);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(242, 22);
            this.txtSerie.TabIndex = 2;
            this.superValidator1.SetValidator1(this.txtSerie, this.requiredFieldValidator2);
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
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
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtNombre, true);
            this.txtNombre.Location = new System.Drawing.Point(287, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 22);
            this.txtNombre.TabIndex = 3;
            this.superValidator1.SetValidator1(this.txtNombre, this.requiredFieldValidator3);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCantidad.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtCantidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCantidad.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtCantidad, true);
            this.txtCantidad.Location = new System.Drawing.Point(287, 91);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ShowUpDown = true;
            this.txtCantidad.Size = new System.Drawing.Size(58, 22);
            this.txtCantidad.TabIndex = 4;
            this.superValidator1.SetValidator1(this.txtCantidad, this.requiredFieldValidator4);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategoria.DataSource = this.equipotipoBindingSource;
            this.cmbCategoria.DisplayMember = "eq_tipo_nombre";
            this.cmbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategoria.ForeColor = System.Drawing.Color.Black;
            this.cmbCategoria.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbCategoria, true);
            this.cmbCategoria.ItemHeight = 16;
            this.cmbCategoria.Location = new System.Drawing.Point(287, 4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(169, 22);
            this.cmbCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCategoria.TabIndex = 1;
            this.superValidator1.SetValidator1(this.cmbCategoria, this.requiredFieldValidator1);
            this.cmbCategoria.ValueMember = "eq_tipo_codigo";
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // equipotipoBindingSource
            // 
            this.equipotipoBindingSource.DataMember = "equipo_tipo";
            this.equipotipoBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // instrumentalDataSet
            // 
            this.instrumentalDataSet.DataSetName = "InstrumentalDataSet";
            this.instrumentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Location = new System.Drawing.Point(539, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 28);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgEquipos
            // 
            this.dgEquipos.AllowUserToOrderColumns = true;
            this.dgEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEquipos.AutoGenerateColumns = false;
            this.dgEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEquipos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eqserieDataGridViewTextBoxColumn,
            this.eqnombreDataGridViewTextBoxColumn,
            this.eqstockDataGridViewTextBoxColumn});
            this.dgEquipos.DataSource = this.equipoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEquipos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEquipos.EnableHeadersVisualStyles = false;
            this.dgEquipos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.highlighter1.SetHighlightOnFocus(this.dgEquipos, true);
            this.dgEquipos.Location = new System.Drawing.Point(4, 204);
            this.dgEquipos.Name = "dgEquipos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEquipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgEquipos.Size = new System.Drawing.Size(774, 257);
            this.dgEquipos.TabIndex = 8;
            this.dgEquipos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgEquipos_DataError);
            // 
            // eqserieDataGridViewTextBoxColumn
            // 
            this.eqserieDataGridViewTextBoxColumn.DataPropertyName = "eq_serie";
            this.eqserieDataGridViewTextBoxColumn.HeaderText = "NUMERO DE SERIE";
            this.eqserieDataGridViewTextBoxColumn.Name = "eqserieDataGridViewTextBoxColumn";
            // 
            // eqnombreDataGridViewTextBoxColumn
            // 
            this.eqnombreDataGridViewTextBoxColumn.DataPropertyName = "eq_nombre";
            this.eqnombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE DEL EQUIPO";
            this.eqnombreDataGridViewTextBoxColumn.Name = "eqnombreDataGridViewTextBoxColumn";
            // 
            // eqstockDataGridViewTextBoxColumn
            // 
            this.eqstockDataGridViewTextBoxColumn.DataPropertyName = "eq_stock";
            this.eqstockDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.eqstockDataGridViewTextBoxColumn.Name = "eqstockDataGridViewTextBoxColumn";
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "equipo";
            this.equipoBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // obtenerequiposBindingSource
            // 
            this.obtenerequiposBindingSource.DataMember = "obtener_equipos";
            this.obtenerequiposBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // obtener_equiposTableAdapter
            // 
            this.obtener_equiposTableAdapter.ClearBeforeFill = true;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // equipo_tipoTableAdapter
            // 
            this.equipo_tipoTableAdapter.ClearBeforeFill = true;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(539, 37);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 28);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "Ac&tualizar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.groupPanel1.Controls.Add(this.buttonX2);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.btnAgregar);
            this.groupPanel1.Controls.Add(this.cmbCategoria);
            this.groupPanel1.Controls.Add(this.txtCantidad);
            this.groupPanel1.Controls.Add(this.txtNombre);
            this.groupPanel1.Controls.Add(this.txtSerie);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(4, 58);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(768, 140);
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
            this.groupPanel1.TabIndex = 11;
            this.groupPanel1.Text = "Agregar Equipos";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(539, 71);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 29);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 7;
            this.buttonX2.Text = "&Salir";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
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
            this.reflectionLabel1.Location = new System.Drawing.Point(255, -6);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(265, 70);
            this.reflectionLabel1.TabIndex = 12;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Administración de </i><font color=\"Orange\">EQUIPOS</font></" +
    "font></b>";
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reflectionImage1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.BackgroundImage = global::Instrumental_Desktop.Properties.Resources.product_sx_011;
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.ForeColor = System.Drawing.Color.Black;
            this.reflectionImage1.Location = new System.Drawing.Point(509, -14);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(61, 78);
            this.reflectionImage1.TabIndex = 13;
            // 
            // superValidator1
            // 
            this.superValidator1.CancelValidatingOnControl = false;
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Este campo es requerido.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Este campo es requerido.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "Este campo es requerido.";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Este campo es requerido.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dgEquipos);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.reflectionImage1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Equipos";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Equipos_FormClosing);
            this.Load += new System.EventHandler(this.Equipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipotipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerequiposBindingSource)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerie;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.Editors.IntegerInput txtCantidad;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCategoria;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgEquipos;
        private System.Windows.Forms.BindingSource obtenerequiposBindingSource;
        private InstrumentalDataSet instrumentalDataSet;
        private InstrumentalDataSetTableAdapters.obtener_equiposTableAdapter obtener_equiposTableAdapter;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private InstrumentalDataSetTableAdapters.equipoTableAdapter equipoTableAdapter;
        private System.Windows.Forms.BindingSource equipotipoBindingSource;
        private InstrumentalDataSetTableAdapters.equipo_tipoTableAdapter equipo_tipoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqserieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqstockDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
    }
}