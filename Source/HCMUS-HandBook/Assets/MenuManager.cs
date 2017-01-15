using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public RawImage background;
    int max = 1000;
    int change = 1;


    // Use this for initialization
    void Start()
    {
        Debug.Log((string)"Start");
    }

    // Update is called once per frame
    void Update()
    {
        // animation background move
        float width =  background.rectTransform.rect.width;
        background.transform.Translate(change,0,0);

        float x = background.rectTransform.position.x;
        if ( x >= max ||  x <= -(max - 768) ) {
            change = -change;
        }
        
        Debug.Log(x);
    }

    public void LoadMainScene()
    {
        Application.LoadLevel("Start");
        Debug.Log("LoadMainScene");
    }

    public void LoadHistoryScene()
    {
        Debug.Log("LoadHistoryScene");
    }

    public void LoadNowScene()
    {
        Debug.Log("LoadNowScene");
    }

    public void LoadAboutScene()
    {
        Debug.Log("LoadAboutScene");
    }
}
