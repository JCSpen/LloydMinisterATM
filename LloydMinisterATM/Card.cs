using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

    public class Card
    {
    protected int CardNum { get; set; }
    protected int Pin { get; set; }
    public Account LinkedAccount { get; set; }

    protected List<Account> LinkedAccounts { get; set; }

    public Card(int cardNum, int pin,Account account)
    {
        CardNum = cardNum;
        Pin = pin;
        LinkedAccount = account;
    }

    public int GetPin()
    {
        return Pin;
    }

    public List<Account> GetLinkedAccounts()
    {
        return LinkedAccounts;
    }

    public void GetOtherAccounts()
    {
        LinkedAccounts = new List<Account>();
        LinkedAccounts.Add(LinkedAccount);
        LinkedAccounts.Add(NewAccountType("Simple Deposit"));
        LinkedAccounts.Add(NewAccountType("Long Term Deposit"));
    }

    public int Withdraw(int amount)
    {
        LinkedAccount.SetBalance(-amount);
        return amount;
    }

    public int Transfer(int amount)
    {
        return amount;
   }
    public double GetBalance()
    {
        return LinkedAccount.GetBalance();
    }

    public List<String> GetStatements()
    {
        List<String> statements = new List<String>();
        for(int i = 0; i < 10; i++)
        {
            statements.Add(LinkedAccount.GetTransaction());
        }
        return statements;   
    }

    public string GetAccountType()
    {
        return LinkedAccount.GetAccountType();
    }

    public Account NewAccountType(string Type)
    {
        int ID = LinkedAccount.GetID();
        double Balance  = LinkedAccount.GetBalance();
        if (Type == "Current Account")
        {
            return LinkedAccount = new CurrentAccount(Type, ID, Balance); 
        }
        else if(Type == "Simple Deposit")
        {
            return LinkedAccount = new SimpleDeposit(Type, ID, Balance);
        }
        else if(Type == "Long Term Deposit")
        {
            return LinkedAccount = new LtDeposit(Type, ID, Balance);
        }
        return LinkedAccount;
    }

}

