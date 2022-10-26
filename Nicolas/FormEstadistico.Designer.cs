namespace TpLab.Nicolas
{
    partial class FormEstadistico
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
            this.DGVTotalSalaMes = new System.Windows.Forms.DataGridView();
            this.DGVVentaSalaThisYear = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTotalSalaMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentaSalaThisYear)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTotalSalaMes
            // 
            this.DGVTotalSalaMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTotalSalaMes.Location = new System.Drawing.Point(24, 80);
            this.DGVTotalSalaMes.Name = "DGVTotalSalaMes";
            this.DGVTotalSalaMes.RowHeadersWidth = 51;
            this.DGVTotalSalaMes.RowTemplate.Height = 29;
            this.DGVTotalSalaMes.Size = new System.Drawing.Size(569, 372);
            this.DGVTotalSalaMes.TabIndex = 0;
            this.DGVTotalSalaMes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTotalSalaMes_CellContentClick);
            // 
            // DGVVentaSalaThisYear
            // 
            this.DGVVentaSalaThisYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVentaSalaThisYear.Location = new System.Drawing.Point(651, 80);
            this.DGVVentaSalaThisYear.Name = "DGVVentaSalaThisYear";
            this.DGVVentaSalaThisYear.RowHeadersWidth = 51;
            this.DGVVentaSalaThisYear.RowTemplate.Height = 29;
            this.DGVVentaSalaThisYear.Size = new System.Drawing.Size(569, 372);
            this.DGVVentaSalaThisYear.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monto total facturado por sala y por mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de entradas vendidas por sala este año";
            // 
            // FormEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVVentaSalaThisYear);
            this.Controls.Add(this.DGVTotalSalaMes);
            this.Name = "FormEstadistico";
            this.Text = "FormEstadistico";
            this.Load += new System.EventHandler(this.FormEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTotalSalaMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentaSalaThisYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DGVTotalSalaMes;
        private DataGridView DGVVentaSalaThisYear;
        private Label label1;
        private Label label2;
    }
}