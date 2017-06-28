using System;
using System.Collections.Generic;
using System.Text;

namespace TWExpenseApp
{
    //This is over all Bill which includes list of expenses
    class Bill
    {
        public int BillId { get; set; }
        public string BillDescription { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public int Total { get; set; }
    }
}
