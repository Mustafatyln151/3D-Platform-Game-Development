using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseScene;

    private bool isPaused = false;

    
    
    private void Start()
    {
        
        pauseScene.SetActive(false);
    
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Pause();
        }


    }


    private void Pause()
    {
        isPaused = !isPaused;

        Time.timeScale = isPaused ? 0f : 1f;

        pauseScene.SetActive(isPaused);



    }
}
