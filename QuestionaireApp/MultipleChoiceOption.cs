using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionaireApp
{
    class MultipleChoiceOption
    {
        public override string ToString()
        {
            return Text;
        }

        // prop
        public bool IsCorrect { get; set; }

        // propfull
        public string Text
        {
            get { return text; }
            set
            {
                if (value == null)
                {
                    value = "";
                }
                text = value;
            }
        }

        // Atributes
        private string text = "";
    }
}
