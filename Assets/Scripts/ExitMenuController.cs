using UnityEngine;
using UnityEngine.InputSystem;

public class ExitMenuController : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
    
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            ExitGame();
        }
    }

}
