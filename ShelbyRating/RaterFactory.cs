using System;

namespace ShelbyRating
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ShelbyRating.{policy.Type}PolicyRater"),
                        new object[] { engine, engine.Logger });
            }
            catch
            {
                return null;
            }
        }
    }
}
