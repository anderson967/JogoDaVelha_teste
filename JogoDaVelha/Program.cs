// Desafio Jogo da Velha KLASSMATT
/*Regras:
    - O jogo ocorre em um tabuleiro 3x3;
    - O jogo será para duas pessoas jogarem, alternadamente;
    - O jogador 1, sempre será o X e sempre iniciará o jogo;
    - O jogador 2, sempre será a O e sempre será o segundo a jogar;
    - O jogo pode ter 3 resultados: vitória do jogador 1, vitória do jogador 2 ou empate;
    - Ganha o jogador que primeiro formar uma reta na diagonal, vertical ou horizontal do tabuleiro.
*/
/*Requisitos de implementação:
    - O jogo deve ser implementado na sua linguagem de preferência;
    - O sistema será uma CLI[2];
    - A cada jogada deve ser montado o tabuleiro na tela;
    - Ao final do jogo deve ser informado o vencedor ou se houve empate;
    - Você deve publicar seu código no github e enviar a url do repositório;
    - Faça uma documentação simples de como jogar o jogo (use um arquivo .md).
*/
/*Dicas:
    - Não é necessário preencher todo o tabuleiro para o jogo terminar;
    - Um jogador só consegue ganhar a partir da sua terceira jogada;
    - É sempre interessante deixar claro para o usuário que tipo de dado é esperado, se necessário, dê um exemplo;
    - Usuários são uma constante incógnita e muitas vezes informam inputs diferente do esperado.
*/

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            new JogoDaVelha.Iniciar();

        }
    }      
}



