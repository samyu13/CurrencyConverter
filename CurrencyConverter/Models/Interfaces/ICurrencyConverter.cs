using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models.Interfaces
{
    public interface ICurrencyConverter
    {
        decimal convert(string to, decimal amount);
    }
}
