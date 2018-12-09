using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullheart;
    public Sprite emptyHeart;

    void Update()
    {   
        // gerir þanning að helathið getur ekki verið meira en það sem er
        // buið að skillgreina mörg hjörtu t.d. default hjá mér er 4.
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            // skoðar ef health er minna en i
            if(i < health)
            {
                hearts[i].sprite = fullheart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            // skoðar hvað eru mörg hjörtu og ef það er meira en numOfHearts þá displayer
            // það ekki(þau auka hjörtu sem eiga ekki að vera.
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
