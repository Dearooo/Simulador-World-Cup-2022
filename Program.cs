using System;
using Simulador_de_Mata_Mata_World_Cup_2022.Models;
using Simulador_de_Mata_Mata_World_Cup_2022.Models.Operacoes;

//Cadastrar Times

/* Grupo A 
CATAR
EQUADOR
SENEGAL
HOLANDA

Grupo B
INGLATERRA
IRÃ
ESTADOS UNIDOS
PAÍS DE GALES

Grupo C
ARGENTINA
ARÁBIA SAUDITA
MÉXICO
POLÔNIA

Grupo D
FRANÇA
AUSTRÁLIA
DINAMARCA
TUNÍSIA

Grupo E
ESPANHA
COSTA RICA
ALEMANHA
JAPÃO

Grupo F
BELGICA
CANADÁ
MARROCOS
CROÁCIA

Grupo G
BRASIL
SÉRVIA
SUÍÇA
CAMARÕES

Grupo H
PORTUGAL
GANA
URUGUAI
COREIA DO SUL */

Time[] A = new Time[4];
A[0].Cadastro("CATAR");
A[1].Cadastro("EQUADOR");
A[2].Cadastro("SENEGAL");
A[3].Cadastro("HOLANDA");

Time[] B = new Time[4];
B[0].Cadastro("INGLATERRA");
B[1].Cadastro("IRÃ");
B[2].Cadastro("ESTADOS UNIDOS");
B[3].Cadastro("PAIS DE GALES");

Time[] C = new Time[4];
C[0].Cadastro("ARGENTINA");
C[1].Cadastro("ARABIA SAUDITA");
C[2].Cadastro("MEXICO");
C[3].Cadastro("POLONIA");

Time[] D = new Time[4];
D[0].Cadastro("FRANÇA");
D[1].Cadastro("AUSTRALIA");
D[2].Cadastro("DINAMARCA");
D[3].Cadastro("TUNISIA");

Time[] E = new Time[4];
E[0].Cadastro("ESPANHA");
E[1].Cadastro("COSTA RICA");
E[2].Cadastro("ALEMANHA");
E[3].Cadastro("JAPAO");

Time[] F = new Time[4];
F[0].Cadastro("BELGICA");
F[1].Cadastro("CANADA");
F[2].Cadastro("MARROCOS");
F[3].Cadastro("CROACIA");

Time[] G = new Time[4];
G[0].Cadastro("BRASIL");
G[1].Cadastro("SERVIA");
G[2].Cadastro("SUIÇA");
G[3].Cadastro("CAMAROES");

Time[] H = new Time[4];
H[0].Cadastro("PORTUGAL");
H[1].Cadastro("GANA");
H[2].Cadastro("URUGUAI");
H[3].Cadastro("COREIA DO SUL");

Operacoes.Controle_FG(A);
Operacoes.Controle_FG(B);
Operacoes.Controle_FG(C);
Operacoes.Controle_FG(D);
Operacoes.Controle_FG(E);
Operacoes.Controle_FG(F);
Operacoes.Controle_FG(G);
Operacoes.Controle_FG(H);

Operacoes.Selecao_quartas(A);
Operacoes.Selecao_quartas(B);
Operacoes.Selecao_quartas(C);
Operacoes.Selecao_quartas(D);
Operacoes.Selecao_quartas(E);
Operacoes.Selecao_quartas(F);
Operacoes.Selecao_quartas(G);
Operacoes.Selecao_quartas(H);

