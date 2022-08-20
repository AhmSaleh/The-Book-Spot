using System.Text.RegularExpressions;

namespace TheBookSpotDomain.Validators
{
    public static class StringValidators
    {
        public static bool ContainsCharsOnly(this string str)
        {
            if (!Regex.IsMatch(str, @"^[a-zA-Z]+$"))
                return false;

            return true;
        }
    }
}
