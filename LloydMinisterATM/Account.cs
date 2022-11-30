using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;


    public class Account
    {
    protected string Type { get; set; }
    protected int ID { get; set; }

    protected double Balance { get; set; }


    public Account(string type, int iD, double balance)
    {
        Type = type;
        ID = iD;
        Balance = balance;
    }

    public double GetBalance()
    {
        return Balance;
    }
    public void SetBalance(double Change)
    {
        Balance = Balance + Change;
    }
    public string GetTransaction()
    {
        return "Last";
    }

    public string GetAccountType()
    {
        return Type;
    }

    public int GetID()
    {
        return ID;
    }

}

