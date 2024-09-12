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
        introtext.DOText("안녕하세요, Z-CITY의 거주민 여러분.\r\nZ-CITY TIMES를 구매해주셔서 감사합니다." +
            "\r\n우리는 보다 정의롭고 아름다운 도시를 유지하기 위해\r\n그 누구보다도 최선을 다하고 있습니다." +
            "\r\n\r\n구매하신 신문을 읽으시려면 AR Glass를 착용해주시고 신문을 다운로드 해 주세요.\r\n\r\n오늘도 좋은 하루되시길 바라겠습니다." +
            " \r\n\r\n감사합니다.", 10).SetEase(Ease.Linear).SetAutoKill(false).Pause();
    }

    public void StartTweens()
    {
        DOTween.PlayAll();
        buttonIntroLetter.SetActive(false);
        buttonNext.SetActive(true);
    }
}
