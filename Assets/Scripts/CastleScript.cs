using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleScript : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            if (level == 1)
            {
                SceneManager.LoadScene("Level2");
            }
           else if (level == 2)
            {
                SceneManager.LoadScene("Win");
            }
        }
    }
}
