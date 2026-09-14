using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Dictionary_Project
{
    public class BankAccountInfo
    {
        public string Name { get; set; }
        public decimal Balance {  get; set; }
    }
    public class BankAccount
    {
        private readonly Dictionary<string, BankAccountInfo> _account = new();

        public void CreateAccount(string Id, string name, decimal balance)
        {
            if (string.IsNullOrWhiteSpace(Id) || string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("AccountId & Account Name is Required");

            if (balance <= 0) throw new ArgumentException("Account balance must be greater than 0");

            if (_account.TryGetValue(Id.Trim(), out BankAccountInfo? bAccount))
                throw new InvalidOperationException("Account already exist.");

            BankAccountInfo newAccount = new BankAccountInfo()
            {
                Name = name,
                Balance = balance
            };

            _account.Add(Id, newAccount);
        }

        public void Deposit(string Id, decimal amount)
        {
            if (string.IsNullOrWhiteSpace(Id))
                throw new ArgumentException("Id & amount is required");

            if (amount <= 0)
                throw new ArgumentException("Amount must be greater than 0");

            if (!_account.TryGetValue(Id.Trim(), out BankAccountInfo? bankAccount))
                throw new InvalidOperationException("Account not found");

            bankAccount.Balance += amount;

        }

        public void Withdraw(string Id, decimal amount)
        {
            if (string.IsNullOrWhiteSpace(Id))
                throw new ArgumentException("Id is required");

            if (amount <= 0)
                throw new ArgumentException("Amount must be greater than 0");

            if (!_account.TryGetValue(Id.Trim(), out BankAccountInfo? bankAccount))
                throw new InvalidOperationException("Account not found");

            if (bankAccount.Balance < amount)
                throw new InvalidOperationException("In-sufficient balance");

            bankAccount.Balance -= amount;
        }
    
        public decimal GetBalance(string Id)
        {
            if (string.IsNullOrWhiteSpace(Id))
                throw new ArgumentException("AccountId is required");

            if (!_account.TryGetValue(Id.Trim(), out BankAccountInfo? bankAccount))
                throw new InvalidOperationException("Account not found");

            return bankAccount.Balance;
        }
    }
}

//5.Bank Account System
//Problem Statement

//Create a bank system where each account has:

//Account Number
//Customer Name
//Balance

//Implement:

//CreateAccount(...)
//Deposit(accountNumber, amount)
//Withdraw(accountNumber, amount)
//GetBalance(accountNumber)

//Rules:

//Account number must be unique
//Withdrawal cannot exceed balance
//Deposit must be positive