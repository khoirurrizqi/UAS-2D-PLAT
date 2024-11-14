using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");  // Ganti dengan nama scene utama
    }
}
