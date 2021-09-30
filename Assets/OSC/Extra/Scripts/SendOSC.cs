using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SendOSC : MonoBehaviour {

	public OSC oscReference;

    public Joystick rotationJoystick, zoomJoystick;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        sendJoystickData();
	}

    public void SendMessageScene(int index)
    {
        OscMessage message = new OscMessage();
        message.address = "/Scene";
        message.values.Add(index);
        oscReference.Send(message);
    }


    void sendJoystickData()
    {
        OscMessage messageRot = new OscMessage();
        messageRot.address = "/Rotation";
        messageRot.values.Add(rotationJoystick.Horizontal);
        messageRot.values.Add(rotationJoystick.Vertical);

        oscReference.Send(messageRot);

        OscMessage messageZoom = new OscMessage();
        messageZoom.address = "/Zoom";
        messageZoom.values.Add(zoomJoystick.Vertical);
        oscReference.Send(messageZoom);
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
