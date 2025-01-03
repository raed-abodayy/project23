using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

namespace Assignmaent29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public static void RepeatString(this string mstr, int nom)// nom= number of muliplier
        {
            string result = "";
            for (int i = 0; i < nom; i++)
            {
                result+=mstr;
            }
            Debug.Log(result);
        }
        
    }
}