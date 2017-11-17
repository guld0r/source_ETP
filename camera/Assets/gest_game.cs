using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gest_game : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject[] listItem;
    public Camera cam;
    public Text TCombos;
    public Text TScore;
    public Canvas canEnd;

    public float timeLeft = 2f;
    public Text timer;
    //Variable globale de score/combos pour le minijeu
    public static int score =0;
    public static int combos = 1;

    private Vector3 scale;
    private int j;



    // Use this for initialization
    void Start () {
        j = 0;
        scale = new Vector3(Screen.width,Screen.height, 1f);
        //print(Screen.width);
        //cam.aspect = (Screen.currentResolution.width / Screen.currentResolution.height);
        TCombos.text = combos.ToString();


    }
	
	// Update is called once per frame
	void FixedUpdate () {
        j++;
        //int randObj = Random.Range(0, listItem.Length);

        if (j % 10 == 0)
        {
            //int i = Random.Range(-37, 37);
            Instantiate(listItem[0], new Vector3(Random.Range(-37, 37), spawnPoint.position.y, 40f), Quaternion.identity);
            
        }
        if (j % 50 == 0)
        {
            Instantiate(listItem[1], new Vector3(Random.Range(-37, 37), spawnPoint.position.y, 40f), Quaternion.identity);
        }

        if (j % 40 == 0)
        {
            Instantiate(listItem[2], new Vector3(Random.Range(-37, 37), spawnPoint.position.y, 40f), Quaternion.identity);
        }


        TCombos.text = combos.ToString();
        TScore.text = score.ToString();      }

    public void Update()
    {
        timeLeft -= Time.deltaTime;
        timer.text = timeLeft.ToString();

        if(timeLeft <= 1)
        {
            timer.text = 0.ToString();
           canEnd.enabled = true;
            Time.timeScale = 0;
        }
    }

}
