namespace MarioLikeGame
{
    partial class frmTelaInicial
    {
        // <summary>
        // Required designer variable.
        // </summary>
        private System.ComponentModel.IContainer components = null;

        // <summary>
        // Clean up any resources being used.
        // </summary>
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaRecorde = new System.Windows.Forms.DataGridView();
            this.pnlTelaInicialSup = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNomeJogo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblJogador = new System.Windows.Forms.Label();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pbMario2 = new System.Windows.Forms.PictureBox();
            this.pbMario1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRecorde)).BeginInit();
            this.pnlTelaInicialSup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaRecorde
            // 
            this.dgvListaRecorde.AllowUserToAddRows = false;
            this.dgvListaRecorde.AllowUserToResizeColumns = false;
            this.dgvListaRecorde.AllowUserToResizeRows = false;
            this.dgvListaRecorde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaRecorde.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaRecorde.BackgroundColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaRecorde.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaRecorde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaRecorde.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaRecorde.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvListaRecorde.Location = new System.Drawing.Point(5, 125);
            this.dgvListaRecorde.Name = "dgvListaRecorde";
            this.dgvListaRecorde.ReadOnly = true;
            this.dgvListaRecorde.RowHeadersVisible = false;
            this.dgvListaRecorde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListaRecorde.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaRecorde.RowTemplate.Height = 50;
            this.dgvListaRecorde.RowTemplate.ReadOnly = true;
            this.dgvListaRecorde.Size = new System.Drawing.Size(1156, 600);
            this.dgvListaRecorde.TabIndex = 0;
            this.dgvListaRecorde.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaRecorde_CellContentClick);
            // 
            // pnlTelaInicialSup
            // 
            this.pnlTelaInicialSup.AutoSize = true;
            this.pnlTelaInicialSup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTelaInicialSup.BackColor = System.Drawing.Color.Coral;
            this.pnlTelaInicialSup.Controls.Add(this.groupBox2);
            this.pnlTelaInicialSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTelaInicialSup.Location = new System.Drawing.Point(0, 0);
            this.pnlTelaInicialSup.Name = "pnlTelaInicialSup";
            this.pnlTelaInicialSup.Size = new System.Drawing.Size(1167, 122);
            this.pnlTelaInicialSup.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pbMario2);
            this.groupBox2.Controls.Add(this.pbMario1);
            this.groupBox2.Controls.Add(this.lblNomeJogo);
            this.groupBox2.Location = new System.Drawing.Point(71, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(928, 108);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblNomeJogo
            // 
            this.lblNomeJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogo.ForeColor = System.Drawing.Color.White;
            this.lblNomeJogo.Location = new System.Drawing.Point(321, 17);
            this.lblNomeJogo.Name = "lblNomeJogo";
            this.lblNomeJogo.Size = new System.Drawing.Size(330, 76);
            this.lblNomeJogo.TabIndex = 7;
            this.lblNomeJogo.Text = "MarioLike";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblJogador);
            this.groupBox1.Controls.Add(this.gbOpcoes);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(722, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 643);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(165, 16);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(165, 46);
            this.lblJogador.TabIndex = 5;
            this.lblJogador.Text = "Jogador";
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.btnSair);
            this.gbOpcoes.Controls.Add(this.btnIniciar);
            this.gbOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcoes.Location = new System.Drawing.Point(83, 141);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(343, 328);
            this.gbOpcoes.TabIndex = 9;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(67, 203);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(204, 115);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(67, 52);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(204, 115);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(100, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(339, 53);
            this.txtNome.TabIndex = 6;
            this.txtNome.Text = "Player 1";
            // 
            // pbMario2
            // 
            this.pbMario2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMario2.Image = global::MarioLikeGame.Properties.Resources.MarioSMBW1;
            this.pbMario2.Location = new System.Drawing.Point(848, 16);
            this.pbMario2.Name = "pbMario2";
            this.pbMario2.Size = new System.Drawing.Size(77, 89);
            this.pbMario2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMario2.TabIndex = 6;
            this.pbMario2.TabStop = false;
            // 
            // pbMario1
            // 
            this.pbMario1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbMario1.Image = global::MarioLikeGame.Properties.Resources.MarioSMBW1;
            this.pbMario1.Location = new System.Drawing.Point(3, 16);
            this.pbMario1.Name = "pbMario1";
            this.pbMario1.Size = new System.Drawing.Size(77, 89);
            this.pbMario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMario1.TabIndex = 5;
            this.pbMario1.TabStop = false;
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1167, 765);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTelaInicialSup);
            this.Controls.Add(this.dgvListaRecorde);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelaInicial";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRecorde)).EndInit();
            this.pnlTelaInicialSup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMario2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaRecorde;
        private System.Windows.Forms.Panel pnlTelaInicialSup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbMario2;
        private System.Windows.Forms.PictureBox pbMario1;
        private System.Windows.Forms.Label lblNomeJogo;
    }
}