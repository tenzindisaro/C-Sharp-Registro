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
            this.dataGridView_registro_pac = new System.Windows.Forms.DataGridView();
            this.textBox_Titular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NotaFiscal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.maskedTextBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_email = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbox_nome_entregador = new System.Windows.Forms.TextBox();
            this.txtbox_cpf_entregador = new System.Windows.Forms.TextBox();
            this.comboBox_funcionario = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBox_buscar_cpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSituacao = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.groupBox_hora = new System.Windows.Forms.GroupBox();
            this.textBox_hora = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_registro_pac)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.groupBox_hora.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // rdb_Titular_cpf
            // 
            this.rdb_Titular_cpf.AutoSize = true;
            this.rdb_Titular_cpf.Checked = true;
            this.rdb_Titular_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Titular_cpf.ForeColor = System.Drawing.Color.White;
            this.rdb_Titular_cpf.Location = new System.Drawing.Point(108, 93);
            this.rdb_Titular_cpf.Name = "rdb_Titular_cpf";
            this.rdb_Titular_cpf.Size = new System.Drawing.Size(96, 19);
            this.rdb_Titular_cpf.TabIndex = 1;
            this.rdb_Titular_cpf.TabStop = true;
            this.rdb_Titular_cpf.Text = "CPF Titular";
            this.rdb_Titular_cpf.UseVisualStyleBackColor = true;
            this.rdb_Titular_cpf.CheckedChanged += new System.EventHandler(this.rdb_Titular_cpf_CheckedChanged);
            // 
            // rdb_NotaFiscal
            // 
            this.rdb_NotaFiscal.AutoSize = true;
            this.rdb_NotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_NotaFiscal.ForeColor = System.Drawing.Color.White;
            this.rdb_NotaFiscal.Location = new System.Drawing.Point(9, 93);
            this.rdb_NotaFiscal.Name = "rdb_NotaFiscal";
            this.rdb_NotaFiscal.Size = new System.Drawing.Size(97, 19);
            this.rdb_NotaFiscal.TabIndex = 2;
            this.rdb_NotaFiscal.Text = "Nota Fiscal";
            this.rdb_NotaFiscal.UseVisualStyleBackColor = true;
            this.rdb_NotaFiscal.CheckedChanged += new System.EventHandler(this.rdb_NotaFiscal_CheckedChanged);
            // 
            // txtBox_buscar
            // 
            this.txtBox_buscar.Location = new System.Drawing.Point(9, 118);
            this.txtBox_buscar.Name = "txtBox_buscar";
            this.txtBox_buscar.Size = new System.Drawing.Size(186, 20);
            this.txtBox_buscar.TabIndex = 3;
            this.txtBox_buscar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titular:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_registro_pac);
            this.groupBox1.Location = new System.Drawing.Point(15, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacotes Registrados no Dia";
            // 
            // dataGridView_registro_pac
            // 
            this.dataGridView_registro_pac.AllowUserToAddRows = false;
            this.dataGridView_registro_pac.AllowUserToDeleteRows = false;
            this.dataGridView_registro_pac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_registro_pac.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_registro_pac.Name = "dataGridView_registro_pac";
            this.dataGridView_registro_pac.ReadOnly = true;
            this.dataGridView_registro_pac.Size = new System.Drawing.Size(564, 110);
            this.dataGridView_registro_pac.TabIndex = 0;
            // 
            // textBox_Titular
            // 
            this.textBox_Titular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Titular.Location = new System.Drawing.Point(17, 175);
            this.textBox_Titular.Name = "textBox_Titular";
            this.textBox_Titular.Size = new System.Drawing.Size(134, 23);
            this.textBox_Titular.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nota Fiscal:";
            // 
            // textBox_NotaFiscal
            // 
            this.textBox_NotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NotaFiscal.Location = new System.Drawing.Point(17, 115);
            this.textBox_NotaFiscal.Name = "textBox_NotaFiscal";
            this.textBox_NotaFiscal.Size = new System.Drawing.Size(134, 23);
            this.textBox_NotaFiscal.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Funcionário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "CPF Titular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Situação:";
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.BackColor = System.Drawing.Color.White;
            this.button_Cadastrar.Location = new System.Drawing.Point(9, 175);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(184, 46);
            this.button_Cadastrar.TabIndex = 17;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = false;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_Editar
            // 
            this.button_Editar.BackColor = System.Drawing.Color.White;
            this.button_Editar.Location = new System.Drawing.Point(9, 280);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(184, 46);
            this.button_Editar.TabIndex = 18;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = false;
            this.button_Editar.Click += new System.EventHandler(this.button_Editar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.BackColor = System.Drawing.Color.White;
            this.button_deletar.Location = new System.Drawing.Point(9, 333);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(184, 46);
            this.button_deletar.TabIndex = 20;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = false;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(156, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Telefone:";
            // 
            // button_Buscar
            // 
            this.button_Buscar.BackColor = System.Drawing.Color.White;
            this.button_Buscar.Location = new System.Drawing.Point(9, 228);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(184, 46);
            this.button_Buscar.TabIndex = 27;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = false;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // maskedTextBox_CPF
            // 
            this.maskedTextBox_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_CPF.Location = new System.Drawing.Point(159, 236);
            this.maskedTextBox_CPF.Mask = "000,000,000-00";
            this.maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            this.maskedTextBox_CPF.Size = new System.Drawing.Size(134, 23);
            this.maskedTextBox_CPF.TabIndex = 0;
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(159, 175);
            this.maskedTextBox_telefone.Mask = "(00)0 0000-0000";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(134, 23);
            this.maskedTextBox_telefone.TabIndex = 0;
            // 
            // maskedTextBox_email
            // 
            this.maskedTextBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_email.Location = new System.Drawing.Point(17, 236);
            this.maskedTextBox_email.Name = "maskedTextBox_email";
            this.maskedTextBox_email.Size = new System.Drawing.Size(134, 23);
            this.maskedTextBox_email.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(299, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 104;
            this.label12.Text = "Entregador";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(299, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 105;
            this.label13.Text = "CPF Entregador:";
            // 
            // txtbox_nome_entregador
            // 
            this.txtbox_nome_entregador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nome_entregador.Location = new System.Drawing.Point(302, 115);
            this.txtbox_nome_entregador.Name = "txtbox_nome_entregador";
            this.txtbox_nome_entregador.Size = new System.Drawing.Size(134, 23);
            this.txtbox_nome_entregador.TabIndex = 106;
            // 
            // txtbox_cpf_entregador
            // 
            this.txtbox_cpf_entregador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cpf_entregador.Location = new System.Drawing.Point(302, 175);
            this.txtbox_cpf_entregador.Name = "txtbox_cpf_entregador";
            this.txtbox_cpf_entregador.Size = new System.Drawing.Size(134, 23);
            this.txtbox_cpf_entregador.TabIndex = 23;
            // 
            // comboBox_funcionario
            // 
            this.comboBox_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_funcionario.FormattingEnabled = true;
            this.comboBox_funcionario.Location = new System.Drawing.Point(159, 115);
            this.comboBox_funcionario.Name = "comboBox_funcionario";
            this.comboBox_funcionario.Size = new System.Drawing.Size(134, 25);
            this.comboBox_funcionario.TabIndex = 107;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 78);
            this.panel1.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(13, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(562, 63);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registro de Pacotes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.txtBox_buscar_cpf);
            this.panel2.Controls.Add(this.button_Cadastrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_Buscar);
            this.panel2.Controls.Add(this.rdb_Titular_cpf);
            this.panel2.Controls.Add(this.button_Editar);
            this.panel2.Controls.Add(this.rdb_NotaFiscal);
            this.panel2.Controls.Add(this.button_deletar);
            this.panel2.Controls.Add(this.txtBox_buscar);
            this.panel2.Location = new System.Drawing.Point(597, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 453);
            this.panel2.TabIndex = 122;
            // 
            // txtBox_buscar_cpf
            // 
            this.txtBox_buscar_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_buscar_cpf.Location = new System.Drawing.Point(9, 118);
            this.txtBox_buscar_cpf.Mask = "000,000,000-00";
            this.txtBox_buscar_cpf.Name = "txtBox_buscar_cpf";
            this.txtBox_buscar_cpf.Size = new System.Drawing.Size(186, 23);
            this.txtBox_buscar_cpf.TabIndex = 1;
            // 
            // maskedTextBoxSituacao
            // 
            this.maskedTextBoxSituacao.Enabled = false;
            this.maskedTextBoxSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxSituacao.Location = new System.Drawing.Point(302, 236);
            this.maskedTextBoxSituacao.Name = "maskedTextBoxSituacao";
            this.maskedTextBoxSituacao.Size = new System.Drawing.Size(134, 23);
            this.maskedTextBoxSituacao.TabIndex = 123;
            this.maskedTextBoxSituacao.Text = "Presente";
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.textBox_data);
            this.groupBox_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox_Data.Location = new System.Drawing.Point(451, 115);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(140, 57);
            this.groupBox_Data.TabIndex = 124;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "Data";
            // 
            // textBox_data
            // 
            this.textBox_data.Enabled = false;
            this.textBox_data.Location = new System.Drawing.Point(6, 25);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(118, 26);
            this.textBox_data.TabIndex = 0;
            // 
            // groupBox_hora
            // 
            this.groupBox_hora.Controls.Add(this.textBox_hora);
            this.groupBox_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox_hora.Location = new System.Drawing.Point(451, 202);
            this.groupBox_hora.Name = "groupBox_hora";
            this.groupBox_hora.Size = new System.Drawing.Size(140, 57);
            this.groupBox_hora.TabIndex = 125;
            this.groupBox_hora.TabStop = false;
            this.groupBox_hora.Text = "Hora";
            // 
            // textBox_hora
            // 
            this.textBox_hora.Enabled = false;
            this.textBox_hora.Location = new System.Drawing.Point(6, 25);
            this.textBox_hora.Name = "textBox_hora";
            this.textBox_hora.Size = new System.Drawing.Size(118, 26);
            this.textBox_hora.TabIndex = 0;
            // 
            // Form5_Registro_Pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_hora);
            this.Controls.Add(this.groupBox_Data);
            this.Controls.Add(this.maskedTextBoxSituacao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_funcionario);
            this.Controls.Add(this.txtbox_cpf_entregador);
            this.Controls.Add(this.txtbox_nome_entregador);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.maskedTextBox_email);
            this.Controls.Add(this.maskedTextBox_telefone);
            this.Controls.Add(this.maskedTextBox_CPF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_NotaFiscal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Titular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form5_Registro_Pac";
            this.Text = "Registro de Pacotes";
            this.Load += new System.EventHandler(this.Form5_Registro_Pac_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_registro_pac)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            this.groupBox_hora.ResumeLayout(false);
            this.groupBox_hora.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbox_nome_entregador;
        private System.Windows.Forms.TextBox txtbox_cpf_entregador;
        private System.Windows.Forms.ComboBox comboBox_funcionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSituacao;
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.GroupBox groupBox_hora;
        private System.Windows.Forms.TextBox textBox_hora;
        private System.Windows.Forms.DataGridView dataGridView_registro_pac;
        private System.Windows.Forms.MaskedTextBox txtBox_buscar_cpf;
    }
}