namespace ProjetoSistemaTI18N
{
    partial class Atualizar
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
            this.codigo = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.nome = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buscarBotao = new System.Windows.Forms.Button();
            this.atualizarBotao = new System.Windows.Forms.Button();
            this.voltarButao = new System.Windows.Forms.Button();
            this.labelAtualizar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(36, 64);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(65, 20);
            this.codigo.TabIndex = 0;
            this.codigo.Text = "Código";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(127, 65);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(127, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(36, 112);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(55, 20);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome";
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(36, 159);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(79, 20);
            this.telefone.TabIndex = 3;
            this.telefone.Text = "Telefone";
            // 
            // cidade
            // 
            this.cidade.AutoSize = true;
            this.cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.Location = new System.Drawing.Point(36, 205);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(65, 20);
            this.cidade.TabIndex = 4;
            this.cidade.Text = "Cidade";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(36, 247);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(66, 20);
            this.estado.TabIndex = 5;
            this.estado.Text = "Estado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(127, 159);
            this.maskedTextBox2.Mask = "(99) 99999-9999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(127, 20);
            this.maskedTextBox2.TabIndex = 7;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buscarBotao
            // 
            this.buscarBotao.Location = new System.Drawing.Point(21, 306);
            this.buscarBotao.Name = "buscarBotao";
            this.buscarBotao.Size = new System.Drawing.Size(70, 39);
            this.buscarBotao.TabIndex = 10;
            this.buscarBotao.Text = "Buscar";
            this.buscarBotao.UseVisualStyleBackColor = true;
            this.buscarBotao.Click += new System.EventHandler(this.buscarBotao_Click);
            // 
            // atualizarBotao
            // 
            this.atualizarBotao.Location = new System.Drawing.Point(118, 306);
            this.atualizarBotao.Name = "atualizarBotao";
            this.atualizarBotao.Size = new System.Drawing.Size(70, 39);
            this.atualizarBotao.TabIndex = 11;
            this.atualizarBotao.Text = "Atualizar";
            this.atualizarBotao.UseVisualStyleBackColor = true;
            this.atualizarBotao.Click += new System.EventHandler(this.atualizarBotao_Click);
            // 
            // voltarButao
            // 
            this.voltarButao.Location = new System.Drawing.Point(216, 306);
            this.voltarButao.Name = "voltarButao";
            this.voltarButao.Size = new System.Drawing.Size(67, 39);
            this.voltarButao.TabIndex = 12;
            this.voltarButao.Text = "Voltar";
            this.voltarButao.UseVisualStyleBackColor = true;
            this.voltarButao.Click += new System.EventHandler(this.voltarButao_Click);
            // 
            // labelAtualizar
            // 
            this.labelAtualizar.AutoSize = true;
            this.labelAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtualizar.Location = new System.Drawing.Point(91, 12);
            this.labelAtualizar.Name = "labelAtualizar";
            this.labelAtualizar.Size = new System.Drawing.Size(129, 31);
            this.labelAtualizar.TabIndex = 13;
            this.labelAtualizar.Text = "Atualizar";
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 381);
            this.Controls.Add(this.labelAtualizar);
            this.Controls.Add(this.voltarButao);
            this.Controls.Add(this.atualizarBotao);
            this.Controls.Add(this.buscarBotao);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.codigo);
            this.Name = "Atualizar";
            this.Text = "Atualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label cidade;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buscarBotao;
        private System.Windows.Forms.Button atualizarBotao;
        private System.Windows.Forms.Button voltarButao;
        private System.Windows.Forms.Label labelAtualizar;
    }
}