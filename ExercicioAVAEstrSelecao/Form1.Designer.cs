namespace ExercicioAVAEstrSelecao
{
    partial class FrmDiaSemana
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
            this.lblDia = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(33, 9);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(151, 17);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Digite o número do dia";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(36, 40);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(206, 22);
            this.txtDia.TabIndex = 1;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.ForeColor = System.Drawing.Color.Red;
            this.lblDiaSemana.Location = new System.Drawing.Point(33, 84);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(0, 29);
            this.lblDiaSemana.TabIndex = 2;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(36, 137);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(167, 137);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmDiaSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 176);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblDia);
            this.Name = "FrmDiaSemana";
            this.Text = "Dia da Semana";
            this.Load += new System.EventHandler(this.FrmDiaSemana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnFechar;
    }
}

