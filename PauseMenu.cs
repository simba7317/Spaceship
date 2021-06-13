using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
  [SerializeField]
  private GameObject go_BaseUi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(!GameManager.isPause)
               CallMenu();
            else
               CloseMenu();
        }
    }

    private void CallMenu()
    {
    GameManager.isPause = true;
    go_BaseUi.SetActive(true);
    Time.timeScale = 0f;
    }

    private void CloseMenu()
    {
    GameManager.isPause = false;
    go_BaseUi.SetActive(false);
    Time.timeScale = 1f;
    }

    public void ClickSave()
    {
    Debug.Log("세이브");
    }

    public void ClickLoad()
    {
    Debug.Log("로드");
    }

    public void ClickExit()
    {
    Debug.Log("게임종료");
    Application.Quit();
    }
}
