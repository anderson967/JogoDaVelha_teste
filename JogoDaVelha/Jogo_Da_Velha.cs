using System;


namespace JogoDaVelha
{
    internal class Iniciar
    {
        public Iniciar()
        {

            int a = 1;
            while (a>0)
            {
                MenuIniciar();
                ImprimirTabuleiro();
                Jogar();
                EscolherQuemComeça();
                VezJogador_1();
                MostrarTabela();
                Escolher();
                VezJogador_2();
                MostrarTabela();
                VezJogador_1();
                MostrarTabela();
                Escolher();
                VezJogador_2();
                MostrarTabela();
                FimDoJogo();
                
                a = 0;
            }
        }
        public void MenuIniciar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************");
            Console.WriteLine("*     JOGO DA VELHA     *");
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ImprimirTabuleiro()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("*      ___|___|___      *");
            Console.WriteLine("*      ___|___|___      *");
            Console.WriteLine("*         |   |         *");
            Console.WriteLine("*************************");
            return;
        }
        public static void EscolherQuemComeça()
        {
            bool b = true;
            while (b)
            {
                try
                {
                    Console.Write("Digite 1 para jogar com X e 0 para jogar com O: ");
                    int marcador = int.Parse(Console.ReadLine());
                    if (marcador == 0)
                    {
                        Jogador_2();
                        b = false;
                    }
                    else if (marcador == 1)
                    {
                        Jogador_1();
                        b = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um numero válido!");
                }

            }
            return;
        }
        private void MostrarTabela()
        {
            Console.WriteLine(ObterTabela());
        }
        public static void Jogar()
        {
            bool a = true;
            while (a)
            {
                try
                {
                    Console.Write("Digite 1 para jogar e 0 para sair: ");
                    int jogar = int.Parse(Console.ReadLine());
                    if (jogar == 0)
                    {
                        Console.WriteLine("Você não quer jogar!");
                        Console.WriteLine("Fim do Jogo!");
                        a = false;
                    }
                    else if (jogar == 1)
                    {
                        Console.WriteLine("Você quer jogar!");
                        a = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um numero válido!");
                }

            }
            return;
        }
        public static void Jogador_1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Você é o jogador 1!");
            Console.ForegroundColor = ConsoleColor.White;
            return;

        }
        public static void Jogador_2()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Você é o jogador 2!");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }

        public static void VezJogador_1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Jogador 1!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void VezJogador_2()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Jogador 2!");
            Console.ForegroundColor = ConsoleColor.White;

        }
        public int Escolher()
        {
            Console.Write("Escolha uma Posição: ");
            int a = int.Parse(Console.ReadLine());
            return a;
        }
        public static void FimDoJogo()
        {
            Console.WriteLine("Fim do Jogo!");
            return;
        }
        private bool fimDeJogo;
        private char[] pos;
        private char vez;
        private int quantidadePreenchida;

       
        private string ObterTabela()
        {
            pos = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return $"__{pos[0]}__|__{pos[1]}__|__{pos[2]}__\n" +
                   $"__{pos[3]}__|__{pos[4]}__|__{pos[5]}__\n" +
                   $"  {pos[6]}  |  {pos[7]}  |  {pos[8]}  \n\n";
        }
    }
}

