using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    [SerializeField] private GameObject startMenuPanel;

    public void OnClickStartMenuPlayButton()
    {
        // �÷��̾��� �̸��� �����ϰ� ������ �����ϴ� StartMenuPanel�� ����.
        startMenuPanel.SetActive(true);
        Time.timeScale = 0.0f;      // �ڿ� �ִϸ��̼��� �����ϵ��� timeScale�� 0���� ����
    }

    public void OnClickStartMenuPanelPlayButton()
    {
        // ĳ���� �̸� �Ѱ��ֱ�

        // timeScale ���� -> �ΰ��� �ð��� �帣����
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("SampleScene");      // SampleScene���� ȭ�� ��ȯ
    }
}
