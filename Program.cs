using System;
using System.Collections.Generic;
class Program
{

    static void Main (string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Anna");
        list.Add("James");
        list.Add("Bruno");
        list.Insert(2, "Marco"); //adiciona o elemento na posição 2, empurrando o que estava no 2 para baxo

        foreach(string obj in list) // obj recebe a list que nomes
        {
            Console.WriteLine( obj);
        }
         Console.WriteLine("Size of List : " + list.Count); // conta quantos elementos existe na lista começando do 1
         // Podemos passar uma expressao LAMBDA, função que faz a logica para achar o que você quer.
       
        string s1 = list.Find(x => x[0] == 'A');// encontra o 1° A
         Console.WriteLine("First 'A': " + s1);
       
        string s2 = list.FindLast(x => x[0] == 'A');// encontra o ultimo A
         Console.WriteLine("Last 'A': " + s2);

        int post1 = list.FindIndex(x => x[0] == 'A');// pega a 1º posição de quem começa com A
            Console.WriteLine("First position 'A': " + post1);

        int post2 = list.FindLastIndex(x => x[0] == 'A');// pega a 1º posição de quem começa com A
            Console.WriteLine("Last position 'A': " + post2);

        //cria uma nova lista para guardar o resultado do filtro
        List<string> list2 = list.FindAll(x =>  x.Length == 5); // encontra todo mundo cujo o tamanho do nome seja 5
            Console.WriteLine("-----------------------------");

        foreach(string obj2  in list2)
        {
            Console.WriteLine(obj2);

        }
        Console.WriteLine("-----------------------------");
        
        list.Remove("Alex");
        foreach(string obj3 in list)
        {
            Console.WriteLine(obj3);

        }
        Console.WriteLine("-----------------------------");
        list.RemoveAll(x => x[0] == 'M');
        {
            foreach( string obj4 in list)
            {
                Console.WriteLine(obj4);
            }
        }

        Console.WriteLine("-----------------------------");

        list.RemoveAt(2); // remove o elemento pela posição.
        foreach (string obj5 in list)
        {
            Console.WriteLine(obj5);

        }

    }



}
