using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderCreation : MonoBehaviour
{
    public GameObject[] listOfOrders;
    bool full = false;
    float y = -2f;

    void Start()
    {

    }

    void Update()
    {
        CreateOrderMenu();
    }

    void CreateOrderMenu(){
        GameObject[] listOfCreatedOrders = GameObject.FindGameObjectsWithTag("Order");
        if(!full){
            //int k = 0;
            float positionShift = 0;
            //string text;
            if(!Found(listOfCreatedOrders, 1)){
                positionShift = 0;
            }
            else if(!Found(listOfCreatedOrders, 2)){
                positionShift = 1;
            }
            else if(!Found(listOfCreatedOrders, 3)){
                positionShift = 2;
            }
            Debug.Log(positionShift);
            //Instantiate(listOfOrders[Random.Range(0, listOfOrders.Length)], new Vector3(-6.32f, 3.45f + positionShift * y ,0f), Quaternion.identity).GetComponentInChildren<TextMeshProUGUI>().text = GameObject.FindGameObjectsWithTag("Order").Length.ToString();
            Instantiate(listOfOrders[Random.Range(0, listOfOrders.Length)], new Vector3(-6.32f, 3.45f + positionShift * y ,0f), Quaternion.identity).GetComponentInChildren<TextMeshProUGUI>().text = (positionShift+1).ToString();
        }
        if(GameObject.FindGameObjectsWithTag("Order").Length >= 3){
            full = true;
        }
        else{
            full = false;
        }
    }

    bool Found(GameObject[] list, int number){
        bool check = false;
        for(int i = 0; i < list.Length; i++){
            if(list[i].GetComponentInChildren<TextMeshProUGUI>().text == number.ToString()){
                check = true;
            }
        }
        return check;
    }
}
