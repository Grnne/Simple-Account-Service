﻿using Simple_Account_Service.Features.Transactions.Entities;

namespace Simple_Account_Service.Features.Accounts.Entities;

public class Account
{
    public Guid Id { get; set; }

    public Guid OwnerId { get; set; }

    public AccountType Type { get; set; }

    public string Currency { get; set; } = null!;

    public decimal Balance { get; set; }

    public decimal? InterestRate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ClosedAt { get; set; }

    public List<Transaction> Transactions { get; set; } = [];
}

public enum AccountType
{
    Checking,
    Deposit,
    Credit
}