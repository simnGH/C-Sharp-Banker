using System;
using System.IO;

// Define bank account
// Basics from https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-of-objects-in-C-Sharp/

public class BankAccount
{
    public int sortCode;
    public int accountNumber;
    public string accountType;
    public string forename;
    public string surname;
    public double balance;
  
    public BankAccount(int sortCode, int accountNumber, string accountType, string forename, string surname, double balance)
    {
        this.sortCode = sortCode;
        this.accountNumber = accountNumber;
        this.accountType = accountType;
        this.forename = forename;
        this.surname = surname;
        this.balance = balance;
    }
  
    public int SortCode { get; set ; }
    public int AccountNumber { get; set ; }
    public string AccountType { get; set ; }
    public string Forename { get; set ; }
    public string Surname { get; set ; }
    public double Balance { get; set ; }
}