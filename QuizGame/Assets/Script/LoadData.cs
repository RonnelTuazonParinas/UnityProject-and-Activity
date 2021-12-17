using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour
{
    public Text UserNameBox;
    void Start()
    {
        UserNameBox.text = PlayerPrefs.GetString("username");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
