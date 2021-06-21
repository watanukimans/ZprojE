using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform playerHand,EnemyHand;

    bool isPlayerTurn = true; 
    List<int> deck = new List<int>() {1,2,3,4,5,6,7,8,9};
    List<int> deck2 = new List<int>() {1,2,3,4,5,6,7,8,9};
    public CardEntity cardEntity;
    public float countDown = 5.0f;
    public int turn = 0;
    

    void Start()
    {
        StartGame();
    }
    void Update()
    {
        Debug.Log(countDown);
        if (countDown >= 0)
        {
            countDown -= Time.deltaTime;

        }
        else if (countDown < 0)
        {
            GameObject[] Card10 = GameObject.FindGameObjectsWithTag("Card10");
            foreach (GameObject card10 in Card10)
                GameObject.Destroy(card10);
            ChangeTurn();
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
        if (cardID == 1)
        {
            card.tag = "Card1";
        }
        if (cardID == 2)
        {
            card.tag = "Card2";
        }
        if (cardID == 3)
        {
            card.tag = "Card3";
        }
        if (cardID == 4)
        {
            card.tag = "Card4";
        }
        if (cardID == 5)
        {
            card.tag = "Card5";
        }
        if (cardID == 6)
        {
            card.tag = "Card6";
        }
        if (cardID == 7)
        {
            card.tag = "Card7";
        }
        if (cardID == 8)
        {
            card.tag = "Card8";
        }
        if (cardID == 9)
        {
            card.tag = "Card9";
        }
        if (cardID == 10)
        {
            card.tag = "Card10";
        }
    }
    public void CreateCard2(int cardID, Transform place)
    {
        CardController card = Instantiate(cardPrefab, place);
        card.Initura(cardID);
        if (cardID == 1)
        {
            card.tag = "Card1";
        }
        if (cardID == 2)
        {
            card.tag = "Card2";
        }
        if (cardID == 3)
        {
            card.tag = "Card3";
        }
        if (cardID == 4)
        {
            card.tag = "Card4";
        }
        if (cardID == 5)
        {
            card.tag = "Card5";
        }
        if (cardID == 6)
        {
            card.tag = "Card6";
        }
        if (cardID == 7)
        {
            card.tag = "Card7";
        }
        if (cardID == 8)
        {
            card.tag = "Card8";
        }
        if (cardID == 9)
        {
            card.tag = "Card9";
        }
        if (cardID == 10)
        {
            card.tag = "Card10";
        }
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
    void SetStartHand() // 手札を配る
    {
        Shuffle();
        int decknum = Random.Range(1, 3);
        switch (decknum)
        {
            case 1:
                for (int i = 0; i < 11; i++)
                {
                    DrowCard(playerHand);
                }
                for (int i = 0; i < 11; i++)
                {
                    DrowCard4(EnemyHand);
                }
                ChangeTurn();
                break;
            case 2:
                for (int i = 0; i < 11; i++)
                {
                    DrowCard2(playerHand);
                }
                for (int i = 0; i < 11; i++)
                {
                    DrowCard3(EnemyHand);
                }
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
        turn++;
        Debug.Log(turn);
        CreateCard2(10, EnemyHand);
        countDown = 5.0f;
        Debug.Log("Playerのターン");
    }

    void EnemyTurn()
    {
        turn++;
        Debug.Log(turn);
        CreateCard(10, playerHand);
        countDown = 5.0f;
        Debug.Log("Enemyのターン");
    }
    void Shuffle ()
    {
        int n = deck.Count;
        while(n>1)
        { n--;
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
}
