using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Fungsi untuk mulai permainan
    public void StartGame()
    {
        // Ganti dengan nama scene permainan yang Anda miliki, misalnya "GameScene"
        SceneManager.LoadScene("Level1");  
    }

    // Fungsi untuk menampilkan kredit
    public void ShowCredits()
    {
        // Ganti dengan nama scene yang menampilkan kredit, misalnya "CreditsScene"
        SceneManager.LoadScene("CreditScene");  
    }

    // Fungsi untuk keluar dari permainan
    public void QuitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();  // Keluar dari aplikasi
    }
}
