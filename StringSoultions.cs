namespace CodewarsSolutions
{
    public class StringSolutions
    {
        public static string Disemvowel(string str)
        {
            List<string> vowels = new List<string>()
                {
                    "a","e","i","o","u"
                };
            foreach (var item in vowels)
                {
                    str = str.Replace(item, "");
                }
            return str;
        }
        public static int StrCount(string str, char letter)
        {
            int result = 0;
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == letter)
                {
                    result++;
                }
            }
            return result;

        }
    }
}
