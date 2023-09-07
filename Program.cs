using Microsoft.VisualBasic;
using System.Dynamic;
using System.Xml.Linq;

namespace WillProject;


public class Program
{
    static void Main(string[] args)
    {
        string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
        string filePath = projectFolder + Path.DirectorySeparatorChar + "videogames.csv";

        List<VideoGame> game = new List<VideoGame>();


        using (var s = new StreamReader(filePath))
        {
            while (!s.EndOfStream)
            {
                string? line = s.ReadLine();

                string[] lineElements = line.Split(',');

                VideoGame v = new VideoGame()
                {
                    Name = lineElements[0].Trim(),
                    Platform = lineElements[1].Trim(),
                    Year = lineElements[2].Trim(),
                    Genre = lineElements[3].Trim(),
                    Publisher = lineElements[4].Trim(),
                    NASales = lineElements[5].Trim(),
                    EUSales = lineElements[6].Trim(),
                    JPSales = lineElements[7].Trim(),
                    OtherSales = lineElements[8].Trim(),
                    GlobalSales = lineElements[9].Trim(),
                };

                game.Add(v);
            }
        }
        game.Sort();
        /* foreach (var v in game)
         {
             Console.WriteLine(v);
             Console.WriteLine("-----------------");
         }
        */
        var finder = game.Where(v => v.Publisher == "Ubisoft");

        foreach (var v in finder)
        {
            Console.WriteLine(v);
            Console.WriteLine("-----------------");
        }

        double ubiGames = finder.Count();
        double perc = ubiGames / game.Count() * 100;

       /* Console.WriteLine($"Out of {game.Count} there are {ubiGames} games.");
        Console.WriteLine($"This means that this makes up {perc: 0.##}% of the list");
       */
        var genrer = game.Where(v => v.Genre == "Action");
       
        foreach (var v in genrer)
        {
            Console.WriteLine(v);
            Console.WriteLine("-----------------");
        }
        double genreList = genrer.Count();
        double genrePerc = genreList / game.Count() * 100;

        Console.WriteLine($"Out of {game.Count} there are {genreList} games of this genre.");
        Console.WriteLine($"This means that this makes up{genrePerc: 0.##}% of the list");

        Console.WriteLine("What is the genre you would like?");
        string genree = Console.ReadLine();
        Data(game, genree);

        Console.WriteLine("What is the publisher you would like to select?");
        string pubb = Console.ReadLine();
        Pub(game, pubb);
    }

    static void Data(List<VideoGame> game, string type)
    {
        var total = game.Count();
        var type2 = new List<VideoGame>();
        var genrers = game.Where(v => v.Genre == type);

        /*foreach (var g in genrers)
        {
            if (g.Genre == type)
            {
                type2.Add(g);
            }
        }*/
            double numGenre = genrers.Count();

            var pct = numGenre / total * 100;
           
        
            Console.WriteLine($"There are {numGenre} {type} type games out of {total} total games which is {pct : 0.##}%.");
        
    }

    static void Pub(List<VideoGame> game, string type)
    {
        var total = game.Count();
        var type2 = new List<VideoGame>();
        var pubs = game.Where(v => v.Publisher == type);

        
        double numPub = pubs.Count();

        var pct = numPub / total * 100;


        Console.WriteLine($"There are {numPub} {type} type games out of {total} total games which is {pct:0.##}%.");

    }
}

    








