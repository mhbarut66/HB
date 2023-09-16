using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAdmin : MonoBehaviour
{
    [SerializeField] private GameObject cameraAnim;
    [SerializeField] private GameObject RollingCircle;
    [SerializeField] private GameObject Spawner;
    [SerializeField] private GameObject RestartButton;
    [SerializeField] private GameObject ScoreText;
    public void FinishGame()
    {
        Debug.Log("Oyun Bitir Çağırıldı");
        Spawner.GetComponent<Spawner>().enabled = false;
        RollingCircle.GetComponent<RollingCircle>().enabled = false;
        cameraAnim.GetComponent<CameraAnim>().CameraAnimation();
        ScoreText.transform.position = new Vector2(90, 295);
        Invoke("RestartGame",1f);
    }

    private void RestartGame()
    {
        RestartButton.SetActive(true);
        RestartButton.gameObject.SetActive(true);
    }
}
