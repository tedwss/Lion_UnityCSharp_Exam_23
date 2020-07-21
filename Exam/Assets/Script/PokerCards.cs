using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class PokerCards : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();

    private string[] type = { "Spades", "Heart", "Diamond", "Club" };

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(0.1f);

        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.eulerAngles = new Vector3(180, 0, 0);
            child.localScale = Vector3.one * 20;
            float x = i % 13;
            int y = i / 13;
            child.position = new Vector3((i - 6) * 1.3f, 0, 0);

            yield return null;
        }
        GetAllCard();

        var start = from card in cards
                   where card.name.Contains(type[3]) || card.name.Contains(type[2]) || card.name.Contains(type[1]) || card.name.Contains(type[0])
                   select card;

        foreach (var item in start) Instantiate(item, transform);

        StartCoroutine(SetChildPosition());

        SetChildPosition();
    }

    private void GetAllCard()
    {
        if (cards.Count == 52) return;

        for (int i = 0; i < type.Length; i++)
        {
            for (int j = 1; j < 14; j++)
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

    private void DeleteAllChild()
    {
        for (int i = 0; i < transform.childCount; i++)
            Destroy(transform.GetChild(i).gameObject);        
    }

    private IEnumerator SetChildPosition()
    {
        yield return new WaitForSeconds(0.1f);

        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.eulerAngles = new Vector3(180, 0, 0);
            child.localScale = Vector3.one * 20;
            float x = i % 13;
            int y = i / 13;
            child.position = new Vector3((i - 6) * 1.3f, 0, 0);

            yield return null;
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("第四題");
        }
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("第一題");
        }
    }

}
