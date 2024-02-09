namespace ProjetoSistemaTI18N
{
    partial class Cadastrar
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
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cadastrarBotao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.voltarBotao = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nome.Location = new System.Drawing.Point(109, 156);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(158, 26);
            this.nome.TabIndex = 3;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(29, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(28, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // cidade
            // 
            this.cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cidade.Location = new System.Drawing.Point(109, 259);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(158, 26);
            this.cidade.TabIndex = 7;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.estado.Location = new System.Drawing.Point(109, 307);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(158, 26);
            this.estado.TabIndex = 9;
            this.estado.TextChanged += new System.EventHandler(this.estado_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(30, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkCyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cadastrar Pessoa";
            // 
            // cadastrarBotao
            // 
            this.cadastrarBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarBotao.Location = new System.Drawing.Point(57, 349);
            this.cadastrarBotao.Name = "cadastrarBotao";
            this.cadastrarBotao.Size = new System.Drawing.Size(205, 49);
            this.cadastrarBotao.TabIndex = 11;
            this.cadastrarBotao.Text = "Cadastrar";
            this.cadastrarBotao.UseVisualStyleBackColor = true;
            this.cadastrarBotao.Click += new System.EventHandler(this.cadastrarBotao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(28, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cidade";
            // 
            // voltarBotao
            // 
            this.voltarBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarBotao.Location = new System.Drawing.Point(57, 399);
            this.voltarBotao.Name = "voltarBotao";
            this.voltarBotao.Size = new System.Drawing.Size(205, 49);
            this.voltarBotao.TabIndex = 13;
            this.voltarBotao.Text = "Voltar";
            this.voltarBotao.UseVisualStyleBackColor = true;
            this.voltarBotao.Click += new System.EventHandler(this.voltarBotao_Click);
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.codigo.Location = new System.Drawing.Point(108, 107);
            this.codigo.Mask = "99999";
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(157, 26);
            this.codigo.TabIndex = 14;
            this.codigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codigo_MaskInputRejected);
            // 
            // telefone
            // 
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.telefone.Location = new System.Drawing.Point(109, 207);
            this.telefone.Mask = "(99) 99999-9999";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(157, 26);
            this.telefone.TabIndex = 15;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.voltarBotao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cadastrarBotao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cadastrarBotao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button voltarBotao;
        private System.Windows.Forms.MaskedTextBox codigo;
        private System.Windows.Forms.MaskedTextBox telefone;
    }
}