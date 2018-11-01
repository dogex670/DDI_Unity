//This script outputs the current position of a touch

//Attach this script to a GameObject
//Create a Text GameObject (Create>UI>Text)
//Attach the Text to the Text field in the Inspector window of your GameObject


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TouchPositionExample : MonoBehaviour
{
    public Text m_Text;

    void Update()
    {
        Touch touch = Input.GetTouch(0);

        //Update the Text on the screen depending on current position of the touch each frame
        m_Text.text = "Touch Position : " + touch.position;
        print(m_Text);
    }
}