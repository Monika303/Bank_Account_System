using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huss
{
    public interface IbankAccountOperations//this is an inteface,this menans that all the children of the bankAccount can use this methods differently
    {
        void deposit(decimal amount);//add money
        void withdraw(decimal amount);//take out money
        void displayInfo();
    }
    public abstract class bankAccount : IbankAccountOperations
    //i created an abstract class because i want the children of the bankAccount
    //to have everything that has the parent class and i do not want to create an object of the bankAccounr

    {
        //Fields that the bank acoount has
        public string name {  get; set; }
        public decimal accountBalance { get; set; }
        public int accountNumber {  get; set; }


        //a constructor for the fields
        public bankAccount(string name,decimal accountBalance,int accountNumber)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.name = name;


        }
        //inheriting the interface
        public abstract void deposit(decimal amount);
        public abstract void withdraw(decimal amount);
        public abstract void displayInfo();


    }
    //creating a class that inherits from the bankaccount
    public class Savings : bankAccount 
    
    {
        public Savings(string name, decimal accountBalance, int accountNumber) : base(name, accountBalance, accountNumber) { }

        public override void deposit(decimal amount)
        {
            if (amount == 0)
            {
                Console.WriteLine("the amount of the money you want to add needs to be more than 0");
            }
            else
            {
                accountBalance=  accountBalance+amount;
            }
        }
        public override void withdraw(decimal amount)
        {
            if(accountBalance==0||amount>accountBalance)
            {
                Console.WriteLine("not suffisient funds");

            }
            else
            {
                accountBalance= accountBalance-amount;
            }

        }
        public override void displayInfo()
        {
            Console.WriteLine("the name of the owner is" + name);
            Console.WriteLine("the account balance is"+accountBalance);
            Console.WriteLine("the account number is"+accountNumber);
        }
    }






}
