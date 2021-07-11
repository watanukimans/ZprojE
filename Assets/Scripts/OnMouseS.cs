using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class OnMouseS : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject thisCard;
    
    // Start is called before the first frame update
    public void OnPointerEnter(PointerEventData eventData)
    {
        Vector3 Apos = thisCard.transform.position;
        Vector3 Jpos = GameObject.FindGameObjectWithTag("Card10").transform.position;
        Vector3 Ypos = GameManager.Instance.Yajirusi.transform.position;
        //Vector3 Bpos = thisCard.transform.localPosition;
        Ypos.x = Apos.x;
        GameManager.Instance.Yajirusi.transform.position = Ypos;
        float distance = (Apos - Jpos).magnitude;
        Debug.Log(distance);
        //Y座標が100以下の時実行
        //if (Apos.y<100)
        //{
            Debug.Log("入ったよ");
            if (distance < 37)
            {
                return;
            }
            else if (distance >= 37&&distance <38)
            {
            GameManager.Instance.EmotionMinus();
                Debug.Log("1番近いカードです");
            }
            else if (distance >= 74 && distance < 75)
            {
            for(int i=0; i<2; i++)
            {
                GameManager.Instance.EmotionMinus();
            }
                Debug.Log("2番目に近いカードです");
            }
            else if (distance >= 111 && distance < 112)
            {
            for (int i = 0; i < 3; i++)
            {
                GameManager.Instance.EmotionMinus();
            }
            Debug.Log("3番目に近いカードです");
            }
            else if (distance >= 148 && distance < 149)
            {
            for (int i = 0; i < 4; i++)
            {
                GameManager.Instance.EmotionMinus();
            }
            Debug.Log("4番目に近いカードです");
            }
            else if (distance >= 185 && distance < 186)
            {
            for (int i = 0; i < 5; i++)
            {
                GameManager.Instance.EmotionMinus();
            }
            Debug.Log("5番目に近いカードです");
            }
            else if (distance >= 222 && distance < 223)
            {
            for (int i = 0; i < 6; i++)
            {
                GameManager.Instance.EmotionMinus();
            }
            Debug.Log("6番目に近いカードです");
            }
            else if (distance >= 259 && distance < 260)
            {
            for (int i = 0; i < 7; i++)
            {
                GameManager.Instance.EmotionMinus();
            }
            Debug.Log("7番目に近いカードです");
            }
            else if (distance >= 296 && distance < 297)
            {
            for (int i = 0; i < 8; i++)
            {
                GameManager.Instance.EmotionMinus();
            }
            Debug.Log("8番目に近いカードです");
            }
            else if (distance >= 333 && distance < 334)
            {
            for (int i = 0; i < 9; i++)
            {
                GameManager.Instance.EmotionMinus();
            }
            Debug.Log("9番目に近いカードです");
            }
        //}
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Vector3 Apos = thisCard.transform.position;
        Vector3 Jpos = GameObject.FindGameObjectWithTag("Card10").transform.position;
        float distance = (Apos - Jpos).magnitude;
        if (distance < 37)
        {
            return;
        }
        else if (distance >= 37 && distance < 38)
        {
            GameManager.Instance.EmotionPlus();
        }
        else if (distance >= 74 && distance < 75)
        {
            for (int i = 0; i < 2; i++)
            {
                GameManager.Instance.EmotionPlus();
            }
        }
        else if (distance >= 111 && distance < 112)
        {
            for (int i = 0; i < 3; i++)
            {
                GameManager.Instance.EmotionPlus();
            }
        }
        else if (distance >= 148 && distance < 149)
        {
            for (int i = 0; i < 4; i++)
            {
                GameManager.Instance.EmotionPlus();
            }
        }
        else if (distance >= 185 && distance < 186)
        {
            for (int i = 0; i < 5; i++)
            {
                GameManager.Instance.EmotionPlus();
            }
        }
        else if (distance >= 222 && distance < 223)
        {
            for (int i = 0; i < 6; i++)
            {
                GameManager.Instance.EmotionPlus();
            }
        }
        else if (distance >= 259 && distance < 260)
        {
            for (int i = 0; i < 7; i++)
            {
                GameManager.Instance.EmotionPlus();
            }
        }
        else if (distance >= 296 && distance < 297)
        {
            for (int i = 0; i < 8; i++)
            {
                GameManager.Instance.EmotionPlus();
            }
        }
        else if (distance >= 333 && distance < 334)
        {
            for (int i = 0; i < 9; i++)
            {
                GameManager.Instance.EmotionPlus();
            }
        }
        Debug.Log("出たよ");
    }
}
