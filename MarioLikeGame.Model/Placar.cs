﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarioLikeGame.Model
{
    public class Placar
    {
        private int idJogador;
        public string nomeJogador;
        public int scoreJogador;
        public DateTime dataScoreJogador;
        public string tempoJogo;

        public Placar()
        {        
        }

        public Placar(int idJogador, string nomeJogador, int scoreJogador, DateTime dataScoreJogador, string tempoJogo)
        {
            IdJogador = idJogador;
            NomeJogador = nomeJogador;
            ScoreJogador = scoreJogador;
            DataScoreJogador = dataScoreJogador;
            TempoJogo = tempoJogo;
        }

        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string NomeJogador { get => nomeJogador; set => nomeJogador = value; }
        public int ScoreJogador { get => scoreJogador; set => scoreJogador = value; }
        public DateTime DataScoreJogador { get => dataScoreJogador; set => dataScoreJogador = value; }
        public string TempoJogo { get => tempoJogo; set => tempoJogo = value; }

       
    }
}
