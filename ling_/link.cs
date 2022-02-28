using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите следующие запросы, используя язык LINQ:
//Покажите все фильмы в алфавитном порядке.
//Покажите все фильмы, отсортированные по убыванию кассовых сборов.
//Покажите фильмы только жанра «Ужастик».
//Покажите жанры всех фильмов в алфавитном порядке.
namespace ling_
{

    class link // отвечает за главный цикл 
    {
        public link()
        {
           
            Films[] film = 
            { 
               new Films("sad",43,"horror movie"),   /*не мое придумывать название фильмов*/
                    new Films("aa",23,"das"),
                    new Films("as",24,"qwe")
            };

            IEnumerable<Films> nana = film.OrderByDescending(s => s.Box_office);   // использовал метод расширения
            IEnumerable<Films> nanaa = film.OrderBy(s => s.Name);

            IEnumerable<string> nanaaa = from s in film                                   // по простому через обычный запрос
                                         where s.Horror_movie == "horror movie"
                                         select s.Horror_movie;

            IEnumerable<Films> nanaa1 = film.OrderBy(s => s.Horror_movie);




            foreach (var s in nana)
            {
                Console.WriteLine("По убыванию кассовых сборов");
                Console.WriteLine(s.ToString());
            }
            foreach (var s in nanaa)
            {
                Console.WriteLine("По алфавиту");
                Console.WriteLine(s.ToString());
            }
            foreach (var s in nanaaa)
            {
                    Console.WriteLine("По жанру");
                    Console.WriteLine(s.ToString());               
            }
            foreach (var s in nanaa1)
            {
                Console.WriteLine("По алфавит жанров");
                Console.WriteLine(s.ToString());
            }
        }

    }
}
