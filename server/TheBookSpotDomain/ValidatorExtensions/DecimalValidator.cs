namespace TheBookSpotDomain.ValidatorExtensions
{
    public static class DecimalValidators
    {
        public static bool GraterThanZero(this decimal number)
        {
            if (number > 0)
                return true;

            return false;
        }
    }
}
