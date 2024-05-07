using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel;      // ������\������UI-Text�I�u�W�F�N�g
    int kyori;      // ������ۑ�����ϐ�
    public Image timeGauge;
    public static float lastTime;
    // Start is called before the first frame update
    void Start()
    {
        kyori = 0;
        lastTime = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 100f;

        // �c�莞�Ԃ��O�ɂȂ�����V�[���������[�h
        if(lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }

        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km";
    }
}
