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

    protected class SimpleDeposit : Account
    {
        public SimpleDeposit(string type, int iD, double balance) : base(type, iD, balance)
        {

        }
    }

    protected class LtDeposit : Account
    {
        public LtDeposit(string type, int iD, double balance) : base(type, iD, balance)
        {

        }
    }

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

}

