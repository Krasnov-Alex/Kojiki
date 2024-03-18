using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseAdd : MonoBehaviour
{
    public GameObject ground;
    public GameObject house;
    public int count = 4;

    void Start()
    {
        
    }

    public void NewAdd()
    {
        GameObject target = ground.gameObject.transform.GetChild(count).gameObject;
        GameObject newHouse = Instantiate(house, target.transform.position, Quaternion.identity);
        newHouse.transform.position = new Vector3(newHouse.transform.position.x, 0.3f, newHouse.transform.position.z);
        count++;
    }
}
