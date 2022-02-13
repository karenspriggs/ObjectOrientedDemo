using System;
using System.Collections.Generic;
using System.Text;

namespace Currency
{
    public interface ICurrency
    {
        // Changed MonetaryValue to a double as the test methods try to add the property to another value that is a double
        decimal MonetaryValue { get; set; }

        string Name { get; set; }

        string About();

        string Portait { get; }
        string ReverseMotif { get; }
    }
}
