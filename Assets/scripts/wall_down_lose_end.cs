using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wall_down_lose_end : MonoBehaviour {

void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.name == "spr_main")
        {
        	SceneManager.LoadSceneAsync("gameover", LoadSceneMode.Additive);
        };
    }
}