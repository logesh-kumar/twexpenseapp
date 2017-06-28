using System;
using System.Collections.Generic;
using System.Text;

namespace TWExpenseApp
{
    //Participant is a subset of expense. 
    //For each expense there may be one or more participants
    class Participant
    {
        public Person Person { get; set; }
        public int AmountSpent { get; set; }
        public virtual Expense Expense { get; set; }
    }
}
