namespace Identity.Data.Seed;

using System;
using System.Collections.Generic;
using Identity.Models;

public static class InitialData
{
    public static List<User> Users { get; }

    static InitialData()
    {
        Users = new List<User>
        {
            new User
            {
                Id = NewId.NextGuid(),
                FirstName = "Van",
                LastName = "One",
                UserName = "van1",
                PassPortNumber = "12345678",
                Email = "van1@test.com",
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new User
            {
                Id = NewId.NextGuid(),
                FirstName = "Van",
                LastName = "Two",
                UserName = "van2",
                PassPortNumber = "87654321",
                Email = "van2@test.com",
                SecurityStamp = Guid.NewGuid().ToString()
            }
        };
    }
}