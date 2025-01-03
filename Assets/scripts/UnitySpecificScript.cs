using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignmaent29
{
public class UnitySpecificScript : MonoBehaviour
{
    public GameObject TargetObject;

    void OnEnable()
    {
        print("GameObject is Enabled");
    }

    void OnDisable()
    {
        print("GameObject is Disabled");
    }
    void Start()
    {
        print("Game started!");
        GameObject target = GameObject.Find("TargetObject");

        if (target)
        {
            print(target.name);
        }
        else
        {
            print(" TargetObject not found.");
        }


        GameObject joker = GameObject.FindGameObjectWithTag("Joker");

        if (joker)
        {
            print(joker.name);
        }
        else
        {
            print(" joker not found.");
        }

        Light light = GameObject.FindObjectOfType<Light>();

        if (light)
        {
            print(light.name);
        }
        else
        {
            print("light not  found.");
        }

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            TargetObject.SetActive(false);
            print("TargetObject is deactivated!");
        }

    }
}
}