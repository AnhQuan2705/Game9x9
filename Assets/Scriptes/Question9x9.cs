using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Question9x9 : MonoBehaviour
{
    public Image imgColor;
    public Image imgContent;
    public int id;
    [HideInInspector]
    public Answer9x9 answer;
    [HideInInspector]
    public BaiToan9x9 baitoan9x9;
    private bool _lock = false;

    public void OnClick()
    {
        Debug.Log("question lock: " + _lock);
        if (!_lock)
        {
            if (baitoan9x9.answerReceive != null || baitoan9x9.answerReceiveClass1Chapter2 != null || baitoan9x9.answerReceiveClass2Chapter1 != null)
            {
                //nhan answer
                _lock = true;
                answer = baitoan9x9.answerReceive;
                answer = baitoan9x9.answerReceiveClass1Chapter2;
                answer = baitoan9x9.answerReceiveClass2Chapter1;
                answer = baitoan9x9.answerReceiveTongHop;
                baitoan9x9.QuestionReceiveAnswer(this);
                baitoan9x9.QuestionReceiveAnswerClass1Chapter2(this);
                baitoan9x9.QuestionReceiveAnswerClass2Chapter1(this);
                baitoan9x9.QuestionReceiveAnswerTongHop(this);
            }
            else
            {
                Debug.Log("Chua bam cau tra loi");
            }
        }
        else
        {
            //cancel cau troi bat ky
            if (!baitoan9x9.panelShowAnswer.activeSelf || !baitoan9x9.panelShowAnswerClass1Chapter2.activeSelf || !baitoan9x9.panelShowAnswerClass2Chapter1.activeSelf || !baitoan9x9.panelShowAnswerTongHop.activeSelf)
            {
                baitoan9x9.QuestionCancelAnswer(answer, this);
                baitoan9x9.QuestionCancelAnswerClass1Chapter2(answer, this);
                baitoan9x9.QuestionCancelAnswerClass2Chapter1(answer, this);
                baitoan9x9.QuestionCancelAnswerTongHop(answer, this);
                imgColor.gameObject.SetActive(false);
                answer = null;
                _lock = false;
            }
            else
            {
                Debug.Log("da show cau tra loi, can chon dap an tuong ung");
            }
        }
    }
    public void ReceiveAnswer()
    {
        //nhan answer, nhung cho hieu ung
        baitoan9x9.imgColorMoveTo.gameObject.SetActive(false);
        imgColor.gameObject.SetActive(true);
    }
    public void ReceiveAnswerClass1Chapter2()
    {
        //nhan answer, nhung cho hieu ung
        baitoan9x9.imgColorMoveTo.gameObject.SetActive(false);
        imgColor.gameObject.SetActive(true);
    }
    public void ReceiveAnswerClass2Chapter1()
    {
        //nhan answer, nhung cho hieu ung
        baitoan9x9.imgColorMoveTo.gameObject.SetActive(false);
        imgColor.gameObject.SetActive(true);
    }
    public void ReceiveAnswerTongHop()
    {
        //nhan answer, nhung cho hieu ung
        baitoan9x9.imgColorMoveTo.gameObject.SetActive(false);
        imgColor.gameObject.SetActive(true);
    }
}
