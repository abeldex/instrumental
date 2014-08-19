namespace Instrumental_Desktop
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgCategoria = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.eq_tipo_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eqtiponombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipotipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentalDataSet = new Instrumental_Desktop.InstrumentalDataSet();
            this.equipo_tipoTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.equipo_tipoTableAdapter();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("El campo ID no puede estar vacio.");
            this.rangeValidator1 = new DevComponents.DotNetBar.Validator.RangeValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("El campo Nombre no puede estar vacio.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipotipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).BeginInit();
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
            this.reflectionLabel1.Location = new System.Drawing.Point(157, -4);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(410, 70);
            this.reflectionLabel1.TabIndex = 14;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Administración de </i><font color=\"Orange\">CATEGORIAS DE EQ" +
    "UIPOS</font></font></b>";
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reflectionImage1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.BackgroundImage = global::Instrumental_Desktop.Properties.Resources.red_metal_tool_box_hi;
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.ForeColor = System.Drawing.Color.Black;
            this.reflectionImage1.Location = new System.Drawing.Point(574, 3);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(75, 58);
            this.reflectionImage1.TabIndex = 15;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.groupPanel1.Controls.Add(this.txtID);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.buttonX2);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.btnAgregar);
            this.groupPanel1.Controls.Add(this.txtNombre);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Location = new System.Drawing.Point(3, 67);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(776, 75);
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
            this.groupPanel1.TabIndex = 16;
            this.groupPanel1.Text = "Agregar Nueva Categoría";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.FocusHighlightColor = System.Drawing.Color.Maroon;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtID, true);
            this.txtID.Location = new System.Drawing.Point(104, 8);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 22);
            this.txtID.TabIndex = 1;
            this.superValidator1.SetValidator1(this.txtID, this.requiredFieldValidator1);
            this.superValidator1.SetValidator2(this.txtID, this.rangeValidator1);
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
            this.labelX1.Location = new System.Drawing.Point(75, 6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(23, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "ID:";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(691, 6);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 26);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 5;
            this.buttonX2.Text = "&Salir";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(610, 6);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 26);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Ac&tualizar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Location = new System.Drawing.Point(529, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "&Agregar";
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
            this.txtNombre.Location = new System.Drawing.Point(264, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 22);
            this.txtNombre.TabIndex = 2;
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
            this.labelX2.Location = new System.Drawing.Point(199, 8);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(93, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Nombre:";
            // 
            // dgCategoria
            // 
            this.dgCategoria.AllowUserToOrderColumns = true;
            this.dgCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCategoria.AutoGenerateColumns = false;
            this.dgCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eq_tipo_codigo,
            this.eqtiponombreDataGridViewTextBoxColumn});
            this.dgCategoria.DataSource = this.equipotipoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCategoria.EnableHeadersVisualStyles = false;
            this.dgCategoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.highlighter1.SetHighlightOnFocus(this.dgCategoria, true);
            this.dgCategoria.Location = new System.Drawing.Point(3, 151);
            this.dgCategoria.Name = "dgCategoria";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCategoria.Size = new System.Drawing.Size(774, 617);
            this.dgCategoria.TabIndex = 6;
            this.dgCategoria.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgCategoria_DataError);
            // 
            // eq_tipo_codigo
            // 
            this.eq_tipo_codigo.DataPropertyName = "eq_tipo_codigo";
            this.eq_tipo_codigo.HeaderText = "ID";
            this.eq_tipo_codigo.Name = "eq_tipo_codigo";
            // 
            // eqtiponombreDataGridViewTextBoxColumn
            // 
            this.eqtiponombreDataGridViewTextBoxColumn.DataPropertyName = "eq_tipo_nombre";
            this.eqtiponombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE DE LA CATEGORÍA";
            this.eqtiponombreDataGridViewTextBoxColumn.Name = "eqtiponombreDataGridViewTextBoxColumn";
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
            // equipo_tipoTableAdapter
            // 
            this.equipo_tipoTableAdapter.ClearBeforeFill = true;
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
            this.requiredFieldValidator1.ErrorMessage = "El campo ID no puede estar vacio.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.ErrorMessage = "El ID debe ser mayor a 0 y no estar repetido con los registros.";
            this.rangeValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.rangeValidator1.MaximumValue = "9999";
            this.rangeValidator1.MinimumValue = "0";
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "El campo Nombre no puede estar vacio.";
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
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 773);
            this.Controls.Add(this.dgCategoria);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Categorias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias de Equipos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Categorias_FormClosing);
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipotipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgCategoria;
        private InstrumentalDataSet instrumentalDataSet;
        private System.Windows.Forms.BindingSource equipotipoBindingSource;
        private InstrumentalDataSetTableAdapters.equipo_tipoTableAdapter equipo_tipoTableAdapter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eq_tipo_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqtiponombreDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RangeValidator rangeValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
    }
}