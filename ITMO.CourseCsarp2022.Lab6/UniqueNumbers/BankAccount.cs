﻿class BankAccount
{
    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextAccNo++;
    }

    public decimal Deposit(decimal amount)
    {
        if (amount > 0)
            accBal += amount;
        return accBal;
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
        }
        return sufficientFunds;
    }

    public void TransferFrom(BankAccount accFrom, decimal amount)
    {
        if (accFrom.Withdraw(amount))
            this.Deposit(amount);
    }

    private long accNo;
    private decimal accBal;
    private AccountType accType;

    private static long nextAccNo = 123;
}
