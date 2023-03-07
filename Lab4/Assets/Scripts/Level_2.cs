using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_2 : MonoBehaviour
{
    public GameObject Swiss;
    new public AudioSource audio; 
    public string text;


    public void OnTriggerEnter2D(Collider2D collider2D) {
        if (collider2D.gameObject.CompareTag("Player")) {
            print("Entered..");
            Swiss.transform.position = new Vector3(Random.Range(-40f, 40f),Random.Range(-25f, 25f),1);
            GameManager.Instance.incScore();        
        }
    }

    public void OnTriggerExit2D(Collider2D collider2D) {
        StopCoroutine("Beep");
    }


    // Start is called before the first frame update
    void Start()
    {
        Swiss.transform.position = new Vector3(Random.Range(-40f, 40f),Random.Range(-25f, 25f),1);
    }




        

    // Update is called once per frame
    void Update()
    {

    }
}
