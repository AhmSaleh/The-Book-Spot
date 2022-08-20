namespace TheBookSpotDomain.ValidatorExtensions
{
    public static class IntValidators
    {
        public static bool ValidPublicationYear(this int year)
        {
            if (year < 1700 || year > DateTime.Now.Year)
                return false;

            return true;
        }

    }
}
