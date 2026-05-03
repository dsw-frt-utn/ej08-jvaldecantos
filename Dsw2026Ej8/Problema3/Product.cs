using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema03
{
    internal class Product
    {
        public string Description { get; set; }

        public void ModDescription(string newDescription)
        {
            Description = newDescription;
        }
    }
}
