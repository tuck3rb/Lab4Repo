using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    void Awake(){
        if (GameManager.Instance.canvas == null){
            GameManager.Instance.canvas = gameObject;
            //GameManager.Instance.dialogBox = gameObject.
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
