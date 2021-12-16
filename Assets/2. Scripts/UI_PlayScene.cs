using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_PlayScene : MonoBehaviour
{
    [Tooltip("Fade ������Ʈ �޾ƿ���")]
    [SerializeField] private UI_Died fade;

    // DiedScene���� �Ѿ���� FadeOut�ϴ� ����
    void Start()
    {
        StartCoroutine(toDiedScene());
    }
    public IEnumerator toDiedScene()
    {
        yield return new WaitForSeconds(0.5f);
        fade.Fade();
        yield return null;
    }
}
