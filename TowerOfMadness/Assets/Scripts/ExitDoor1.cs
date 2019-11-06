using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor1 : MonoBehaviour
{
    public int gemsRemaining;
    public AudioClip clip;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if(gemsRemaining == 0)
            {
                SceneManager.LoadScene("Level2");
            }
            else {
                AudioSource.PlayClipAtPoint(clip, transform.position);
            }
            
        }
    }

    void Awake()
    {
        gemsRemaining = GameManager.Instance.gemsRemaining;
    }
}
