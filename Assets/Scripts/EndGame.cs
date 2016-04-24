using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

    public bool requireButtonPress;
    private bool waitForPress;

    void Update () 
    {
	    if(waitForPress && Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("Got it");
            Application.Quit();
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Brobot")
        {
            if (requireButtonPress)
            {
                waitForPress = true;
                return;
            }
        }
    }
}
