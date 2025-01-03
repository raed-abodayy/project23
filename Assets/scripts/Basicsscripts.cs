using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignmaent29
{
public class Basicsscripts : MonoBehaviour
{

    void Start()
    {
        var num = 5;
        //var name = "Raed";
        //var real = false;
        Debug.Log (num % 2 == 1?$"The number: {num} is odd":$"The number {num} is not odd");
        Debug.Log(System.DateTime.Now.ToShortDateString());
        Debug.Log(System.DateTime.Now.ToShortTimeString());
        Debug.Log(System.DateTime.Now.DayOfWeek);
    }
}
}