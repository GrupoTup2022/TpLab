namespace TpLab.Luks
{
    partial class ComprobanteInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprobanteInsert));
            this.dgv_tickets = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreciosinDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuentoticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePromo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_peli = new System.Windows.Forms.ComboBox();
            this.cbo_sala = new System.Windows.Forms.ComboBox();
            this.cbo_horario = new System.Windows.Forms.ComboBox();
            this.cbo_audio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dgv_Butacas = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.n_cant = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_FormasVenta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_comprobante = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_pagos = new System.Windows.Forms.Button();
            this.cbo_promos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.butacaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Butacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tickets
            // 
            this.dgv_tickets.AllowUserToAddRows = false;
            this.dgv_tickets.AllowUserToDeleteRows = false;
            this.dgv_tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tickets.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.salaticket,
            this.horarioticket,
            this.tituloTicket,
            this.PreciosinDescuento,
            this.Descuentoticket,
            this.NombrePromo,
            this.PrecioTicket});
            this.dgv_tickets.Location = new System.Drawing.Point(557, 32);
            this.dgv_tickets.Name = "dgv_tickets";
            this.dgv_tickets.ReadOnly = true;
            this.dgv_tickets.RowHeadersVisible = false;
            this.dgv_tickets.RowHeadersWidth = 51;
            this.dgv_tickets.RowTemplate.Height = 25;
            this.dgv_tickets.Size = new System.Drawing.Size(620, 352);
            this.dgv_tickets.TabIndex = 0;
            this.dgv_tickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tickets_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero de Butaca";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // salaticket
            // 
            this.salaticket.HeaderText = "Sala";
            this.salaticket.MinimumWidth = 6;
            this.salaticket.Name = "salaticket";
            this.salaticket.ReadOnly = true;
            // 
            // horarioticket
            // 
            this.horarioticket.HeaderText = "Horario";
            this.horarioticket.MinimumWidth = 6;
            this.horarioticket.Name = "horarioticket";
            this.horarioticket.ReadOnly = true;
            // 
            // tituloTicket
            // 
            this.tituloTicket.HeaderText = "Titulo";
            this.tituloTicket.MinimumWidth = 6;
            this.tituloTicket.Name = "tituloTicket";
            this.tituloTicket.ReadOnly = true;
            // 
            // PreciosinDescuento
            // 
            this.PreciosinDescuento.HeaderText = "Precio sin descuento";
            this.PreciosinDescuento.MinimumWidth = 6;
            this.PreciosinDescuento.Name = "PreciosinDescuento";
            this.PreciosinDescuento.ReadOnly = true;
            // 
            // Descuentoticket
            // 
            this.Descuentoticket.HeaderText = "Descuento";
            this.Descuentoticket.MinimumWidth = 6;
            this.Descuentoticket.Name = "Descuentoticket";
            this.Descuentoticket.ReadOnly = true;
            // 
            // NombrePromo
            // 
            this.NombrePromo.HeaderText = "Promo";
            this.NombrePromo.MinimumWidth = 6;
            this.NombrePromo.Name = "NombrePromo";
            this.NombrePromo.ReadOnly = true;
            // 
            // PrecioTicket
            // 
            this.PrecioTicket.HeaderText = "Precio Final";
            this.PrecioTicket.MinimumWidth = 6;
            this.PrecioTicket.Name = "PrecioTicket";
            this.PrecioTicket.ReadOnly = true;
            // 
            // cbo_peli
            // 
            this.cbo_peli.FormattingEnabled = true;
            this.cbo_peli.Location = new System.Drawing.Point(154, 55);
            this.cbo_peli.Name = "cbo_peli";
            this.cbo_peli.Size = new System.Drawing.Size(121, 23);
            this.cbo_peli.TabIndex = 1;
            this.cbo_peli.SelectedIndexChanged += new System.EventHandler(this.cbo_peli_SelectedIndexChanged_1);
            // 
            // cbo_sala
            // 
            this.cbo_sala.FormattingEnabled = true;
            this.cbo_sala.Location = new System.Drawing.Point(380, 52);
            this.cbo_sala.Name = "cbo_sala";
            this.cbo_sala.Size = new System.Drawing.Size(121, 23);
            this.cbo_sala.TabIndex = 2;
            this.cbo_sala.SelectedIndexChanged += new System.EventHandler(this.cbo_sala_SelectedIndexChanged_1);
            // 
            // cbo_horario
            // 
            this.cbo_horario.FormattingEnabled = true;
            this.cbo_horario.Location = new System.Drawing.Point(380, 15);
            this.cbo_horario.Name = "cbo_horario";
            this.cbo_horario.Size = new System.Drawing.Size(121, 23);
            this.cbo_horario.TabIndex = 3;
            this.cbo_horario.SelectedIndexChanged += new System.EventHandler(this.cbo_horario_SelectedIndexChanged_1);
            // 
            // cbo_audio
            // 
            this.cbo_audio.FormattingEnabled = true;
            this.cbo_audio.Location = new System.Drawing.Point(154, 96);
            this.cbo_audio.Name = "cbo_audio";
            this.cbo_audio.Size = new System.Drawing.Size(121, 23);
            this.cbo_audio.TabIndex = 4;
            this.cbo_audio.SelectedIndexChanged += new System.EventHandler(this.cbo_audio_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(85, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pelicula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(89, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Audio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(311, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(330, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sala:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(154, 15);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(121, 23);
            this.dtp_fecha.TabIndex = 9;
            this.dtp_fecha.ValueChanged += new System.EventHandler(this.dtp_fecha_ValueChanged);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_fecha.Location = new System.Drawing.Point(95, 21);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(41, 15);
            this.lbl_fecha.TabIndex = 10;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // dgv_Butacas
            // 
            this.dgv_Butacas.AllowUserToAddRows = false;
            this.dgv_Butacas.AllowUserToDeleteRows = false;
            this.dgv_Butacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Butacas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Butacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Butacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E});
            this.dgv_Butacas.Location = new System.Drawing.Point(28, 157);
            this.dgv_Butacas.Name = "dgv_Butacas";
            this.dgv_Butacas.ReadOnly = true;
            this.dgv_Butacas.RowHeadersVisible = false;
            this.dgv_Butacas.RowHeadersWidth = 51;
            this.dgv_Butacas.RowTemplate.Height = 25;
            this.dgv_Butacas.Size = new System.Drawing.Size(498, 188);
            this.dgv_Butacas.TabIndex = 11;
            this.dgv_Butacas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Butacas_CellContentClick);
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.MinimumWidth = 6;
            this.A.Name = "A";
            this.A.ReadOnly = true;
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.MinimumWidth = 6;
            this.B.Name = "B";
            this.B.ReadOnly = true;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.MinimumWidth = 6;
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.MinimumWidth = 6;
            this.D.Name = "D";
            this.D.ReadOnly = true;
            // 
            // E
            // 
            this.E.HeaderText = "E";
            this.E.MinimumWidth = 6;
            this.E.Name = "E";
            this.E.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(303, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad:";
            // 
            // n_cant
            // 
            this.n_cant.Location = new System.Drawing.Point(380, 121);
            this.n_cant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_cant.Name = "n_cant";
            this.n_cant.Size = new System.Drawing.Size(121, 23);
            this.n_cant.TabIndex = 14;
            this.n_cant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_cant.ValueChanged += new System.EventHandler(this.n_cant_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(39, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Butaca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(557, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tickets:";
            // 
            // cbo_FormasVenta
            // 
            this.cbo_FormasVenta.FormattingEnabled = true;
            this.cbo_FormasVenta.Location = new System.Drawing.Point(405, 377);
            this.cbo_FormasVenta.Name = "cbo_FormasVenta";
            this.cbo_FormasVenta.Size = new System.Drawing.Size(121, 23);
            this.cbo_FormasVenta.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(399, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Forma de Venta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(164, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Agregar forma ";
            // 
            // btn_comprobante
            // 
            this.btn_comprobante.Image = global::FrontCine.Properties.Resources.okPNG64;
            this.btn_comprobante.Location = new System.Drawing.Point(1101, 406);
            this.btn_comprobante.Name = "btn_comprobante";
            this.btn_comprobante.Size = new System.Drawing.Size(61, 41);
            this.btn_comprobante.TabIndex = 22;
            this.btn_comprobante.UseVisualStyleBackColor = true;
            this.btn_comprobante.Click += new System.EventHandler(this.btn_comprobante_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(28, 369);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 29);
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_pagos
            // 
            this.btn_pagos.Image = global::FrontCine.Properties.Resources.plus64;
            this.btn_pagos.Location = new System.Drawing.Point(278, 364);
            this.btn_pagos.Name = "btn_pagos";
            this.btn_pagos.Size = new System.Drawing.Size(47, 38);
            this.btn_pagos.TabIndex = 24;
            this.btn_pagos.UseVisualStyleBackColor = true;
            this.btn_pagos.Click += new System.EventHandler(this.btn_pagos_Click);
            // 
            // cbo_promos
            // 
            this.cbo_promos.FormattingEnabled = true;
            this.cbo_promos.Location = new System.Drawing.Point(380, 86);
            this.cbo_promos.Name = "cbo_promos";
            this.cbo_promos.Size = new System.Drawing.Size(121, 23);
            this.cbo_promos.TabIndex = 25;
            this.cbo_promos.SelectedIndexChanged += new System.EventHandler(this.cbo_promos_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(315, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Promo:";
            // 
            // butacaID
            // 
            this.butacaID.HeaderText = "Numero Butaca";
            this.butacaID.MinimumWidth = 6;
            this.butacaID.Name = "butacaID";
            this.butacaID.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero de Butaca";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(213, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "de pago";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontCine.Properties.Resources.LogoPng;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(481, 305);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ComprobanteInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1181, 503);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbo_promos);
            this.Controls.Add(this.btn_pagos);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_comprobante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbo_FormasVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.n_cant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_Butacas);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_audio);
            this.Controls.Add(this.cbo_horario);
            this.Controls.Add(this.cbo_sala);
            this.Controls.Add(this.cbo_peli);
            this.Controls.Add(this.dgv_tickets);
            this.Name = "ComprobanteInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Comprobante";
            this.Load += new System.EventHandler(this.ComprobanteInsert_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Butacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_tickets;
        private ComboBox cbo_peli;
        private ComboBox cbo_sala;
        private ComboBox cbo_horario;
        private ComboBox cbo_idioma;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtp_fecha;
        private Label lbl_fecha;
        private DataGridView dgv_Butacas;
        private Label label5;
        private NumericUpDown n_cant;
        private Label label6;
        private Label label7;
        private ComboBox cbo_FormasVenta;
        private Label label8;
        private Label label9;
        private Button btn_ticket;
        private Button btn_comprobante;
        private Button btn_cancelar;
        private Button btn_pagos;
        private ComboBox cbo_audio;
        private ComboBox cbo_promos;
        private Label label10;
        private DataGridViewTextBoxColumn butacaID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Label label11;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridViewCheckBoxColumn A;
        private DataGridViewCheckBoxColumn B;
        private DataGridViewCheckBoxColumn C;
        private DataGridViewCheckBoxColumn D;
        private DataGridViewCheckBoxColumn E;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn salaticket;
        private DataGridViewTextBoxColumn horarioticket;
        private DataGridViewTextBoxColumn tituloTicket;
        private DataGridViewTextBoxColumn PreciosinDescuento;
        private DataGridViewTextBoxColumn Descuentoticket;
        private DataGridViewTextBoxColumn NombrePromo;
        private DataGridViewTextBoxColumn PrecioTicket;
    }
}