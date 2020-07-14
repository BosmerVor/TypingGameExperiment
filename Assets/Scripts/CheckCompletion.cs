using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCompletion : MonoBehaviour
{
    string pressedButtons;
    public bool completed = false;
    public int numberOfPressed = 0;

    void Start()
    {
        for(int i = 0; i < transform.childCount; i++){
            pressedButtons += transform.GetChild(i).GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text;
        }
        Debug.Log(pressedButtons);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(numberOfPressed.ToString() + pressedButtons.Length.ToString());
        if(pressedButtons.Length == numberOfPressed){
            completed = true;
        }
    }
}
