﻿using Simple_Account_Service.Application.ForFakesAndDummies;
using Simple_Account_Service.Infrastructure.Data;

namespace Simple_Account_Service.Infrastructure.Repositories;

public class OwnerRepository(FakeDb db) : IOwnerRepository
{
    public async Task<Owner?> GetByIdAsync(Guid accountId)
    {
        return await db.GetOwnerByIdAsync(accountId);
    }

    public async Task<Owner> CreateAsync(Owner entity)
    {
        return await db.AddOwnerAsync(entity);
    }

    public async Task<Owner> UpdateAsync(Owner entity)
    {
        await db.UpdateOwnerAsync(entity);
        return entity;
    }

    public async Task DeleteAsync(Guid accountId)
    {
        await db.RemoveOwnerAsync(accountId);
    }
}