namespace Stripe
{
    public class QuoteSubscriptionDataEffectiveDate : StringEnum
    {
        /// <summary>Special value used to end a customer's trial immediately.</summary>
        public static readonly QuoteSubscriptionDataEffectiveDate CurrentPeriodEnd = new QuoteSubscriptionDataEffectiveDate("current_period_end");

        private QuoteSubscriptionDataEffectiveDate(string value)
            : base(value)
        {
        }
    }
}
