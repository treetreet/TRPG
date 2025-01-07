using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCharactor : MonoBehaviour
{
    public GameObject uiPrefab; // ������ UI ������
    public Transform parentTransform; // �θ�� ������ Transform (��: Canvas)
    static int charactorNum = 0;
    public void CloneUI()
    {
        charactorNum++;
        if (uiPrefab != null && parentTransform != null)
        {
            GameObject clonedUI = Instantiate(uiPrefab, parentTransform); // ����
            clonedUI.transform.localPosition = Vector3.zero; // ��ġ �ʱ�ȭ (�ʿ信 ���� ����)
            clonedUI.transform.localScale = Vector3.one; // ������ �ʱ�ȭ (�ʿ信 ���� ����)
        }
        else
        {
            Debug.LogWarning("uiPrefab �Ǵ� parentTransform�� �������� �ʾҽ��ϴ�.");
        }
    }
}