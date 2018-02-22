using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.API.Add
{
    public class AddRepository : IAddRepository
    {
        public int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
