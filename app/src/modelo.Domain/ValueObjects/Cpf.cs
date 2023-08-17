using System;
using modelo.Domain.Entities.Base;

namespace modelo.Domain.ValueObjects
{
    public struct Cpf
    {
        private readonly string _value;

        private Cpf(string value)
        {
            value = CpfValidation.ClearCpf(value);
            AssertionConcern.AssertArgumentLength(value, 11, "Max char is 11!");
            AssertionConcern.AssertCpfIsValid(value, "O CPF é inválido");

            _value = value;
        }

        public static Cpf Parse(string value)
        {
            if (TryParse(value, out var result))
            {
                return result;
            }
            throw new ArgumentException();
        }

        public static bool TryParse(string value, out Cpf cpf)
        {
            cpf = new Cpf(value);
            return true;
        }

        public override string ToString() => _value;

        public static implicit operator Cpf(string input) => Parse(input);
    }
}