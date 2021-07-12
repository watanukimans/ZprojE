using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform playerHand,EnemyHand;

    bool isPlayerTurn = true; 
    List<int> deck = new List<int>() {};
    List<int> deck2 = new List<int>() {};
    public CardEntity cardEntity;
    public float countDown = 5.0f;
    public int turn = 0;
    public int decknum;
    //テスト用
    public int dCard;
    public int t1;
    public int t2;
    public int t3;
    public int t4;
    public int t5;
    public int t6;
    public int t7;
    public int t8;
    public int t9;
    public Image UIobj;
    public float countTime = 5.0f;

    //funamon変数
    public GameObject PlayerDeck;
    public GameObject EnemyDeck;


    void Start()
    {
        StartGame();
    }
    void Update()
    {
        //Debug.Log("相手のターンまで"+countDown);
        if (countDown >= 0)
        {
            countDown -= Time.deltaTime;
            UIobj.fillAmount -= 1.0f / countTime*Time.deltaTime;
        }
        else if (countDown < 0)
        {
            GameObject[] Card10 = GameObject.FindGameObjectsWithTag("Card10");
            foreach (GameObject card10 in Card10)
                GameObject.Destroy(card10);
            ChangeTurn();
        }

        //funamon
        
        if (isPlayerTurn) //プレイヤーがカードを引く
        {
            PlayerDeck.transform.position = new Vector3(450, 800, 0);
            EnemyDeck.transform.position = new Vector3(450, 100, 0);
        }
        else
        {
            PlayerDeck.transform.position = new Vector3(450, 100, 0);
            EnemyDeck.transform.position = new Vector3(450, 800, 0);
        }
        

    }
    void StartGame()
    {
        // 初期手札を配る
        SetStartHand();

        // ターンの決定
        //TurnCalc();
    }

    public void CreateCard(int cardID, Transform place)
    {
        CardController card = Instantiate(cardPrefab, place);
        card.Init(cardID);
        //お試し用4行
        card.tag = "Card" + cardID;
    }
    public void CreateCard2(int cardID, Transform place)
    {
        CardController card = Instantiate(cardPrefab, place);
        card.Initura(cardID);
        card.tag = "Card" + cardID;
    }
    void DrowCard(Transform hand) // カードを引く
    {
        // デッキがないなら引かない
        if (deck.Count == 0)
        {
            return;
        }

        // デッキの一番上のカードを抜き取り、手札に加える
        int cardID = deck[0];
        deck.RemoveAt(0);
        CreateCard(cardID, hand);
    }
    void DrowCard2(Transform hand) // カードを引く
    {
        // デッキがないなら引かない
        if (deck2.Count == 0)
        {
            return;
        }

        // デッキの一番上のカードを抜き取り、手札に加える
        int cardID = deck2[0];
        deck2.RemoveAt(0);
        CreateCard2(cardID, hand);
    }
    /*
    void DrowCard2(Transform hand) // カードを引く
    {
        // デッキがないなら引かない
        if (deck2.Count == 0)
        {
            return;
        }

        // デッキの一番上のカードを抜き取り、手札に加える
        int cardID = deck2[0];
        deck2.RemoveAt(0);
        CreateCard(cardID, hand);
    }
    void DrowCard3(Transform hand) // カードを引く
    {
        // デッキがないなら引かない
        if (deck.Count == 0)
        {
            return;
        }

        // デッキの一番上のカードを抜き取り、手札に加える
        int cardID = deck[0];
        deck.RemoveAt(0);
        CreateCard2(cardID, hand);
    }
    void DrowCard4(Transform hand) // カードを引く
    {
        // デッキがないなら引かない
        if (deck2.Count == 0)
        {
            return;
        }

        // デッキの一番上のカードを抜き取り、手札に加える
        int cardID = deck2[0];
        deck2.RemoveAt(0);
        CreateCard2(cardID, hand);
    }
    */
    void SetStartHand() // 手札を配る
    {
        //Shuffle();
        decknum = Random.Range(1, 3);
        switch (decknum)
        {
            case 1: //自分ジョーカー
                /*
                for (int i = 0; i < 11; i++)
                {
                    DrowCard(playerHand);
                }
                for (int i = 0; i < 11; i++)
                {
                    DrowCard4(EnemyHand);
                }
                */
                ChangeTurn();
                break;
            case 2: //相手ジョーカー
                /*
                for (int i = 0; i < 11; i++)
                {
                    DrowCard2(playerHand);
                }
                for (int i = 0; i < 11; i++)
                {
                    DrowCard3(EnemyHand);
                }
                */
                PlayerTurn();
                break;
        }
    }
    void TurnCalc() // ターンを管理する
    {
        if (isPlayerTurn)
        {
            PlayerTurn();
        }
        else
        {
            EnemyTurn();
        }
    }
    public void ChangeTurn() // ターンエンド処理
    {
        isPlayerTurn = !isPlayerTurn; // ターンを逆にする
        TurnCalc(); // ターンを相手に回す
    }
    void PlayerTurn()
    {
        MaxGauge();
        SetHand();
        turn++;
        Debug.Log(turn);
        //CreateCard2(10, EnemyHand);
        countDown = 5.0f;
        Debug.Log("Playerのターン");
    }

    void EnemyTurn()
    {
        MaxGauge();
        SetHand();
        turn++;
        Debug.Log(turn);
        //CreateCard(10, playerHand);
        countDown = 5.0f;
        Debug.Log("Enemyのターン");
    }
    void Shuffle()
    {
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = UnityEngine.Random.Range(0, n + 1);
            int temp = deck[k];
            deck[k] = deck[n];
            deck[n] = temp;
        }
        int m = deck2.Count;
        while (m > 1)
        {
            m--;
            int l = UnityEngine.Random.Range(0, m + 1);
            int temp2 = deck2[l];
            deck2[l] = deck2[m];
            deck2[m] = temp2;
        }
    }
    //ここから下未実装
    void SetHand()
    {
        //ターンごとの手札シャッフル
        ReShuffle();
        Shuffle();
        for (int i = 0; i < 11; i++)
        {
            DrowCard(playerHand);
        }
        for (int i = 0; i < 11; i++)
        {
            DrowCard2(EnemyHand);
        }
    }
    void ReShuffle()
    //ターンごとのデッキリストを定義
    {
        DeleteCard();
        Debug.Log(dCard);
        for (int n = 1; n < 11; n++)
        {
            deck.Remove(n);
            deck2.Remove(n);
        }
        for (int n = 1; n < 10; n++)
        {
            deck.Add(n);
            deck2.Add(n);
        }
        if (isPlayerTurn == true)
            {
                deck2.Add(10);
            }
            else
            {
                deck.Add(10);
            }
        if (dCard == 1)
        {
            deck.Remove(t1);
            deck2.Remove(t1);
        }
        if (dCard == 2)
        {
            deck.Remove(t1);
            deck.Remove(t2);
            deck2.Remove(t1);
            deck2.Remove(t2);
        }
        if (dCard == 3)
        {
            deck.Remove(t1);
            deck.Remove(t2);
            deck.Remove(t3);
            deck2.Remove(t1);
            deck2.Remove(t2);
            deck2.Remove(t3);
        }
        if (dCard == 4)
        {
            deck.Remove(t1);
            deck.Remove(t2);
            deck.Remove(t3);
            deck.Remove(t4);
            deck2.Remove(t1);
            deck2.Remove(t2);
            deck2.Remove(t3);
            deck2.Remove(t4);
        }
        if (dCard == 5)
        {
            deck.Remove(t1);
            deck.Remove(t2);
            deck.Remove(t3);
            deck.Remove(t4);
            deck.Remove(t5);
            deck2.Remove(t1);
            deck2.Remove(t2);
            deck2.Remove(t3);
            deck2.Remove(t4);
            deck2.Remove(t5);
        }
        if (dCard == 6)
        {
            deck.Remove(t1);
            deck.Remove(t2);
            deck.Remove(t3);
            deck.Remove(t4);
            deck.Remove(t5);
            deck.Remove(t6);
            deck2.Remove(t1);
            deck2.Remove(t2);
            deck2.Remove(t3);
            deck2.Remove(t4);
            deck2.Remove(t5);
            deck2.Remove(t6);
        }
        if (dCard == 7)
        {
            deck.Remove(t1);
            deck.Remove(t2);
            deck.Remove(t3);
            deck.Remove(t4);
            deck.Remove(t5);
            deck.Remove(t6);
            deck.Remove(t7);
            deck2.Remove(t1);
            deck2.Remove(t2);
            deck2.Remove(t3);
            deck2.Remove(t4);
            deck2.Remove(t5);
            deck2.Remove(t6);
            deck2.Remove(t7);
        }
        if (dCard == 8)
        {
            deck.Remove(t1);
            deck.Remove(t2);
            deck.Remove(t3);
            deck.Remove(t4);
            deck.Remove(t5);
            deck.Remove(t6);
            deck.Remove(t7);
            deck.Remove(t8);
            deck2.Remove(t1);
            deck2.Remove(t2);
            deck2.Remove(t3);
            deck2.Remove(t4);
            deck2.Remove(t5);
            deck2.Remove(t6);
            deck2.Remove(t7);
            deck2.Remove(t8);
        }
        if (dCard == 9)
        {
            deck.Remove(t1);
            deck.Remove(t2);
            deck.Remove(t3);
            deck.Remove(t4);
            deck.Remove(t5);
            deck.Remove(t6);
            deck.Remove(t7);
            deck.Remove(t8);
            deck.Remove(t9);
            deck2.Remove(t1);
            deck2.Remove(t2);
            deck2.Remove(t3);
            deck2.Remove(t4);
            deck2.Remove(t5);
            deck2.Remove(t6);
            deck2.Remove(t7);
            deck2.Remove(t8);
            deck2.Remove(t9);
            //勝利条件を満たした
        }
    }
    void DeleteCard()
    {
        GameObject[] Card1 = GameObject.FindGameObjectsWithTag("Card1");
        foreach (GameObject card1 in Card1)
            GameObject.Destroy(card1);
        GameObject[] Card2 = GameObject.FindGameObjectsWithTag("Card2");
        foreach (GameObject card2 in Card2)
            GameObject.Destroy(card2);
        GameObject[] Card3 = GameObject.FindGameObjectsWithTag("Card3");
        foreach (GameObject card3 in Card3)
            GameObject.Destroy(card3);
        GameObject[] Card4 = GameObject.FindGameObjectsWithTag("Card4");
        foreach (GameObject card4 in Card4)
            GameObject.Destroy(card4);
        GameObject[] Card5 = GameObject.FindGameObjectsWithTag("Card5");
        foreach (GameObject card5 in Card5)
            GameObject.Destroy(card5);
        GameObject[] Card6 = GameObject.FindGameObjectsWithTag("Card6");
        foreach (GameObject card6 in Card6)
            GameObject.Destroy(card6);
        GameObject[] Card7 = GameObject.FindGameObjectsWithTag("Card7");
        foreach (GameObject card7 in Card7)
            GameObject.Destroy(card7);
        GameObject[] Card8 = GameObject.FindGameObjectsWithTag("Card8");
        foreach (GameObject card8 in Card8)
            GameObject.Destroy(card8);
        GameObject[] Card9 = GameObject.FindGameObjectsWithTag("Card9");
        foreach (GameObject card9 in Card9)
            GameObject.Destroy(card9);
    }
    public void MaxGauge()
    {
        UIobj.fillAmount = 1;
    }

}
