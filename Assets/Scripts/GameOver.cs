using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //nur für 2d und bei der Tür muss der trigger angeschaltet werden
    void OnTriggerEnter2D(Collider2D collision){
        GameObject collisionGameObject = collision.gameObject;
        if(collisionGameObject.name == "NikolaWheel"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
        }
    }
}
