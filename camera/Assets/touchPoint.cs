using UnityEngine;
using System.Collections;

public class touchPoint : MonoBehaviour {

    //nombre de point que rapporte l'objet
    public int value;
    public ParticleSystem particule;
    
    void OnMouseDown()
    {
               
        if (value > 0)
        {
            gest_game.score = gest_game.score + (value * gest_game.combos);
            gest_game.combos = gest_game.combos + 1;
        } else
        {
            if (gest_game.score + (value * gest_game.combos) <= 0)
            {
                gest_game.score = 0;
            }
            else
            {
                gest_game.score = gest_game.score +value ;
            }

            gest_game.combos = 1;
        }
        
        Instantiate(particule, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "deathZone")
            Destroy(gameObject);

    }
}
