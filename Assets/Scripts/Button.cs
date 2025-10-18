using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    private void FixedUpdate()
    {
        OnStart();
        OnExit();
        OnStageSelect();
    }

    private void OnStart()
    {
        
    }

    private void OnExit()
    {
        Application.Quit();
    }

    private void OnStageSelect()
    {
        SceneManager.LoadScene("GameScene");
    }
}
