
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    public void StartGame()

    {
         SceneManager.LoadScene("RocketMouse");
    }

    public Animator StartButton;
    public Animator SettingsButton;

    public void OpenSettings()
    {
        StartButton.SetBool("Ishidden", true);
        SettingsButton.SetBool("Ishidden", true);
    }
}
