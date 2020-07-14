using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeAway : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer image, childImage;
    TextMeshProUGUI letter;
    bool pressed = false;
    
    void Start()
    {
        image = transform.GetComponent<SpriteRenderer>();
        childImage = transform.GetChild(1).GetComponent<SpriteRenderer>();
        letter = transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(!pressed){
            if(Input.GetKeyDown(letter.text.ToLower())){

                Color tempColor = image.color;
                tempColor.a = 0.5f;
                image.color = tempColor;

                tempColor = childImage.color;
                tempColor.a = 0.5f;
                childImage.color = tempColor;

                letter.text = "";
                transform.parent.GetComponent<CheckCompletion>().numberOfPressed += 1;
                pressed = true;
            }
        }
    }
}
