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
        //thisCard = GameManager.Instance.allCard;
        Vector3 Apos = thisCard.transform.position;
        Vector3 Jpos = GameObject.FindGameObjectWithTag("Card10").transform.position;
        float distance = (Apos - Jpos).magnitude;
        Debug.Log(distance);
        //Y座標が100以下の時実行
        if (Apos.y<100)
        {
            Debug.Log("入ったよ");
            if (distance < 47)
            {
                return;
            }
            else if (distance >= 47&&distance <48)
            {
                Debug.Log("1番近いカードです");
            }
            else if (distance >= 95 && distance < 96)
            {
                Debug.Log("2番目に近いカードです");
            }
            else if (distance >= 143 && distance < 144)
            {
                Debug.Log("3番目に近いカードです");
            }
            else if (distance >= 190 && distance < 191)
            {
                Debug.Log("4番目に近いカードです");
            }
            else if (distance >= 238 && distance < 239)
            {
                Debug.Log("5番目に近いカードです");
            }
            else if (distance >= 286 && distance < 297)
            {
                Debug.Log("6番目に近いカードです");
            }
            else if (distance >= 333 && distance < 334)
            {
                Debug.Log("7番目に近いカードです");
            }
            else if (distance >= 381 && distance < 382)
            {
                Debug.Log("8番目に近いカードです");
            }
            else if (distance >= 429 && distance < 430)
            {
                Debug.Log("9番目に近いカードです");
            }
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("出たよ");
    }
}
