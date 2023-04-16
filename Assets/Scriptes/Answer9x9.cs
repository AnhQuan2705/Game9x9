using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer9x9 : MonoBehaviour
{
    public Image imgColor;
    public Image imgContent;
    [HideInInspector] public int id;
    [HideInInspector] public BaiToan9x9 baitoan9x9;

    [SerializeField] private GameObject objLock;
    private bool block = false;

    private void Start()
    {
        objLock.gameObject.SetActive(false);
    }
    public void OnClick()
    {
        Debug.Log(block);
        if (!block)
        {
            baitoan9x9.AnswerClick(this);
            baitoan9x9.AnswerClickClass1Chapter2(this);
            baitoan9x9.AnswerClickClass2Chapter1(this);
            baitoan9x9.AnswerClickTongHop(this);
            imgColor.gameObject.SetActive(false);
            objLock.gameObject.SetActive(true);
            block = true;
        }
    }
    public void CancelAnswer()
    {
        block = false;
        imgColor.gameObject.SetActive(true);
        objLock.gameObject.SetActive(false);
        baitoan9x9.imgColorMoveTo.gameObject.SetActive(false);
    }
    public void CancelAnswerClass1Chapter2()
    {
        block = false;
        imgColor.gameObject.SetActive(true);
        objLock.gameObject.SetActive(false);
        baitoan9x9.imgColorMoveTo.gameObject.SetActive(false);
    }
    public void CancelAnswerClass2Chapter1()
    {
        block = false;
        imgColor.gameObject.SetActive(true);
        objLock.gameObject.SetActive(false);
        baitoan9x9.imgColorMoveTo.gameObject.SetActive(false);
    }
    public void CancelAnswerTongHop()
    {
        block = false;
        imgColor.gameObject.SetActive(true);
        objLock.gameObject.SetActive(false);
        baitoan9x9.imgColorMoveTo.gameObject.SetActive(false);
    }
    public void LockAnswer()
    {
        objLock.gameObject.SetActive(true);
        imgColor.gameObject.SetActive(false);
        baitoan9x9.panelShowAnswer.gameObject.SetActive(false);
    }
    public void LockAnswerClass1Chapter2()
    {
        objLock.gameObject.SetActive(true);
        imgColor.gameObject.SetActive(false);
        baitoan9x9.panelShowAnswerClass1Chapter2.gameObject.SetActive(false);
    }
    public void LockAnswerClass2Chapter1()
    {
        objLock.gameObject.SetActive(true);
        imgColor.gameObject.SetActive(false);
        baitoan9x9.panelShowAnswerClass2Chapter1.gameObject.SetActive(false);
    }
    public void LockAnswerTongHop()
    {
        objLock.gameObject.SetActive(true);
        imgColor.gameObject.SetActive(false);
        baitoan9x9.panelShowAnswerTongHop.gameObject.SetActive(false);
    }
}
