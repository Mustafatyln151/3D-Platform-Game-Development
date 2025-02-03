using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript: MonoBehaviour
{
    
    public void playApp()
    {
        SceneManager.LoadScene("SampleScene");



    }


    public void quitApp()
    {

        Application.Quit();// Belki quit'e basýldýðýnda siyah sahne gelebilir.

    }

    public void restart()
    {

        Time.timeScale = 1.0f; // Oyunu tekrar normal hýzýna getirme

        SceneManager.LoadScene("SampleScene");


    }

    public void GoBack()
    {

        SceneManager.LoadScene("2mainMenu");




    }







}
