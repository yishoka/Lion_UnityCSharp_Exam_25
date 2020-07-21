using System.Collections;
using System.Collections.Generic;   // List
using UnityEngine;
using System.Linq;                  // 查詢

[ExecuteInEditMode]
public class Card : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();

    private string[] type = { "Spades", "Diamond", "Heart", "Club" };


    private void Start()
    {
        GetAllCard();
    }

    private void GetAllCard()
    {
        if (cards.Count == 52) return;

        for (int i = 0; i < type.Length; i++)
        {
            for (int j = 0; j < 14 ; j++)
            {
                string number = j.ToString();

                switch (j)
                {
                    case 1:
                        number = "A";
                        break;
                    case 11:
                        number = "J";
                        break;
                    case 12:
                        number = "Q";
                        break;
                    case 13:
                        number = "K";
                        break;
                }

                GameObject card = Resources.Load<GameObject>("PlayingCards_" + number + type[i]);

                cards.Add(card);
            }
        }
    }

    /// <summary>
    /// 透過花色選取卡牌
    /// </summary>
    /// <param name="type">花色</param>
    public void ChooseCardByType(string type)
    {
        // 暫存牌組
        var temp = cards.Where((x) => x.name.Contains(type));

        // 迴圈 遍尋 暫存牌組 生成
        foreach (var item in temp) Instantiate(item, transform);
    }

    /// <summary>
    /// 排序：花色、數字由小到大
    /// </summary>
    public void Sort()
    {

        //var sort = from card in cards
        //           where card.name.Contains(type)[3]) || card.name.Contains(type)[2]) || card.name.Contains(type)[1]) || card.name.Contains(type)[0])
        //           select card;
    }
}
