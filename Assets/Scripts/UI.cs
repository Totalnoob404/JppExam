using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class UI : MonoBehaviour
{
    [SerializeField] Button sphereButton;
    [SerializeField] Button cylinderButton;
    [SerializeField] List<GameObject> playerObjects;


    public void StartGame(int number)
    {
        GameManager.Instance.playerObject = playerObjects[number];
        SceneManager.LoadScene(1);
    }
}
