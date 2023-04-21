using System;
using Classes;


namespace A;
public class Program
{
    static void Main(string[] args){

var account = new BankAccount("SBI", -10000);
var account2 = new BankAccount("SBH", 10000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");
    account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);
    }
}




