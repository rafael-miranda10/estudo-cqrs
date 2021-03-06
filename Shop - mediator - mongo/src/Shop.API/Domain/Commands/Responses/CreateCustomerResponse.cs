﻿using System;

namespace Shop.API.Domain.Commands.Responses
{
    public class CreateCustomerResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}
