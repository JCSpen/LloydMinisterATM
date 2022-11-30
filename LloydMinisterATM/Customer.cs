using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Customer
    {
        protected int ID { get; set; }
        protected List<Account> Accounts { get; set; }

        protected List<Card> Cards { get; set; }

        public Customer()
    {
        ID = GetID();
    }

        private int GetID()
    {
        return ID;
    }
    }

