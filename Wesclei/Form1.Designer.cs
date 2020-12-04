namespace Wesclei
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_custo = new System.Windows.Forms.Label();
            this.lb_distância = new System.Windows.Forms.Label();
            this.lb_captura = new System.Windows.Forms.Label();
            this.lb_nivel = new System.Windows.Forms.Label();
            this.rb_nao = new System.Windows.Forms.RadioButton();
            this.rb_sim = new System.Windows.Forms.RadioButton();
            this.tx_distancia = new System.Windows.Forms.TextBox();
            this.tx_custo = new System.Windows.Forms.TextBox();
            this.tx_nivel = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ReadOnlyChanged += new System.EventHandler(this.dataGridView1_ReadOnlyChanged);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(103, 19);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 33);
            this.btn_excluir.TabIndex = 1;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incluir.Location = new System.Drawing.Point(6, 19);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(75, 33);
            this.btn_incluir.TabIndex = 0;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(19, 20);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(37, 16);
            this.lb_data.TabIndex = 2;
            this.lb_data.Text = "Data";
            // 
            // lb_custo
            // 
            this.lb_custo.AutoSize = true;
            this.lb_custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_custo.Location = new System.Drawing.Point(19, 60);
            this.lb_custo.Name = "lb_custo";
            this.lb_custo.Size = new System.Drawing.Size(42, 16);
            this.lb_custo.TabIndex = 3;
            this.lb_custo.Text = "Custo";
            // 
            // lb_distância
            // 
            this.lb_distância.AutoSize = true;
            this.lb_distância.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_distância.Location = new System.Drawing.Point(19, 100);
            this.lb_distância.Name = "lb_distância";
            this.lb_distância.Size = new System.Drawing.Size(64, 16);
            this.lb_distância.TabIndex = 4;
            this.lb_distância.Text = "Distância";
            // 
            // lb_captura
            // 
            this.lb_captura.AutoSize = true;
            this.lb_captura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_captura.Location = new System.Drawing.Point(19, 146);
            this.lb_captura.Name = "lb_captura";
            this.lb_captura.Size = new System.Drawing.Size(55, 16);
            this.lb_captura.TabIndex = 5;
            this.lb_captura.Text = "Captura";
            // 
            // lb_nivel
            // 
            this.lb_nivel.AutoSize = true;
            this.lb_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nivel.Location = new System.Drawing.Point(19, 196);
            this.lb_nivel.Name = "lb_nivel";
            this.lb_nivel.Size = new System.Drawing.Size(62, 16);
            this.lb_nivel.TabIndex = 6;
            this.lb_nivel.Text = "Nivel dor";
            // 
            // rb_nao
            // 
            this.rb_nao.AutoSize = true;
            this.rb_nao.Location = new System.Drawing.Point(97, 146);
            this.rb_nao.Name = "rb_nao";
            this.rb_nao.Size = new System.Drawing.Size(45, 17);
            this.rb_nao.TabIndex = 7;
            this.rb_nao.TabStop = true;
            this.rb_nao.Text = "Não";
            this.rb_nao.UseVisualStyleBackColor = true;
            // 
            // rb_sim
            // 
            this.rb_sim.AutoSize = true;
            this.rb_sim.Location = new System.Drawing.Point(170, 147);
            this.rb_sim.Name = "rb_sim";
            this.rb_sim.Size = new System.Drawing.Size(42, 17);
            this.rb_sim.TabIndex = 8;
            this.rb_sim.TabStop = true;
            this.rb_sim.Text = "Sim";
            this.rb_sim.UseVisualStyleBackColor = true;
            // 
            // tx_distancia
            // 
            this.tx_distancia.Location = new System.Drawing.Point(97, 98);
            this.tx_distancia.Name = "tx_distancia";
            this.tx_distancia.Size = new System.Drawing.Size(180, 20);
            this.tx_distancia.TabIndex = 11;
            // 
            // tx_custo
            // 
            this.tx_custo.Location = new System.Drawing.Point(97, 57);
            this.tx_custo.Name = "tx_custo";
            this.tx_custo.Size = new System.Drawing.Size(180, 20);
            this.tx_custo.TabIndex = 12;
            // 
            // tx_nivel
            // 
            this.tx_nivel.Location = new System.Drawing.Point(97, 194);
            this.tx_nivel.Name = "tx_nivel";
            this.tx_nivel.Size = new System.Drawing.Size(180, 20);
            this.tx_nivel.TabIndex = 13;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(143, 245);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(83, 31);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(45, 245);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(81, 31);
            this.btn_salvar.TabIndex = 15;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.tx_distancia);
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Controls.Add(this.lb_data);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.lb_custo);
            this.groupBox1.Controls.Add(this.tx_nivel);
            this.groupBox1.Controls.Add(this.lb_distância);
            this.groupBox1.Controls.Add(this.tx_custo);
            this.groupBox1.Controls.Add(this.lb_captura);
            this.groupBox1.Controls.Add(this.lb_nivel);
            this.groupBox1.Controls.Add(this.rb_nao);
            this.groupBox1.Controls.Add(this.rb_sim);
            this.groupBox1.Location = new System.Drawing.Point(429, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 308);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(97, 16);
            this.data.Mask = "00/00/0000 90:00";
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(180, 20);
            this.data.TabIndex = 16;
            this.data.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_excluir);
            this.groupBox2.Controls.Add(this.btn_incluir);
            this.groupBox2.Location = new System.Drawing.Point(430, -3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 60);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "ACME FLIGHT MANAGER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_custo;
        private System.Windows.Forms.Label lb_distância;
        private System.Windows.Forms.Label lb_captura;
        private System.Windows.Forms.Label lb_nivel;
        private System.Windows.Forms.RadioButton rb_nao;
        private System.Windows.Forms.RadioButton rb_sim;
        private System.Windows.Forms.TextBox tx_distancia;
        private System.Windows.Forms.TextBox tx_custo;
        private System.Windows.Forms.TextBox tx_nivel;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox data;
    }
}

