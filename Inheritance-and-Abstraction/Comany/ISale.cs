﻿namespace Company
{
    using System;

    public interface ISale
    {
        string ProductName { get; set; }

        DateTime SaleDate { get; set; }

        decimal Price { get; set; }
    }
}