﻿using AuthApp.Db;
using Microsoft.EntityFrameworkCore;

namespace AuthApp.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AuthAppDb _context;
    public UserRepository(AuthAppDb context)
    {
        _context = context;
    }
    public async Task<User?> CreateUser(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return user;
    }

    public async Task<User?> GetUser(long userId)
    {
        return await _context
            .Users
            .FirstOrDefaultAsync(u => u.Id == userId);
    }

    public async Task<User?> GetUser(string email)
    {
        return await _context
            .Users
            .FirstOrDefaultAsync(u => u.Email == email);
    }
}
