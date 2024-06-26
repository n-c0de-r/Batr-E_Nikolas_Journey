using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform player;
    public GameObject playerWheel;

    public Transform elevator;
    public Transform downpos;
    public Transform upperpos;

    public float speed;
    bool iselevatordown;

    private void OnCollisionEnter2D(Collision2D playerWheel) {
        playerWheel.transform.parent = elevator;
        }
    private void OnCollisionExit2D(Collision2D playerWheel) {
        playerWheel.transform.parent = player;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= downpos.position.y) {
                iselevatordown = true;
        }
        else if (transform.position.y >= upperpos.position.y) {
                iselevatordown = false;
        }
        if(iselevatordown) {
            transform.position = Vector2.MoveTowards(transform.position, upperpos.position, speed * Time.deltaTime);
        }
        else {
            transform.position = Vector2.MoveTowards(transform.position, downpos.position, speed * Time.deltaTime);
        }
    }
    
}
