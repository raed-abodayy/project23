using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignmaent29
{
public class tstcstmobj : MonoBehaviour
{
    CustomObject tst1;
    CustomObject tst2;
    void Start()
    {
        tst1 = new CustomObject(2, "raed");
        tst2 = new CustomObject(2, "ibrahim");
        Debug.Log(tst1==tst2);
        Debug.Log(tst1!=tst2);
    }

}
}