using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public Button playB;
    public Button exitB;
    // Start is called before the first frame update
    void Start()
    {
        playB.onClick.AddListener(() =>
       {
           SceneManager.LoadScene("SampleScene");
       });
        exitB.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}

   
