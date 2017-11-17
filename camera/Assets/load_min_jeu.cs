using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class load_min_jeu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(loadScene);
	}
	void loadScene()
    {
        SceneManager.LoadScene("mini_jeu_fruit");
       
    }
}
