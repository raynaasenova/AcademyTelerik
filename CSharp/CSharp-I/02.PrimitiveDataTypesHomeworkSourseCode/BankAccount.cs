using System;
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

class BankAccount
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Angelov";
        string lastNme = "Petrov";
        string fullName = firstName + " " + middleName + " " + lastNme;
        decimal balance = 10000M; 
        string bankName = "БАНКА ДСК";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        string bic = "STSABGSF";
        ulong creditCard1 = 78403085784303834;
        ulong creditCard2 = 73954578343057754;
        ulong creditCard3 = 23448508508354667;
        Console.WriteLine("Name: {0}", fullName);
        Console.WriteLine("Balance: {0} лева", balance);
        Console.WriteLine("Bank: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("BIC: {0}", bic);
        Console.WriteLine("Credit card № {0} \nCredit card № {1} \nCredit card № {2}", creditCard1, creditCard2, creditCard3);

    }
}
