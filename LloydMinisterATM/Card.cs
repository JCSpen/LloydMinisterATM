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
    protected Account LinkedAccount { get; set; }

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
}

