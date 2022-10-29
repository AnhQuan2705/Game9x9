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
            if (baitoan9x9.answerReceive != null)
            {
                //nhan answer
                _lock = true;
                answer = baitoan9x9.answerReceive;
                baitoan9x9.QuestionReceiveAnswer(this);
            }
            else
            {
                Debug.Log("Chua bam cau tra loi");
            }

        }
        else
        {
            //cancel cau troi bat ky
            if (!baitoan9x9.panelShowAnswer.activeSelf)
            {
                baitoan9x9.QuestionCancelAnswer(answer, this);
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
        baitoan9x9.CheckComplete();
    }
}
