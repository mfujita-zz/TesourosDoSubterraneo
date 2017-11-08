using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosaoAnimatorControllerHelper : MonoBehaviour 
{
    public void TerminouAnimacao()
    {
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        gc.OnGameOver();
    }
}
