using System.Text;

namespace Algorithms
{
    class Challenge
    {
        public string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
                sb.Append(input[i]);

            return sb.ToString();
        }

        public string Normalize(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            
            return input.Replace(",","");
        }
    }
}