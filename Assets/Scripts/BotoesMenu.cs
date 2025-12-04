using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void IniciarJogo()
    {
        SceneManager.LoadScene("GameScene");
    }

    // Update is called once per frame
    public void SairDoJogo()
    {
        Application.Quit();
    }

    public void VoltarProMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
