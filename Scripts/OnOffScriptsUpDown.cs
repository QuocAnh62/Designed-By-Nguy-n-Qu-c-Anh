using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffScriptsUpDown : MonoBehaviour
{
    public static OnOffScriptsUpDown instance; // For Scripts PickUpCarrot

    private void Awake()
    {
        if (instance == null) { instance = this; }
    }

    public void InActiveScripts(List<GameObject> carrot)
    {
        foreach (GameObject obj in carrot)
        {
            AnimationUpDown script = obj.GetComponent<AnimationUpDown>();
            if (script != null)  // Chỉ vô hiệu hóa nếu script tồn tại
            {
                script.enabled = false;
            }
        }
    }

    public void ActiveScripts()
    {
        foreach (GameObject obj in SpawnCarrot.instance.poolCarrot)
        {
            AnimationUpDown script = obj.GetComponent<AnimationUpDown>();
            if (script != null && !script.enabled) // if script not null and enable false. Then sey enable true
            {
                script.enabled = true;
            }
        }
    }
}
