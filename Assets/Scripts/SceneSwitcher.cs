using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("AppBolitas");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("AppBolitas2");
    }

    public void LoadScene4()
    {
        SceneManager.LoadScene("AppBisel2");
    }
}