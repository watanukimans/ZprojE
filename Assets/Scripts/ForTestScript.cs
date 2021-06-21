using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //OnClickS用
    void ReDeck(int n)
    {
        int deCard = GameManager.Instance.dCard;
        if (deCard == 1)
        {
            GameManager.Instance.t1 = n;
        }
        if (deCard == 2)
        {
            GameManager.Instance.t2 = n;
        }
        if (deCard == 3)
        {
            GameManager.Instance.t3 = n;
        }
        if (deCard == 4)
        {
            GameManager.Instance.t4 = n;
        }
        if (deCard == 5)
        {
            GameManager.Instance.t5 = n;
        }
        if (deCard == 6)
        {
            GameManager.Instance.t6 = n;
        }
        if (deCard == 7)
        {
            GameManager.Instance.t7 = n;
        }
        if (deCard == 8)
        {
            GameManager.Instance.t8 = n;
        }
        if (deCard == 9)
        {
            GameManager.Instance.t9 = n;
        }

    }
}
