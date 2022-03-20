using System;
using Lista_con_Interface_Y_Generics.arrayList;
using Lista_con_Interface_Y_Generics.linkedlist;

namespace Lista_con_Interface_Y_Generics
{
    class program
    {
        static void Main(string[] args)
        {
            List<string> team1 = new linkedlist.LinkedList<string>();
            List<string> team2 = new linkedlist.LinkedList<string>();
            List<string> team3 = new linkedlist.LinkedList<string>();

            Console.WriteLine("Ejecuccion con Listas de tipo LinkedList");
            probarList(team1, team2, team3);

            Console.WriteLine();

            team1 = new arrayList.ArrayList<string>();
            team2 = new arrayList.ArrayList<string>();
            team3 = new arrayList.ArrayList<string>();

            Console.WriteLine("Ejecuccion con Listas de tipo ArrayList");
            probarList(team1, team2, team3);
        }

        public static void probarList(List<string> team1, List<string> team2, List<string> team3)
        {
            team1.addAtTail("Jesus");
            team1.addAtTail("Salomon");
            team1.addAtTail("Yael");

            team2.addAtFront("Cristian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");

            team3.addAtFront("Imelda");

            Iterator<string> iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            Console.WriteLine();

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team1.remove(0);
            team1.addAtFront("Rebeca");
            Console.WriteLine();
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team2.remove(2);
            team2.addAtTail("Rita");
            Console.WriteLine();
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes");
            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team3.remove(0);
            team3.remove(0);
            team3.addAtTail("Tadeo");
            team3.addAtFront("Isai");
            Console.WriteLine();
            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes");

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            if (team1.getAt(1).Equals("Salomon"))
            {
                team1.setAt(1, "Luis");
            }

            Console.WriteLine();
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }
        }
    }
}