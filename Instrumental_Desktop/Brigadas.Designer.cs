namespace Instrumental_Desktop
{
    partial class Brigadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brigadas));
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbTipoBrigada = new System.Windows.Forms.ComboBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtSemestre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtGrupo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgBrigadas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bricodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brinombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brigrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brigadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentalDataSet = new Instrumental_Desktop.InstrumentalDataSet();
            this.brigadaTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.brigadaTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Campo Requerido.");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Campo requerido.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.fKalumnobrigadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.alumnoTableAdapter();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBrigadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKalumnobrigadaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.reflectionLabel1.Location = new System.Drawing.Point(257, -1);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(293, 70);
            this.reflectionLabel1.TabIndex = 18;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Administración de </i><font color=\"Orange\">BRIGADAS</font><" +
    "/font></b>";
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
            this.reflectionImage1.Image = global::Instrumental_Desktop.Properties.Resources._1379300865_testimonials1;
            this.reflectionImage1.Location = new System.Drawing.Point(528, -1);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(111, 102);
            this.reflectionImage1.TabIndex = 19;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmbTipoBrigada);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txtSemestre);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.btnSalir);
            this.groupPanel1.Controls.Add(this.btnActualizar);
            this.groupPanel1.Controls.Add(this.btnAgregar);
            this.groupPanel1.Controls.Add(this.txtNombre);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtGrupo);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(-2, 66);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(879, 144);
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
            this.groupPanel1.TabIndex = 20;
            this.groupPanel1.Text = "Agregar Alumnos";
            // 
            // cmbTipoBrigada
            // 
            this.cmbTipoBrigada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoBrigada.BackColor = System.Drawing.Color.White;
            this.cmbTipoBrigada.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoBrigada.FormattingEnabled = true;
            this.cmbTipoBrigada.Items.AddRange(new object[] {
            "PA",
            "SS",
            "PP",
            "PI"});
            this.cmbTipoBrigada.Location = new System.Drawing.Point(265, 97);
            this.cmbTipoBrigada.Name = "cmbTipoBrigada";
            this.cmbTipoBrigada.Size = new System.Drawing.Size(87, 21);
            this.cmbTipoBrigada.TabIndex = 30;
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
            this.labelX4.Location = new System.Drawing.Point(227, 96);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(40, 23);
            this.labelX4.TabIndex = 29;
            this.labelX4.Text = "Tipo:";
            // 
            // txtSemestre
            // 
            this.txtSemestre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSemestre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSemestre.Border.Class = "TextBoxBorder";
            this.txtSemestre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSemestre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSemestre.FocusHighlightColor = System.Drawing.Color.Maroon;
            this.txtSemestre.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtSemestre, true);
            this.txtSemestre.Location = new System.Drawing.Point(265, 70);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(87, 22);
            this.txtSemestre.TabIndex = 28;
            this.superValidator1.SetValidator1(this.txtSemestre, this.requiredFieldValidator1);
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
            this.labelX3.Location = new System.Drawing.Point(203, 69);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(67, 23);
            this.labelX3.TabIndex = 27;
            this.labelX3.Text = "Semestre:";
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalir.Location = new System.Drawing.Point(544, 78);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 26);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnActualizar.Location = new System.Drawing.Point(544, 46);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 26);
            this.btnActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Location = new System.Drawing.Point(544, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.txtNombre.FocusHighlightColor = System.Drawing.Color.Maroon;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtNombre, true);
            this.txtNombre.Location = new System.Drawing.Point(265, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 22);
            this.txtNombre.TabIndex = 17;
            this.superValidator1.SetValidator1(this.txtNombre, this.requiredFieldValidator2);
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
            this.labelX2.Location = new System.Drawing.Point(207, 13);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(52, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Nombre:";
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
            this.txtGrupo.FocusHighlightColor = System.Drawing.Color.Maroon;
            this.txtGrupo.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtGrupo, true);
            this.txtGrupo.Location = new System.Drawing.Point(265, 42);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(87, 22);
            this.txtGrupo.TabIndex = 15;
            this.superValidator1.SetValidator1(this.txtGrupo, this.requiredFieldValidator1);
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
            this.labelX1.Location = new System.Drawing.Point(215, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 23);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "Grupo:";
            // 
            // dgBrigadas
            // 
            this.dgBrigadas.AllowUserToOrderColumns = true;
            this.dgBrigadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBrigadas.AutoGenerateColumns = false;
            this.dgBrigadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBrigadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBrigadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgBrigadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBrigadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bricodigoDataGridViewTextBoxColumn,
            this.brinombreDataGridViewTextBoxColumn,
            this.brigrupoDataGridViewTextBoxColumn});
            this.dgBrigadas.DataSource = this.brigadaBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBrigadas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgBrigadas.EnableHeadersVisualStyles = false;
            this.dgBrigadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.highlighter1.SetHighlightOnFocus(this.dgBrigadas, true);
            this.dgBrigadas.Location = new System.Drawing.Point(-2, 211);
            this.dgBrigadas.Name = "dgBrigadas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBrigadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgBrigadas.Size = new System.Drawing.Size(879, 375);
            this.dgBrigadas.TabIndex = 21;
            this.dgBrigadas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgBrigadas_DataError);
            // 
            // bricodigoDataGridViewTextBoxColumn
            // 
            this.bricodigoDataGridViewTextBoxColumn.DataPropertyName = "bri_codigo";
            this.bricodigoDataGridViewTextBoxColumn.HeaderText = "NÚMERO DE LA BRIGADA";
            this.bricodigoDataGridViewTextBoxColumn.Name = "bricodigoDataGridViewTextBoxColumn";
            this.bricodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brinombreDataGridViewTextBoxColumn
            // 
            this.brinombreDataGridViewTextBoxColumn.DataPropertyName = "bri_nombre";
            this.brinombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE DE LA BRIGADA";
            this.brinombreDataGridViewTextBoxColumn.Name = "brinombreDataGridViewTextBoxColumn";
            // 
            // brigrupoDataGridViewTextBoxColumn
            // 
            this.brigrupoDataGridViewTextBoxColumn.DataPropertyName = "bri_grupo";
            this.brigrupoDataGridViewTextBoxColumn.HeaderText = "GRUPO DE LA BRIGADA";
            this.brigrupoDataGridViewTextBoxColumn.Name = "brigrupoDataGridViewTextBoxColumn";
            // 
            // brigadaBindingSource
            // 
            this.brigadaBindingSource.DataMember = "brigada";
            this.brigadaBindingSource.DataSource = this.instrumentalDataSet;
            this.brigadaBindingSource.CurrentChanged += new System.EventHandler(this.brigadaBindingSource_CurrentChanged);
            // 
            // instrumentalDataSet
            // 
            this.instrumentalDataSet.DataSetName = "InstrumentalDataSet";
            this.instrumentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brigadaTableAdapter
            // 
            this.brigadaTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.BackColor = System.Drawing.Color.White;
            this.fillBy1ToolStrip.ForeColor = System.Drawing.Color.Black;
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(801, 25);
            this.fillBy1ToolStrip.TabIndex = 22;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
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
            this.requiredFieldValidator2.ErrorMessage = "Campo Requerido.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Campo requerido.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            this.highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Orange;
            // 
            // fKalumnobrigadaBindingSource
            // 
            this.fKalumnobrigadaBindingSource.DataMember = "FK_alumno_brigada";
            this.fKalumnobrigadaBindingSource.DataSource = this.brigadaBindingSource;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // Brigadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 598);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dgBrigadas);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Brigadas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BRIGADAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Brigadas_FormClosing);
            this.Load += new System.EventHandler(this.Brigadas_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBrigadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKalumnobrigadaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.ButtonX btnActualizar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGrupo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgBrigadas;
        private InstrumentalDataSet instrumentalDataSet;
        private System.Windows.Forms.BindingSource brigadaBindingSource;
        private InstrumentalDataSetTableAdapters.brigadaTableAdapter brigadaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bricodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brinombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brigrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.ComboBox cmbTipoBrigada;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSemestre;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.BindingSource fKalumnobrigadaBindingSource;
        private InstrumentalDataSetTableAdapters.alumnoTableAdapter alumnoTableAdapter;
    }
}