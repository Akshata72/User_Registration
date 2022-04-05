using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegex
{
    public class UserRegistrationCustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            USER_ENTERED_EMPTY,
            USER_LESSTHAN_MINIMUM_LENGTH,
            USER_ENTERED_NUMBER,
            USER_ENTERED_LOWERCASE,
            USER_ENTERED_SPECIAL_CHARACTER,
            USER_NOT_ENTERED_LETTER_OR_DIGIT,
            USER_ENTERED_ATLEAST__ONE_UPPERCASE_LATTER,
            USER_ENTERED_LETTERS,
            USER_LESSTHAN_LENGTH,
            USER_DOSE_NOT_ENTERED_ANYSYMBOL,
            USER_DOES_NOT_ENTERED_UPPERCASE_LATTER,
            USER_DOES_NOT_ENTERED_ANYDIGIT,
            USER_ENTERED_ATLEAST__ONE_LOWERCASE_LATTER
        }
        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}