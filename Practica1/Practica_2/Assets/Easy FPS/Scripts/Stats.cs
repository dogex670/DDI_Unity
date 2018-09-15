using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    private bool paused = false;
    public GameObject StatusPanel;

    // Update is called once per frame


    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {

            paused = !paused;
            StatusPanel.SetActive(paused);


        }
        //  Cursor.visible = true;

        if (paused)
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        else
        {
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

    }

    public void ContinueGame()
    {
        Debug.Log("Continuar");
        paused = false;
        StatusPanel.SetActive(paused);

    }
    public void Reset()
    {
        Debug.Log("Reset");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }
    public void MuteMusic()
    {
        if (AudioListener.volume == 0f)
        {
            AudioListener.volume = 1f;
        }
        else
        {
            AudioListener.volume = 0f;
        }


    }

}
