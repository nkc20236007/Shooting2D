using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPre; // �G�̃v���n�u��ۑ�����ϐ�
    float delta; // �o�ߎ��Ԍv�Z�p
    float Span;
    // Start is called before the first frame update
    void Start()
    {
        delta = 0;
        Span = 1;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > Span)
        {
            //  ���Ԍo�߂�ۑ����Ă���ϐ����O�ɃN���A����
            delta = 0;

            // �G���o���Ԋu�����X�ɒZ������
            Span -= 0.01f;
            // �G�𐶐�����
            GameObject go = Instantiate(EnemyPre);
            int py = Random.Range(-6, 7);
            go.transform.position = new Vector3(10, py, 0);

 
        }
    }
}
