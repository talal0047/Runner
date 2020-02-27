using UnityEngine;

public class Endtrigger : MonoBehaviour {

    public manager gamemanager;
    void OnTriggerEnter()
    {
        gamemanager.levelcomplete();
    }
}
