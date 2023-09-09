using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainManager : MonoBehaviour
{
    [SerializeField]
    private List<Shape> shapes = new List<Shape>();
    [SerializeField]
    private TextMeshProUGUI WelcomePerson;

    public void Start()
    {
        if (TitleManager.instant != null && TitleManager.instant.PlayerName != null) { 
            WelcomePerson.text = TitleManager.instant.PlayerName;
        }
    }

    // Update is called once per frame
    public void ButtonPressed()
    {
        
        for (int i = 0; i < shapes.Count; i++)
        {
            shapes[i].Move();
        }
    }
}
