using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture08
{
    public class Processor : MyFirstInterface, IImporter
    {
        List<FileInfo> films = new List<FileInfo>();
        public List<FileInfo> ImportFile()
        {
            string pathoffile = "C:\\VS\\film.csv";
            string[] lines= File.ReadAllLines(pathoffile);
            FileInfo film = null;
            for(int i = 0; i < lines.Length; i++)
            {
                try
                {
                    film = new FileInfo();
                    string[] cols = lines[i].Split(';');
                    film.YearOfRelease = int.Parse(cols[0]);
                    film.LengthinMinutes = int.Parse(cols[1]);
                    film.Title = cols[2];
                    film.Subject = cols[3];
                    film.Actor = cols[4];
                    film.Actress = cols[5];
                    film.Director = cols[6];
                    film.Popularity = int.Parse(cols[7]);

                    if (cols[8] == "Yes")
                    {
                        film.AwardWon = true;
                    }
                    else
                    {
                        film.AwardWon = false;
                    }
                    films.Add(film);
                }
                catch(Exception e)
                {
                    string s = "Lets find out the error";
                } 
                  
            }
            return films;

        }
        public int CountAllFiles()
        {
          return films.Count;
        }

        public string FetchFileinformation()
        {
            throw new NotImplementedException();
        }

        public List<Student> ImportStudentsFromFile(string filepath)
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            /*try 
            {
                Console.WriteLine("Please provide me ID");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(id);
                Student s = new Student();
                s.Id = id;

            }// if something unexpected here, program moves on to catch
            catch(Exception ex) 
            { Console.WriteLine(ex.Message); }*/

            ImportFile();
            int totalFilms = CountAllFiles();
            Console.WriteLine($"Total Number of Films: {totalFilms}");
            var filmsPopular = FilmsThatAreMorePopularThan(70);
            Console.WriteLine("Films that are more popular than 70");
            foreach(FileInfo info in filmsPopular)
            {
                Console.WriteLine(info);
            }

            StringBuilder s = new StringBuilder();

            var matchedFilms = SearchByTitle("home");
            Console.WriteLine("Films match the title home:");
            foreach (FileInfo info in matchedFilms)
            {
                s.AppendLine(info.ToString());
                Console.WriteLine(info);
            }
            File.WriteAllText($"C:\\VS\\filmmatched_jhome.csv", s.ToString());
        }

        List<FileInfo> FilmsThatAreMorePopularThan(int popularity)
        {
            List < FileInfo > popularFilms = new List<FileInfo>();
            foreach (FileInfo f in films)
            {
                if(f.Popularity > popularity)
                {
                    popularFilms.Add(f);
                }
            }
            return popularFilms;
        }

        List<FileInfo> SearchByTitle(string partTitle)
        {
            List<FileInfo> matchedFilms = new List<FileInfo>();
            foreach (FileInfo f in films)
            {
                if (f.Title.ToLower().Contains(partTitle.ToLower()))
                {
                    matchedFilms.Add(f);
                }
            }
            return matchedFilms;
        }
    }
}
