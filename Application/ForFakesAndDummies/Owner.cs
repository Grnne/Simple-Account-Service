﻿using System.ComponentModel.DataAnnotations;

namespace Simple_Account_Service.Application.ForFakesAndDummies;

public class Owner
{
    public Guid Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; } = null!;
}
