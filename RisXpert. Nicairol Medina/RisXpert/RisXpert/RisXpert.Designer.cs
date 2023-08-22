namespace RisXpert
{
    partial class RisXpert
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button10 = new Button();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TBDAÑO = new TextBox();
            TBRIESGO = new TextBox();
            TBNOMBRE = new TextBox();
            button2 = new Button();
            button1 = new Button();
            DGV1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            RIESGO = new DataGridViewTextBoxColumn();
            DAÑO = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            DGV3 = new DataGridView();
            SUSTITUCION = new DataGridViewTextBoxColumn();
            EXTENSION = new DataGridViewTextBoxColumn();
            FUNCION = new DataGridViewTextBoxColumn();
            PROFUNDIDAD = new DataGridViewTextBoxColumn();
            AGRESION = new DataGridViewTextBoxColumn();
            VULNERABILIDAD = new DataGridViewTextBoxColumn();
            DGV2 = new DataGridView();
            IDENTIFICACION = new DataGridViewTextBoxColumn();
            ANALISTA = new DataGridViewTextBoxColumn();
            AMENAZA = new DataGridViewTextBoxColumn();
            PERJUICIO = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            button5 = new Button();
            DGV5 = new DataGridView();
            IMPORTANCIA_DEL_SUCESO = new DataGridViewTextBoxColumn();
            DAÑOS_OCASIONADOS = new DataGridViewTextBoxColumn();
            CARACTER_DE_RIESGO = new DataGridViewTextBoxColumn();
            PROBABILIDAD_DE_RIESGO = new DataGridViewTextBoxColumn();
            CUANTIFICACION_DE_RIESGO = new DataGridViewTextBoxColumn();
            DGV4 = new DataGridView();
            S = new DataGridViewTextBoxColumn();
            E = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            P = new DataGridViewTextBoxColumn();
            A = new DataGridViewTextBoxColumn();
            V = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            button9 = new Button();
            button7 = new Button();
            DGV6 = new DataGridView();
            IDENTIF = new DataGridViewTextBoxColumn();
            NOM = new DataGridViewTextBoxColumn();
            VALOR_ER_RIESGO = new DataGridViewTextBoxColumn();
            CLASE_DE_RIESGO = new DataGridViewTextBoxColumn();
            MITIGACION = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV4).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV6).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1024, 481);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(button10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(TBDAÑO);
            tabPage1.Controls.Add(TBRIESGO);
            tabPage1.Controls.Add(TBNOMBRE);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(DGV1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1016, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Fase 1";
            tabPage1.Click += tabPage1_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Location = new Point(373, 124);
            button10.Name = "button10";
            button10.Size = new Size(107, 23);
            button10.TabIndex = 13;
            button10.Text = "Pasar";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(486, 174);
            label9.Name = "label9";
            label9.Size = new Size(95, 25);
            label9.TabIndex = 12;
            label9.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(486, 282);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 9;
            label4.Text = "DAÑO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(486, 228);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 8;
            label3.Text = "RIESGO";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // TBDAÑO
            // 
            TBDAÑO.Location = new Point(486, 310);
            TBDAÑO.Name = "TBDAÑO";
            TBDAÑO.Size = new Size(171, 23);
            TBDAÑO.TabIndex = 5;
            // 
            // TBRIESGO
            // 
            TBRIESGO.Location = new Point(486, 256);
            TBRIESGO.Name = "TBRIESGO";
            TBRIESGO.Size = new Size(171, 23);
            TBRIESGO.TabIndex = 4;
            // 
            // TBNAME
            // 
            TBNAME.Location = new Point(486, 202);
            TBNAME.Name = "TBNAME";
            TBNAME.Size = new Size(171, 23);
            TBNAME.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(373, 95);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 2;
            button2.Text = "guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(373, 66);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 1;
            button1.Text = "agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DGV1
            // 
            DGV1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV1.BackgroundColor = SystemColors.ActiveBorder;
            DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV1.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, RIESGO, DAÑO });
            DGV1.Location = new Point(8, 164);
            DGV1.Name = "DGV1";
            DGV1.RowHeadersVisible = false;
            DGV1.RowTemplate.Height = 25;
            DGV1.Size = new Size(472, 330);
            DGV1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // NAME
            // 
            NAME.HeaderText = "NAME";
            NAME.Name = "NAME";
            // 
            // RIESGO
            // 
            RIESGO.HeaderText = "RIESGO";
            RIESGO.Name = "RIESGO";
            // 
            // DAÑO
            // 
            DAÑO.HeaderText = "DAÑO";
            DAÑO.Name = "DAÑO";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(DGV3);
            tabPage2.Controls.Add(DGV2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1016, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Fase 2";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(911, 395);
            button4.Name = "button4";
            button4.Size = new Size(94, 23);
            button4.TabIndex = 3;
            button4.Text = "siguiente";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(911, 424);
            button3.Name = "button3";
            button3.Size = new Size(97, 23);
            button3.TabIndex = 2;
            button3.Text = "color";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DGV3
            // 
            DGV3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV3.BackgroundColor = SystemColors.ActiveBorder;
            DGV3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV3.Columns.AddRange(new DataGridViewColumn[] { SUSTITUCION, EXTENSION, FUNCION, PROFUNDIDAD, AGRESION, VULNERABILIDAD });
            DGV3.Location = new Point(454, 6);
            DGV3.Name = "DGV3";
            DGV3.RowHeadersVisible = false;
            DGV3.RowTemplate.Height = 25;
            DGV3.Size = new Size(372, 258);
            DGV3.TabIndex = 1;
            // 
            // SUSTITUCION
            // 
            SUSTITUCION.HeaderText = "S";
            SUSTITUCION.Name = "SUSTITUCION";
            // 
            // EXTENSION
            // 
            EXTENSION.HeaderText = "E";
            EXTENSION.Name = "EXTENSION";
            // 
            // FUNCION
            // 
            FUNCION.HeaderText = "F";
            FUNCION.Name = "FUNCION";
            // 
            // PROFUNDIDAD
            // 
            PROFUNDIDAD.HeaderText = "P";
            PROFUNDIDAD.Name = "PROFUNDIDAD";
            // 
            // AGRESION
            // 
            AGRESION.HeaderText = "A";
            AGRESION.Name = "AGRESION";
            // 
            // VULNERABILIDAD
            // 
            VULNERABILIDAD.HeaderText = "V";
            VULNERABILIDAD.Name = "VULNERABILIDAD";
            // 
            // DGV2
            // 
            DGV2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV2.BackgroundColor = SystemColors.ActiveBorder;
            DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV2.Columns.AddRange(new DataGridViewColumn[] { IDENTIFICACION, ANALISTA, AMENAZA, PERJUICIO });
            DGV2.Location = new Point(6, 6);
            DGV2.Name = "DGV2";
            DGV2.RowHeadersVisible = false;
            DGV2.RowTemplate.Height = 25;
            DGV2.Size = new Size(442, 258);
            DGV2.TabIndex = 0;
            // 
            // IDENTIFICACION
            // 
            IDENTIFICACION.HeaderText = "ID";
            IDENTIFICACION.Name = "IDENTIFICACION";
            // 
            // ANALISTA
            // 
            ANALISTA.HeaderText = "NOMBRE";
            ANALISTA.Name = "ANALISTA";
            // 
            // AMENAZA
            // 
            AMENAZA.HeaderText = "RIESGO";
            AMENAZA.Name = "AMENAZA";
            // 
            // PERJUICIO
            // 
            PERJUICIO.HeaderText = "DAÑO";
            PERJUICIO.Name = "PERJUICIO";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Transparent;
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(DGV5);
            tabPage3.Controls.Add(DGV4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1016, 453);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Fase 3";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(913, 144);
            button5.Name = "button5";
            button5.Size = new Size(95, 23);
            button5.TabIndex = 2;
            button5.Text = "CALCULAR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // DGV5
            // 
            DGV5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV5.BackgroundColor = SystemColors.ActiveBorder;
            DGV5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV5.Columns.AddRange(new DataGridViewColumn[] { IMPORTANCIA_DEL_SUCESO, DAÑOS_OCASIONADOS, CARACTER_DE_RIESGO, PROBABILIDAD_DE_RIESGO, CUANTIFICACION_DE_RIESGO });
            DGV5.Location = new Point(452, 173);
            DGV5.Name = "DGV5";
            DGV5.RowHeadersVisible = false;
            DGV5.RowTemplate.Height = 25;
            DGV5.Size = new Size(556, 274);
            DGV5.TabIndex = 1;
            // 
            // IMPORTANCIA_DEL_SUCESO
            // 
            IMPORTANCIA_DEL_SUCESO.HeaderText = "IMPORTANCIA";
            IMPORTANCIA_DEL_SUCESO.Name = "IMPORTANCIA_DEL_SUCESO";
            // 
            // DAÑOS_OCASIONADOS
            // 
            DAÑOS_OCASIONADOS.HeaderText = "DAÑOS";
            DAÑOS_OCASIONADOS.Name = "DAÑOS_OCASIONADOS";
            // 
            // CARACTER_DE_RIESGO
            // 
            CARACTER_DE_RIESGO.HeaderText = "CARACTER";
            CARACTER_DE_RIESGO.Name = "CARACTER_DE_RIESGO";
            // 
            // PROBABILIDAD_DE_RIESGO
            // 
            PROBABILIDAD_DE_RIESGO.HeaderText = "PROBABLIDAD";
            PROBABILIDAD_DE_RIESGO.Name = "PROBABILIDAD_DE_RIESGO";
            // 
            // CUANTIFICACION_DE_RIESGO
            // 
            CUANTIFICACION_DE_RIESGO.HeaderText = "CUANTIFICACION";
            CUANTIFICACION_DE_RIESGO.Name = "CUANTIFICACION_DE_RIESGO";
            // 
            // DGV4
            // 
            DGV4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV4.BackgroundColor = SystemColors.ActiveBorder;
            DGV4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV4.Columns.AddRange(new DataGridViewColumn[] { S, E, F, P, A, V });
            DGV4.Location = new Point(8, 173);
            DGV4.Name = "DGV4";
            DGV4.RowHeadersVisible = false;
            DGV4.RowTemplate.Height = 25;
            DGV4.Size = new Size(438, 274);
            DGV4.TabIndex = 0;
            DGV4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // S
            // 
            S.HeaderText = "S";
            S.Name = "S";
            // 
            // E
            // 
            E.HeaderText = "E";
            E.Name = "E";
            // 
            // F
            // 
            F.HeaderText = "F";
            F.Name = "F";
            // 
            // P
            // 
            P.HeaderText = "P";
            P.Name = "P";
            // 
            // A
            // 
            A.HeaderText = "A";
            A.Name = "A";
            // 
            // V
            // 
            V.HeaderText = "V";
            V.Name = "V";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Transparent;
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(DGV6);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1016, 453);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Fase 4";
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(886, 139);
            button9.Name = "button9";
            button9.Size = new Size(122, 23);
            button9.TabIndex = 4;
            button9.Text = "clasif";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(749, 139);
            button7.Name = "button7";
            button7.Size = new Size(122, 23);
            button7.TabIndex = 1;
            button7.Text = "valor";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // DGV6
            // 
            DGV6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV6.BackgroundColor = SystemColors.ActiveBorder;
            DGV6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV6.Columns.AddRange(new DataGridViewColumn[] { IDENTIF, NOM, VALOR_ER_RIESGO, CLASE_DE_RIESGO, MITIGACION });
            DGV6.Location = new Point(8, 168);
            DGV6.Name = "DGV6";
            DGV6.RowHeadersVisible = false;
            DGV6.RowTemplate.Height = 25;
            DGV6.Size = new Size(1002, 279);
            DGV6.TabIndex = 0;
            // 
            // IDENTIF
            // 
            IDENTIF.HeaderText = "ID";
            IDENTIF.Name = "IDENTIF";
            // 
            // NOM
            // 
            NOM.HeaderText = "Nombre";
            NOM.Name = "NOM";
            // 
            // VALOR_ER_RIESGO
            // 
            VALOR_ER_RIESGO.HeaderText = "Valor del Riesgo";
            VALOR_ER_RIESGO.Name = "VALOR_ER_RIESGO";
            // 
            // CLASE_DE_RIESGO
            // 
            CLASE_DE_RIESGO.HeaderText = "Clase de Riesgo";
            CLASE_DE_RIESGO.Name = "CLASE_DE_RIESGO";
            // 
            // MITIGACION
            // 
            MITIGACION.HeaderText = "Mitigación";
            MITIGACION.Name = "MITIGACION";
            // 
            // RisXpert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1024, 493);
            Controls.Add(tabControl1);
            Name = "RisXpert";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV3).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV5).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV4).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView DGV1;
        private TabPage tabPage2;
        private DataGridView DGV2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView DGV3;
        private DataGridView DGV4;
        private DataGridView DGV5;
        private DataGridView DGV6;
        private TextBox TBDAÑO;
        private TextBox TBRIESGO;
        private TextBox TBNOMBRE;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn RIESGO;
        private DataGridViewTextBoxColumn DAÑO;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button7;
        private DataGridViewTextBoxColumn SUSTITUCION;
        private DataGridViewTextBoxColumn EXTENSION;
        private DataGridViewTextBoxColumn FUNCION;
        private DataGridViewTextBoxColumn PROFUNDIDAD;
        private DataGridViewTextBoxColumn AGRESION;
        private DataGridViewTextBoxColumn VULNERABILIDAD;
        private DataGridViewTextBoxColumn IDENTIFICACION;
        private DataGridViewTextBoxColumn ANALISTA;
        private DataGridViewTextBoxColumn AMENAZA;
        private DataGridViewTextBoxColumn PERJUICIO;
        private DataGridViewTextBoxColumn S;
        private DataGridViewTextBoxColumn E;
        private DataGridViewTextBoxColumn F;
        private DataGridViewTextBoxColumn P;
        private DataGridViewTextBoxColumn A;
        private DataGridViewTextBoxColumn V;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label9;
        private Button button10;
        private DataGridViewTextBoxColumn IMPORTANCIA_DEL_SUCESO;
        private DataGridViewTextBoxColumn DAÑOS_OCASIONADOS;
        private DataGridViewTextBoxColumn CARACTER_DE_RIESGO;
        private DataGridViewTextBoxColumn PROBABILIDAD_DE_RIESGO;
        private DataGridViewTextBoxColumn CUANTIFICACION_DE_RIESGO;
        private Button button9;
        private DataGridViewTextBoxColumn IDENTIF;
        private DataGridViewTextBoxColumn NOM;
        private DataGridViewTextBoxColumn VALOR_ER_RIESGO;
        private DataGridViewTextBoxColumn CLASE_DE_RIESGO;
        private DataGridViewTextBoxColumn MITIGACION;
    }
}