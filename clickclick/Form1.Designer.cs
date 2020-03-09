namespace clickclick
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.mao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Label();
            this.pontos = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mao
            // 
            this.mao.BackColor = System.Drawing.Color.Transparent;
            this.mao.BackgroundImage = global::clickclick.Properties.Resources.nyjmytmkt7;
            this.mao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mao.FlatAppearance.BorderSize = 0;
            this.mao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mao.ForeColor = System.Drawing.Color.Transparent;
            this.mao.Location = new System.Drawing.Point(620, 335);
            this.mao.Name = "mao";
            this.mao.Size = new System.Drawing.Size(67, 135);
            this.mao.TabIndex = 2;
            this.mao.UseVisualStyleBackColor = false;
            this.mao.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tempo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(568, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pontuação";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(568, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Record";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempo
            // 
            this.tempo.Location = new System.Drawing.Point(38, 87);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(89, 21);
            this.tempo.TabIndex = 6;
            this.tempo.Text = "10";
            this.tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pontos
            // 
            this.pontos.AutoSize = true;
            this.pontos.Location = new System.Drawing.Point(690, 9);
            this.pontos.Name = "pontos";
            this.pontos.Size = new System.Drawing.Size(13, 13);
            this.pontos.TabIndex = 7;
            this.pontos.Text = "0";
            // 
            // record
            // 
            this.record.AutoSize = true;
            this.record.Location = new System.Drawing.Point(690, 49);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(13, 13);
            this.record.TabIndex = 8;
            this.record.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::clickclick.Properties.Resources.E1Wb5mf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 715);
            this.Controls.Add(this.record);
            this.Controls.Add(this.pontos);
            this.Controls.Add(this.tempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mao);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tempo;
        private System.Windows.Forms.Label pontos;
        private System.Windows.Forms.Label record;
        private System.Windows.Forms.Timer timer1;
    }
}

