using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class IntroLetter : MonoBehaviour
{
    public Text introtext;
    public GameObject buttonIntroLetter;
    public GameObject buttonNext;

    private void Start()
    {
        introtext.DOText("�ȳ��ϼ���, Z-CITY�� ���ֹ� ������.\r\nZ-CITY TIMES�� �������ּż� �����մϴ�." +
            "\r\n�츮�� ���� ���ǷӰ� �Ƹ��ٿ� ���ø� �����ϱ� ����\r\n�� �������ٵ� �ּ��� ���ϰ� �ֽ��ϴ�." +
            "\r\n\r\n�����Ͻ� �Ź��� �����÷��� AR Glass�� �������ֽð� �Ź��� �ٿ�ε� �� �ּ���.\r\n\r\n���õ� ���� �Ϸ�ǽñ� �ٶ�ڽ��ϴ�." +
            " \r\n\r\n�����մϴ�.", 10).SetEase(Ease.Linear).SetAutoKill(false).Pause();
    }

    public void StartTweens()
    {
        DOTween.PlayAll();
        buttonIntroLetter.SetActive(false);
        buttonNext.SetActive(true);
    }
}
