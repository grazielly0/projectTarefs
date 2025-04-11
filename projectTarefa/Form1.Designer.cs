namespace projectTarefa
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.caixa1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Visualizar = new System.Windows.Forms.Button();
            this.naoFez1 = new System.Windows.Forms.Button();
            this.criar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.caixa4 = new System.Windows.Forms.MaskedTextBox();
            this.caixa3 = new System.Windows.Forms.MaskedTextBox();
            this.caixa2 = new System.Windows.Forms.MaskedTextBox();
            this.naoFez4 = new System.Windows.Forms.Button();
            this.naoFez3 = new System.Windows.Forms.Button();
            this.naoFez2 = new System.Windows.Forms.Button();
            this.visualizar2 = new System.Windows.Forms.Button();
            this.visualizar4 = new System.Windows.Forms.Button();
            this.visualizar3 = new System.Windows.Forms.Button();
            this.atualize1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoje";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // caixa1
            // 
            this.caixa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.caixa1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa1.ForeColor = System.Drawing.Color.SteelBlue;
            this.caixa1.Location = new System.Drawing.Point(247, 145);
            this.caixa1.Name = "caixa1";
            this.caixa1.Size = new System.Drawing.Size(587, 38);
            this.caixa1.TabIndex = 1;
            this.caixa1.TextChanged += new System.EventHandler(this.caixa1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(253, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tarefa 1";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // Visualizar
            // 
            this.Visualizar.BackColor = System.Drawing.Color.AliceBlue;
            this.Visualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizar.ForeColor = System.Drawing.Color.SteelBlue;
            this.Visualizar.Location = new System.Drawing.Point(659, 152);
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(80, 23);
            this.Visualizar.TabIndex = 11;
            this.Visualizar.Text = "Visualizar";
            this.Visualizar.UseVisualStyleBackColor = false;
            this.Visualizar.Click += new System.EventHandler(this.Visualizar_Click);
            // 
            // naoFez1
            // 
            this.naoFez1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.naoFez1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naoFez1.ForeColor = System.Drawing.Color.SteelBlue;
            this.naoFez1.Location = new System.Drawing.Point(747, 152);
            this.naoFez1.Name = "naoFez1";
            this.naoFez1.Size = new System.Drawing.Size(75, 23);
            this.naoFez1.TabIndex = 16;
            this.naoFez1.Text = "Não Feita";
            this.naoFez1.UseVisualStyleBackColor = true;
            // 
            // criar
            // 
            this.criar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(49)))), ((int)(((byte)(77)))));
            this.criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criar.Location = new System.Drawing.Point(1161, 373);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(49, 43);
            this.criar.TabIndex = 21;
            this.criar.Text = "+";
            this.criar.UseVisualStyleBackColor = false;
            this.criar.Click += new System.EventHandler(this.criar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(253, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tarefa 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(253, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tarefa 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(253, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tarefa 2";
            // 
            // caixa4
            // 
            this.caixa4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.caixa4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa4.ForeColor = System.Drawing.Color.SteelBlue;
            this.caixa4.Location = new System.Drawing.Point(247, 313);
            this.caixa4.Mask = "\\";
            this.caixa4.Name = "caixa4";
            this.caixa4.Size = new System.Drawing.Size(587, 38);
            this.caixa4.TabIndex = 24;
            // 
            // caixa3
            // 
            this.caixa3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.caixa3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa3.ForeColor = System.Drawing.Color.SteelBlue;
            this.caixa3.Location = new System.Drawing.Point(247, 258);
            this.caixa3.Name = "caixa3";
            this.caixa3.Size = new System.Drawing.Size(587, 38);
            this.caixa3.TabIndex = 23;
            this.caixa3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.caixa3_MaskInputRejected_1);
            // 
            // caixa2
            // 
            this.caixa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.caixa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa2.ForeColor = System.Drawing.Color.SteelBlue;
            this.caixa2.Location = new System.Drawing.Point(247, 201);
            this.caixa2.Name = "caixa2";
            this.caixa2.Size = new System.Drawing.Size(587, 38);
            this.caixa2.TabIndex = 22;
            this.caixa2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.caixa2_MaskInputRejected_1);
            // 
            // naoFez4
            // 
            this.naoFez4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naoFez4.ForeColor = System.Drawing.Color.SteelBlue;
            this.naoFez4.Location = new System.Drawing.Point(747, 322);
            this.naoFez4.Name = "naoFez4";
            this.naoFez4.Size = new System.Drawing.Size(75, 23);
            this.naoFez4.TabIndex = 33;
            this.naoFez4.Text = "Não Feita";
            this.naoFez4.UseVisualStyleBackColor = true;
            // 
            // naoFez3
            // 
            this.naoFez3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naoFez3.ForeColor = System.Drawing.Color.SteelBlue;
            this.naoFez3.Location = new System.Drawing.Point(747, 210);
            this.naoFez3.Name = "naoFez3";
            this.naoFez3.Size = new System.Drawing.Size(75, 23);
            this.naoFez3.TabIndex = 32;
            this.naoFez3.Text = "Não Feita";
            this.naoFez3.UseVisualStyleBackColor = true;
            // 
            // naoFez2
            // 
            this.naoFez2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naoFez2.ForeColor = System.Drawing.Color.SteelBlue;
            this.naoFez2.Location = new System.Drawing.Point(750, 266);
            this.naoFez2.Name = "naoFez2";
            this.naoFez2.Size = new System.Drawing.Size(75, 23);
            this.naoFez2.TabIndex = 31;
            this.naoFez2.Text = "Não Feita";
            this.naoFez2.UseVisualStyleBackColor = true;
            // 
            // visualizar2
            // 
            this.visualizar2.BackColor = System.Drawing.Color.AliceBlue;
            this.visualizar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.visualizar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizar2.ForeColor = System.Drawing.Color.SteelBlue;
            this.visualizar2.Location = new System.Drawing.Point(659, 267);
            this.visualizar2.Name = "visualizar2";
            this.visualizar2.Size = new System.Drawing.Size(80, 23);
            this.visualizar2.TabIndex = 30;
            this.visualizar2.Text = "Visualizar";
            this.visualizar2.UseVisualStyleBackColor = false;
            // 
            // visualizar4
            // 
            this.visualizar4.BackColor = System.Drawing.Color.AliceBlue;
            this.visualizar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.visualizar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizar4.ForeColor = System.Drawing.Color.SteelBlue;
            this.visualizar4.Location = new System.Drawing.Point(659, 322);
            this.visualizar4.Name = "visualizar4";
            this.visualizar4.Size = new System.Drawing.Size(80, 23);
            this.visualizar4.TabIndex = 29;
            this.visualizar4.Text = "Visualizar";
            this.visualizar4.UseVisualStyleBackColor = false;
            // 
            // visualizar3
            // 
            this.visualizar3.BackColor = System.Drawing.Color.AliceBlue;
            this.visualizar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.visualizar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizar3.ForeColor = System.Drawing.Color.SteelBlue;
            this.visualizar3.Location = new System.Drawing.Point(659, 209);
            this.visualizar3.Name = "visualizar3";
            this.visualizar3.Size = new System.Drawing.Size(80, 23);
            this.visualizar3.TabIndex = 28;
            this.visualizar3.Text = "Visualizar";
            this.visualizar3.UseVisualStyleBackColor = false;
            // 
            // atualize1
            // 
            this.atualize1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.atualize1.Location = new System.Drawing.Point(934, 94);
            this.atualize1.Name = "atualize1";
            this.atualize1.Size = new System.Drawing.Size(102, 31);
            this.atualize1.TabIndex = 34;
            this.atualize1.Text = "Atualizar";
            this.atualize1.UseVisualStyleBackColor = false;
            this.atualize1.Click += new System.EventHandler(this.atualize1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.atualize1);
            this.Controls.Add(this.naoFez4);
            this.Controls.Add(this.naoFez3);
            this.Controls.Add(this.naoFez2);
            this.Controls.Add(this.visualizar2);
            this.Controls.Add(this.visualizar4);
            this.Controls.Add(this.visualizar3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.caixa4);
            this.Controls.Add(this.caixa3);
            this.Controls.Add(this.caixa2);
            this.Controls.Add(this.criar);
            this.Controls.Add(this.naoFez1);
            this.Controls.Add(this.Visualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caixa1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caixa1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Visualizar;
        private System.Windows.Forms.Button naoFez1;
        private System.Windows.Forms.Button criar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox caixa4;
        private System.Windows.Forms.MaskedTextBox caixa3;
        private System.Windows.Forms.MaskedTextBox caixa2;
        private System.Windows.Forms.Button naoFez4;
        private System.Windows.Forms.Button naoFez3;
        private System.Windows.Forms.Button naoFez2;
        private System.Windows.Forms.Button visualizar2;
        private System.Windows.Forms.Button visualizar4;
        private System.Windows.Forms.Button visualizar3;
        private System.Windows.Forms.Button atualize1;
    }
}

