using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector3.zero; // �ړ�������ۑ�����ϐ�
    Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        // �A�j���[�^�[�R���|�[�l���g�̏���ۑ�
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5;
        // �ړ��������Z�b�g
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        // ��ʓ��ړ�����
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        // �A�j���[�V�����ݒ�
        if(dir.y == 0)
        {
            // �A�j���[�V�����N���b�v�yPlayer�z���Đ�
            anime.Play("Player");
        }
        else if(dir.y == 1)
        {
            anime.Play("PlayerL");
        }
        else if (dir.y == -1)
        {
            anime.Play("PlayerR");
        }
    }
}
