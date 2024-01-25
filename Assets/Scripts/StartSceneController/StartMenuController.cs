using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    [SerializeField] private GameObject startMenuPanel;

    public void OnClickStartMenuPlayButton()
    {
        // 플레이어의 이름을 선택하고 게임을 시작하는 StartMenuPanel을 띄운다.
        startMenuPanel.SetActive(true);
        Time.timeScale = 0.0f;      // 뒤에 애니메이션이 정지하도록 timeScale을 0으로 변경
    }

    public void OnClickStartMenuPanelPlayButton()
    {
        // 캐릭터 이름 넘겨주기

        // timeScale 변경 -> 인게임 시간이 흐르도록
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("SampleScene");      // SampleScene으로 화면 전환
    }
}
