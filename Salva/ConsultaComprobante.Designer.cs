﻿namespace TpLab.Salva
{
    partial class ConsultaComprobante
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
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dataSetTotalYear1 = new TpLab.Nicolas.DataSetTotalYear();
            this.dgvComprobante = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cbFormaVenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTotalYear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(122, 46);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(160, 27);
            this.dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(334, 46);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(160, 27);
            this.dtpHasta.TabIndex = 1;
            // 
            // dataSetTotalYear1
            // 
            this.dataSetTotalYear1.DataSetName = "DataSetTotalYear";
            this.dataSetTotalYear1.Namespace = "http://tempuri.org/DataSetTotalYear.xsd";
            this.dataSetTotalYear1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvComprobante
            // 
            this.dgvComprobante.AllowUserToAddRows = false;
            this.dgvComprobante.AllowUserToDeleteRows = false;
            this.dgvComprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvComprobante.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobante.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvComprobante.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvComprobante.Location = new System.Drawing.Point(22, 178);
            this.dgvComprobante.Name = "dgvComprobante";
            this.dgvComprobante.ReadOnly = true;
            this.dgvComprobante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvComprobante.RowTemplate.Height = 29;
            this.dgvComprobante.Size = new System.Drawing.Size(663, 367);
            this.dgvComprobante.TabIndex = 2;
            this.dgvComprobante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobante_CellContentClick);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFiltrar.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltrar.Location = new System.Drawing.Point(549, 73);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(121, 48);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TpLab.Properties.Resources.LogoPng;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Miriam Libre", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUser.Location = new System.Drawing.Point(122, 14);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(81, 29);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Desde:";
            // 
            // cbFormaVenta
            // 
            this.cbFormaVenta.FormattingEnabled = true;
            this.cbFormaVenta.Location = new System.Drawing.Point(298, 125);
            this.cbFormaVenta.Name = "cbFormaVenta";
            this.cbFormaVenta.Size = new System.Drawing.Size(196, 28);
            this.cbFormaVenta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(334, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam Libre", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(122, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Forma de Pago:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TpLab.Properties.Resources.document;
            this.pictureBox2.Location = new System.Drawing.Point(617, 474);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // ConsultaComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(712, 573);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbFormaVenta);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvComprobante);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Name = "ConsultaComprobante";
            this.Text = "ConsultaComprobante";
            this.Load += new System.EventHandler(this.ConsultaComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTotalYear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Nicolas.DataSetTotalYear dataSetTotalYear1;
        private DataGridView dgvComprobante;
        private Button btnFiltrar;
        private PictureBox pictureBox1;
        private Label lblUser;
        private ComboBox cbFormaVenta;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}