using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    public TextMeshProUGUI counter;
    public TextMeshProUGUI timer;
    public GameObject curtain;

    public GameObject box;
    public TextMeshProUGUI text;
    void Awake(){
        if (GameManager.Instance.canvas == null){
            GameManager.Instance.canvas = gameObject;
            GameManager.Instance.ScoreText = counter;
            GameManager.Instance.TimerText = timer;
            GameManager.Instance.curtain = curtain;
            GameManager.Instance.dialogBox = box;
            GameManager.Instance.dialogText = text;
           // GameManager.Instance.dialogBox = gameObject.GetComponent<DialogText>;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
