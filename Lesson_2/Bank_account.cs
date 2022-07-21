using Homework_OOP_2;

namespace OOP_2
{
    enum _enum_account_type
    {
        debit,
        credit
    }

    internal class Bank_account
    {
        private int _balance;
        private static long _accountNumber;
        private readonly _enum_account_type _enum_account_type;

        public Bank_account(int balance)
        {
            _balance = balance;
            Print();
        }

        public Bank_account(_enum_account_type enum_account_type)
        {
            _enum_account_type = enum_account_type;
            Print();
        }

        public Bank_account(int balance, _enum_account_type enum_account_type)
        {
            _balance = balance;
            _enum_account_type = enum_account_type;
            Print();
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

        internal void ChooseUrAction(Bank_account bank_account)
        {
            Console.WriteLine(@"Пожалуйста,напишите,что бы вы хотели сделать : Пополнить или Снять? Или просто посмотреть?");
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
                case "Посмотреть":
                {
                    break;
                }
                default:
                    {
                        Console.WriteLine("Вы ввели некорректное действие,пожалуйста,повторите попытку");
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
            else
            Console.WriteLine("Введено некорректное значение!");
        }

        internal void P2PTransfer(Bank_account bank_Account, int quantiti)
        {
            Console.WriteLine(
                $"Перевод с банковского счёта : {_accountNumber},баланс счёта : {_balance}р, желаемая сумма перевода {quantiti}р.");
            if (quantiti < 0)
            {
                Console.WriteLine("Вы ввели некорректное значение.");
            }
            else
            {
                if (quantiti <= _balance)
                {
                    int newBalance = bank_Account._balance - quantiti;
                    bank_Account._balance = newBalance;
                    Console.WriteLine(
                        $"Успешная операция перевода на сумму : {quantiti}р, со счёта : {_accountNumber}, остаток средств {_balance} ");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine($"Операция невозможна : недостаточно денег на счету, доступная сумма {bank_Account._balance}.");
                }
            }
        }
    }
}