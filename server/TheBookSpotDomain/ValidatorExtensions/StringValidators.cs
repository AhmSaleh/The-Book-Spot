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
        public static bool ValidISBN(this string str)
        {
            if (!Regex.IsMatch(str, @"^?:ISBN(?:-10)?:? )?(?=[0-9X]{10}$|(?=(?:[0-9]+[- ]){3}"))
                return false;

            return true;
        }


    }
}
