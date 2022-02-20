using System;

namespace LSP.Good
{
    public abstract class Tax : Employee
    {
        protected Tax(string fullName, decimal salary) : base(fullName, salary) { }

        public virtual decimal CalculateTax() => throw new NotImplementedException();
    }
}
