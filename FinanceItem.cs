using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsFinanceApp
{
    internal class FinanceItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public int Value { get; set; } //First 2 digits of the int are the tenth and hundreth places

        public FinanceItem()
        {
            Name = "Item";
            Description = String.Empty;
            Date = DateTime.Now;
            Value = 0;
        }

        public string GetItemString()
        {
            return Name + " - $" + (Value / 100).ToString();
        }
    }
}
