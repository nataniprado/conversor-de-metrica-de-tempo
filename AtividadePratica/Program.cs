//Atividade: Elaborar um Projeto Sobre Um Sistema de Conversão de Tempo;
//Problema: Conversão de uma métrica de tempo, para outra;
//Título: Sistema de Conversão do Tempo
//Autor: Natani Prado
//Data: 22/04/2022

//--------------------------------------- Declaração de Variaveis -------------------------------------------------//
const int OPCAO_SEGUNDO = 1;
const int OPCAO_MINUTO = 2;
const int OPCAO_HORA = 3;
const int OPCAO_DIA = 4;
const int OPCAO_MES = 5;

int metrica = 0;
int valor;
int metricaConversao;
int segundo;
int minuto;
int hora;
int dia;
int mes;
string resultado="";

//--------------------------------------- Entradas -------------------------------------------------//

Console.WriteLine("Segue as opções a ser escolhida: ");
Console.WriteLine("1-Segundo;");
Console.WriteLine("2-Minuto;");
Console.WriteLine("3-Hora;");
Console.WriteLine("4-Dia;");
Console.WriteLine("5-Mês;");

Console.Write("Digite a opção desejada: ");
metrica = int.Parse(Console.ReadLine());
if (metrica < 1 || metrica > 5)
{
    Console.WriteLine("Valor digitado inválido!");
    return; 
}

Console.WriteLine("Digite um valor a ser convertido: ");
valor = int.Parse(Console.ReadLine());
if (valor <1)
{
    Console.WriteLine("Número Inválido");
    return;
}

Console.WriteLine("Escolha qual a métrica que deseja que a conversão seja feita.");
Console.WriteLine("1-Segundo;");
Console.WriteLine("2-Minuto;");
Console.WriteLine("3-Hora;");
Console.WriteLine("4-Dia;");
Console.WriteLine("5-Mês;");
Console.Write("Digite a opção escolhida: ");
metricaConversao = int.Parse(Console.ReadLine());
if (metricaConversao < 1 || metricaConversao >= 6)
{
    Console.WriteLine("Número Inválido!");
    return;
}

//--------------------------------------- Processamento -------------------------------------------------//

if(metrica == OPCAO_MINUTO)
{
    valor = valor * 60;
} else if (metrica == OPCAO_HORA)
{
    valor = valor * 60 * 60;
} else if(metrica == OPCAO_DIA)
{
    valor = valor * 24 * 60 * 60; 
} else if (metrica== OPCAO_MES)
{
    valor= valor * 30 * 24 * 60 * 60;
}


if (metricaConversao == OPCAO_SEGUNDO)
{
    resultado = "Resultado: "+valor+" Segundo(s)";
}
else if (metricaConversao == OPCAO_MINUTO)
{
    segundo = valor % 60;
    minuto = valor / 60;
    string segundoString;
    if (segundo < 10)
    {
        segundoString = "0" + segundo;
    }
    else { 
        segundoString= segundo.ToString();
    }

    resultado = "Resultado: " + minuto + ":" + segundoString + " Minuto(s)";
}

if (metricaConversao == OPCAO_HORA)
{
    minuto = valor / 60;
    hora = minuto / 60;
    string minutoString;
    if(minuto % 60 == 0)
    {
        minutoString = "00";
    }
    else if (minuto < 10)
    {
        minutoString = "0" + minuto;
    }
    else
    {
        minutoString = minuto.ToString();
    }

    resultado = "Resultado: " + hora + ":" + minutoString + " Hora(s)";
}
if (metricaConversao == OPCAO_DIA)
{
    hora =( valor / 60 / 60) % 24;

    dia = valor / 60 / 60  / 24;

    string horastring;
    if (hora % 24 == 0)
    {
        horastring = "00";
    }
    else if (hora < 10)
    {
        horastring = "0" + hora;
    }
    else
    {
        horastring = hora.ToString();
    }
    resultado = "Resultado: " + dia + " dia(s) e " + horastring + " hora(s)";
}

if (metricaConversao== OPCAO_MES)
{
    dia = (valor / 60 / 60 / 24) % 30;
    mes = valor /60/60/ 24 / 30;

    resultado = "Resultado: " + mes + " mês e " + dia + " dia(s)";
}

//--------------------------------------- Resolução -------------------------------------------------//

Console.WriteLine(resultado);





