using Quiz.Domain;
using System;

namespace QuizEstude.ConsoleUI
{
    public class MeuApp
    {
        static void Main(string[] args)
        {
            var idQuestionario = Guid.NewGuid();
            Questionario questionario = new Questionario(idQuestionario,"Padrões de Projetos");

            var idPergunta1 = Guid.NewGuid();
            questionario.AddPergunta(idPergunta1,"Qual o padrão de projeto mais utilizado?");

            var idOp1 = Guid.NewGuid();
            var idOp2 = Guid.NewGuid();
            var idOp3 = Guid.NewGuid();
            var idOp4 = Guid.NewGuid();

            questionario.GetPergunta(idPergunta1)
                        .AddOpcaoResposta(idOp1,"Visitor", false)
                        .AddOpcaoResposta(idOp2,"Memento", false)
                        .AddOpcaoResposta(idOp3,"Decorator", false)
                        .AddOpcaoResposta(idOp4,"Facade", true);

            Console.WriteLine(questionario.ToString());

            QuestionarioResposta questionarioResposta = new QuestionarioResposta(questionario);
            questionarioResposta.AddResposta(idPergunta1, idOp2);

            Console.WriteLine(questionarioResposta.ToString());
            Console.ReadLine();
        }
    }
}
