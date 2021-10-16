using System;

namespace Exercicios_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            bool validacao = true;
     
            Program program = new Program();

            Console.WriteLine("############# - Bem Vindo ! - #############");

            do
            {

                Console.WriteLine("Qual a opcao desejada? ");
                Console.WriteLine("(1) - Calcular IMC");
                Console.WriteLine("(2) - Descubra quantos salários mínimos vc ganha");
                Console.WriteLine("(3) - Qual o volume de uma esfera?");
                Console.WriteLine("(4) - Média escolar com recuperação");
                Console.WriteLine("(5) - Animais de Estimação");
                Console.WriteLine("(6) - Sair");

                Console.WriteLine("Digite sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 1: //IMC

                        double peso;
                        double altura;
                        double imc;

                        Console.WriteLine("############# - Calcule seu IMC ! - #############");
                        Console.WriteLine("Digite o seu peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a sua altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());

                        imc = program.Imc(peso, altura);


                        Console.WriteLine("Seu IMC = {0}", imc);

                        if (imc < 20)
                        {
                            Console.WriteLine("Você está abaixo do peso!! Procure melhorar sua saúde");

                        }
                        else if (imc == 20 && imc <= 25)
                        {

                            Console.WriteLine("Peso está dentro do ideal!! Mantenha-se assim.");

                        } 
                        {
                            Console.WriteLine("Você está acima do peso!! Mantenha-se assim.");
                        }

                        break;

                    case 2: //SALARIO

                        double salario;
                        double salariominimo;
                        double resultado;

                        Console.WriteLine("############# - Descubra quantos salários mínimos vc ganha! - #############");
                        Console.WriteLine("Digite seu salário: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o valor do salário mínimo atual: ");
                        salariominimo = Convert.ToDouble(Console.ReadLine());

                        resultado = program.CalculaSalario(salario, salariominimo);
                        Console.WriteLine("Você recebe a quantidade de {0} salario(s) mínimo(s)", resultado );

                        break;

                    case 3: //VOLUME

                        double raio;
                        double volume;

                        Console.WriteLine("############# - Calcule o volume de uma esfera - #############");
                        Console.WriteLine("Digite o raio da esfera em cm: ");
                        raio = Convert.ToDouble(Console.ReadLine());

                        volume = program.CalculaVolume(raio);
                        Console.WriteLine("O volume de sua esfera é {0} litros ", volume);

                        break;

                    case 4: //MÉDIA

                        double n1, n2, n3;
                        double media;
                        


                        Console.WriteLine("############# - Descubra se você foi aprovado - #############");
                        Console.WriteLine("Digite sua nota da primeira prova: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite sua nota da segunda prova: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite sua nota da terceira prova: ");
                        n3 = Convert.ToDouble(Console.ReadLine());

                        media = program.Media(n1, n2, n3);
                        media = Math.Round(media, 2);

                        Console.WriteLine("Sua média: {0} ", media);

                        if (media >= 7)
                        {
                            Console.WriteLine("Você foi APROVADO!! Parabéns!");
                        }
                        else
                        {
                            Console.WriteLine("Você foi REPROVADO!! Realize a prova de recuperação...");
                            Console.WriteLine(program.MediaRec(media));

                        }

                        break;

                    case 4: //ANIMAIS DE ESTIMAÇÃO

                        string animal1,
                               animal2,
                               animal3, 
                               animal4, 
                               animal5;


                        Console.WriteLine("############# - Animais de estimação - #############");
                        Console.WriteLine("Digite 5 animais de estimação");


                        break;

                    // SAIR
                    case 6:
                        validacao = false;
                        break;

                     //qualquer outra resposta fora das que foram apresentadadas
                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;

                }

                Console.WriteLine("Pressione Enter para reinciar");
                Console.ReadLine();
                Console.Clear();

            } while (validacao);

        }

        //calcula imc
        public double Imc(double peso, double altura)
        {
            return (peso / (altura * altura)) ;
        }

        //calcula salario
        public double CalculaSalario(double salario, double salariominimo)
        {

            return salario / salariominimo;

        }

        //calcula volume
        public double CalculaVolume(double raio)
        {

            return (4 *  3.14 * (raio * raio* raio))/3;

        }

        //calcula media das 3 notas
        public double Media(double n1, double n2, double n3)
        {

            return (n1 + n2 + n3) / 3;

        }

        //calcula media final com nota da prova de recuperação
        public double MediaRec(double media)
        {
            double n4;
            double rec;
           
            Console.WriteLine("Digite sua nota da prova de recuperação: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            rec = (n4 + media) / 2;
            rec = Math.Round(rec, 2);
            if (rec >= 5){

                Console.WriteLine("Sua nota final é {0}!!", rec);
                Console.WriteLine("Você foi APROVADO na segunda chamada!!");
                return 0;
            }
            else
            {
                Console.WriteLine("Sua nota final é {0}!!", rec);
                Console.WriteLine("Você foi REPROVADO! Estude mais na próxima vez!");
                return 0;
            }

        }

        //

       
    }
}
