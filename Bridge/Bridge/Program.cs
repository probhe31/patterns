using System;

namespace Bridge
{
    using System;
    using System.Collections.Generic;
    using Bridge.FirstVersion.Formatters;
    using Bridge.FirstVersion.Manuscripts;

    public static class Program
    {
        public static void Main()
        {
            var documents = new List<Manuscript>();
            var formatter = new FancyFormatter(); // new BackwardsFormatter();

            var faq = new Faq(formatter) { Title = "The Bridge Pattern" };
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "You have a proliferation of classes resulting from a coupled interface and numerous implementations.");
            documents.Add(faq);

            var book = new Book(formatter)
            {
                Title = "Game Engine Architecture",
                Author = "Jason Gregory",
                Text = "Theory and practice of game engine software development."
            };
            documents.Add(book);

            var paper = new TermPaper(formatter)
            {
                Class = "Level Up!",
                Student = "Scott Rogers",
                Text = "Introduction a game design.",
                References = "Theory of fun"
            };
            documents.Add(paper);

            foreach (var doc in documents)
            {
                doc.Print();
            }

            Console.ReadKey();
        }
    }
}
