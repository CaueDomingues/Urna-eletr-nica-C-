using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Trabalho_Urna_Cauê_e_Pablo_Furtado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dlecaração das variaveis utilizadas 
            int voto1 = 0, voto2 = 0, voto3 = 0, voto4 = 0, voto5 = 0, voto6 = 0, voto7 = 0;
            int votosFinal = 0;
            int escolhaCand;
            double porcent1, porcent2, porcent3, porcent4, porcent5, porcent6, porcent7;


            //Inicio do laço de repetição
            do
            {
                //Apresentação da urna
                Console.WriteLine("Urna eletrônica para eleição do melhor lavador de carros da cidade de Americana.");
                Console.WriteLine("Nessa urna você escolhe seu candidato de acordo com o número do mesmo.\nPara encerrar a excução do programa da eleição digite 0 (zero).");

                //Conversão da tecla digitada para o valor da escolha do candidato
                Console.WriteLine("\nEscolha o seu candidato");
                Console.WriteLine("\n1-Claudio\n\n2-Cleber\n\n3-Cezar\n\n4-Celso\n\n5-Celto\n\n6-Cido\n\nPresione alguma tecla numérica para votar nulo (diferente de 0 a 6)");
                escolhaCand = Convert.ToInt32(Console.ReadLine());


                
                //Inicio do laço de acumulador

                switch (escolhaCand)
                {

                    case 0:
                        Console.WriteLine("\nVotação finalizada");
                        break;


                
                    case 1://Candidato 1

                        Console.Clear();
                        Console.WriteLine("Candidato Claudio");
                        Console.WriteLine("Digite ENTER para continuar");
                        voto1++;
                        votosFinal++;
                        Console.ReadLine();


                        break;

                    case 2://Candidato 2

                        Console.Clear();
                        Console.WriteLine("Candidato Cleber");
                        Console.WriteLine("Digite ENTER para continuar");
                        voto2++;
                        votosFinal++;
                        Console.ReadLine();


                        break;

                    case 3://Candidato 3

                        Console.Clear();
                        Console.WriteLine("Candidato Cezar");
                        Console.WriteLine("Digite ENTER para continuar");
                        voto3++;
                        votosFinal++;
                        Console.ReadLine();


                        break;

                    case 4://Candidato 4

                        Console.Clear();
                        Console.WriteLine("Candidato Celso");
                        Console.WriteLine("Digite ENTER para continuar");
                        voto4++;
                        votosFinal++;
                        Console.ReadLine();


                        break;

                    case 5://Candidato 5

                        Console.Clear();
                        Console.WriteLine("Candidato Celto");
                        Console.WriteLine("Digite ENTER para continuar");
                        voto5++;
                        votosFinal++;
                        Console.ReadLine();


                        break;

                    case 6://Candidato 6

                        Console.Clear();
                        Console.WriteLine("Candidato Cido");
                        Console.WriteLine("Digite ENTER para continuar");
                        voto6++;
                        votosFinal++;
                        Console.ReadLine();


                        break;




                    default://Acumulador dos votos nulos com base no default 
                        Console.Clear();
                        Console.WriteLine("Voto nulo registrado");
                        voto7++;
                        votosFinal++;
                        Console.ReadLine();
                        break;





                }







                //Fim do laço de repetição
            } while (escolhaCand != 0);



            //Inicio dos resultados
            Console.Clear();
            Console.WriteLine("\n          Resultados");


            //Quantidade total de votos
            Console.WriteLine($"\nA quantidade total de votos é {votosFinal}");



            //Quantidade individual
            Console.WriteLine("\nQuantidade individual de votos:");



            //Exibição dos votos em numeros inteiros e porcentagem
            porcent1 = 100 / votosFinal * voto1;
            Console.WriteLine($"\nClaudio teve {voto1} votos ({porcent1}%)");

            porcent2 = 100 / votosFinal * voto2;
            Console.WriteLine($"Cleber teve {voto2} votos ({porcent2}%)");

            porcent3 = 100 / votosFinal * voto3;
            Console.WriteLine($"Cezar teve {voto3} votos ({porcent3}%)");

            porcent4 = 100 / votosFinal * voto4;
            Console.WriteLine($"Celso teve {voto4} votos ({porcent4}%)");

            porcent5 = 100 / votosFinal * voto5;
            Console.WriteLine($"Celto teve {voto5} votos ({porcent5}%)");

            porcent6 = 100 / votosFinal * voto6;
            Console.WriteLine($"Cido teve {voto6} votos ({porcent6}%)");

            porcent7 = 100 / votosFinal * voto7;
            Console.WriteLine($"Tivemos {voto7} votos nulos ({porcent7}%)");




            //Estrutura de decição do vencedor, demonstrando a porcentagem do mesmo 
            if (voto1 > voto2 && voto1 > voto3 && voto1 > voto4 && voto1 > voto5 && voto1 > voto6 && voto1 > voto7)
            {
                Console.WriteLine($"\nClaudio venceu a eleição com {porcent1}% dos votos");
            }
            else if (voto2 > voto1 && voto2 > voto3 && voto2 > voto4 && voto2 > voto5 && voto2 > voto6 && voto2 > voto7)
            {
                Console.WriteLine($"\nCleber venceu a eleição com {porcent2}% dos votos");
            }
            else if (voto3 > voto2 && voto3 > voto4 && voto3 > voto5 && voto3 > voto6 && voto3 > voto7 && voto3 > voto1)
            {
                Console.WriteLine($"\nCezar venceu a eleição com {porcent3}% dos votos");
            }
            else if (voto4 > voto3 && voto4 > voto5 && voto4 > voto6 && voto4 > voto7 && voto4 > voto1 && voto4 > voto2)
            {
                Console.WriteLine($"\nCelso venceu a eleição com {porcent4}% dos votos");
            }
            else if (voto5 > voto4 && voto5 > voto6 && voto5 > voto7 && voto5 > voto1 && voto5 > voto2 && voto5 > voto3)
            {
                Console.WriteLine($"\nCelto venceu a eleição com {porcent5}% dos votos");
            }
            else if (voto6 > voto5 && voto6 > voto7 && voto6 > voto1 && voto6 > voto2 && voto6 > voto3 && voto6 > voto4)
            {
                Console.WriteLine($"\nCido venceu a eleição com {porcent6}% dos votos");
            }
            else if (voto7 > voto6 && voto7 > voto1 && voto7 > voto2 && voto7 > voto3 && voto7 > voto4 && voto7 > voto5)
            {
                Console.WriteLine($"\nVotos nulos venceram, sera necessário uma nova eleição");
            }
            else//Estrutura para verificar se houvem empate
            {
                Console.WriteLine("\nHouve empate, sera necessário uma nova eleição");
            }







            Console.Read();


        }
    }
}

