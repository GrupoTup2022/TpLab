﻿namespace TpLab.Luks
{
    partial class PagosForm
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
            this.cb_fp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_restante = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_terminar = new System.Windows.Forms.Button();
            this.FP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_fp
            // 
            this.cb_fp.FormattingEnabled = true;
            this.cb_fp.Location = new System.Drawing.Point(126, 21);
            this.cb_fp.Name = "cb_fp";
            this.cb_fp.Size = new System.Drawing.Size(121, 23);
            this.cb_fp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forma de Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto:";
            // 
            // tb_monto
            // 
            this.tb_monto.Location = new System.Drawing.Point(126, 77);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(121, 23);
            this.tb_monto.TabIndex = 3;
            // 
            // dgv_lista
            // 
            this.dgv_lista.AllowUserToAddRows = false;
            this.dgv_lista.AllowUserToDeleteRows = false;
            this.dgv_lista.AllowUserToResizeColumns = false;
            this.dgv_lista.AllowUserToResizeRows = false;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FP,
            this.Monto});
            this.dgv_lista.Location = new System.Drawing.Point(264, 12);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.RowHeadersVisible = false;
            this.dgv_lista.RowTemplate.Height = 25;
            this.dgv_lista.Size = new System.Drawing.Size(147, 210);
            this.dgv_lista.TabIndex = 4;
            this.dgv_lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto Restante:";
            // 
            // lbl_restante
            // 
            this.lbl_restante.AutoSize = true;
            this.lbl_restante.Location = new System.Drawing.Point(166, 170);
            this.lbl_restante.Name = "lbl_restante";
            this.lbl_restante.Size = new System.Drawing.Size(38, 15);
            this.lbl_restante.TabIndex = 6;
            this.lbl_restante.Text = "label4";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(166, 207);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(38, 15);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "label5";
            this.lbl_total.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Monto Total:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(143, 119);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_terminar
            // 
            this.btn_terminar.Location = new System.Drawing.Point(336, 228);
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.Size = new System.Drawing.Size(75, 23);
            this.btn_terminar.TabIndex = 10;
            this.btn_terminar.Text = "Terminar";
            this.btn_terminar.UseVisualStyleBackColor = true;
            this.btn_terminar.Click += new System.EventHandler(this.btn_terminar_Click);
            // 
            // FP
            // 
            this.FP.HeaderText = "Forma Pago";
            this.FP.Name = "FP";
            this.FP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FP.Width = 70;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 70;
            // 
            // PagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 255);
            this.Controls.Add(this.btn_terminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_restante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_lista);
            this.Controls.Add(this.tb_monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_fp);
            this.Name = "PagosForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_fp;
        private Label label1;
        private Label label2;
        private TextBox tb_monto;
        private DataGridView dgv_lista;
        private Label label3;
        private Label lbl_restante;
        private Label lbl_total;
        private Label label6;
        private Button btn_agregar;
        private Button btn_terminar;
        private DataGridViewTextBoxColumn FP;
        private DataGridViewTextBoxColumn Monto;
    }
}