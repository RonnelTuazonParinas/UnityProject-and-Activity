using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour {

    public gameManager gameManagers;

    void OnTriggerEnter()
    {
        gameManagers.CompleteLevel();
    }

}
