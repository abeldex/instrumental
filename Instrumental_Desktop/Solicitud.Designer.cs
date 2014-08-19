namespace Instrumental_Desktop
{
    partial class Solicitud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.dgPracticas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentalDataSet = new Instrumental_Desktop.InstrumentalDataSet();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.calendar = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.menuSolicitud = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnDetalles = new DevComponents.DotNetBar.ButtonItem();
            this.btnRecibir = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuSolicitud)).BeginInit();
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
            this.reflectionLabel1.Location = new System.Drawing.Point(222, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(293, 70);
            this.reflectionLabel1.TabIndex = 24;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Administración de </i><font color=\"Orange\">SOLICITUDES</fon" +
    "t></font></b>";
            // 
            // dgPracticas
            // 
            this.dgPracticas.AllowUserToAddRows = false;
            this.dgPracticas.AllowUserToDeleteRows = false;
            this.dgPracticas.AllowUserToOrderColumns = true;
            this.dgPracticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Column1});
            this.menuSolicitud.SetContextMenuEx(this.dgPracticas, this.buttonItem1);
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
            this.dgPracticas.Location = new System.Drawing.Point(5, 278);
            this.dgPracticas.Name = "dgPracticas";
            this.dgPracticas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPracticas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPracticas.RowHeadersVisible = false;
            this.dgPracticas.Size = new System.Drawing.Size(774, 171);
            this.dgPracticas.TabIndex = 32;
            this.dgPracticas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPracticas_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "practica_codigo";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // instrumentalDataSet
            // 
            this.instrumentalDataSet.DataSetName = "InstrumentalDataSet";
            this.instrumentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.groupPanel1.Controls.Add(this.calendar);
            this.groupPanel1.Controls.Add(this.btnSalir);
            this.groupPanel1.Location = new System.Drawing.Point(5, 88);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(785, 184);
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
            this.groupPanel1.TabIndex = 33;
            this.groupPanel1.Text = "Consultar Solicitudes por fecha:";
            // 
            // calendar
            // 
            this.calendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.calendar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.calendar.BackgroundStyle.Class = "MonthCalendarAdv";
            this.calendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.calendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendar.ContainerControlProcessDialogKey = true;
            this.calendar.DisplayMonth = new System.DateTime(2013, 9, 1, 0, 0, 0, 0);
            this.calendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.ForeColor = System.Drawing.Color.Black;
            this.calendar.Location = new System.Drawing.Point(309, 3);
            this.calendar.MarkedDates = new System.DateTime[0];
            this.calendar.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.calendar.MonthlyMarkedDates = new System.DateTime[0];
            this.calendar.Name = "calendar";
            // 
            // 
            // 
            this.calendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendar.Size = new System.Drawing.Size(181, 172);
            this.calendar.TabIndex = 30;
            this.calendar.Text = "monthCalendarAdv1";
            this.calendar.TodayButtonVisible = true;
            this.calendar.TwoLetterDayName = false;
            this.calendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calendar.DateChanged += new System.EventHandler(this.calendar_DateChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalir.Location = new System.Drawing.Point(535, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 26);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.reflectionImage1.Image = global::Instrumental_Desktop.Properties.Resources.solicitud;
            this.reflectionImage1.Location = new System.Drawing.Point(521, 12);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(111, 102);
            this.reflectionImage1.TabIndex = 25;
            // 
            // menuSolicitud
            // 
            this.menuSolicitud.AntiAlias = true;
            this.menuSolicitud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuSolicitud.ForeColor = System.Drawing.Color.Black;
            this.menuSolicitud.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.menuSolicitud.Location = new System.Drawing.Point(12, 12);
            this.menuSolicitud.Name = "menuSolicitud";
            this.menuSolicitud.Size = new System.Drawing.Size(106, 25);
            this.menuSolicitud.Stretch = true;
            this.menuSolicitud.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.menuSolicitud.TabIndex = 34;
            this.menuSolicitud.TabStop = false;
            this.menuSolicitud.Text = "contextMenuBar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDetalles,
            this.btnRecibir});
            this.buttonItem1.Text = "Recibir Equipos";
            // 
            // btnDetalles
            // 
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Text = "Ver Detalles";
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnRecibir
            // 
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Text = "Recibir Equipos";
            // 
            // Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.menuSolicitud);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dgPracticas);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.reflectionImage1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Solicitud";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes";
            this.Load += new System.EventHandler(this.Solicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentalDataSet)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgPracticas;
        private InstrumentalDataSet instrumentalDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv calendar;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.ContextMenuBar menuSolicitud;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnDetalles;
        private DevComponents.DotNetBar.ButtonItem btnRecibir;
    }
}