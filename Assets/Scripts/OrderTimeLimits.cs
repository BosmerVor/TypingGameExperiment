using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderTimeLimits : MonoBehaviour
{
    Vector3 position;
    public float speed = 0.2f;
    public bool chosen = false;

    KeyCode key;
    string numberOfOrder;
    void Start()
    {
        position = transform.position;
        numberOfOrder = transform.GetComponentInChildren<TextMeshProUGUI>().text;
    }

    // Update is called once per frame
    void Update()
    {
        if(!chosen){
            MoveLeft();
        }
        StopIfPicked();
        if(chosen){
            bool compl = CheckIfCompleted();
            if(compl){
                Destroy(gameObject);
                Destroy(GameObject.FindGameObjectWithTag("Ingredients"));
            }
        }
    }

    void MoveLeft(){
        position -= new Vector3(Time.deltaTime * speed, 0f, 0f);
        transform.position = position;
    }

    void StopIfPicked(){
        if(key.ToString() == ("Alpha" + numberOfOrder)){
            chosen = true;
        }
        if(numberOfOrder == "1"){
            if(key.ToString() == "Alpha2" || key.ToString() == "Alpha3"){
                chosen = false;
            }
        }
        else if(numberOfOrder == "2"){
            if(key.ToString() == "Alpha1" || key.ToString() == "Alpha3"){
                chosen = false;
            }
        }
        else if(numberOfOrder == "3"){
            if(key.ToString() == "Alpha1" || key.ToString() == "Alpha2"){
                chosen = false;
            }
        }
    }

    bool CheckIfCompleted(){
        return GameObject.FindWithTag("Ingredients").GetComponentInChildren<CheckCompletion>().completed;
    }

    void OnGUI(){
        Event e = Event.current;
        if(e.isKey){
            key = e.keyCode;
        }
    }
}
