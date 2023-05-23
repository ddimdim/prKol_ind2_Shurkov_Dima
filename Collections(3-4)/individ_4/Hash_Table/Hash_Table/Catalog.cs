using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class Catalog
    {
        static Hashtable katalog = new Hashtable();
        public void Add_Disk()
        {

            Console.WriteLine("Введите название диска");
            string disk = Console.ReadLine();

            katalog.Add(disk, new ArrayList());
            Console.WriteLine("Диск добавлен в каталог");

        }

        public void Remove_Disk()
        {
            Console.WriteLine("Введите название диска, который хотите удалить");
            string disk = Console.ReadLine();
            if (katalog.ContainsKey(disk))
            {
                katalog.Remove(disk);
                Console.WriteLine("Диск удален из каталога");
            }
            else
            {
                Console.WriteLine("Диск не найден в каталоге ");
            }
        }

        public void Add_Song()
        {
            Console.WriteLine("Введите название диска");
            string disk = Console.ReadLine();
            if (katalog.ContainsKey(disk))
            {
                Console.WriteLine("Введите название песни");
                string song = Console.ReadLine();
                Console.WriteLine("Введите исполнителя");
                string artist = Console.ReadLine();
                string info = $"{song} - {artist}";
                ArrayList songs = (ArrayList)katalog[disk];
                songs.Add(info);
                Console.WriteLine("Песня добавлена на диск");
            }
            else
            {
                Console.WriteLine("Диск не найден в каталоге");
            }
        }
        public void Remove_Song()
        {
            Console.WriteLine("Введите название диска");
            string disk = Console.ReadLine();
            if (katalog.ContainsKey(disk))
            {
                Console.WriteLine("Введите название песни и исполнителя через запятую");
                string song = Console.ReadLine();
                ArrayList songs = (ArrayList)katalog[disk];
                if (songs.Contains(song))
                {
                    songs.Remove(song);
                    Console.WriteLine("Песня удалена с диска");
                }
                else
                {
                    Console.WriteLine("Песня не найдена на диске");
                }
            }
            else
                Console.WriteLine("Диск не найден в каталог");
        }
        public void Print()
        {
            Console.WriteLine("Содержиммое каталога");
            foreach (string disk in katalog.Keys)
            {
                Console.WriteLine($"Диск: {disk}");
                ArrayList songs = (ArrayList)katalog[disk];
                Console.WriteLine("Песни");
                foreach (string song in songs)
                {
                    Console.WriteLine(song);
                }
            }

        }
        public void Search()
        {
            Console.WriteLine("Введите исполнителя");
            string artist = Console.ReadLine();

            Console.WriteLine("Возможно вы искали это");
            foreach (string disk in katalog.Keys)
            {
                ArrayList songs = (ArrayList)katalog[disk];

                foreach (string song in songs)
                {
                    if (song.Contains(artist))
                    {
                        Console.WriteLine($"{song} - {disk}");
                    }
                }
            }
        }

    }
}
