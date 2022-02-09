using System;

namespace QuestionaireApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // New instance of class
            MultipleChoiceQuestion question = new MultipleChoiceQuestion();

            // Make sure this does not crash the app
            //question.SetText(null);
            //question.GetText().ToLower();

            //Console.WriteLine("The question: " + question.GetText());

            question.Text = "Is C# cool to learn?";
            Console.WriteLine("Question: " + question.Text);

            // Via option 1 (prefered)
            question.AddOption("Yes, C# is cool!", true);

            // Via option 2
            MultipleChoiceOption thirdOption = new MultipleChoiceOption();
            thirdOption.Text = "Don't know ...";
            thirdOption.IsCorrect = false;
            question.AddOption(thirdOption);

            MultipleChoiceOption option = new MultipleChoiceOption();
            option.Text = "No, C# is boring.";
            option.IsCorrect = false;
            question.AddOption(option);
            Console.WriteLine(option);

            Console.WriteLine("\n\n");
            Console.WriteLine(question);

        }
    }
}
