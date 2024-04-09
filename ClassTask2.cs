using System.Text;

namespace HW0406
{
    public class Task2
    {
        static string MorseCode(char character)
        {
            switch (char.ToUpper(character))
            {
                case 'A':
                    return ".-";
                case 'B':
                    return "-...";
                case 'C':
                    return "-.-.";
                case 'D':
                    return "-..";
                case 'E':
                    return ".";
                case 'F':
                    return "..-.";
                case 'G':
                    return "--.";
                case 'H':
                    return "....";
                case 'I':
                    return "..";
                case 'J':
                    return ".---";
                case 'K':
                    return "-.-";
                case 'L':
                    return ".-..";
                case 'M':
                    return "--";
                case 'N':
                    return "-.";
                case 'O':
                    return "---";
                case 'P':
                    return ".--.";
                case 'Q':
                    return "--.-";
                case 'R':
                    return ".-.";
                case 'S':
                    return "...";
                case 'T':
                    return "-";
                case 'U':
                    return "..-";
                case 'V':
                    return "...-";
                case 'W':
                    return ".--";
                case 'X':
                    return "-..-";
                case 'Y':
                    return "-.--";
                case 'Z':
                    return "--..";
                default:
                    return "Unknown Morse code";
            }
        }

        public static string Coder(string text)
        {
            StringBuilder newText = new StringBuilder();

            string[] arrText = text.Split(' ');

            foreach (string word in arrText)
            {
                char[] chars = word.ToCharArray();

                foreach (char c in chars)
                {
                    newText.Append(MorseCode(c) + ".");
                }
                newText.Append("...");
            }

            string textCode = newText.ToString();

            return textCode;

        }


    }

}
