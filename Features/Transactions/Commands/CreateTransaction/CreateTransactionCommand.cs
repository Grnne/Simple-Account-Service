﻿namespace Simple_Account_Service.Features.Transactions.Commands.CreateTransaction;

public record CreateTransactionCommand(Guid AccountId, CreateTransactionDto CreateTransactionDto);
