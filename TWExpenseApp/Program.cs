using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TWExpenseApp
{
    
    //A spent 100 for Snacks for A, B, C and D
    //B spent 500 for Taxi for C and D
    //D spent 300 for Bus for A and B
    class Program
    {
        public static Participant CreateParticipant(Int32 amountSpent, Person person)
        {
            return new Participant
            {
                AmountSpent = amountSpent,
                Person = person
            };
        }

        public Program()
        {
            
        }

        public string CalculateExpense(Bill bill) {
            

            return JsonConvert.SerializeObject(bill);
        }

        static void Main(string[] args)
        {
            var program = new Program();

            var bill = new Bill();
            bill.BillId = 1;
            bill.BillDescription = "Went to movie";
     
            bill.Expenses = new List<Expense>
            {
                new Expense{
                    Cost = 100,
                    Participants = new List<Participant>{
                        CreateParticipant(100, new Person{ Name = "A", Age = 30 }),
                        CreateParticipant(0, new Person{ Name = "B", Age = 30 }),
                        CreateParticipant(0, new Person{ Name = "C", Age = 30 }),
                        CreateParticipant(0, new Person{ Name = "D", Age = 30 })
                    }
                },
                new Expense{
                    Cost = 500,
                    Participants = new List<Participant>{
                        CreateParticipant(0, new Person{ Name = "A", Age = 30 }),
                        CreateParticipant(500, new Person{ Name = "B", Age = 30 }),
                        CreateParticipant(0, new Person{ Name = "C", Age = 30 }),
                        CreateParticipant(0, new Person{ Name = "D", Age = 30 })
                    }
                },
                new Expense{
                    Cost = 300,
                    Participants = new List<Participant>{
                        CreateParticipant(0, new Person{ Name = "A", Age = 30 }),
                        CreateParticipant(0, new Person{ Name = "B", Age = 30 }),
                        CreateParticipant(0, new Person{ Name = "C", Age = 30 }),
                        CreateParticipant(300, new Person{ Name = "D", Age = 30 })
                    }
                }
            };

            var json = program.CalculateExpense(bill);
            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}