using UnityEngine;

public class Battery : MonoBehaviour
{
    public RobotMovement robotMovement;

    private void OnTriggerEnter(Collider other) 
    {
        robotMovement.energy = 100f;
    }
}
