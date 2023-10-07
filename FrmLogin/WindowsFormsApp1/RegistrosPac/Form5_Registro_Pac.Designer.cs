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
            this.rdb_Titular = new System.Windows.Forms.RadioButton();
            this.rdb_NotaFiscal = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Titular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NotaFiscal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Funcionario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.comboBox_Situacao = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_Deletados_dia = new System.Windows.Forms.RadioButton();
            this.rdb_Editados_Dia = new System.Windows.Forms.RadioButton();
            this.rdb_Registro_Dia = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.maskedTextBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Data = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Hora = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox_email = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // rdb_Titular
            // 
            this.rdb_Titular.AutoSize = true;
            this.rdb_Titular.Location = new System.Drawing.Point(491, 23);
            this.rdb_Titular.Name = "rdb_Titular";
            this.rdb_Titular.Size = new System.Drawing.Size(54, 17);
            this.rdb_Titular.TabIndex = 1;
            this.rdb_Titular.TabStop = true;
            this.rdb_Titular.Text = "Titular";
            this.rdb_Titular.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(635, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titular:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacotes Registrados no Dia";
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
            this.label3.Location = new System.Drawing.Point(205, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nota Fiscal";
            // 
            // textBox_NotaFiscal
            // 
            this.textBox_NotaFiscal.Location = new System.Drawing.Point(271, 54);
            this.textBox_NotaFiscal.Name = "textBox_NotaFiscal";
            this.textBox_NotaFiscal.Size = new System.Drawing.Size(100, 20);
            this.textBox_NotaFiscal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Funcionário:";
            // 
            // textBox_Funcionario
            // 
            this.textBox_Funcionario.Location = new System.Drawing.Point(84, 54);
            this.textBox_Funcionario.Name = "textBox_Funcionario";
            this.textBox_Funcionario.Size = new System.Drawing.Size(100, 20);
            this.textBox_Funcionario.TabIndex = 12;
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
            this.button_Editar.Location = new System.Drawing.Point(296, 372);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(75, 66);
            this.button_Editar.TabIndex = 18;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(698, 388);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 35);
            this.button_sair.TabIndex = 19;
            this.button_sair.Text = "Menu//SAir";
            this.button_sair.UseVisualStyleBackColor = true;
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(410, 372);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 66);
            this.button_deletar.TabIndex = 20;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_Deletados_dia);
            this.groupBox2.Controls.Add(this.rdb_Editados_Dia);
            this.groupBox2.Controls.Add(this.rdb_Registro_Dia);
            this.groupBox2.Location = new System.Drawing.Point(588, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Lista:";
            // 
            // rdb_Deletados_dia
            // 
            this.rdb_Deletados_dia.AutoSize = true;
            this.rdb_Deletados_dia.Location = new System.Drawing.Point(7, 70);
            this.rdb_Deletados_dia.Name = "rdb_Deletados_dia";
            this.rdb_Deletados_dia.Size = new System.Drawing.Size(92, 17);
            this.rdb_Deletados_dia.TabIndex = 2;
            this.rdb_Deletados_dia.TabStop = true;
            this.rdb_Deletados_dia.Text = "Deletados Dia";
            this.rdb_Deletados_dia.UseVisualStyleBackColor = true;
            // 
            // rdb_Editados_Dia
            // 
            this.rdb_Editados_Dia.AutoSize = true;
            this.rdb_Editados_Dia.Location = new System.Drawing.Point(7, 46);
            this.rdb_Editados_Dia.Name = "rdb_Editados_Dia";
            this.rdb_Editados_Dia.Size = new System.Drawing.Size(85, 17);
            this.rdb_Editados_Dia.TabIndex = 1;
            this.rdb_Editados_Dia.TabStop = true;
            this.rdb_Editados_Dia.Text = "Editados Dia";
            this.rdb_Editados_Dia.UseVisualStyleBackColor = true;
            // 
            // rdb_Registro_Dia
            // 
            this.rdb_Registro_Dia.AutoSize = true;
            this.rdb_Registro_Dia.Location = new System.Drawing.Point(7, 20);
            this.rdb_Registro_Dia.Name = "rdb_Registro_Dia";
            this.rdb_Registro_Dia.Size = new System.Drawing.Size(83, 17);
            this.rdb_Registro_Dia.TabIndex = 0;
            this.rdb_Registro_Dia.TabStop = true;
            this.rdb_Registro_Dia.Text = "Registro Dia";
            this.rdb_Registro_Dia.UseVisualStyleBackColor = true;
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
            this.button_Buscar.Location = new System.Drawing.Point(521, 372);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 66);
            this.button_Buscar.TabIndex = 27;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
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
            // maskedTextBox_Data
            // 
            this.maskedTextBox_Data.Location = new System.Drawing.Point(459, 54);
            this.maskedTextBox_Data.Mask = "00/00/0000";
            this.maskedTextBox_Data.Name = "maskedTextBox_Data";
            this.maskedTextBox_Data.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Data.TabIndex = 0;
            this.maskedTextBox_Data.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_Hora
            // 
            this.maskedTextBox_Hora.Location = new System.Drawing.Point(459, 101);
            this.maskedTextBox_Hora.Mask = "90:00";
            this.maskedTextBox_Hora.Name = "maskedTextBox_Hora";
            this.maskedTextBox_Hora.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Hora.TabIndex = 28;
            this.maskedTextBox_Hora.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Hora:";
            // 
            // maskedTextBox_email
            // 
            this.maskedTextBox_email.Location = new System.Drawing.Point(84, 141);
            this.maskedTextBox_email.Mask = "000000000000@\\americ\\an\\as,com";
            this.maskedTextBox_email.Name = "maskedTextBox_email";
            this.maskedTextBox_email.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_email.TabIndex = 0;
            // 
            // Form5_Registro_Pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox_email);
            this.Controls.Add(this.maskedTextBox_Hora);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maskedTextBox_Data);
            this.Controls.Add(this.maskedTextBox_telefone);
            this.Controls.Add(this.maskedTextBox_CPF);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox_Situacao);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_Editar);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Funcionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_NotaFiscal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Titular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdb_NotaFiscal);
            this.Controls.Add(this.rdb_Titular);
            this.Controls.Add(this.label1);
            this.Name = "Form5_Registro_Pac";
            this.Text = "Registro de Pacaotes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_Titular;
        private System.Windows.Forms.RadioButton rdb_NotaFiscal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Titular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_NotaFiscal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Funcionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.ComboBox comboBox_Situacao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_Deletados_dia;
        private System.Windows.Forms.RadioButton rdb_Editados_Dia;
        private System.Windows.Forms.RadioButton rdb_Registro_Dia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Data;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Hora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_email;
    }
}