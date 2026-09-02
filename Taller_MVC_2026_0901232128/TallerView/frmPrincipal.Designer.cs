namespace TallerView
{
    partial class frmPrincipal
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
            this.DgvConsultaTabla = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultaTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConsultaTabla
            // 
            this.DgvConsultaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultaTabla.Location = new System.Drawing.Point(12, 194);
            this.DgvConsultaTabla.Name = "DgvConsultaTabla";
            this.DgvConsultaTabla.RowHeadersWidth = 51;
            this.DgvConsultaTabla.RowTemplate.Height = 24;
            this.DgvConsultaTabla.Size = new System.Drawing.Size(776, 244);
            this.DgvConsultaTabla.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(583, 101);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(205, 76);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Datos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.DgvConsultaTabla);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultaTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConsultaTabla;
        private System.Windows.Forms.Button btnConsultar;
    }
}