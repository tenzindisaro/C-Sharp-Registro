namespace WindowsFormsApp1.RegistrosPac
{
    partial class Form5_Registro_Pac
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
            this.rdb_Titular_cpf = new System.Windows.Forms.RadioButton();
            this.rdb_NotaFiscal = new System.Windows.Forms.RadioButton();
            this.txtBox_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_Titular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NotaFiscal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.comboBox_Situacao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.maskedTextBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_email = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbox_nome_entregador = new System.Windows.Forms.TextBox();
            this.txtbox_cpf_entregador = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // rdb_Titular_cpf
            // 
            this.rdb_Titular_cpf.AutoSize = true;
            this.rdb_Titular_cpf.Location = new System.Drawing.Point(468, 23);
            this.rdb_Titular_cpf.Name = "rdb_Titular_cpf";
            this.rdb_Titular_cpf.Size = new System.Drawing.Size(77, 17);
            this.rdb_Titular_cpf.TabIndex = 1;
            this.rdb_Titular_cpf.TabStop = true;
            this.rdb_Titular_cpf.Text = "CPF Titular";
            this.rdb_Titular_cpf.UseVisualStyleBackColor = true;
            // 
            // rdb_NotaFiscal
            // 
            this.rdb_NotaFiscal.AutoSize = true;
            this.rdb_NotaFiscal.Location = new System.Drawing.Point(551, 23);
            this.rdb_NotaFiscal.Name = "rdb_NotaFiscal";
            this.rdb_NotaFiscal.Size = new System.Drawing.Size(78, 17);
            this.rdb_NotaFiscal.TabIndex = 2;
            this.rdb_NotaFiscal.TabStop = true;
            this.rdb_NotaFiscal.Text = "Nota Fiscal";
            this.rdb_NotaFiscal.UseVisualStyleBackColor = true;
            // 
            // txtBox_buscar
            // 
            this.txtBox_buscar.Location = new System.Drawing.Point(635, 22);
            this.txtBox_buscar.Name = "txtBox_buscar";
            this.txtBox_buscar.Size = new System.Drawing.Size(138, 20);
            this.txtBox_buscar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titular:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(16, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacotes Registrados no Dia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 170);
            this.dataGridView1.TabIndex = 0;
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_Titular
            // 
            this.textBox_Titular.Location = new System.Drawing.Point(84, 101);
            this.textBox_Titular.Name = "textBox_Titular";
            this.textBox_Titular.Size = new System.Drawing.Size(100, 20);
            this.textBox_Titular.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nota Fiscal";
            // 
            // textBox_NotaFiscal
            // 
            this.textBox_NotaFiscal.Location = new System.Drawing.Point(287, 57);
            this.textBox_NotaFiscal.Name = "textBox_NotaFiscal";
            this.textBox_NotaFiscal.Size = new System.Drawing.Size(100, 20);
            this.textBox_NotaFiscal.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Funcionário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Situação:";
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.Location = new System.Drawing.Point(190, 372);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(75, 66);
            this.button_Cadastrar.TabIndex = 17;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_Editar
            // 
            this.button_Editar.Location = new System.Drawing.Point(390, 372);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(75, 66);
            this.button_Editar.TabIndex = 18;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            this.button_Editar.Click += new System.EventHandler(this.button_Editar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(296, 372);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 66);
            this.button_deletar.TabIndex = 20;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // comboBox_Situacao
            // 
            this.comboBox_Situacao.FormattingEnabled = true;
            this.comboBox_Situacao.Items.AddRange(new object[] {
            "Recebido",
            "Entregue"});
            this.comboBox_Situacao.Location = new System.Drawing.Point(445, 141);
            this.comboBox_Situacao.Name = "comboBox_Situacao";
            this.comboBox_Situacao.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Situacao.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Telefone:";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(484, 372);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 66);
            this.button_Buscar.TabIndex = 27;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // maskedTextBox_CPF
            // 
            this.maskedTextBox_CPF.Location = new System.Drawing.Point(271, 100);
            this.maskedTextBox_CPF.Mask = "000,000,000-00";
            this.maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            this.maskedTextBox_CPF.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_CPF.TabIndex = 0;
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(271, 141);
            this.maskedTextBox_telefone.Mask = "(00)0 0000-0000";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_telefone.TabIndex = 0;
            // 
            // maskedTextBox_email
            // 
            this.maskedTextBox_email.Location = new System.Drawing.Point(84, 141);
            this.maskedTextBox_email.Name = "maskedTextBox_email";
            this.maskedTextBox_email.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_email.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(298, 13);
            this.label11.TabIndex = 103;
            this.label11.Text = "Todos os campos com asterisco (\"*\") devem ser preenchidos.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 104;
            this.label12.Text = "entregador";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(568, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 105;
            this.label13.Text = "cpf entregador";
            // 
            // txtbox_nome_entregador
            // 
            this.txtbox_nome_entregador.Location = new System.Drawing.Point(459, 58);
            this.txtbox_nome_entregador.Name = "txtbox_nome_entregador";
            this.txtbox_nome_entregador.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nome_entregador.TabIndex = 106;
            // 
            // txtbox_cpf_entregador
            // 
            this.txtbox_cpf_entregador.Location = new System.Drawing.Point(650, 58);
            this.txtbox_cpf_entregador.Name = "txtbox_cpf_entregador";
            this.txtbox_cpf_entregador.Size = new System.Drawing.Size(100, 20);
            this.txtbox_cpf_entregador.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 107;
            // 
            // Form5_Registro_Pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtbox_cpf_entregador);
            this.Controls.Add(this.txtbox_nome_entregador);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maskedTextBox_email);
            this.Controls.Add(this.maskedTextBox_telefone);
            this.Controls.Add(this.maskedTextBox_CPF);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_Situacao);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_Editar);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_NotaFiscal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Titular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_buscar);
            this.Controls.Add(this.rdb_NotaFiscal);
            this.Controls.Add(this.rdb_Titular_cpf);
            this.Controls.Add(this.label1);
            this.Name = "Form5_Registro_Pac";
            this.Text = "Registro de Pacotes";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_Titular_cpf;
        private System.Windows.Forms.RadioButton rdb_NotaFiscal;
        private System.Windows.Forms.TextBox txtBox_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Titular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_NotaFiscal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.ComboBox comboBox_Situacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbox_nome_entregador;
        private System.Windows.Forms.TextBox txtbox_cpf_entregador;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}