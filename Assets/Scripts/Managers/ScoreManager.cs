using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using EasyUI.Popup;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    [TextArea(5, 20)] public string longText;
    Text text;
    int pause = 0;
    int ms = 0;


    void Awake ()
    {
        text = GetComponent <Text> ();
        score = 0;
    }

    void Pause()
    {
        Debug.Log("Pause command called");
        Time.timeScale = 0;
    }
    void Continue()
    {
        Debug.Log("Continue command called");
        Time.timeScale = 1;
    }

    void Update ()
    {
        text.text = "Score: " + score;
        if(pause == 0)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Pause();
                pause = 1;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Continue();
                pause = 0;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("Dev command called");
            
            Popup.Show("Developed By", "Jaskarandeep Singh \nManvi Mehendiyan \nTaesha \nHimanshu Singla \nMani Garg \nAnkur Garg", "Close Me",PopupColor.Black);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit command called");
            text.text = "Quitting";
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
