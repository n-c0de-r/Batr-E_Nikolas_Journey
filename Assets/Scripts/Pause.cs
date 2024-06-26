using UnityEngine;
using UnityEngine.SceneManagement;

//Source: https://www.youtube.com/watch?v=9dYDBomQpBQ, https://www.youtube.com/watch?v=TVSLCZWYL_E
public class Pause : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenu;

    void Start(){
        pauseMenu.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(paused){
                Resume();
            }else{
                DoPause();
            }
        }
    }

    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        paused = false;        
    }

    void DoPause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void MainMenu(){
        Time.timeScale = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    public void Restart(){ 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        paused = false; 
    }
}
