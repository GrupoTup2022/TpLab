namespace TpLab.Genagamer
{
    partial class consulta_funciones_mas_vendidas
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBmes = new System.Windows.Forms.ComboBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloPeliculaCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBgeneros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultarTickets = new System.Windows.Forms.Button();
            this.txtCantidadTickets = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBmes);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.CBgeneros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 451);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "5 peliculas mas vistas según el mes y género de este año:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CBmes
            // 
            this.CBmes.FormattingEnabled = true;
            this.CBmes.Location = new System.Drawing.Point(159, 90);
            this.CBmes.Name = "CBmes";
            this.CBmes.Size = new System.Drawing.Size(133, 23);
            this.CBmes.TabIndex = 6;
            this.CBmes.SelectedIndexChanged += new System.EventHandler(this.CBmes_SelectedIndexChanged);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(159, 140);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(121, 23);
            this.btn_consultar.TabIndex = 5;
            this.btn_consultar.Text = "CONSULTAR";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCLM,
            this.tituloPeliculaCLM,
            this.generoCLM});
            this.dataGridView1.Location = new System.Drawing.Point(30, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(495, 236);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCLM
            // 
            this.idCLM.HeaderText = "id";
            this.idCLM.Name = "idCLM";
            // 
            // tituloPeliculaCLM
            // 
            this.tituloPeliculaCLM.HeaderText = "Titulo de la pelicula";
            this.tituloPeliculaCLM.Name = "tituloPeliculaCLM";
            this.tituloPeliculaCLM.Width = 200;
            // 
            // generoCLM
            // 
            this.generoCLM.HeaderText = "Genero de la pelicula";
            this.generoCLM.Name = "generoCLM";
            this.generoCLM.Width = 150;
            // 
            // CBgeneros
            // 
            this.CBgeneros.FormattingEnabled = true;
            this.CBgeneros.Location = new System.Drawing.Point(159, 33);
            this.CBgeneros.Name = "CBgeneros";
            this.CBgeneros.Size = new System.Drawing.Size(158, 23);
            this.CBgeneros.TabIndex = 2;
            this.CBgeneros.SelectedIndexChanged += new System.EventHandler(this.CBgeneros_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione un mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione un género:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(870, 465);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultarTickets);
            this.groupBox2.Controls.Add(this.txtCantidadTickets);
            this.groupBox2.Location = new System.Drawing.Point(698, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(274, 115);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad de tickets vendidos el año pasado de genero accion";
            // 
            // btnConsultarTickets
            // 
            this.btnConsultarTickets.Location = new System.Drawing.Point(85, 86);
            this.btnConsultarTickets.Name = "btnConsultarTickets";
            this.btnConsultarTickets.Size = new System.Drawing.Size(100, 23);
            this.btnConsultarTickets.TabIndex = 7;
            this.btnConsultarTickets.Text = "CONSULTAR";
            this.btnConsultarTickets.UseVisualStyleBackColor = true;
            this.btnConsultarTickets.Click += new System.EventHandler(this.btnConsultarTickets_Click);
            // 
            // txtCantidadTickets
            // 
            this.txtCantidadTickets.Location = new System.Drawing.Point(85, 45);
            this.txtCantidadTickets.Name = "txtCantidadTickets";
            this.txtCantidadTickets.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadTickets.TabIndex = 0;
            // 
            // consulta_funciones_mas_vendidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "consulta_funciones_mas_vendidas";
            this.Text = "consulta_funciones_mas_vendidas";
            this.Load += new System.EventHandler(this.consulta_funciones_mas_vendidas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btn_consultar;
        private DataGridView dataGridView1;
        private ComboBox CBgeneros;
        private Label label3;
        private Label label2;
        private Button btnCancelar;
        private ComboBox CBmes;
        private GroupBox groupBox2;
        private TextBox txtCantidadTickets;
        private Button btnConsultarTickets;
        private DataGridViewTextBoxColumn idCLM;
        private DataGridViewTextBoxColumn tituloPeliculaCLM;
        private DataGridViewTextBoxColumn generoCLM;
    }
}