using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id=1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Líquido"},
                    new Alternativa { Correta = true, Descricao = "Sólido"},
                    new Alternativa { Correta = false, Descricao = "Gasoso"},
                    new Alternativa { Correta = false, Descricao = "Vaporoso"}
                }

            },

            new Pergunta
            {
                Id = 2,
                Enunciado = "Quantas dentições naturais tem o ser humano durante a vida?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Uma"},
                new Alternativa { Correta = true, Descricao = "Duas"},
                new Alternativa { Correta = false, Descricao = "Três"},
                new Alternativa { Correta = false, Descricao = "Quatro"}
                }
            },

            new Pergunta
            {
                Id = 3,
                Enunciado = "Quem tem por lema a frase: Sempre alerta?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Bombeiros"},
                new Alternativa { Correta = false, Descricao = "Médicos"},
                new Alternativa { Correta = false, Descricao = "Policiais"},
                new Alternativa { Correta = true, Descricao = "Escoteiros"}
                }
            },
            
            new Pergunta
            {
                Id = 4, 
                Enunciado = "Em qual país surgiu a máfia?",
                Alternativas = new()
                {
                new Alternativa { Correta = true, Descricao = "Italia"},
                new Alternativa { Correta = false, Descricao = "Estados Unidos"},
                new Alternativa { Correta = false, Descricao = "Inglaterra"},
                new Alternativa { Correta = false, Descricao = "Espanha"}
                }
            },

            new Pergunta
            {
                Id = 5,
                Enunciado = "Segundo a bíblia, quem foi morto por Caim?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Adão"},
                new Alternativa { Correta = true, Descricao = "Abel"},
                new Alternativa { Correta = false, Descricao = "Isaac"},
                new Alternativa { Correta = false, Descricao = "Abraão"}
                }
            },

            new Pergunta
            {
                Id = 6,
                Enunciado = "Quem ocupou o cargo de Ministro da Saúde do Brasil no ano de 2000?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Adib Jatene"},
                new Alternativa { Correta = false, Descricao = "José Serra"},
                new Alternativa { Correta = false, Descricao = "Ciro Gomes"},
                new Alternativa { Correta = true, Descricao = "Pedro Malan"}
                }
            },

            new Pergunta
            {
                Id = 7,
                Enunciado = "Quem é o inimigo do piu-piu nos esenhos animados?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Mingau"},
                new Alternativa { Correta = false, Descricao = "Tom"},
                new Alternativa { Correta = false, Descricao = "Felix"},
                new Alternativa { Correta = true, Descricao = "Frajola"}
                }
            },

            new Pergunta
            {
                Id = 8, 
                Enunciado = "Joana Prado é o nome verdadeiro de qual artista?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Tiazinha"},
                new Alternativa { Correta = true, Descricao = "Feiticeira"},
                new Alternativa { Correta = false, Descricao = "Lady Lu"},
                new Alternativa { Correta = false, Descricao = "Sheila Mello"}
                }
            },

             new Pergunta
             {
                Id = 9,
                Enunciado = "Quantos dias tem um ano bissexto?",
                Alternativas = new()
                 {
                new Alternativa { Correta = false, Descricao = "364"},
                new Alternativa { Correta = false, Descricao = "365"},
                new Alternativa { Correta = true, Descricao = "366"},
                new Alternativa { Correta = false, Descricao = "367"}
                }
             },

             new Pergunta
             {
                Id = 10,
                Enunciado = "Qual é a cidade conhecida como a terra da garoa?",
                Alternativas = new()
                { 
                new Alternativa { Correta = true, Descricao = "São Paulo"},
                new Alternativa { Correta = false, Descricao = "Rio de Janeiro"},
                new Alternativa { Correta = false, Descricao = "Piracicaba"},
                new Alternativa { Correta = false, Descricao = "Porto Alegre"}
                }
             },
 
             new Pergunta
             {
                Id = 11,
                Enunciado = "O violoncelo é um tipo de instrumento de?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Sopro"},
                new Alternativa { Correta = false, Descricao = "Repercussão"},
                new Alternativa { Correta = false, Descricao = "Percussão"},
                new Alternativa { Correta = true, Descricao = "Cordas"}
                }
             },

             new Pergunta
             {
                Id = 12,
                Enunciado = "Com que fruta a Branca de Neve foi envenenada?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Pêra"},
                new Alternativa { Correta = true, Descricao = "Maçã"},
                new Alternativa { Correta = false, Descricao = "Melão"},
                new Alternativa { Correta = false, Descricao = "Laranja"}
                }
             },

             new Pergunta
             {
                Id = 13,
                Enunciado = "Qual é a área da medicina que trata de crianças?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Geriatria"},
                new Alternativa { Correta = false, Descricao = "Biologia"},
                new Alternativa { Correta = true, Descricao = "Pediatria"},
                new Alternativa { Correta = false, Descricao = "Infantologia"}
                }
             },

             new Pergunta
             {
                Id = 14,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Gerald Ford"},
                new Alternativa { Correta = true, Descricao = "Henry Ford"},
                new Alternativa { Correta = false, Descricao = "Harrison Ford"},
                new Alternativa { Correta = false, Descricao = "Anna Ford"}
                }
             },

             new Pergunta
             {
                Id = 15,
                Enunciado = "De acordo com a Bíblia, qual era o fruto proibido?",
                 Alternativas = new()
                 {
                new Alternativa { Correta = false, Descricao = "Mamão"},
                new Alternativa { Correta = false, Descricao = "Uva"},
                new Alternativa { Correta = false, Descricao = "Abacaxi"},
                new Alternativa { Correta = true, Descricao = "Maçã"}
                 }
             },

             new Pergunta
             {
                Id = 16,
                Enunciado = "Quando é comemorado o dia de Santo Antônio?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "12 de agosto"},
                new Alternativa { Correta = true, Descricao = "11 de janeiro"},
                new Alternativa { Correta = false, Descricao = "7 de setembro "},
                new Alternativa { Correta = false, Descricao = "13 de junho"}
                }
             },

             new Pergunta
             {
                Id = 17,
                Enunciado = "Qual estação do ano fica entre o verão e o inverno?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Verão"},
                new Alternativa { Correta = true, Descricao = "Outono"},
                new Alternativa { Correta = false, Descricao = "Inverno"},
                new Alternativa { Correta = false, Descricao = "Primavera"}
                }
             },

             new Pergunta
             {
                Id = 18, 
                Enunciado = "Qual é o significado da palavra inglesa I love you?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "Bom dia"},
                new Alternativa { Correta = false, Descricao = "Até logo"},
                new Alternativa { Correta = true, Descricao = "Eu amo você"},
                new Alternativa { Correta = false, Descricao = "Estpu com fome"}
                }
             },

             new Pergunta
             {
                Id = 19,
                Enunciado = "Quem inventou o telefone?",
                Alternativas = new()
                {
                new Alternativa { Correta = true, Descricao = "Graham Bell"},
                new Alternativa { Correta = false, Descricao = "George Washington"},
                new Alternativa { Correta = false, Descricao = "Thomas Edison"},
                new Alternativa { Correta = false, Descricao = "Marconi"}
                }
             },

             new Pergunta
             {
                Id = 20,
                Enunciado = "Segundo a Bíblia, quantos discípulos tinha Jesus Cristo?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Dez"},
                new Alternativa { Correta = false, Descricao = "Onze"},
                new Alternativa { Correta = true, Descricao = "Doze"},
                new Alternativa { Correta = false, Descricao = "Treze"}
                
                }
                
             },

              List<Pergunta> perguntas_medias = new()
              {
              new Pergunta
              {
                Id = 1,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra?",
                Alternativas = new[]
                {

                new Alternativa { Correta = true, Descricao = "Seis"},
                new Alternativa { Correta = false, Descricao = "Oito"},
                new Alternativa { Correta = false, Descricao = "Dez"},
                new Alternativa { Correta = false, Descricao = "Doze"}
                }
              
              },

              
              new Pergunta
              {
                Id = 2,
                Enunciado = "Em qual estádio Pelé marcou o seu milésimo gol?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Morumbi"},
                new Alternativa { Correta = false, Descricao = "Pacaembu"},
                new Alternativa { Correta = true, Descricao = "Maracanã"},
                new Alternativa { Correta = false, Descricao = "Mineirão"}

                }
              },


              new Pergunta
              {
                Id = 3,
                Enunciado = "Qual ,é a moeda oficial da Alemanha?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Lira"},
                new Alternativa { Correta = false, Descricao = "Marco"},
                new Alternativa { Correta = true, Descricao = "Franco"},
                new Alternativa { Correta = false, Descricao = "Mineirão"}

                }
              },




        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
