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
                new Alternativa { Correta = false, Descricao = "Uma"},
                new Alternativa { Correta = true, Descricao = "Duas"},
                new Alternativa { Correta = false, Descricao = "Três"},
                new Alternativa { Correta = false, Descricao = "Quatro"}
            },

            new Pergunta
            {
                Id = 3,
                Enunciado = "Quem tem por lema a frase: Sempre alerta?", 
                new Alternativa { Correta = false, Descricao = "Bombeiros"},
                new Alternativa { Correta = false, Descricao = "Médicos"},
                new Alternativa { Correta = false, Descricao = "Policiais"},
                new Alternativa { Correta = true, Descricao = "Escoteiros"}
            },
            
            new Pergunta
            {
                Id = 4, 
                Enunciado = "Em qual país surgiu a máfia?",
                new Alternativa { Correta = true, Descricao = "Italia"},
                new Alternativa { Correta = false, Descricao = "Estados Unidos"},
                new Alternativa { Correta = false, Descricao = "Inglaterra"},
                new Alternativa { Correta = false, Descricao = "Espanha"}
            },

            new Pergunta
            {
                Id = 5,
                Enunciado = "Segundo a bíblia, quem foi morto por Caim?",
                new Alternativa { Correta = false, Descricao = "Adão"},
                new Alternativa { Correta = true, Descricao = "Abel"},
                new Alternativa { Correta = false, Descricao = "Isaac"},
                new Alternativa { Correta = false, Descricao = "Abraão"}

            },

            new Pergunta
            {
                Id = 6,
                Enunciado = "Quem ocupou o cargo de Ministro da Saúde do Brasil no ano de 2000?",
                new Alternativa { Correta = false, Descricao = "Adib Jatene"},
                new Alternativa { Correta = false, Descricao = "José Serra"},
                new Alternativa { Correta = false, Descricao = "Ciro Gomes"},
                new Alternativa { Correta = true, Descricao = "Pedro Malan"}

            },

            new Pergunta
            {
                Id = 7,
                Enunciado = "Quem é o inimigo do piu-piu nos esenhos animados?",
                new Alternativa { Correta = false, Descricao = "Mingau"},
                new Alternativa { Correta = false, Descricao = "Tom"},
                new Alternativa { Correta = false, Descricao = "Felix"},
                new Alternativa { Correta = true, Descricao = "Frajola"}
            },

            new Pergunta
            {
                Id = 8, 
                Enunciado = "Joana Prado é o nome verdadeiro de qual artista?",
                new Alternativa { Correta = false, Descricao = "Tiazinha"},
                new Alternativa { Correta = true, Descricao = "Feiticeira"},
                new Alternativa { Correta = false, Descricao = "Lady Lu"},
                new Alternativa { Correta = false, Descricao = "Sheila Mello"}
            },

             new Pergunta
            {
                Id = 9,
                Enunciado = "Quantos dias tem um ano bissexto?",
                new Alternativa { Correta = false, Descricao = "364"},
                new Alternativa { Correta = false, Descricao = "365"},
                new Alternativa { Correta = true, Descricao = "366"},
                new Alternativa { Correta = false, Descricao = "367"}
            },

              new Pergunta
            {
                Id = 10,
                Enunciado = "Qual é a cidade conhecida como a terra da garoa?",
                new Alternativa { Correta = true, Descricao = "São Paulo"},
                new Alternativa { Correta = false, Descricao = "Rio de Janeiro"},
                new Alternativa { Correta = false, Descricao = "Piracicaba"},
                new Alternativa { Correta = false, Descricao = "Porto Alegre"}
            },

               new Pergunta
            {
                Id = 11,
                Enunciado = "O violoncelo é um tipo de instrumento de?",
                new Alternativa { Correta = false, Descricao = "Sopro"},
                new Alternativa { Correta = false, Descricao = "Repercussão"},
                new Alternativa { Correta = false, Descricao = "Percussão"},
                new Alternativa { Correta = true, Descricao = "Cordas"}
            },

                new Pergunta
            {
                Id = 12,
                Enunciado = "Com que fruta a Branca de Neve foi envenenada?",
                new Alternativa { Correta = false, Descricao = "Pêra"},
                new Alternativa { Correta = true, Descricao = "Maçã"},
                new Alternativa { Correta = false, Descricao = "Melão"},
                new Alternativa { Correta = false, Descricao = "Laranja"}
            },

                 new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é a área da medicina que trata de crianças?",
                new Alternativa { Correta = false, Descricao = "Geriatria"},
                new Alternativa { Correta = false, Descricao = "Biologia"},
                new Alternativa { Correta = true, Descricao = "Pediatria"},
                new Alternativa { Correta = false, Descricao = "Infantologia"}
            },

                  new Pergunta
            {
                Id = 14,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                new Alternativa { Correta = false, Descricao = "Gerald Ford"},
                new Alternativa { Correta = true, Descricao = "Henry Ford"},
                new Alternativa { Correta = false, Descricao = "Harrison Ford"},
                new Alternativa { Correta = false, Descricao = "Anna Ford"}
            },

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
