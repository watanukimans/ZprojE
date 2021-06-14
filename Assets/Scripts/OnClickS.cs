using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnClickS : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject panel;
    public Image cardImage;
    public Sprite ace;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;
    public Sprite joker;

    public void OnPointerClick(PointerEventData eventData)
    {
        //Y座標を移動
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        pos.y -= 200f;
        myTransform.position = pos;
        // クリックされた時に行いたい処理
        Debug.Log("押されたよ");
        if (this.gameObject.CompareTag("Card1"))
        {
            cardImage.sprite = ace;
            //Destroy(this.gameObject);
            GameObject[] Card1 = GameObject.FindGameObjectsWithTag("Card1");
            foreach (GameObject card1 in Card1)
                GameObject.Destroy(card1,2.0f);
        }
        if (this.gameObject.CompareTag("Card2"))
        {
            cardImage.sprite = two;
            //Destroy(this.gameObject);
            GameObject[] Card2 = GameObject.FindGameObjectsWithTag("Card2");
            foreach (GameObject card2 in Card2)
                GameObject.Destroy(card2, 2.0f);
        }
        if (this.gameObject.CompareTag("Card3"))
        {
            cardImage.sprite = three;
            //Destroy(this.gameObject);
            GameObject[] Card3 = GameObject.FindGameObjectsWithTag("Card3");
            foreach (GameObject card3 in Card3)
                GameObject.Destroy(card3, 2.0f);
        }
        if (this.gameObject.CompareTag("Card4"))
        {
            cardImage.sprite = four;
            //Destroy(this.gameObject);
            GameObject[] Card4 = GameObject.FindGameObjectsWithTag("Card4");
            foreach (GameObject card4 in Card4)
                GameObject.Destroy(card4, 2.0f);
        }
        if (this.gameObject.CompareTag("Card5"))
        {
            cardImage.sprite = five;
            //Destroy(this.gameObject);
            GameObject[] Card5 = GameObject.FindGameObjectsWithTag("Card5");
            foreach (GameObject card5 in Card5)
                GameObject.Destroy(card5, 2.0f);
        }
        if (this.gameObject.CompareTag("Card6"))
        {
            cardImage.sprite = six;
            //Destroy(this.gameObject);
            GameObject[] Card6 = GameObject.FindGameObjectsWithTag("Card6");
            foreach (GameObject card6 in Card6)
                GameObject.Destroy(card6, 2.0f);
        }
        if (this.gameObject.CompareTag("Card7"))
        {
            cardImage.sprite = seven;
            //Destroy(this.gameObject);
            GameObject[] Card7 = GameObject.FindGameObjectsWithTag("Card7");
            foreach (GameObject card7 in Card7)
                GameObject.Destroy(card7, 2.0f);
        }
        if (this.gameObject.CompareTag("Card8"))
        {
            cardImage.sprite = eight;
            //Destroy(this.gameObject);
            GameObject[] Card8 = GameObject.FindGameObjectsWithTag("Card8");
            foreach (GameObject card8 in Card8)
                GameObject.Destroy(card8, 2.0f);
        }
        if (this.gameObject.CompareTag("Card9"))
        {
            cardImage.sprite = nine;
            //Destroy(this.gameObject);
            GameObject[] Card9 = GameObject.FindGameObjectsWithTag("Card9");
            foreach (GameObject card9 in Card9)
                GameObject.Destroy(card9, 2.0f);
        }
        if (this.gameObject.CompareTag("Card10"))
        {
            cardImage.sprite = joker;
            GameObject[] Card10 = GameObject.FindGameObjectsWithTag("Card10");
            foreach (GameObject card10 in Card10)
                GameObject.Destroy(card10, 2.0f);
        }
    }
}
