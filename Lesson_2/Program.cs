using OOP_2;

namespace Homework_OOP_2
{
    class programm
    {
        static void Main(string[] args)
        {
            // Bank_account bank_Account = new Bank_account(350_000, _enum_account_type.debit);
            // bank_Account.ChooseUrAction(bank_Account);
            // bank_Account.P2PTransfer(bank_Account,10000);

            // Independent_HomeWork Converter = new Independent_HomeWork(); /*OOP_3.2*/
            // string hello = Converter.SampleConv("Some text + some words,u can try it,friend");
            // Console.WriteLine(hello);

            string s = File.ReadAllText(@"C:\GeekBrains\Homework\Lesson_2\Lesson_2\Contacts.txt");
            MailExtracter.SearchMail(ref s);
            Console.WriteLine(s);
           
        }
    }
}