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

            }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
