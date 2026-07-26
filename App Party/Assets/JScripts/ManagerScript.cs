using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour
{

    public string SceneName;

    private void OnMouseDown()
    {
        if (SceneName != null)
            SceneManager.LoadScene(SceneName);
    }
}
