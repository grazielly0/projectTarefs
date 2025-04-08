namespace projectTarefa
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
            this.caixa5 = new System.Windows.Forms.TextBox();
            this.caixa6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cadastro = new System.Windows.Forms.Button();
            this.prioridade = new System.Windows.Forms.GroupBox();
            this.voltar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.caixa8 = new System.Windows.Forms.TextBox();
            this.prioridade1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.prioridade.SuspendLayout();
            this.SuspendLayout();
            // 
            // caixa5
            // 
            this.caixa5.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa5.Location = new System.Drawing.Point(58, 131);
            this.caixa5.Name = "caixa5";
            this.caixa5.Size = new System.Drawing.Size(643, 33);
            this.caixa5.TabIndex = 0;
            this.caixa5.TextChanged += new System.EventHandler(this.caixa5_TextChanged);
            // 
            // caixa6
            // 
            this.caixa6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.caixa6.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa6.Location = new System.Drawing.Point(58, 198);
            this.caixa6.Name = "caixa6";
            this.caixa6.Size = new System.Drawing.Size(643, 30);
            this.caixa6.TabIndex = 1;
            this.caixa6.TextChanged += new System.EventHandler(this.caixa6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(55, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data de Vencimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(57, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prioriadade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(118, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adicionar Tarefa";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // cadastro
            // 
            this.cadastro.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.cadastro.Location = new System.Drawing.Point(348, 387);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(95, 33);
            this.cadastro.TabIndex = 22;
            this.cadastro.Text = "Cadastrar";
            this.cadastro.UseVisualStyleBackColor = true;
            this.cadastro.Click += new System.EventHandler(this.button4_Click);
            // 
            // prioridade
            // 
            this.prioridade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.prioridade.Controls.Add(this.dateTimePicker1);
            this.prioridade.Controls.Add(this.prioridade1);
            this.prioridade.Controls.Add(this.label6);
            this.prioridade.Controls.Add(this.caixa8);
            this.prioridade.Controls.Add(this.voltar);
            this.prioridade.Controls.Add(this.cadastro);
            this.prioridade.Controls.Add(this.label3);
            this.prioridade.Controls.Add(this.label5);
            this.prioridade.Controls.Add(this.label4);
            this.prioridade.Controls.Add(this.label2);
            this.prioridade.Controls.Add(this.label1);
            this.prioridade.Controls.Add(this.caixa6);
            this.prioridade.Controls.Add(this.caixa5);
            this.prioridade.Location = new System.Drawing.Point(12, 12);
            this.prioridade.Name = "prioridade";
            this.prioridade.Size = new System.Drawing.Size(763, 426);
            this.prioridade.TabIndex = 0;
            this.prioridade.TabStop = false;
            this.prioridade.Text = "groupBox1";
            this.prioridade.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // voltar
            // 
            this.voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.voltar.Location = new System.Drawing.Point(643, 377);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(104, 34);
            this.voltar.TabIndex = 23;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(57, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "Código";
            // 
            // caixa8
            // 
            this.caixa8.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa8.Location = new System.Drawing.Point(58, 67);
            this.caixa8.Name = "caixa8";
            this.caixa8.Size = new System.Drawing.Size(643, 33);
            this.caixa8.TabIndex = 24;
            this.caixa8.TextChanged += new System.EventHandler(this.caixa8_TextChanged);
            // 
            // prioridade1
            // 
            this.prioridade1.FormattingEnabled = true;
            this.prioridade1.Items.AddRange(new object[] {
            " Baixa",
            "Média",
            "Alta"});
            this.prioridade1.Location = new System.Drawing.Point(331, 328);
            this.prioridade1.Name = "prioridade1";
            this.prioridade1.Size = new System.Drawing.Size(121, 21);
            this.prioridade1.TabIndex = 30;
            this.prioridade1.Text = "Adicionar Prioridade";
            this.prioridade1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 267);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(641, 20);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prioridade);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.prioridade.ResumeLayout(false);
            this.prioridade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox caixa5;
        private System.Windows.Forms.TextBox caixa6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cadastro;
        private System.Windows.Forms.GroupBox prioridade;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox caixa8;
        private System.Windows.Forms.ComboBox prioridade1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}