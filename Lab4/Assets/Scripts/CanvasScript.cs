using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    public TextMeshProUGUI counter;
    public GameObject curtain;
    void Awake(){
        if (GameManager.Instance.canvas == null){
            GameManager.Instance.canvas = gameObject;
            GameManager.Instance.ScoreText = counter;
            GameManager.Instance.curtain = curtain;
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
