using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager2 : MonoBehaviour
{
    public static MainManager2 Instance;
    public string userName;
    public InputField inputField;


    // Start is called before the first frame update
    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
            
        Instance = this;
        DontDestroyOnLoad(gameObject);

        {
            userName = PlayerPrefs.GetString("playerName", "Player");
            inputField.text = userName;
        }
    }
    public void SetName(string text)
    {
        userName = text;
        PlayerPrefs.SetString("Player", userName);
    }
}
