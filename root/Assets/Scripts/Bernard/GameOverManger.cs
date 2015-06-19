using UnityEngine;
using System.Collections;

public class GameOverManger : MonoBehaviour 
{

    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
            anim.SetTrigger("GameOver");
    }

}
