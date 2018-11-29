﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mariolikegame.DAL;

namespace MarioLikeGame
{
    public partial class frmTelaInicial : Form
    {       

        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void PreencherGrid()
        {
            //Declarando a DAL
            GamerDAL gamerDAL;

            //Instanciando a DAL na construçao do formulario
            gamerDAL = new GamerDAL();

            //Limpando o DataSource
            dgvListaRecorde.DataSource = null;

            //Listando a DAL
            dgvListaRecorde.DataSource = gamerDAL.Listar();

            //Removendo a coluna id_Jogador
            dgvListaRecorde.Columns.Remove("IdJogador");
        }
        

        private void txtIniciar_Click(object sender, EventArgs e)
        {
            //Nao exibir a instancia atual da classe
            this.Visible = false;
            //Criar uma nova instancia do frmTelaJogo()
            var frm = new frmTelaJogo();
            //Pega o nome do jogador e envia para o Form1
            frm.nomeGamer = txtNome.Text;
            //Exibir o Formulario
            frm.ShowDialog();            
            //Exibir a nova instancia da classe
            this.Visible = true;
            //Lista o DataGrid
            PreencherGrid();

           
        }

        private void frmTelaInicial_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            PreencherGrid();

            //Setar o foco para o TextBox: nome do jogador
            txtNome.Focus();
            txtNome.Select();
        }

        

        private void gbOpcoes_Enter(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvListaRecorde_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
