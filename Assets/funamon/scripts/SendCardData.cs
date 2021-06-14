using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendCardData : MonoBehaviour
{
    GameObject MainBrain; //自身のネットワークオブジェクトを格納
    // Start is called before the first frame update
    void Start()
    {
        MainBrain = TestScene.My;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click1() //カードをクリックする
    {
        MainBrain.SendMessage("Select", this.gameObject.name);
    }
}
