namespace WindowsFormsApp1
{
    partial class FormRetirarPac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetirarPac));
            this.txtbox_cpf_entregador = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_hora = new System.Windows.Forms.GroupBox();
            this.textBox_hora = new System.Windows.Forms.TextBox();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.maskedTextBoxSituacao = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_buscar_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.rdb_Titular_cpf = new System.Windows.Forms.RadioButton();
            this.button_Editar = new System.Windows.Forms.Button();
            this.rdb_NotaFiscal = new System.Windows.Forms.RadioButton();
            this.button_deletar = new System.Windows.Forms.Button();
            this.txtBox_buscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_funcionario = new System.Windows.Forms.ComboBox();
            this.txtbox_nome_entregador = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox_email = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NotaFiscal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Titular = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_retirada_pac = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_hora.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_retirada_pac)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_cpf_entregador
            // 
            this.txtbox_cpf_entregador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cpf_entregador.Location = new System.Drawing.Point(301, 174);
            this.txtbox_cpf_entregador.Mask = "000,000,000-00";
            this.txtbox_cpf_entregador.Name = "txtbox_cpf_entregador";
            this.txtbox_cpf_entregador.Size = new System.Drawing.Size(134, 23);
            this.txtbox_cpf_entregador.TabIndex = 132;
            // 
            // groupBox_hora
            // 
            this.groupBox_hora.Controls.Add(this.textBox_hora);
            this.groupBox_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_hora.Location = new System.Drawing.Point(450, 201);
            this.groupBox_hora.Name = "groupBox_hora";
            this.groupBox_hora.Size = new System.Drawing.Size(140, 57);
            this.groupBox_hora.TabIndex = 148;
            this.groupBox_hora.TabStop = false;
            this.groupBox_hora.Text = "Hora de Chegada";
            // 
            // textBox_hora
            // 
            this.textBox_hora.Enabled = false;
            this.textBox_hora.Location = new System.Drawing.Point(6, 25);
            this.textBox_hora.Name = "textBox_hora";
            this.textBox_hora.Size = new System.Drawing.Size(118, 21);
            this.textBox_hora.TabIndex = 0;
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.textBox_data);
            this.groupBox_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Data.Location = new System.Drawing.Point(450, 114);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(140, 57);
            this.groupBox_Data.TabIndex = 147;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "Data de Chegada";
            // 
            // textBox_data
            // 
            this.textBox_data.Enabled = false;
            this.textBox_data.Location = new System.Drawing.Point(6, 25);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(118, 21);
            this.textBox_data.TabIndex = 0;
            // 
            // maskedTextBoxSituacao
            // 
            this.maskedTextBoxSituacao.Enabled = false;
            this.maskedTextBoxSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxSituacao.Location = new System.Drawing.Point(301, 235);
            this.maskedTextBoxSituacao.Name = "maskedTextBoxSituacao";
            this.maskedTextBoxSituacao.Size = new System.Drawing.Size(134, 23);
            this.maskedTextBoxSituacao.TabIndex = 146;
            this.maskedTextBoxSituacao.Text = "Presente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtBox_buscar_cpf);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_Buscar);
            this.panel2.Controls.Add(this.rdb_Titular_cpf);
            this.panel2.Controls.Add(this.button_Editar);
            this.panel2.Controls.Add(this.rdb_NotaFiscal);
            this.panel2.Controls.Add(this.button_deletar);
            this.panel2.Controls.Add(this.txtBox_buscar);
            this.panel2.Location = new System.Drawing.Point(596, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 453);
            this.panel2.TabIndex = 145;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(9, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 46);
            this.button2.TabIndex = 18;
            this.button2.Text = "Gerar Relatório";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Retirar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_buscar_cpf
            // 
            this.txtBox_buscar_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_buscar_cpf.Location = new System.Drawing.Point(7, 117);
            this.txtBox_buscar_cpf.Mask = "000,000,000-00";
            this.txtBox_buscar_cpf.Name = "txtBox_buscar_cpf";
            this.txtBox_buscar_cpf.Size = new System.Drawing.Size(186, 23);
            this.txtBox_buscar_cpf.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // button_Buscar
            // 
            this.button_Buscar.BackColor = System.Drawing.Color.White;
            this.button_Buscar.Location = new System.Drawing.Point(9, 155);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(184, 46);
            this.button_Buscar.TabIndex = 13;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = false;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // rdb_Titular_cpf
            // 
            this.rdb_Titular_cpf.AutoSize = true;
            this.rdb_Titular_cpf.Checked = true;
            this.rdb_Titular_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Titular_cpf.ForeColor = System.Drawing.Color.White;
            this.rdb_Titular_cpf.Location = new System.Drawing.Point(106, 93);
            this.rdb_Titular_cpf.Name = "rdb_Titular_cpf";
            this.rdb_Titular_cpf.Size = new System.Drawing.Size(96, 19);
            this.rdb_Titular_cpf.TabIndex = 11;
            this.rdb_Titular_cpf.TabStop = true;
            this.rdb_Titular_cpf.Text = "CPF Titular";
            this.rdb_Titular_cpf.UseVisualStyleBackColor = true;
            this.rdb_Titular_cpf.CheckedChanged += new System.EventHandler(this.rdb_Titular_cpf_CheckedChanged);
            // 
            // button_Editar
            // 
            this.button_Editar.BackColor = System.Drawing.Color.White;
            this.button_Editar.Location = new System.Drawing.Point(9, 279);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(184, 46);
            this.button_Editar.TabIndex = 15;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = false;
            this.button_Editar.Click += new System.EventHandler(this.button_Editar_Click);
            // 
            // rdb_NotaFiscal
            // 
            this.rdb_NotaFiscal.AutoSize = true;
            this.rdb_NotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_NotaFiscal.ForeColor = System.Drawing.Color.White;
            this.rdb_NotaFiscal.Location = new System.Drawing.Point(7, 93);
            this.rdb_NotaFiscal.Name = "rdb_NotaFiscal";
            this.rdb_NotaFiscal.Size = new System.Drawing.Size(97, 19);
            this.rdb_NotaFiscal.TabIndex = 10;
            this.rdb_NotaFiscal.Text = "Nota Fiscal";
            this.rdb_NotaFiscal.UseVisualStyleBackColor = true;
            this.rdb_NotaFiscal.CheckedChanged += new System.EventHandler(this.rdb_NotaFiscal_CheckedChanged);
            // 
            // button_deletar
            // 
            this.button_deletar.BackColor = System.Drawing.Color.White;
            this.button_deletar.Location = new System.Drawing.Point(9, 332);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(184, 46);
            this.button_deletar.TabIndex = 16;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = false;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // txtBox_buscar
            // 
            this.txtBox_buscar.Location = new System.Drawing.Point(7, 118);
            this.txtBox_buscar.Name = "txtBox_buscar";
            this.txtBox_buscar.Size = new System.Drawing.Size(186, 20);
            this.txtBox_buscar.TabIndex = 3;
            this.txtBox_buscar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 78);
            this.panel1.TabIndex = 144;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(13, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(562, 63);
            this.label4.TabIndex = 8;
            this.label4.Text = "Retirada de Pacotes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_funcionario
            // 
            this.comboBox_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_funcionario.FormattingEnabled = true;
            this.comboBox_funcionario.Location = new System.Drawing.Point(158, 114);
            this.comboBox_funcionario.Name = "comboBox_funcionario";
            this.comboBox_funcionario.Size = new System.Drawing.Size(134, 25);
            this.comboBox_funcionario.TabIndex = 127;
            // 
            // txtbox_nome_entregador
            // 
            this.txtbox_nome_entregador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nome_entregador.Location = new System.Drawing.Point(301, 114);
            this.txtbox_nome_entregador.Name = "txtbox_nome_entregador";
            this.txtbox_nome_entregador.Size = new System.Drawing.Size(134, 23);
            this.txtbox_nome_entregador.TabIndex = 128;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(298, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 143;
            this.label13.Text = "CPF Entregador:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(298, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 142;
            this.label12.Text = "Entregador";
            // 
            // maskedTextBox_email
            // 
            this.maskedTextBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_email.Location = new System.Drawing.Point(16, 235);
            this.maskedTextBox_email.Name = "maskedTextBox_email";
            this.maskedTextBox_email.Size = new System.Drawing.Size(134, 23);
            this.maskedTextBox_email.TabIndex = 134;
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(158, 174);
            this.maskedTextBox_telefone.Mask = "(00)0 0000-0000";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(134, 23);
            this.maskedTextBox_telefone.TabIndex = 130;
            // 
            // maskedTextBox_CPF
            // 
            this.maskedTextBox_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_CPF.Location = new System.Drawing.Point(158, 235);
            this.maskedTextBox_CPF.Mask = "000,000,000-00";
            this.maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            this.maskedTextBox_CPF.Size = new System.Drawing.Size(134, 23);
            this.maskedTextBox_CPF.TabIndex = 136;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 141;
            this.label9.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 140;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 139;
            this.label7.Text = "Situação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 138;
            this.label6.Text = "CPF Titular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 137;
            this.label5.Text = "Funcionário:";
            // 
            // textBox_NotaFiscal
            // 
            this.textBox_NotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NotaFiscal.Location = new System.Drawing.Point(16, 114);
            this.textBox_NotaFiscal.Name = "textBox_NotaFiscal";
            this.textBox_NotaFiscal.Size = new System.Drawing.Size(134, 23);
            this.textBox_NotaFiscal.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 135;
            this.label3.Text = "Nota Fiscal:";
            // 
            // textBox_Titular
            // 
            this.textBox_Titular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Titular.Location = new System.Drawing.Point(16, 174);
            this.textBox_Titular.Name = "textBox_Titular";
            this.textBox_Titular.Size = new System.Drawing.Size(134, 23);
            this.textBox_Titular.TabIndex = 129;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_retirada_pac);
            this.groupBox1.Location = new System.Drawing.Point(14, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 173);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacotes Registrados no Dia";
            // 
            // dataGridView_retirada_pac
            // 
            this.dataGridView_retirada_pac.AllowUserToAddRows = false;
            this.dataGridView_retirada_pac.AllowUserToDeleteRows = false;
            this.dataGridView_retirada_pac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_retirada_pac.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_retirada_pac.Name = "dataGridView_retirada_pac";
            this.dataGridView_retirada_pac.ReadOnly = true;
            this.dataGridView_retirada_pac.Size = new System.Drawing.Size(564, 148);
            this.dataGridView_retirada_pac.TabIndex = 14;
            this.dataGridView_retirada_pac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_retirada_pac_CellClick);
            this.dataGridView_retirada_pac.SelectionChanged += new System.EventHandler(this.dataGridView_retirada_pac_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 131;
            this.label2.Text = "Titular:";
            // 
            // FormRetirarPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_cpf_entregador);
            this.Controls.Add(this.groupBox_hora);
            this.Controls.Add(this.groupBox_Data);
            this.Controls.Add(this.maskedTextBoxSituacao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_funcionario);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRetirarPac";
            this.Text = "Americanas Rastreio";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRetirarPac_FormClosing);
            this.Load += new System.EventHandler(this.FormRetirarPac_Load);
            this.groupBox_hora.ResumeLayout(false);
            this.groupBox_hora.PerformLayout();
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_retirada_pac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtbox_cpf_entregador;
        private System.Windows.Forms.GroupBox groupBox_hora;
        private System.Windows.Forms.TextBox textBox_hora;
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSituacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtBox_buscar_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.RadioButton rdb_Titular_cpf;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.RadioButton rdb_NotaFiscal;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.TextBox txtBox_buscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_funcionario;
        private System.Windows.Forms.TextBox txtbox_nome_entregador;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_email;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_NotaFiscal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Titular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_retirada_pac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}