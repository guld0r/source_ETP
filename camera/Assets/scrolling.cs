using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Parallax scrolling script that should be assigned to a layer
/// </summary>
public class scrolling : MonoBehaviour
{
    /// <summary>
    /// Scrolling speed
    /// </summary>
    public Vector2 speed = new Vector2(2, 2);

    /// <summary>
    /// Moving direction
    /// </summary>
    public Vector2 direction = new Vector2(-1, 0);

    public SpriteRenderer[] background;

    public Camera mainCam;

    public GameObject[] obstacles;

    public GameObject SpawZone;

    private int j;

    public float timeVict = 30;

    public Text VictText;

    public Canvas Victory;
    public Canvas Ui;
    public Canvas pausecan;

    public Button BtnPause;

    private void Start()
    {
        BtnPause.onClick.AddListener(pause);
    }


    void Update()
    {
        // Movement
        Vector3 movement = new Vector3(
          speed.x * direction.x,
          speed.y * direction.y,
          0);
        
        movement *= Time.deltaTime;
        transform.Translate(movement);

        mainCam.transform.position = new Vector3(transform.position.x+8.5f,0,-10);

        VictText.text = timeVict.ToString();
        timeVict -= Time.deltaTime;

        if (timeVict <= 0)
        {
            Time.timeScale = 0.0f;
            Ui.enabled = false;
            Victory.enabled = true;
        }


        if (background[0].IsVisibleFrom(Camera.main) == false)
        {
            SpriteRenderer swap;
            swap = background[0];

            background[0].transform.position = new Vector3(background[1].transform.position.x + background[1].bounds.size.x-0.5f, 0, 4);

            
            background[0] = background[1];
            background[1] = swap;
        }

        




    }

  

    void FixedUpdate()
    {
        j++;
        print(j);
        if ( j % 80 == 0)
        {
            Instantiate(obstacles[Random.Range(0, obstacles.Length-1)], SpawZone.transform.position, Quaternion.identity);


        }
    }
    
    public void pause()
    {
        Time.timeScale = 0.0f;
        Ui.enabled = false;
        pausecan.enabled = true;
    }

    public void restart() {
        
            Time.timeScale = 1f;
            Ui.enabled = true;
            pausecan.enabled = false;
        }





}


