using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderAssembly : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] listOfItems;
    GameObject prefabItem;
    
    bool firstOrder = false;
    bool secondOrder = false;
    bool thirdOrder = false;

    KeyCode key;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartOrder();
        if(GameObject.FindGameObjectsWithTag("Ingredients").Length == 0){
            firstOrder = false;
            secondOrder = false;
            thirdOrder = false;
        }
    }

    void StartOrder(){
        if(Input.GetKeyDown("1") && !firstOrder){
            GameObject existItem = GameObject.FindGameObjectWithTag("Ingredients");
            if(existItem != null){
                Destroy(existItem);
            }

            GameObject[] listOfOrders = GameObject.FindGameObjectsWithTag("Order");
            foreach(GameObject order in listOfOrders){
                if(order.GetComponentInChildren<TextMeshProUGUI>().text == "1"){
                    name = order.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
                }
            }
            //string name = listOfOrders[0].GetComponentsInChildren<TextMeshProUGUI>()[1].text;
            foreach(GameObject item in listOfItems){
                if(item.name == name){
                    prefabItem = item;
                    break;
                }
            }
            Instantiate(prefabItem);
            
            firstOrder = true;
            secondOrder = false;
            thirdOrder = false;
        }
        if(Input.GetKeyDown("2") && !secondOrder){
            GameObject existItem = GameObject.FindGameObjectWithTag("Ingredients");
            if(existItem != null){
                Destroy(existItem);
            }
            
            GameObject[] listOfOrders = GameObject.FindGameObjectsWithTag("Order");
            foreach(GameObject order in listOfOrders){
                if(order.GetComponentInChildren<TextMeshProUGUI>().text == "2"){
                    name = order.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
                }
            }
            //string name = listOfOrders[1].GetComponentsInChildren<TextMeshProUGUI>()[1].text;
            foreach(GameObject item in listOfItems){
                if(item.name == name){
                    prefabItem = item;
                    break;
                }
            }
            Instantiate(prefabItem);

            firstOrder = false;
            secondOrder = true;
            thirdOrder = false;
        }
        if(Input.GetKeyDown("3") && !thirdOrder){
            GameObject existItem = GameObject.FindGameObjectWithTag("Ingredients");
            if(existItem != null){
                Destroy(existItem);
            }
            
            GameObject[] listOfOrders = GameObject.FindGameObjectsWithTag("Order");
            foreach(GameObject order in listOfOrders){
                if(order.GetComponentInChildren<TextMeshProUGUI>().text == "3"){
                    name = order.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
                }
            }
            //string name = listOfOrders[2].GetComponentsInChildren<TextMeshProUGUI>()[1].text;
            foreach(GameObject item in listOfItems){
                if(item.name == name){
                    prefabItem = item;
                    break;
                }
            }
            Instantiate(prefabItem);
            
            firstOrder = false;
            secondOrder = false;
            thirdOrder = false;
        }
    }
}
