using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplete : MonoBehaviour {

    public void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
