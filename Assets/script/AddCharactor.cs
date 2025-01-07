using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCharactor : MonoBehaviour
{
    public GameObject uiPrefab; // 복제할 UI 프리팹
    public Transform parentTransform; // 부모로 설정할 Transform (예: Canvas)
    static int charactorNum = 0;
    public void CloneUI()
    {
        charactorNum++;
        if (uiPrefab != null && parentTransform != null)
        {
            GameObject clonedUI = Instantiate(uiPrefab, parentTransform); // 복제
            clonedUI.transform.localPosition = Vector3.zero; // 위치 초기화 (필요에 따라 조정)
            clonedUI.transform.localScale = Vector3.one; // 스케일 초기화 (필요에 따라 조정)
        }
        else
        {
            Debug.LogWarning("uiPrefab 또는 parentTransform이 설정되지 않았습니다.");
        }
    }
}