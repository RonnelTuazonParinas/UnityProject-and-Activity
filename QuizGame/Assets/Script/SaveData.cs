using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
    public InputField textbox;

    public void clicksave()
    {
        PlayerPrefs.SetString("username", textbox.text);
        SceneManager.LoadScene("GameScene");
            
    }
}
