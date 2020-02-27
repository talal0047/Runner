using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class manager : MonoBehaviour {

    bool chk = false;
    public float restartdelay = 1f;
    public GameObject CompleteLevelUI;
    public Text highscore;
    public Transform player;

    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }
    public void levelcomplete()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void EndGame() {
        if (chk == false)
        {
            chk = true;
            Debug.Log("Game Over");
            Invoke("restart", restartdelay);
        }
    }

    void restart()
    {   
        if ((int)player.position.z > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", (int)player.position.z);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void reset()
    {
        PlayerPrefs.DeleteKey("highscore");
        highscore.text = ("0");
    }

}
