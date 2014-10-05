﻿namespace Company
{
    using System.Collections.Generic;

    public interface ISalesEmployee : IRegularEmployee
    {
        IList<ISale> Sales { get; set; }
    }
}