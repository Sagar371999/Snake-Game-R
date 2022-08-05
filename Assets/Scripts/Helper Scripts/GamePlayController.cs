using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController instance;

    public GameObject fruit_PickUp, bomb_PickUp, powerUp_PickUp;

    private float min_X = -4.25f, max_X = 4.25f, min_Y = -2.26f, max_Y = 2.26f;

    private float z_Pos = 5.8f;

    private TextMeshProUGUI score_Text;

    //private TextMeshProUGUI gameOver_Text;
    private int scoreCount = 0;

    [SerializeField]
    private Button exitButtonMainGame;


    private 
    void Awake()
    {
        MakeInstance();
    }

    private void Start()
    {
        score_Text = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        
        
        Invoke("StartSpawning", 5.0f);
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void StartSpawning()
    {
        StartCoroutine(SpawnPickUps());
    }
    public void CancleSpawning()
    {
        CancelInvoke("StartSpawning");
    }

    IEnumerator SpawnPickUps()
    {
        yield return new WaitForSeconds(Random.Range(1f, 1.5f));

        if (Random.Range(0, 10) > 2)
        {
            Instantiate(fruit_PickUp, new Vector3(Random.Range(min_X, max_X), Random.Range(min_Y, max_Y),
                z_Pos), Quaternion.identity);
        }

        else if(Random.Range(0, 10) == 2)
        {
            Instantiate(bomb_PickUp, new Vector3(Random.Range(min_X, max_X), Random.Range(min_Y, max_Y),
                z_Pos), Quaternion.identity);
        }

        else
        {
            Instantiate(powerUp_PickUp, new Vector3(Random.Range(min_X, max_X), Random.Range(min_Y, max_Y),
                z_Pos), Quaternion.identity);
        }

        Invoke("StartSpawning", 1f);
    }

    public void IncreaseScore()
    {
        scoreCount += 1;
        score_Text.text = "Score : " + scoreCount;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Boot");
        //SceneManager.UnloadSceneAsync(2);
    }
}
