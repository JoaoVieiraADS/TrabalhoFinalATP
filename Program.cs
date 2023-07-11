using System.Net.Sockets;
using System.Reflection;

namespace Trabalho_final_ATP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            object[,] voos = new object[3,103] ; //matriz de 3 colunas e 103 linhas (Essa matriz e usada para cadastros de voos e passageiros)//
            double  passageirosCadastrados = 0,passageirosCadastrados2 = 0, passageirosCadastrados3 = 0, quantidadedeassentos1 = 0, quantidadedeassentos2 = 0, quantidadedeassentos3= 0;
            

            while (true)//Loop principal para continuação da exibição do menu principal//   
            {
                Console.WriteLine("----------VENDAS DE PASSAGENS AÉREAS----------");
                Console.WriteLine("Opção 1 : Cadastrar voos");
                Console.WriteLine("Opção 2 : Cadastrar passageiros");
                Console.WriteLine("Opção 3 : Ver voos");
                Console.WriteLine("Opção 4 : Ver passageiros");
                Console.WriteLine("Opção 5 : Alterar um passageiro");
                Console.WriteLine("Opção 6 : Excluir passageiro");
                Console.WriteLine("Opção 7 : Alterar voo");
                Console.WriteLine("Opção 8 : Excluir voo");
                Console.WriteLine("Digite 0 para sair");

                int opcoes = int.Parse(Console.ReadLine()); 

                // Finalizar programa caso o usuário digite zero //
                if ( opcoes == 0 ) { Console.WriteLine("Volte sempre (;"); break; }

                // Cadastro de voos ( Opção 1 do menu principal//
                if (opcoes == 1 ) 
                {
                    for (int i = 0; i < 3; ) // Loop para percorrer a matriz e guardar os dados dos voos na 3 primeiras colunas ( deixando as demais colunas para os passageiros)// 
                    {
                        int j = 0; 
                        
                            Console.WriteLine("----------Cadastro de voos----------");
                            Console.WriteLine();
                            Console.WriteLine("Digite o código do vôo");
                            voos[i, j] = Console.ReadLine();
                            j++;
                            Console.WriteLine("Digite a distância a ser percorrida em KM");
                            voos[i, j] = double.Parse(Console.ReadLine()); 
                            j++;
                            Console.WriteLine("Digite a quantidade de assentos no vôo ( máximo 50)");
                            voos[i, j] = double.Parse(Console.ReadLine());
                            
                            j--; 
                            j--; 
                            i++;
                           
                            if ( i == 3 ) { Console.WriteLine("Limite de cadastro atingido"); break; } 
                                              
                                                                           
                    }
                   
                }


                // Cadastro de passageiros ( Opção 2 do menu principal)//
                else if (opcoes == 2) 
                {

                    Console.WriteLine("---------------Cadastro de passageiros---------------");
                    Console.WriteLine();
                    Console.WriteLine("Digite o código do voo");
                    object codigoDoVoo = Console.ReadLine();

                    bool vooEncontrado = false; // variável com valor boleano usada para executar uma mensagem caso o código de voo digitado pelo usuário não seja encontrado//
                    
                        int j = 0;
                        
                        if (codigoDoVoo.Equals (voos[0, j])) // Compara o codigo digitado pelo usuário com o primeiro código de voo cadastrado//
                        { 
                            vooEncontrado = true;  // da o valor de true para que nao exiba a mensagem de voo não encontrado//
                            quantidadedeassentos1 = (double)voos[0, j + 2]; // A variável quanridadedeassentos recebe o valor de assentos disponiveis cadastrados no voo//
                                                    
                           for(j = 3; j < 103;)// loop para armazenar os dados dos passageiros no primeiro voo cadastrado ( observe que nao muda a linha somente coluna) //
                           { 
                                if (passageirosCadastrados >= quantidadedeassentos1) // interrompe o cadastro de passageiros quando a quantidade de assentos disponiveis e == a passageiroscadastrados //
                                {
                                Console.WriteLine("limite de cadastros do voo atingido");  break;
                                }
                                Console.WriteLine("Digite o nome do passageiro");
                                voos[0, j] = Console.ReadLine();
                                j++;
                                Console.WriteLine("Digite o código do passageiro");
                                voos[0, j] = Console.ReadLine();
                                passageirosCadastrados++;// Usada para armazenar a quantidade de passageiros cadastrados do primeiro voo
                            int terminoCadastroPassageiros = 0;
                                Console.WriteLine("Digite 1 para continuar e 2 para finalizar"); // Caso o usuário não queira cadastrar todos espaços que o voo possui ele digita 2 e executa a condição abaixo finalizando o programa//
                                terminoCadastroPassageiros = int.Parse(Console.ReadLine());
                                if (terminoCadastroPassageiros == 2) { Console.WriteLine("Cadastro de passageiros realizado com sucesso");  break; } 
                                j++;
                                
                           }

                        }
                                               

                        else if (codigoDoVoo.Equals(voos[1 , j])) // Compara o codigo digitado pelo usuário com o segundo código de voo cadastrado // 
                    { 
                            vooEncontrado = true;  
                            quantidadedeassentos2 = (double)voos[1, j + 2];

                            for (j = 3; j < 103;)
                            { 
                                if (passageirosCadastrados2 >= quantidadedeassentos2) 
                                {
                                    Console.WriteLine("limite de cadastros do voo atingido");   break; 
                                }
                                Console.WriteLine("Digite o nome do passageiro");
                                voos[1, j] = Console.ReadLine(); 
                                j++;
                                Console.WriteLine("Digite o código do passageiro");
                                voos[1, j] = Console.ReadLine();
                                passageirosCadastrados2++;// Usada para armazenar a quantidade de passageiros cadastrados do segundo voo
                            int terminoCadastroPassageiros = 0;
                                Console.WriteLine("Digite 1 para continuar e 2 para finalizar");
                                terminoCadastroPassageiros = int.Parse(Console.ReadLine());
                                if (terminoCadastroPassageiros == 2) { Console.WriteLine("Cadastro de passageiros realizado com sucesso");  break; }
                                j++;
                            }
                            
                        }

                        else if (codigoDoVoo.Equals(voos[2 , j])) // Compara o codigo digitado pelo usuário com o terceiro código de voo cadastrado//
                        {
                            vooEncontrado = true;  
                            quantidadedeassentos3 = (double)voos[2, j + 2]; 

                            for (j = 3; j < 103;) 
                            { 
                                if (passageirosCadastrados3 >= quantidadedeassentos3) 
                                {
                                    Console.WriteLine("limite de cadastros do voo atingido"); break; 
                                }
                                Console.WriteLine("Digite o nome do passageiro");
                                voos[2, j] = Console.ReadLine(); 
                                j++;
                                Console.WriteLine("Digite o código do passageiro");
                                voos[2, j] = Console.ReadLine();
                                passageirosCadastrados3++; // Usada para armazenar a quantidade de passageiros cadastrados do terceiro voo
                                int terminoCadastroPassageiros = 0;
                                Console.WriteLine("Digite 1 para continuar e 2 para finalizar");
                                terminoCadastroPassageiros = int.Parse(Console.ReadLine());
                                if(terminoCadastroPassageiros == 2) { Console.WriteLine("Cadastro de passageiros realizado com sucesso");  break; }
                                j++;
                            }

                        }

                    
                    if (!vooEncontrado) { Console.WriteLine("Voo não encontrado"); }
                                                                
                }

                // Opcão para navegar e ver os dados de cada voo ou de todos ... ( Opção 3 do menu principal )//
                else if(opcoes == 3)
                {
                    while (true) // Loop para a exibição continua do menu de sub-opções 
                    {
                        Console.WriteLine("----------Escolha uma sub-opção----------");
                        Console.WriteLine("Sub-opção 1 : Ver todos os voos");
                        Console.WriteLine("Sub-opção 2 : Ver voo com mais passageiros");
                        Console.WriteLine("Sub-opção 3 : Ver voo com menos passageiros");
                        Console.WriteLine("Sub-opção 4 : Ver voo de maior distância");
                        Console.WriteLine("Sub-opção 5 : Ver voo com menor distância");
                        Console.WriteLine("Sub-opção 6 : Ver média de ocupação dos voos");
                        Console.WriteLine("Digite 0 para finalizar");

                        int subOpcoes = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        // Ver todos os voos //
                        if(subOpcoes == 1) //Mostra todos os voos e os passageiros cadastrado neles //
                        {
                            for (int i = 0; i < 1; i++) // Loop para dados dos voos e passageiros cadastrado no primeiro voo
                            {
                                Console.WriteLine();
                                Console.WriteLine("*****Voo 1*****");
                                Console.WriteLine();
                                Console.WriteLine("Código do voo : " + voos[i, 0]);
                                
                                Console.WriteLine("Distância percorrida : " + voos[i, 1] + " km");
                                
                                Console.WriteLine("Quantidade de assentos do voo : " + voos[i, 2]);
                                
                                for (int j = 3; j < 103; j++)
                                {
                                    if (voos[i, j] != null)
                                    {
                                        
                                        Console.WriteLine();
                                        Console.WriteLine("Passageiros cadastrados no voo");
                                        Console.WriteLine("Nome do passageiro : " + voos[i, j]);
                                        j++;
                                        Console.WriteLine("Código do passageiro : " + voos[i, j]);


                                    }
                                }
                            }

                            for (int i = 1; i < 2; i++) // Loop para dados dos voos e passageiros cadastrado no primeiro voo
                            {
                                Console.WriteLine();
                                Console.WriteLine("*****Voo 2*****");
                                Console.WriteLine();
                                Console.WriteLine("Código do voo : " + voos[i, 0]);

                                Console.WriteLine("Distância percorrida : " + voos[i, 1] + " km");

                                Console.WriteLine("Quantidade de assentos do voo : " + voos[i, 2]);

                                for (int j = 3; j < 103; j++)
                                {
                                    if (voos[i, j] != null)
                                    {

                                        Console.WriteLine();
                                        Console.WriteLine("Passageiros cadastrados no voo");
                                        Console.WriteLine("Nome do passageiro : " + voos[i, j]);
                                        j++;
                                        Console.WriteLine("Código do passageiro : " + voos[i, j]);


                                    }
                                }
                            }

                            for (int i = 2; i < 3; i++) // Loop para dados dos voos e passageiros cadastrado no primeiro voo
                            {
                                Console.WriteLine();
                                Console.WriteLine("*****Voo 3*****");
                                Console.WriteLine();
                                Console.WriteLine("Código do voo : " + voos[i, 0]);

                                Console.WriteLine("Distância percorrida : " + voos[i, 1] + " km");

                                Console.WriteLine("Quantidade de assentos do voo : " + voos[i, 2]);

                                for (int j = 3; j < 103; j++)
                                {
                                    if (voos[i, j] != null)
                                    {

                                        Console.WriteLine();
                                        Console.WriteLine("Passageiros cadastrados no voo");
                                        Console.WriteLine("Nome do passageiro : " + voos[i, j]);
                                        j++;
                                        Console.WriteLine("Código do passageiro : " + voos[i, j]);


                                    }
                                }
                            }

                        }

                        //Voo com mais passageiro//
                        else if(subOpcoes == 2) 
                        {
                           // Usa a variavel de controle de passageiros para comparar qual tem o valor maior e descobri qual voo tem mais passageiro//  
                           if(passageirosCadastrados > passageirosCadastrados2 && passageirosCadastrados > passageirosCadastrados3)
                           {
                                Console.WriteLine("O voo com mais passageiros é : Voo 1 : Quantidade de passageiros : " + passageirosCadastrados );

                           }

                           else if (passageirosCadastrados2 > passageirosCadastrados && passageirosCadastrados2 > passageirosCadastrados3)
                           {

                                Console.WriteLine("O voo com mais passageiros é : Voo 2 : Quantidade de passageiros : " + passageirosCadastrados2);

                           }

                           else { Console.WriteLine("O voo com mais passageiros é : Voo 3 : Quantidade de passageiros : " + passageirosCadastrados3); }

                        }

                        //Voo comenos passageiros //
                        else if (subOpcoes == 3)
                        {
                            // Compara a variavel de controle de passageiros para comparar qual tem o valor menos e descobri qual voo tem mais passageiro//
                            if (passageirosCadastrados < passageirosCadastrados2 && passageirosCadastrados < passageirosCadastrados3)
                            {
                                Console.WriteLine("O voo com menos passageiros é : Voo 1 : Quantidade de passageiros : " + passageirosCadastrados);

                            }

                            else if (passageirosCadastrados2 < passageirosCadastrados && passageirosCadastrados2 < passageirosCadastrados3)
                            {

                                Console.WriteLine("O voo com menos passageiros é : Voo 2 : Quantidade de passageiros : " + passageirosCadastrados2);

                            }

                            else { Console.WriteLine("O voo com menos passageiros é : Voo 3 : Quantidade de passageiros : " + passageirosCadastrados3); }

                        }

                        //Voo com maior distância //
                        else if (subOpcoes == 4)
                        {
                            double maiorDistancia = 0;
                            int j = 1;
                           
                            maiorDistancia = (double)voos[0, j]; // Pega a distância cadastrada no primeiro voo 
                            
                            for (int i = 0; i < 3; i++)
                            {
                                                             
                                if (maiorDistancia < (double)voos[i, j]) //Compara todas as distâncias cadastradas
                                {
                                    maiorDistancia = (double)voos[i, j]; //Percorre e armazena o valor maio na variavel maior distância
                                }

                            }
                            if ((double)voos[0,1] == maiorDistancia) //compara o valor da distancia do primeiro voo com o valor da variavel maiorDistancia, caso seja == executa a resposta //
                            {
                                Console.WriteLine("O voo com a maior distância a ser percorrida é : ***Voo1***  " );
                                Console.WriteLine("Distância percorrida pelo voo e de : " + maiorDistancia + " km");
                            }
                            else if ((double)voos[1,1] == maiorDistancia) //compara o valor da distancia do segundo voo com o valor da variavel maiorDistancia, caso seja == executa a resposta //
                            {
                                Console.WriteLine("O voo com a maior distância a ser percorrida é : ***Voo2***  ");
                                Console.WriteLine("Distância percorrida pelo voo e de : " + maiorDistancia + " km");
                            }
                            else //compara o valor da distancia do terceiro voo com o valor da variavel maiorDistancia, caso seja == executa a resposta //
                            {
                                Console.WriteLine("O voo com a maior distância a ser percorrida é : ***Voo3***  ");
                                Console.WriteLine("Distância percorrida pelo voo e de : " + maiorDistancia + " km");
                            }
                                                        
                        }

                        //Voo com menor distância //
                        else if(subOpcoes == 5)
                        {
                            //Ultiliza a mesma logica do voo de maior distancia so que agora pega o menos valor
                            double menorDistancia = 0;
                            int j = 1;
                            menorDistancia = (double)voos[0, j];

                            for (int i = 0; i < 3; i++)
                            {

                                if (menorDistancia > (double)voos[i, j])
                                {
                                    menorDistancia = (double)voos[i, j];

                                }

                            }
                            if ((double)voos[0, 1] == menorDistancia)
                            {
                                Console.WriteLine("O voo com a maior distância a ser percorrida é : ***Voo 1***  ");
                                Console.WriteLine("Distância percorrida pelo voo e de : " + menorDistancia + " km");
                            }
                            else if ((double)voos[1, 1] == menorDistancia)
                            {
                                Console.WriteLine("O voo com a maior distância a ser percorrida é : ***Voo 2***  ");
                                Console.WriteLine("Distância percorrida pelo voo e de : " + menorDistancia + " km");
                            }
                            else
                            {
                                Console.WriteLine("O voo com a maior distância a ser percorrida é : ***Voo 3***  ");
                                Console.WriteLine("Distância percorrida pelo voo e de : " + menorDistancia
                                    + " km");
                            }


                        }

                        // Média de ocupação dos voos //
                        else if(subOpcoes == 6)
                        {
                            
                            double mediaDeOcupacao1 = 0.0, mediaDeOcupacao2 = 0.0, mediaDeOcupacao3 = 0.0;
                           if(passageirosCadastrados != null) //Verifica se existe passageiros cadastrados no voo//
                           {
                                mediaDeOcupacao1 = (passageirosCadastrados / quantidadedeassentos1 * 100); //Pega a quantidade de assentos cadastrados no voo e passageiros cadastrado e faz o calculo da média de ocupação
                                Console.WriteLine("A média de ocupação do Voo 1 é de " + mediaDeOcupacao1 + " %");
                                Console.WriteLine();
                                Console.WriteLine(passageirosCadastrados + " " + quantidadedeassentos1);
                           }
                           
                           if(passageirosCadastrados2 != null) //Verifica se existe passageiros cadastrados no voo//
                           {
                                mediaDeOcupacao2 = (passageirosCadastrados2 / quantidadedeassentos2 * 100); //Pega a quantidade de assentos cadastrados no voo e passageiros cadastrado e faz o calculo da média de ocupação
                                Console.WriteLine("A média de ocupação do Voo 2 é de " + mediaDeOcupacao2 + " %");
                                Console.WriteLine();
                           }
                            
                           if (passageirosCadastrados3 != null)//Verifica se existe passageiros cadastrados no voo//
                           {
                                mediaDeOcupacao3 = ((passageirosCadastrados3 / quantidadedeassentos3) * 100); //Pega a quantidade de assentos cadastrados no voo e passageiros cadastrado e faz o calculo da média de ocupação
                                Console.WriteLine("A média de ocupação do Voo 3 é de " + mediaDeOcupacao3 + " %");
                           }
                                                                       
                                                     
                        }

                        else if (subOpcoes == 0) { Console.WriteLine("Volte sempre que precisar :)"); break; }

                    }

                }

                // Ver passageiros (Opção 4 do menu principal) //
                else if(opcoes == 4)
                {
                   
                    Console.WriteLine("----------Escolha uma sub-opção----------");
                    Console.WriteLine("Sub-opção 1 : Ver passageiro específico");
                    Console.WriteLine("Sub-opção 2 : Ver todos os passageiros de um voo");
                    Console.WriteLine("Digite 0 para finalizar");
                    
                    int subopcoes = int.Parse(Console.ReadLine());

                    if (subopcoes == 0) { Console.WriteLine("Volte sempre que precisar"); break; }

                    // Sub-opção para ver passageiro específico //
                    else if (subopcoes == 1) 
                    {
                        Console.WriteLine("Digite o código do passageiro");
                        object codigoPassageiro = Console.ReadLine(); // Recebe o código do passageiro fornecido pelo usuário

                        bool passageiroEncontrado = false; // Variavel com valor boleano para exibição de mensagem caso o passageiro não seja encontrado

                        for(int i = 0; i < 3; i++) //Loop para percorrer nas linhas os voos cadastrado em busca do codigo de passageiro informado  
                        {

                            for (int j = 4; j < 103; j += 2) //Loop para percorrer nas linhas os voos cadastrado em busca do codigo de passageiro informado( percorrer so as colunas de codigo nao de nome )//
                            {
                                if (codigoPassageiro.Equals(voos[i, j])) //Compara o codigo digitado com os codigos cadastrados de passageiros usa o metodo equals para comparação ja que se trata de um valor armazenado em um objeto
                                {
                                    Console.WriteLine(voos[i, j - 1]); //Exibe o nome do passageiro caso seja encontrado um passageiro cadastro com o codigo de busca
                                    passageiroEncontrado = true; 
                                    break;
                                }
                            }
                            if (passageiroEncontrado) { break; }
                        }
                       


                        if (!passageiroEncontrado)
                        {
                            Console.WriteLine("Passageiro não encontrado"); // Mensagem de passageiro nao encontrado caso nao exista um passageiro cadastrado com o codigo fornecido
                        }
                    }

                    //Ver todos passageiros de um voo //
                    else if (subopcoes == 2)
                    {
                        Console.WriteLine("Digite o código do voo");
                        object codigoDoVoo = Console.ReadLine();

                        bool vooEncontrado = false; // Variavel com valor boleano para exibição de mensagem caso o voo não seja encontrado



                        for (int i = 0; i < 3; i++) //Loop para percorrer nas linhas os voos cadastrado em busca do codigo de voo informado( percorrer so as colunas de codigo nao de nome )//
                        {
                            if (codigoDoVoo.Equals(voos[i, 0])) //Compara o codigo digitado com os codigos cadastrados de voo usa o metodo equals para comparação ja que se trata de um valor armazenado em um objeto
                            {
                                for (int j = 3; j < 103; j ++)
                                {
                                    if (voos[i, j] != null) // verifica se o valor nao é nulo, se for nao exibe na tela
                                    {
                                        Console.WriteLine(voos[i, j]);
                                    }
                                  
                                }

                                vooEncontrado = true;
                                break;
                            }
                        }

                        if (!vooEncontrado)
                        {
                            Console.WriteLine("Voo não encontrado."); // Mensagem de voo nao encontrado caso nao exista um voo cadastrado com o codigo fornecido
                        }
                    }

                }
                

                // Alterar passageiro (Opção 5 do menu principal)//
                else if (opcoes == 5)
                {
                    Console.WriteLine("---------------Alteração de passageiro---------------");
                    Console.WriteLine();
                    Console.WriteLine("Digite o código do voo");
                    object codigoDoVoo = Console.ReadLine();

                    bool vooEncontrado = false;

                    int j = 0;
                    for(int i = 0;i < 3;i++)
                    {

                        if (codigoDoVoo.Equals(voos[i, j])) //Compara o codigo digitado com os codigos cadastrados de voos usa o metodo equals para comparação ja que se trata de um valor armazenado em um objeto
                        {
                            vooEncontrado = true;

                            Console.WriteLine("Digite o código do passageiro a ser alterado");
                            object codigoPassageiro = Console.ReadLine();

                            for (j = 3; j < 103; j += 2)
                            {
                                if (codigoPassageiro.Equals(voos[i, j + 1])) //Compara o codigo digitado com os codigos cadastrados de passageiros usa o metodo equals para comparação ja que se trata de um valor armazenado em um objeto
                                {
                                    //Alterar o nome e codigo do passageiro escolhido
                                    Console.WriteLine("Digite o novo nome do passageiro");
                                    voos[i, j] = Console.ReadLine();
                                    Console.WriteLine("Digite o novo código do passageiro");
                                    voos[i, j + 1] = Console.ReadLine();
                                    Console.WriteLine("Alteração realizada com sucesso");
                                    break;
                                }
                            }
                        }
                                               
                    }
                                        

                    if (!vooEncontrado)
                    {
                        Console.WriteLine("Voo não encontrado"); break; // mesma logica das ...
                    }

                }

                //Excluir passageiro ( Opção 6 do menu principal ) //   
                else if (opcoes == 6)
                {

                    Console.WriteLine("---------------Exclusão de passageiro---------------");
                    Console.WriteLine();
                    Console.WriteLine("Digite o código do voo");
                    object codigoDoVoo = Console.ReadLine();

                    bool vooEncontrado = false;

                    


                    if (codigoDoVoo.Equals(voos[0, 0])) //Exclui passageiros do primeiro voo cadastrado, a logica de comparação de codigos é igual a anterior
                    {
                        vooEncontrado = true;

                        Console.WriteLine("Digite o código do passageiro que deseja excluir");
                        object codigoPassageiro = Console.ReadLine();

                        for (int j = 4; j < 103; j+=2)
                        {
                            if (codigoPassageiro.Equals(voos[0, j]))
                            {
                                                                                                 
                                voos[0, j] = voos[0, j + 2]; 
                                voos[0, j - 1] = voos[0,j + 1];
                                voos[0, j + 2] = null;
                                voos[0, j + 1] = null;

                                Console.WriteLine("Excluído com sucesso");
                                break;
                            }
                        }
                    }

                    if (codigoDoVoo.Equals(voos[1, 0])) // Exclui passageiros do segundo voo cadastrado, a logica de comparação de codigos é igual a anterior
                    {
                        vooEncontrado = true;

                        Console.WriteLine("Digite o código do passageiro que deseja excluir");
                        object codigoPassageiro = Console.ReadLine();

                        for (int j = 4; j < 103; j += 2)
                        {
                            if (codigoPassageiro.Equals(voos[0, j]))
                            {


                                voos[0, j] = voos[0, j + 2];
                                voos[0, j - 1] = voos[0, j + 1];
                                voos[0, j + 2] = null;
                                voos[0, j + 1] = null;

                                Console.WriteLine("Excluído com sucesso");
                                break;
                            }
                        }
                    }

                    if (codigoDoVoo.Equals(voos[2, 0])) // Exclui passageiros do terceiro voo cadastrado, a logica de comparação de codigos é igual a anterior
                    {
                        vooEncontrado = true;

                        Console.WriteLine("Digite o código do passageiro que deseja excluir");
                        object codigoPassageiro = Console.ReadLine();

                        for (int j = 4; j < 103; j += 2)
                        {
                            if (codigoPassageiro.Equals(voos[0, j]))
                            {


                                voos[0, j] = voos[0, j + 2];
                                voos[0, j - 1] = voos[0, j + 1];
                                voos[0, j + 2] = null;
                                voos[0, j + 1] = null;

                                Console.WriteLine("Excluído com sucesso");
                                break;
                            }
                        }
                    }


                    if (!vooEncontrado)
                    {
                        Console.WriteLine("Voo não encontrado"); break;
                    }

                }

                // Alterar voo ( Opção 7 do menu principal) //
                else if(opcoes == 7)
                {
                    Console.WriteLine("---------------Alteração de voo---------------");
                    Console.WriteLine();
                    Console.WriteLine("Digite o código do voo");
                    object codigoDoVoo = Console.ReadLine();

                    bool vooEncontrado = false;

                    int j = 0;
                    for (int i = 0; i < 3; i++)
                    {

                        if (codigoDoVoo.Equals(voos[i, j]))
                        {
                            vooEncontrado = true;



                           
                                
                                Console.WriteLine("Digite o novo código do voo");
                                voos[i, j ] = Console.ReadLine();
                                Console.WriteLine("Digite distância a ser percorrida pelo voo");
                                voos[i, j + 1 ] = Console.ReadLine();
                                Console.WriteLine("Digite distância a quantidade de assentos disponíveis");
                                voos[i, j + 2] = Console.ReadLine();
                                Console.WriteLine("Alteração realizada com sucesso");
                                break;
                                
                            
                        }

                    }



                    if (!vooEncontrado)
                    {
                        Console.WriteLine("Voo não encontrado"); 
                    }


                }

                // Exclusão de voo ( Opção 8 do menu principal) //
                else if(opcoes == 8)
                {

                    Console.WriteLine("---------------Exclusão de voo---------------");
                    Console.WriteLine();
                    Console.WriteLine("Digite o código do voo que deseja excluir:");
                    object codigoDoVoo = Console.ReadLine();

                    bool vooEncontrado = false;

                    for (int i = 0; i < 3; i++)
                    {
                        if (codigoDoVoo.Equals(voos[i, 0]))
                        {
                            vooEncontrado = true;

                            // Excluir o voo definindo todos os elementos da linha como null
                            for (int j = 0; j < 103; j++)
                            {
                                voos[i, j] = null;
                            }

                            Console.WriteLine("Voo excluído com sucesso");
                            break;
                        }
                    }

                    if (!vooEncontrado)
                    {
                        Console.WriteLine("Voo não encontrado");
                    }


                }


            }

            
        }
            
    }
    
}