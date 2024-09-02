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

              new Pergunta
              {
                Id = 4,
                Enunciado = "Que profissional usa uma ferramenta chamada formão?",
                Alternativas = new[]
                {

                new Alternativa { Correta = true, Descricao = "Carpinteiro"},
                new Alternativa { Correta = false, Descricao = "Relojoeiro"},
                new Alternativa { Correta = false, Descricao = "Confeiteiro"},
                new Alternativa { Correta = false, Descricao = "Bombeiro"}

                }
              },



              new Pergunta
              {
                Id = 5,
                Enunciado = "O que é um oboé?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Vulcão"},
                new Alternativa { Correta = false, Descricao = "Comida"},
                new Alternativa { Correta = true, Descricao = "Instrumento musical"},
                new Alternativa { Correta = false, Descricao = "Tribo indígena"}

                }
              },


              new Pergunta
              {
                Id = 6,
                Enunciado = "No filme, quem era parceiro de crimes da Bonnie?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Bill"},
                new Alternativa { Correta = true, Descricao = "Clyde"},
                new Alternativa { Correta = false, Descricao = "James"},
                new Alternativa { Correta = false, Descricao = "Butch"}

                }
              },


              new Pergunta
              {
                Id = 7,
                Enunciado = "Que país europeu tem como atração a tourada?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Itália"},
                new Alternativa { Correta = true, Descricao = "Espanha"},
                new Alternativa { Correta = false, Descricao = "França"},
                new Alternativa { Correta = false, Descricao = "Alemanha"}

                }
              },

                 new Pergunta
              {
                Id = 8,
                Enunciado = "O que os filatelistas colecionam?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Quadros"},
                new Alternativa { Correta = false, Descricao = "Moedas"},
                new Alternativa { Correta = false, Descricao = "Figurinhas"},
                new Alternativa { Correta = true, Descricao = "Selos"}

                }
              },

              new Pergunta
              {
                Id = 9,
                Enunciado = "Nova Delhi é a capital de que país?",
                Alternativas = new[]
                {

                new Alternativa { Correta = true, Descricao = "Índia"},
                new Alternativa { Correta = false, Descricao = "Islândia"},
                new Alternativa { Correta = false, Descricao = "Paquistão"},
                new Alternativa { Correta = false, Descricao = "México"}

                }
              },

              new Pergunta
              {
                Id = 10,
                Enunciado = "Em que matéria estuda-se álgebra na escola?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Biologia"},
                new Alternativa { Correta = false, Descricao = "Química"},
                new Alternativa { Correta = true, Descricao = "Matemática"},
                new Alternativa { Correta = false, Descricao = "Física"}

                }
              },

              new Pergunta
              {
                Id = 10,
                Enunciado = "O que é um contratorpedeiro?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Avião de caça"},
                new Alternativa { Correta = false, Descricao = "Tanque"},
                new Alternativa { Correta = false, Descricao = "Dirigível"},
                new Alternativa { Correta = true, Descricao = "Navio de guerra"}

                }
              },

              new Pergunta
              {
                Id = 11,
                Enunciado = "Qual é o nome do cachorro de Charlie Brown?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Pluto"},
                new Alternativa { Correta = true, Descricao = "Snoopy"},
                new Alternativa { Correta = false, Descricao = "Floquinho"},
                new Alternativa { Correta = false, Descricao = "Baleia"}

                }
              },

              new Pergunta
              {
                Id = 12,
                Enunciado = "Como é chamado o templo sagrado dos judeus?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Igreja"},
                new Alternativa { Correta = false, Descricao = "Capela"},
                new Alternativa { Correta = true, Descricao = "Sinagoga"},
                new Alternativa { Correta = false, Descricao = "Catedral"}

                }
              },

              new Pergunta
              {
                Id = 13,
                Enunciado = "O FBI é a polícia federal de qual país?",
                Alternativas = new[]
                {

                new Alternativa { Correta = true, Descricao = "Estados Unidos"},
                new Alternativa { Correta = false, Descricao = "Canadá"},
                new Alternativa { Correta = false, Descricao = "França"},
                new Alternativa { Correta = false, Descricao = "Inglaterra"}

                }
              },


              new Pergunta
              {
                Id = 14,
                Enunciado = "Em que cidade foram realizados os jogos olímpicos de 2000?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Munique"},
                new Alternativa { Correta = false, Descricao = "Tóquio"},
                new Alternativa { Correta = false, Descricao = "Atlanta"},
                new Alternativa { Correta = true, Descricao = "Sydney"}

                }
              },

              new Pergunta
              {
                Id = 15,
                Enunciado = "Qual personagem bíblico dividiu as águas do Mar Vermelho?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Abraão"},
                new Alternativa { Correta = true, Descricao = "Moisés"},
                new Alternativa { Correta = false, Descricao = "Josué"},
                new Alternativa { Correta = false, Descricao = "Elias"}

                }
              },

                List<Pergunta> perguntas_dificeis = new()
              {
              new Pergunta
              {
                Id = 1,
                Enunciado = "Em qual país está localizado o “Muro das lamentações",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Alemanha"},
                new Alternativa { Correta = false, Descricao = "Brasil"},
                new Alternativa { Correta = false, Descricao = "Venezuela"},
                new Alternativa { Correta = true, Descricao = "Israel"}

                }
              },

              new Pergunta
              {
                Id = 2,
                Enunciado = "Onde nasceu Van Gogh, o grande pintor impressionista?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Polônia"},
                new Alternativa { Correta = false, Descricao = "França"},
                new Alternativa { Correta = false, Descricao = "Itália"},
                new Alternativa { Correta = true, Descricao = "Holanda"}

                }
              },

              new Pergunta
              {
                Id = 5,
                Enunciado = "Qual é a primeira letra do alfabeto grego?",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Delta"},
                new Alternativa { Correta = false, Descricao = "Beta"},
                new Alternativa { Correta = false, Descricao = "Gama"},
                new Alternativa { Correta = true, Descricao = "Alfa"}

                }
              },

              new Pergunta
              {
                Id = 4,
                Enunciado = "Os nazistas foram julgados em:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Berlim"},
                new Alternativa { Correta = true, Descricao = "Nurembergue"},
                new Alternativa { Correta = false, Descricao = "Munique"},
                new Alternativa { Correta = false, Descricao = "Pariz"}

                }
              },

              new Pergunta
              {
                Id = 5,
                Enunciado = "Em que parte do nosso corpo está o úmero?:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Perna"},
                new Alternativa { Correta = true, Descricao = "Braço"},
                new Alternativa { Correta = false, Descricao = "Quadril"},
                new Alternativa { Correta = false, Descricao = "Coluna"}

                }
              },

              new Pergunta
              {
                Id = 6,
                Enunciado = "O que significa deprecar?:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Renegar"},
                new Alternativa { Correta = false, Descricao = "Sujeitar"},
                new Alternativa { Correta = false, Descricao = "Desmaiar"},
                new Alternativa { Correta = true, Descricao = "Pedir"}

                }
              },

              new Pergunta
              {
                Id = 7,
                Enunciado = "Qual é a religião majoritária da Turquia?:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Budista"},
                new Alternativa { Correta = true, Descricao = "Islâmica"},
                new Alternativa { Correta = false, Descricao = "Católica"},
                new Alternativa { Correta = false, Descricao = "Protestante"}

                }
              },

              new Pergunta
              {
                Id = 7,
                Enunciado = "O que construía Stradivarius?:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Casas"},
                new Alternativa { Correta = true, Descricao = "Armas"},
                new Alternativa { Correta = false, Descricao = "Violinos"},
                new Alternativa { Correta = false, Descricao = "Estradas"}

                }
              },


              new Pergunta
              {
                Id = 8,
                Enunciado = "Qual é o nome dado a um conjunto de sinos?:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Corrimão"},
                new Alternativa { Correta = false, Descricao = "Corselete"},
                new Alternativa { Correta = false, Descricao = "Badalada"},
                new Alternativa { Correta = true, Descricao = "Carrilhão"}

                }
              },


              new Pergunta
              {
                Id = 9,
                Enunciado = "Qual é o apelido do time da Ponte Preta?:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Feiticeira"},
                new Alternativa { Correta = true, Descricao = "Macaca"},
                new Alternativa { Correta = false, Descricao = "Raposa"},
                new Alternativa { Correta = false, Descricao = "Bruxa"}

                }
              },

              new Pergunta
              {
                Id = 10,
                Enunciado = "O que é glicose?:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Aminoácido"},
                new Alternativa { Correta = true, Descricao = "Lipídio"},
                new Alternativa { Correta = false, Descricao = "Proteína"},
                new Alternativa { Correta = false, Descricao = "Hidrato de carbono"}

                }
              },


              new Pergunta
              {
                Id = 11,
                Enunciado = "As Ilhas Malvinas também são chamadas de:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Stanley"},
                new Alternativa { Correta = false, Descricao = "Wedells"},
                new Alternativa { Correta = true, Descricao = "Falkland"},
                new Alternativa { Correta = false, Descricao = "Medanosa"}

                }
              },


                new Pergunta
              {
                Id = 12,
                Enunciado = "Em que país Leonardo da Vinci viveu seus últimos dias?:",
                Alternativas = new[]
                {

                new Alternativa { Correta = true, Descricao = "França"},
                new Alternativa { Correta = false, Descricao = "Espanha"},
                new Alternativa { Correta = false, Descricao = "Holanda"},
                new Alternativa { Correta = false, Descricao = "Itália"}

                }
              },


              new Pergunta
              {
                Id = 13,
                Enunciado = "Pablo Picasso foi um dos criadores do:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Surrealismo"},
                new Alternativa { Correta = true, Descricao = "Cubismo"},
                new Alternativa { Correta = false, Descricao = "Impressionismo"},
                new Alternativa { Correta = false, Descricao = "Realismo"}

                }
              },

              new Pergunta
              {
                Id = 14,
                Enunciado = "Pablo Picasso foi um dos criadores do:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Felinos"},
                new Alternativa { Correta = false, Descricao = "Sirênios"},
                new Alternativa { Correta = true, Descricao = "Cetáceos"},
                new Alternativa { Correta = false, Descricao = "Carnívoros"}

                }
              },

              new Pergunta
              {
                Id = 15,
                Enunciado = "Qual é a maior ilha da Europa?:",
                Alternativas = new[]
                {

                new Alternativa { Correta = false, Descricao = "Irlanda"},
                new Alternativa { Correta = false, Descricao = "Sicília"},
                new Alternativa { Correta = false, Descricao = "Islândia"},
                new Alternativa { Correta = true, Descricao = "Grã-Bretanha"}

                }
        }
                
    };

                  Public static Pergunta getRandomPerguntaFacil()
                  {

                  }


        public App()
        {
            InitializeComponent();

            
            MainPage = new AppShell();
        }
    }
}
