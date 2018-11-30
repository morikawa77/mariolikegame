using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mariolikegame.DAL;
using MarioLikeGame.Model;

namespace MarioLikeGame
{   
    public partial class frmTelaJogo : Form
    {
        //Declarando a DAL
        GamerDAL gamerDAL;

        //Criando um atributo para pegar o nome do jogador
        public string nomeGamer { get; set; }

        


        //Atributos para controle da movimentaçao do personagem
        public bool paraCima;
        public bool paraBaixo;
        public bool paraDireita;
        public bool paraEsquerda;        

        //Variavel para condiçoes de vitoria/derrota
        private bool vitoria = false;

        //variavel para pontuacao
        private int pontos = 0;

        //variavel para contar os segundos
        private int segundos = 0;

        //variavel para contar os minutos
        private int minutos = 0;

        //Atributo responsavel pela velocidade de locomoçao do jogador
        public int velocidade = 10;

        //Criar uma lista de midias
        List<System.Windows.Media.MediaPlayer> sounds = new List<System.Windows.Media.MediaPlayer>();

        public frmTelaJogo()
        {
            InitializeComponent();
        }            
                     
       
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            

            switch (e.KeyCode)
            {
                case Keys.Left:
                    paraEsquerda = true;                
                    break;

                case Keys.Right:
                    paraDireita = true;
                    break;

                case Keys.Up:
                    paraCima = true;
                    break;

                case Keys.Down:
                    paraBaixo = true;
                    break;
            }

        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    paraEsquerda = false;
                    break;

                case Keys.Right:
                    paraDireita = false;
                    break;

                case Keys.Up:
                    paraCima = false;
                    break;

                case Keys.Down:
                    paraBaixo = false;
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPontos.Text = "Pontos: " + pontos;
            

            if (paraEsquerda)
            {
                //Movimenta o personagem para a esquerda
                personagem.Left -= velocidade;
            }

            if (paraDireita)
            {
                //Movimenta o personagem para a direita
                personagem.Left += velocidade;
            }

            if (paraCima)
            {
                //Movimenta o personagem para cima
                personagem.Top -= velocidade;
            }

            if (paraBaixo)
            {
                //Movimenta o personagem para baixo
                personagem.Top += velocidade;
            }

            //Posicionamento do personagem dentro da area do fomulario (tela)
            if (personagem.Left < 0)
            {
                personagem.Left = 0;
            }

            if (personagem.Left > 1090)
            {
                personagem.Left = 1090;
            }

            if (personagem.Top < 70)
            {
                personagem.Top = 70;
            }

            if (personagem.Top > 678)
            {
                personagem.Top = 678;
            }

            //Loop para checar todos os controles inseridos no Form
            foreach (Control item in this.Controls)
            {
                //Verifica se o jogador colidiu com os coletaveis, caso positivo, coletaveis somem
                if (item is PictureBox && (string)item.Tag == "coletaveis" || (string)item.Tag == "coletaveis2")
                {
                    //Checa colisao com as PicturesBox
                    if (((PictureBox)item).Bounds.IntersectsWith(personagem.Bounds))
                    {
                        //tocar o audio
                        //Audio("smb_coin.WAV", "Play");
                        if ((string)item.Tag == "coletaveis")
                        {
                            playSound("smb_coin.WAV");
                        }
                        else
                        {
                            playSound("smb_powerup.WAV");
                        }

                        //Remove o item coletavel
                        this.Controls.Remove(item);

                        //incrementar a variavel pontos
                        pontos++;

                        if (pontos == 14)
                        {                            
                            vitoria = true;
                            GameOver(vitoria);
                            RemovePictureBox();
                            GravaHiScore();

                        }

                       
                    }
                }
                
                //Verifica se o jogador colidiu com o inimigo, caso positivo - GAMEOVER
                if (item is PictureBox && (string)item.Tag == "inimigo")
                {
                    //Checa colisao com as PicturesBox
                    if (((PictureBox)item).Bounds.IntersectsWith(personagem.Bounds))
                    {                        
                        vitoria = false;
                        GameOver(vitoria);
                        RemovePictureBox();
                        GravaHiScore();
                    }
                }
            }            
        }
        
        
        private void GameOver(bool ganhou)
        {                        
            personagem.Visible = false;
            btnRestart.Visible = true;
            btnRestart.Focus();
            

            if (ganhou)
            {
                stopSound();
                //lblGameOver.Text = "Você Venceu!";
                pictureBox24.Visible = true;
                playSound("smb_stage_clear.WAV");
            }
            else
            {
                stopSound();
                //lblGameOver.Text = "GAME OVER";
                pictureBox25.Visible = true;
                playSound("smb_mariodie.WAV");
            }

            timer1.Stop();
            timer2.Stop();            

        }

        private void GravaHiScore()
        {
            //Instanciar a DAL
            gamerDAL = new GamerDAL();

            Placar placar = new Placar();

            var frm = new frmTelaInicial();

            placar.NomeJogador = this.nomeGamer;

            if (!this.nomeGamer.Equals(""))
            {
                placar.NomeJogador = this.nomeGamer;
            }
            else
            {
                placar.NomeJogador = "Player 1";
            }

            placar.ScoreJogador = pontos;
            placar.DataScoreJogador = DateTime.Now;
            placar.TempoJogo = minutos.ToString("00") + ":" + segundos.ToString("00");

            //Chama a funcao inserir da DAL passando o objeto populado como parametro
            if (!gamerDAL.Inserir(placar))
            {
                //Deu pau! Exibir mensagem para o usuario
                MessageBox.Show("Erro ao inserir os dados: \r\n\r\n" +
                    gamerDAL.MensagemErro, "Mario Like Game");
            }
        }

        private void RemovePictureBox ()
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string)item.Tag != "gameOver")
                {
                    ((PictureBox)item).Image = null;
                }
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            segundos++;

            if (segundos == 60)
            {
                minutos++;
                segundos = 0;
            }

            lblTempo.Text = "Tempo: " + minutos.ToString("00") + ":" + segundos.ToString("00");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
        private void frmTelaJogo_Load(object sender, EventArgs e)
        {
            //Audio("01 overworld bgm.mp3", "Play"); 
            playSound("01 overworld bgm.mp3");
        }

        private void playSound(string nome)
        {
            string url = Application.StartupPath + @"\" + nome;
            var sound = new System.Windows.Media.MediaPlayer();
            sound.Open(new Uri(url));
            sound.Play();
            sounds.Add(sound);

        }

        private void stopSound()
        {
            for (int i = sounds.Count -1; i >= 0; i--)
            {
                sounds[i].Stop();
                sounds.RemoveAt(i);
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }
    }

}
