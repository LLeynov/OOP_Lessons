using System.Text.RegularExpressions;

namespace OOP_2
{
    internal class Independent_HomeWork
    {
        public string SampleConv(string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            text = new string(chars);

            return text;
        }
    }

    public class MailExtracter
    {
        public static string SearchMail(ref string s)
        {
            const string MatchEmailPattern =
                @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

            Regex rx = new Regex(
                MatchEmailPattern,
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = rx.Matches(s);

            int noOfMatches = matches.Count;

            string[] arraymatches = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
                arraymatches[i] = matches[i].Value;

            s = string.Join($"\n", arraymatches);

            return s;
        }
    }
}
