using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class GameManager : MonoBehaviour
{

    public TimeManager timeIn;
    public static GameManager I;
    
    //public GameObject Player;
    //public GameObject Enemy;
    //public GameObject Prefab_Attack;
    
    
    
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
        timeIn.EndTimer();
    }

    // �浹 �˰��� �ٸ� �� �κп� ���ؼ� gameobject�� cs ���Ͽ� �ִ°� �� �ٶ����ϴ�
    void OnTriggerEnter2D(Collider2D coll)
    {
        
    }
}
