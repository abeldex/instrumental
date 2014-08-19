namespace Instrumental_Desktop
{
    partial class Practica_Profesores
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
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.lbProfesor = new System.Windows.Forms.ListBox();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentalDataSet = new Instrumental_Desktop.InstrumentalDataSet();
            this.profesorTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.profesorTableAdapter();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lbMateria = new System.Windows.Forms.ListBox();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.materiaTableAdapter();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbPractica = new System.Windows.Forms.ListBox();
            this.practicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.practicaTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.practicaTableAdapter();
            this.dgPracticas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACTICADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtenerpracticaprofesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtener_practica_profesorTableAdapter = new Instrumental_Desktop.InstrumentalDataSetTableAdapters.obtener_practica_profesorTableAdapter();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerpracticaprofesorBindingSource)).BeginInit();
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
            this.reflectionLabel1.Location = new System.Drawing.Point(341, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(424, 70);
            this.reflectionLabel1.TabIndex = 24;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Administración de </i><font color=\"Orange\">PRÁCTICAS A PROF" +
    "ESORES</font></font></b>";
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
            this.reflectionImage1.Image = global::Instrumental_Desktop.Properties.Resources.asign_prof;
            this.reflectionImage1.Location = new System.Drawing.Point(771, 0);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(111, 82);
            this.reflectionImage1.TabIndex = 25;
            // 
            // lbProfesor
            // 
            this.lbProfesor.BackColor = System.Drawing.Color.White;
            this.lbProfesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProfesor.DataSource = this.profesorBindingSource;
            this.lbProfesor.DisplayMember = "profesor_nombre";
            this.lbProfesor.ForeColor = System.Drawing.Color.Black;
            this.lbProfesor.FormattingEnabled = true;
            this.lbProfesor.Location = new System.Drawing.Point(17, 23);
            this.lbProfesor.Name = "lbProfesor";
            this.lbProfesor.Size = new System.Drawing.Size(280, 91);
            this.lbProfesor.TabIndex = 26;
            this.lbProfesor.ValueMember = "profesor_codigo";
            this.lbProfesor.SelectedIndexChanged += new System.EventHandler(this.lbProfesor_SelectedIndexChanged);
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "profesor";
            this.profesorBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // instrumentalDataSet
            // 
            this.instrumentalDataSet.DataSetName = "InstrumentalDataSet";
            this.instrumentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(116, -5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "PROFESORES";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(439, -5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 28;
            this.labelX2.Text = "MATERIAS";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // lbMateria
            // 
            this.lbMateria.BackColor = System.Drawing.Color.White;
            this.lbMateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMateria.DataSource = this.materiaBindingSource;
            this.lbMateria.DisplayMember = "materia_nombre";
            this.lbMateria.ForeColor = System.Drawing.Color.Black;
            this.lbMateria.FormattingEnabled = true;
            this.lbMateria.Location = new System.Drawing.Point(315, 23);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(318, 91);
            this.lbMateria.TabIndex = 29;
            this.lbMateria.ValueMember = "materia_codigo";
            this.lbMateria.SelectedIndexChanged += new System.EventHandler(this.lbMateria_SelectedIndexChanged);
            this.lbMateria.SelectedValueChanged += new System.EventHandler(this.lbMateria_SelectedValueChanged);
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "materia";
            this.materiaBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.groupPanel1.Controls.Add(this.lbPractica);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.btnSalir);
            this.groupPanel1.Controls.Add(this.lbMateria);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.btnActualizar);
            this.groupPanel1.Controls.Add(this.btnAgregar);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.lbProfesor);
            this.groupPanel1.Location = new System.Drawing.Point(1, 74);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1178, 195);
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
            this.groupPanel1.TabIndex = 30;
            this.groupPanel1.Text = "Asignar una Práctica";
            // 
            // lbPractica
            // 
            this.lbPractica.BackColor = System.Drawing.Color.White;
            this.lbPractica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPractica.DataSource = this.practicaBindingSource;
            this.lbPractica.DisplayMember = "practica_nombre";
            this.lbPractica.ForeColor = System.Drawing.Color.Black;
            this.lbPractica.FormattingEnabled = true;
            this.lbPractica.Location = new System.Drawing.Point(661, 23);
            this.lbPractica.Name = "lbPractica";
            this.lbPractica.Size = new System.Drawing.Size(467, 91);
            this.lbPractica.TabIndex = 31;
            this.lbPractica.ValueMember = "practica_codigo";
            this.lbPractica.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // practicaBindingSource
            // 
            this.practicaBindingSource.DataMember = "practica";
            this.practicaBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(849, -5);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 30;
            this.labelX3.Text = "PRÁCTICA";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalir.Location = new System.Drawing.Point(661, 133);
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
            this.btnActualizar.Location = new System.Drawing.Point(558, 133);
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
            this.btnAgregar.Location = new System.Drawing.Point(451, 133);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Asignar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // practicaTableAdapter
            // 
            this.practicaTableAdapter.ClearBeforeFill = true;
            // 
            // dgPracticas
            // 
            this.dgPracticas.AllowUserToOrderColumns = true;
            this.dgPracticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPracticas.AutoGenerateColumns = false;
            this.dgPracticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPracticas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
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
            this.Column1,
            this.mATERIADataGridViewTextBoxColumn,
            this.pRACTICADataGridViewTextBoxColumn});
            this.dgPracticas.DataSource = this.obtenerpracticaprofesorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPracticas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPracticas.EnableHeadersVisualStyles = false;
            this.dgPracticas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.highlighter1.SetHighlightColor(this.dgPracticas, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
            this.highlighter1.SetHighlightOnFocus(this.dgPracticas, true);
            this.dgPracticas.Location = new System.Drawing.Point(1, 275);
            this.dgPracticas.Name = "dgPracticas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPracticas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPracticas.Size = new System.Drawing.Size(1178, 186);
            this.dgPracticas.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "practica_codigo";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // mATERIADataGridViewTextBoxColumn
            // 
            this.mATERIADataGridViewTextBoxColumn.DataPropertyName = "MATERIA";
            this.mATERIADataGridViewTextBoxColumn.FillWeight = 50F;
            this.mATERIADataGridViewTextBoxColumn.HeaderText = "MATERIA";
            this.mATERIADataGridViewTextBoxColumn.Name = "mATERIADataGridViewTextBoxColumn";
            // 
            // pRACTICADataGridViewTextBoxColumn
            // 
            this.pRACTICADataGridViewTextBoxColumn.DataPropertyName = "PRACTICA";
            this.pRACTICADataGridViewTextBoxColumn.HeaderText = "PRACTICA";
            this.pRACTICADataGridViewTextBoxColumn.Name = "pRACTICADataGridViewTextBoxColumn";
            // 
            // obtenerpracticaprofesorBindingSource
            // 
            this.obtenerpracticaprofesorBindingSource.DataMember = "obtener_practica_profesor";
            this.obtenerpracticaprofesorBindingSource.DataSource = this.instrumentalDataSet;
            // 
            // obtener_practica_profesorTableAdapter
            // 
            this.obtener_practica_profesorTableAdapter.ClearBeforeFill = true;
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            this.highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Orange;
            // 
            // Practica_Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 461);
            this.Controls.Add(this.dgPracticas);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.reflectionImage1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Practica_Profesores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Practicas a Profesores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Practica_Profesores_FormClosing);
            this.Load += new System.EventHandler(this.Practica_Profesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.practicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerpracticaprofesorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private System.Windows.Forms.ListBox lbProfesor;
        private InstrumentalDataSet instrumentalDataSet;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private InstrumentalDataSetTableAdapters.profesorTableAdapter profesorTableAdapter;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ListBox lbMateria;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private InstrumentalDataSetTableAdapters.materiaTableAdapter materiaTableAdapter;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.ButtonX btnActualizar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private System.Windows.Forms.ListBox lbPractica;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.BindingSource practicaBindingSource;
        private InstrumentalDataSetTableAdapters.practicaTableAdapter practicaTableAdapter;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgPracticas;
        private System.Windows.Forms.BindingSource obtenerpracticaprofesorBindingSource;
        private InstrumentalDataSetTableAdapters.obtener_practica_profesorTableAdapter obtener_practica_profesorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACTICADataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    }
}