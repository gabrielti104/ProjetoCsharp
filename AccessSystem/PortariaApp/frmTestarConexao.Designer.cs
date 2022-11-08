
namespace PortariaApp
{
    partial class frmTestarConexao
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
            this.btnconectar = new System.Windows.Forms.Button();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconectar
            // 
            this.btnconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconectar.Location = new System.Drawing.Point(41, 263);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(156, 110);
            this.btnconectar.TabIndex = 0;
            this.btnconectar.Text = "Conectar Banco de Dados";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // btndesconectar
            // 
            this.btndesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesconectar.Location = new System.Drawing.Point(262, 263);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(156, 110);
            this.btndesconectar.TabIndex = 1;
            this.btndesconectar.Text = "Desconectar Banco de Dados";
            this.btndesconectar.UseVisualStyleBackColor = true;
            this.btndesconectar.Click += new System.EventHandler(this.btndesconectar_Click);
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensagem.Location = new System.Drawing.Point(103, 162);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(0, 25);
            this.lblmensagem.TabIndex = 2;
            // 
            // frmTestarConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 435);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.btnconectar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmTestarConexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestarConexao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.Label lblmensagem;
    }
}