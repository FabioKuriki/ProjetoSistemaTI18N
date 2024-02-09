namespace ProjetoSistemaTI18N
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.consultar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.deletar = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.consultar.Location = new System.Drawing.Point(55, 204);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(174, 71);
            this.consultar.TabIndex = 1;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.atualizar.Location = new System.Drawing.Point(55, 281);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(174, 71);
            this.atualizar.TabIndex = 2;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = false;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // deletar
            // 
            this.deletar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.deletar.Location = new System.Drawing.Point(55, 358);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(174, 71);
            this.deletar.TabIndex = 3;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = false;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cadastrar.Location = new System.Drawing.Point(55, 127);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(174, 71);
            this.cadastrar.TabIndex = 5;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha uma das opções abaixo:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(281, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.consultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Label label1;
    }
}

