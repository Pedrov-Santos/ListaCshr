using System;
using System.Collections;
using System.Collections.Generic;

namespace ListaPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("João", 15);
            Pessoa p2 = new Pessoa("Leandro", 21);
            Pessoa p3 = new Pessoa("Paulo", 17);
            Pessoa p4 = new Pessoa("Jessica", 18);

            List <Pessoa> LTP = new List<Pessoa>();

            LTP.Add(p1);
            LTP.Add(p2);
            LTP.Add(p3);
            LTP.Add(p4);

            int aux = 0;
            string saux= " ";

            for (int i=0; i < LTP.Count; i++)
            {
                if (LTP[i].idade > aux)
                {
                    aux = LTP[i].idade;
                    saux = LTP[i].nome;
                }
            }
            Console.WriteLine("Pessoas mais velha: " + saux + ", Idade: " + aux +" Anos");

            Console.WriteLine("\nLista atual. ");

            foreach (Pessoa elemt in LTP)
            {
                Console.WriteLine("Nome: " + elemt.nome + " Idade: " + elemt.idade);
            }

            for (int i = 0; i <LTP.Count; i++)
            {
                if(LTP[i].idade < 18)
                {
                    LTP.RemoveAt(i);
                }
            }

            Console.WriteLine("\nLista apos remoçao dos menores de 18 anos de idade. "); 

            foreach (Pessoa elemt in LTP)
            {
                Console.WriteLine("Nome: " +elemt.nome+ " Idade: " + elemt.idade);
            }
            foreach (Pessoa elemt in LTP)
            {
                if(elemt.nome == "Jessica")
                {
                    Console.WriteLine("\nJessica está na lista sua idade é: " + elemt.idade);
                }
            }
        }

    }
}
