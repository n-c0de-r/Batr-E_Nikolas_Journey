using UnityEngine;

public class ScriptLight : MonoBehaviour
{
    IChargeable chargeable;
    [SerializeField] private float energyStrength = 0.02f;

    private void OnTriggerStay2D(Collider2D collider)
    {
        // Get anything that can be charged (has the Interface IChargeable)
        
        if (collider.TryGetComponent<IChargeable>(out chargeable))
        {
            /* Call the Interface's recharge function on what ever object
               Let each Object take care about their individual implementation. */
            chargeable.recharge(energyStrength);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.TryGetComponent<IChargeable>(out chargeable))
        {
            chargeable.resetColor();
        }

    }
}
