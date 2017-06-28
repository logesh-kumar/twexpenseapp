using System;
using System.Collections.Generic;
using System.Text;

namespace TWExpenseApp
{
    //This is subset of bill. List of expenses adds up to make a bill
    //Each Bill may have any number of participants
    class Expense
    {
        public int Cost { get; set; }
        public string Type { get; set; }
        public ICollection<Participant> Participants  { get; set; }
        public virtual Bill Bill { get; set; }
    }
}
