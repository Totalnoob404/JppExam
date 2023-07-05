using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{

    [SerializeField] Button returnButton;
    [SerializeField] GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(GameManager.Instance.playerObject, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
