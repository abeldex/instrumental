namespace Instrumental_Desktop
{
    partial class Practicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Practicas));
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtNumero = new DevComponents.Editors.IntegerInput();
            this.cmbMateria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentalDataSet = new Instrumental_Desktop.InstrumentalDataSet();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgPracticas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.practicanumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practicanombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.materiaTableAdapter();
            this.practicaTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.practicaTableAdapter();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Campo requerido.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Campo requerido.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.reflectionLabel1.Location = new System.Drawing.Point(224, -2);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(293, 70);
            this.reflectionLabel1.TabIndex = 22;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Administración de </i><font color=\"Orange\">PRÁCTICAS</font>" +
    "</font></b>";
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
            this.reflectionImage1.Image = global::Instrumental_Desktop.Properties.Resources.geodesia;
            this.reflectionImage1.Location = new System.Drawing.Point(537, -2);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(111, 102);
            this.reflectionImage1.TabIndex = 23;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.groupPanel1.Controls.Add(this.txtNumero);
            this.groupPanel1.Controls.Add(this.cmbMateria);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnSalir);
            this.groupPanel1.Controls.Add(this.btnActualizar);
            this.groupPanel1.Controls.Add(this.btnAgregar);
            this.groupPanel1.Controls.Add(this.txtNombre);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Location = new System.Drawing.Point(1, 69);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(785, 142);
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
            this.groupPanel1.TabIndex = 24;
            this.groupPanel1.Text = "Agregar una Práctica";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNumero.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtNumero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNumero.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(242, 43);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ShowUpDown = true;
            this.txtNumero.Size = new System.Drawing.Size(80, 22);
            this.txtNumero.TabIndex = 31;
            this.superValidator1.SetValidator1(this.txtNumero, this.requiredFieldValidator1);
            // 
            // cmbMateria
            // 
            this.cmbMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMateria.DataSource = this.materiaBindingSource;
            this.cmbMateria.DisplayMember = "materia_nombre";
            this.cmbMateria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMateria.ForeColor = System.Drawing.Color.Black;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.ItemHeight = 16;
            this.cmbMateria.Location = new System.Drawing.Point(242, 9);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(254, 22);
            this.cmbMateria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbMateria.TabIndex = 30;
            this.cmbMateria.ValueMember = "materia_codigo";
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            this.cmbMateria.SelectedValueChanged += new System.EventHandler(this.cmbMateria_SelectedValueChanged);
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "materia";
            this.materiaBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // instrumentalDataSet
            // 
            this.instrumentalDataSet.DataSetName = "InstrumentalDataSet";
            this.instrumentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.labelX3.Location = new System.Drawing.Point(153, 7);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 23);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "Materia:";
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
            this.labelX1.Location = new System.Drawing.Point(152, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(84, 23);
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "No. de Práctica:";
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalir.Location = new System.Drawing.Point(535, 80);
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
            this.btnActualizar.Location = new System.Drawing.Point(535, 43);
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
            this.btnAgregar.Location = new System.Drawing.Point(535, 9);
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
            this.txtNombre.Location = new System.Drawing.Point(242, 73);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 43);
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
            this.labelX2.Location = new System.Drawing.Point(152, 74);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Nombre:";
            // 
            // dgPracticas
            // 
            this.dgPracticas.AllowUserToOrderColumns = true;
            this.dgPracticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPracticas.AutoGenerateColumns = false;
            this.dgPracticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPracticas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPracticas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPracticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.practicanumeroDataGridViewTextBoxColumn,
            this.practicanombreDataGridViewTextBoxColumn});
            this.dgPracticas.DataSource = this.practicaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPracticas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPracticas.EnableHeadersVisualStyles = false;
            this.dgPracticas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgPracticas.Location = new System.Drawing.Point(1, 217);
            this.dgPracticas.Name = "dgPracticas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPracticas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPracticas.Size = new System.Drawing.Size(785, 242);
            this.dgPracticas.TabIndex = 25;
            this.dgPracticas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgPracticas_DataError);
            // 
            // practicanumeroDataGridViewTextBoxColumn
            // 
            this.practicanumeroDataGridViewTextBoxColumn.DataPropertyName = "practica_numero";
            this.practicanumeroDataGridViewTextBoxColumn.FillWeight = 15F;
            this.practicanumeroDataGridViewTextBoxColumn.HeaderText = "PRÁCTICA NÚMERO";
            this.practicanumeroDataGridViewTextBoxColumn.Name = "practicanumeroDataGridViewTextBoxColumn";
            // 
            // practicanombreDataGridViewTextBoxColumn
            // 
            this.practicanombreDataGridViewTextBoxColumn.DataPropertyName = "practica_nombre";
            this.practicanombreDataGridViewTextBoxColumn.HeaderText = "PRÁCTICA NOMBRE";
            this.practicanombreDataGridViewTextBoxColumn.Name = "practicanombreDataGridViewTextBoxColumn";
            // 
            // practicaBindingSource
            // 
            this.practicaBindingSource.DataMember = "practica";
            this.practicaBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // practicaTableAdapter
            // 
            this.practicaTableAdapter.ClearBeforeFill = true;
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.Enabled = false;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Campo requerido.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Campo requerido.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // Practicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 461);
            this.Controls.Add(this.dgPracticas);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.reflectionImage1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Practicas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practicas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Practicas_FormClosing);
            this.Load += new System.EventHandler(this.Practicas_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.IntegerInput txtNumero;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMateria;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.ButtonX btnActualizar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgPracticas;
        private InstrumentalDataSet instrumentalDataSet;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private InstrumentalDataSetTableAdapters.materiaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.BindingSource practicaBindingSource;
        private InstrumentalDataSetTableAdapters.practicaTableAdapter practicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn practicanumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn practicanombreDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
    }
}