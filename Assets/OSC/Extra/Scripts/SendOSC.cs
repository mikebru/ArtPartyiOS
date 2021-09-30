using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SendOSC : MonoBehaviour {

	public OSC oscReference;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void SendMessageScene(int index)
    {
        OscMessage message = new OscMessage();
        message.address = "/Scene";
        message.values.Add(index);
        oscReference.Send(message);
    }




    /*
    void OnMouseDown() {
        OscMessage message = new OscMessage();
        message.address = "/test";
        message.values.Add(transform.position.x);
        message.values.Add(transform.position.y);
        message.values.Add(transform.position.z);
        oscReference.Send(message);
	}*/

}
