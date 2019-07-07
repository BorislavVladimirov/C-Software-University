using System;
using System.Collections.Generic;
using System.Linq;
namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                Article article = new Article()
                {
                    Title = input[0],
                    Content = input[1],
                    Autor = input[2]
                };

                articles.Add(article);
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(x => x.Autor).ToList();
                    break;
            }

            foreach (Article article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Autor}");
            }
        }
    }
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Autor { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }
    }
}
