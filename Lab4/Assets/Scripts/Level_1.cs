using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour
{
    public GameObject Cheese;
    new public AudioSource audio; 

    public int c = 100;
    public string text;


    public void OnTriggerEnter2D(Collider2D collider2D) {
        if (collider2D.gameObject.CompareTag("Player")) {
            print("Entered..");
            Cheese.transform.position = new Vector3(Random.Range(-40f, 40f),Random.Range(-25f, 25f),1);
            GameManager.Instance.incScore();        
        }
    }
    public void OnTriggerExit2D(Collider2D collider2D) {
        StopCoroutine("Beep");
    }

    IEnumerator Beep()
    {
        if (GetComponent<Collider2D>().gameObject.CompareTag("Player")) {
			audio.Play();
            Cheese.GetComponent<Renderer>().material.color = Color.red;
            c--;
            yield return new WaitForSeconds(0.1f);
            audio.Pause();
            print("ff");
		}
    }

    // Start is called before the first frame update
    void Start()
    {
        Cheese.transform.position = new Vector3(Random.Range(-40f, 40f),Random.Range(-25f, 25f),1);
    }




        

    // Update is called once per frame
    void Update()
    {

    }
}
