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

                    case 5: //ANIMAIS DE ESTIMAÇÃO
                                                                                    
                        Console.WriteLine("############# - Animais de estimação - #############");
                       
                        //cadsatra animal 1
                        Animal animal1 = new Animal();

                        Console.WriteLine("Animal nº1");

                        Console.WriteLine("Nome: ");
                        animal1.nome = Console.ReadLine();

                        Console.WriteLine("Tipo: ");
                        animal1.tipo = Console.ReadLine();
                                                
                        animal1.validaTipo(animal1.tipo);

                        //cadastra animal 2                   
                        Animal animal2 = new Animal();
                        Console.WriteLine("Animal nº2");

                        Console.WriteLine("Nome: ");
                        animal2.nome = Console.ReadLine();

                        Console.WriteLine("Tipo: ");
                        animal2.tipo = Console.ReadLine();

                        animal2.validaTipo(animal2.tipo);

                       
                        //cadastra animal 3
                        Animal animal3 = new Animal();

                        Console.WriteLine("Animal nº3");

                        Console.WriteLine("Nome: ");
                        animal3.nome = Console.ReadLine();

                        Console.WriteLine("Tipo: ");
                        animal3.tipo = Console.ReadLine();

                        animal3.validaTipo(animal3.tipo);


                        //cadastra animal 4
                        Animal animal4 = new Animal();
                        Console.WriteLine("Animal nº4");

                        Console.WriteLine("Nome: ");
                        animal4.nome = Console.ReadLine();

                        Console.WriteLine("Tipo: ");
                        animal4.tipo = Console.ReadLine();
                        
                        animal4.validaTipo(animal4.tipo);

                        //cadastrar animal 5
                        Animal animal5 = new Animal();
                        Console.WriteLine("Animal nº5");

                        Console.WriteLine("Nome: ");
                        animal5.nome = Console.ReadLine();

                        Console.WriteLine("Tipo: ");
                        animal5.tipo = Console.ReadLine();

                        animal5.validaTipo(animal5.tipo);
                         
                       //exibe registros dos tipos cadastrados
                       Console.WriteLine("____________________________________________________________________________________________________\n");

                       Console.WriteLine("Tipos registrados: {0}, {1}, {2}, {3}, {4}. ", animal1.getTipo(), animal2.getTipo(), animal3.getTipo(), animal4.getTipo(), animal5.getTipo());
                       
                       Console.WriteLine("____________________________________________________________________________________________________\n");
                       
                        
                        // contagem de ocorrencias através de array
                        string[] array = new string[] { animal1.getTipo(), animal2.getTipo(), animal3.getTipo(), animal4.getTipo(), animal5.getTipo()};

                        int contagemcachorro = 0;
                        foreach (string cachorro in array)
                        {

                            if (cachorro == "cachorro") contagemcachorro++;

                        }

                        int contagemgato = 0;
                        foreach (string gato in array)
                        {

                            if (gato == "gato") contagemgato++;

                        }

                        int contagempeixe = 0;
                        foreach (string peixe in array)
                        {
                            if (peixe == "peixe") contagempeixe++;

                        }

                        Console.WriteLine("Quantidade de Cachorros {0}, Gatos {1} e Peixes {2}", contagemcachorro, contagemgato, contagempeixe);
                       
                        Console.WriteLine("____________________________________________________________________________________________________");
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
           
           double imc = (peso / (altura * altura)) ;

            if (imc < 20)
            {
                Console.WriteLine("Você está abaixo do peso!! Procure melhorar sua saúde");

            }
            else if (imc == 20 && imc <= 25)
            {
               
                Console.WriteLine("Peso está dentro do ideal!! Mantenha-se assim.");
                return imc;
            }
            {
                Console.WriteLine("Você está acima do peso!! Mantenha-se assim.");
                return imc;
            }

            
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

                
                Console.WriteLine("Você foi APROVADO na segunda chamada!!");
                Console.WriteLine("Sua nota final é:");
                return rec;
            }
            else
            {
                
                Console.WriteLine("Você foi REPROVADO! Estude mais na próxima vez!");
                Console.WriteLine("Sua nota final é:");
                return rec;
            }

        }

               
    }
}
