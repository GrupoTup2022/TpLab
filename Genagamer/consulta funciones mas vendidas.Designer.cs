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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBgeneros = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.idCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloPeliculaCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.DTPmes = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.DTPmes);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.CBgeneros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 451);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones más vendidas según el mes y género:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione un mes:";
            // 
            // CBgeneros
            // 
            this.CBgeneros.FormattingEnabled = true;
            this.CBgeneros.Location = new System.Drawing.Point(159, 33);
            this.CBgeneros.Name = "CBgeneros";
            this.CBgeneros.Size = new System.Drawing.Size(158, 23);
            this.CBgeneros.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCLM,
            this.fechaCLM,
            this.funcionCLM,
            this.tituloPeliculaCLM,
            this.generoCLM,
            this.salaCLM});
            this.dataGridView1.Location = new System.Drawing.Point(19, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(793, 236);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(159, 140);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(121, 23);
            this.btn_consultar.TabIndex = 5;
            this.btn_consultar.Text = "CONSULTAR";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // idCLM
            // 
            this.idCLM.HeaderText = "id";
            this.idCLM.Name = "idCLM";
            // 
            // fechaCLM
            // 
            this.fechaCLM.HeaderText = "Fecha";
            this.fechaCLM.Name = "fechaCLM";
            // 
            // funcionCLM
            // 
            this.funcionCLM.HeaderText = "Funcion";
            this.funcionCLM.Name = "funcionCLM";
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
            // salaCLM
            // 
            this.salaCLM.HeaderText = "Sala";
            this.salaCLM.Name = "salaCLM";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(738, 469);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // DTPmes
            // 
            this.DTPmes.Location = new System.Drawing.Point(159, 87);
            this.DTPmes.Name = "DTPmes";
            this.DTPmes.Size = new System.Drawing.Size(134, 23);
            this.DTPmes.TabIndex = 6;
            this.DTPmes.ValueChanged += new System.EventHandler(this.DTPmes_ValueChanged);
            // 
            // consulta_funciones_mas_vendidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 500);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "consulta_funciones_mas_vendidas";
            this.Text = "consulta_funciones_mas_vendidas";
            this.Load += new System.EventHandler(this.consulta_funciones_mas_vendidas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btn_consultar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idCLM;
        private DataGridViewTextBoxColumn fechaCLM;
        private DataGridViewTextBoxColumn funcionCLM;
        private DataGridViewTextBoxColumn tituloPeliculaCLM;
        private DataGridViewTextBoxColumn generoCLM;
        private DataGridViewTextBoxColumn salaCLM;
        private ComboBox CBgeneros;
        private Label label3;
        private Label label2;
        private Button btnCancelar;
        private DateTimePicker DTPmes;
    }
}