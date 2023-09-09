using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{

    public static TitleManager instant { get; private set; }

    // ABSTRACTION
    private string m_PlayerName;
    public string PlayerName { 
        get { return  m_PlayerName; }
        set {
            if (value.Length > 3)
            {
                m_PlayerName = value;
            }
        }
    }

    [SerializeField]
    private TextMeshProUGUI nameField;
    [SerializeField]
    private TextMeshProUGUI errorLabel;

    public void Awake()
    {
        if (instant == null) { 
            instant = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
        
    }

    public void EnterMainScene() {
        PlayerName = nameField.text;
        if (PlayerName == null)
        {
            errorLabel.gameObject.SetActive(true);
        }
        else
        {
            errorLabel.gameObject.SetActive(false);
            SceneManager.LoadScene(1);
        }
    }
}
