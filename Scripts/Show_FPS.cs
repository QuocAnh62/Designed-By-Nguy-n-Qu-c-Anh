using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Show_FPS : MonoBehaviour
{
    private float deltaTime = 0.0f;
    public TMP_Text fpsText;

    private void Start()
    {
        Application.targetFrameRate = 75;
        QualitySettings.vSyncCount = 0;
    }

    void Update()
    {
        //ShowFPS();
    }

    private void ShowFPS()
    {
        // Tính toán thời gian trôi qua giữa các khung hình
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;

        // Tính toán FPS
        float fps = 1.0f / deltaTime;

        // Cập nhật văn bản hiển thị
        fpsText.text = $"FPS: {Mathf.Ceil(fps)}";
    }
    //void OnGUI()
    //{
    //    if (Event.current.type == EventType.Repaint)
    //    {
    //        // Đây là nơi diễn ra vẽ lại giao diện
    //        Debug.Log("Đang trong sự kiện GUI.Repaint");
    //    }

    //    // Các thành phần GUI khác, như Button hoặc Label
    //    GUILayout.Label("Hello, GUI!");
    //}
}
