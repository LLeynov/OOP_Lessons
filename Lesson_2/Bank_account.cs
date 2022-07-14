

namespace OOP_2
{
    enum _enum_account_type { debit, credit }
    internal class Bank_account
    {

        private readonly int _balance;
        private static long _accountNumber;
        private readonly _enum_account_type _enum_account_type;

        public Bank_account(int balance)
        {
            _balance = balance;
            Print();
            ChooseUrAction();
        }

        public Bank_account(_enum_account_type enum_account_type)
        {
            _enum_account_type = enum_account_type;
            Print();
            ChooseUrAction();
        }

        public Bank_account(int balance, _enum_account_type enum_account_type)
        {
            _balance = balance;
            _enum_account_type = enum_account_type;
            Print();
            ChooseUrAction();
        }
        public long AccountNumber
        {
            get
            {
                Random random = new Random();
                _accountNumber = random.NextInt64(1000_0000_0000_0000, 9999_9999_9999_9999);
                return _accountNumber;
            }

        }
        public void Print()
        {
            Console.WriteLine($"Текущий баланс счёта : {_balance}р.");
            Console.WriteLine($"Текущий тип аккаунта : {_enum_account_type}");
            Console.WriteLine(AccountNumber.ToString("[####-####-####-####]"));

        }

        private void ChooseUrAction()
        {
            Console.WriteLine(@"Пожалуйста,напишите,что бы вы хотели сделать : Пополнить или Снять?");
            string ChosedAction = Console.ReadLine();
            switch (ChosedAction)
            {
                case "Пополнить":
                    {
                        Replenishment();
                        break;
                    }
                case "Снять":
                    {
                        Withdraw();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели некорректное действие,пожалуйста,повторите попытку");

                        ChooseUrAction();
                        break;
                    }
            }


        }
        internal void Withdraw()
        {
            Console.WriteLine($"Введите желаемую сумму для снятия. Доступно для снятия : {_balance}");
            int desired_amount = Convert.ToInt32(Console.ReadLine());
            if (desired_amount <= _balance)
            {
                if (desired_amount > 0)
                {
                    int new_balance = _balance - desired_amount;
                    Console.WriteLine($"Успешное снятие : {desired_amount}р.,на счету осталось : {new_balance}р.");
                }

            }
            else Console.WriteLine("Денег на счету недостаточно для снятия желаемой суммы.");

        }
        internal void Replenishment()
        {
            Console.WriteLine($"Введите желаемую сумму для пополнения. Текущая сумма на счету : {_balance}р.");
            int desired_amount = Convert.ToInt32(Console.ReadLine());
            if (desired_amount > 0)
            {
                int new_balance = _balance + desired_amount;
                Console.WriteLine($"Успешное пополнение,баланс счёта :{new_balance}р.");
            }
            Console.WriteLine("Введено некорректное значение!");
        }

    }
}
