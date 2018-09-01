using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Pauser : MonoBehaviour
{
    private bool paused = false;
    public GameObject PausePanel;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {

            paused = !paused;
            PausePanel.SetActive(paused);
        }

        if (paused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void ContinueGame()
    {
        Debug.Log("Continuar");
        paused = false;
        PausePanel.SetActive(paused);

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
