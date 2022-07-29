using UnityEngine;
using Zenject;

public class DurabilityController : MonoBehaviour
{
    [Inject] protected IDamageCalculator _damageCalculator;

    private void Start()
    {
        int amount = _damageCalculator.CalculateHit(5);
        Debug.Log(amount);
    }
}
