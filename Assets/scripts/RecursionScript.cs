using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        public int num = 7;
        public int FR(int n)
        {
            if (n == 1 || n == 0)
            {
                return n;
            }
            return FR(n - 1) + FR(n - 2);
        }
        void Start()
        {
            Debug.Log(FL(10));
            Debug.Log(FL(30)); 
            Debug.Log(FR(10));
            Debug.Log(FR(30));
        }

        public int FL(int n)
        {
            int result = 0;
            if (n == 1 || n == 0)
                return n;
            int a = 0;
            int b = 1;
            for (int i = 2; i <= n; i++)
            {
                result = b + a;
                a = b;
                b = result;

            }
            return result;
        }
    }
}