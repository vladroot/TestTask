public class PlayerDamageCalculator : IDamageCalculator
{
    public int CalculateHit(int damage)
    {
        return damage * damage;
    }
}
