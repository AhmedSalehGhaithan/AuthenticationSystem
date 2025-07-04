﻿namespace AuthenticationSystem.Domain.Entities;

public abstract class Entity<TKey>
{
    public TKey Id { get; protected set; }
}
