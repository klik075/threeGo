using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TimeManager I;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void makeEnemy()
    {
        //Instantiate(); //gameObject ����
    }

    public void gameOver()
    {
        //�������� �� ����Ǿ��ٰ� ȭ���� �˾��Ǿ�� ��

        //time ������ 0���� �ʱ�ȭ
        I.EndTimer();
    }
}
