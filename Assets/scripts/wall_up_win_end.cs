using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wall_up_win_end : MonoBehaviour {

void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.name == "spr_main")
        {
        	SceneManager.LoadSceneAsync("gamewon", LoadSceneMode.Additive);
        };
    }
}