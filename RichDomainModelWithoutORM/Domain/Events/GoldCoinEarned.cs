namespace RichDomainModelWithoutORM.Domain.Events
{
    public struct GoldCoinEarned
    {
        public readonly string PlayerId;
        public readonly int GoldCoins;

        public GoldCoinEarned(string playerId, int goldCoins)
        {
            PlayerId = playerId;
            GoldCoins = goldCoins;
        }
    }
}
