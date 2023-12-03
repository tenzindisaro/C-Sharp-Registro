namespace WindowsFormsApp1
{
    partial class FormRelatorio
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_buscar = new System.Windows.Forms.TextBox();
            this.txtBox_buscar_cpf = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdb_Titular_cpf = new System.Windows.Forms.RadioButton();
            this.rdb_NotaFiscal = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridRelatorio = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "vão redirecionar para a tela registroPac>>>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.txtBox_buscar);
            this.panel1.Controls.Add(this.txtBox_buscar_cpf);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rdb_Titular_cpf);
            this.panel1.Controls.Add(this.rdb_NotaFiscal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 81);
            this.panel1.TabIndex = 129;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBox_buscar
            // 
            this.txtBox_buscar.Location = new System.Drawing.Point(585, 30);
            this.txtBox_buscar.Name = "txtBox_buscar";
            this.txtBox_buscar.Size = new System.Drawing.Size(186, 20);
            this.txtBox_buscar.TabIndex = 12;
            // 
            // txtBox_buscar_cpf
            // 
            this.txtBox_buscar_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_buscar_cpf.Location = new System.Drawing.Point(237, 37);
            this.txtBox_buscar_cpf.Mask = "000,000,000-00";
            this.txtBox_buscar_cpf.Name = "txtBox_buscar_cpf";
            this.txtBox_buscar_cpf.Size = new System.Drawing.Size(183, 23);
            this.txtBox_buscar_cpf.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(575, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rdb_Titular_cpf
            // 
            this.rdb_Titular_cpf.AutoSize = true;
            this.rdb_Titular_cpf.Checked = true;
            this.rdb_Titular_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Titular_cpf.ForeColor = System.Drawing.Color.White;
            this.rdb_Titular_cpf.Location = new System.Drawing.Point(681, 7);
            this.rdb_Titular_cpf.Name = "rdb_Titular_cpf";
            this.rdb_Titular_cpf.Size = new System.Drawing.Size(96, 19);
            this.rdb_Titular_cpf.TabIndex = 10;
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
            this.rdb_NotaFiscal.Location = new System.Drawing.Point(585, 6);
            this.rdb_NotaFiscal.Name = "rdb_NotaFiscal";
            this.rdb_NotaFiscal.Size = new System.Drawing.Size(97, 19);
            this.rdb_NotaFiscal.TabIndex = 11;
            this.rdb_NotaFiscal.Text = "Nota Fiscal";
            this.rdb_NotaFiscal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(13, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 63);
            this.label4.TabIndex = 8;
            this.label4.Text = "Relatórios";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(435, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 22);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Alfabética";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(435, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 22);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Horário";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(435, 28);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 22);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Situação";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(369, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ordem:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(585, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 46);
            this.button2.TabIndex = 124;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridRelatorio);
            this.groupBox1.Location = new System.Drawing.Point(15, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 259);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacotes Listados";
            // 
            // dataGridRelatorio
            // 
            this.dataGridRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRelatorio.Location = new System.Drawing.Point(7, 19);
            this.dataGridRelatorio.Name = "dataGridRelatorio";
            this.dataGridRelatorio.Size = new System.Drawing.Size(763, 234);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(406, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 46);
            this.button4.TabIndex = 127;
            this.button4.Text = "Semanal";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(47, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 46);
            this.button5.TabIndex = 125;
            this.button5.Text = "Gerar Relatório";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(227, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 46);
            this.button3.TabIndex = 126;
            this.button3.Text = "Diário";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Name = "FormRelatorio";
            this.Text = "FormRelatorio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridRelatorio;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox txtBox_buscar_cpf;
        private System.Windows.Forms.RadioButton rdb_Titular_cpf;
        private System.Windows.Forms.RadioButton rdb_NotaFiscal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_buscar;
    }
}