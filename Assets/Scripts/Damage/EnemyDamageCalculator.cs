public class EnemyDamageCalculator : IDamageCalculator
{
    public int CalculateHit(int damage)
    {
        return damage * 2;
    }
}
