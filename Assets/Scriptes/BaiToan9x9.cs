using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaiToan9x9 : MonoBehaviour
{
    public List<Sprite> listSpriteColor = new List<Sprite>();
    [SerializeField] private Answer9x9 answer99;
    [SerializeField] private Question9x9 question99;
    [HideInInspector] public int currentWeek;
    [HideInInspector] public int currentPractices;
    [HideInInspector] public int currentPlayables;
    [SerializeField] private GameObject panelAnswer;
    [SerializeField] private GameObject panelQuestion;
    [HideInInspector] public Answer9x9 answerReceive;
    public GameObject panelShowAnswer;
    [SerializeField] private Image imgShowAnser;
    public Image imgColorMoveTo;
    [SerializeField] private GameObject panelGamePlay;
    
    [HideInInspector] public List<Sprite> listSpriteAnswer = new List<Sprite>();
    [HideInInspector] public List<Sprite> listSpriteQuestion = new List<Sprite>();
    private List<Answer9x9> listAnswer9x9 = new List<Answer9x9>();
    private List<Question9x9> listQuestion9x9 = new List<Question9x9>();
    [HideInInspector] public Vector3 posPanelShowAnswer;

    [Header("EndGame")]
    [SerializeField] private GameObject panelGameEnd;
    [SerializeField] private TextMeshProUGUI txtHoanThanh;
    [SerializeField] private Image imgStar;
    [SerializeField] private Sprite spriteStarBreak;
    [SerializeField] private Sprite spriteStar;
    [SerializeField] private TextMeshProUGUI txtStar;
    [SerializeField] private TextMeshProUGUI txtTime;
    [SerializeField] private GameObject panelAnswerEndGame;
    [SerializeField] private GameObject panelQuestionEndGame;
    [SerializeField] private Timer Timer;
    [SerializeField] private Qa9x9 qa9x9;
    [SerializeField] private Sprite spriteTrue;
    [SerializeField] private Sprite spriteFalse;
    public void Start()
    {
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.offsetMin = Vector2.zero;
        rectTransform.offsetMax = Vector2.zero;
        posPanelShowAnswer = panelShowAnswer.transform.position;
        Init();
        GetData();
        InitAnswer();
        InitQuestion();
        Reset();
        panelGamePlay.transform.localScale = new Vector3(1, 1, 1);
    }
    #region GamePlay
    public void Init()
    {
        imgColorMoveTo.gameObject.SetActive(false);
        panelGamePlay.SetActive(true);
        panelGamePlay.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGamePlay, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelGameEnd.SetActive(false);

        panelShowAnswer.SetActive(false);
        panelShowAnswer.transform.localScale = Vector3.zero;
    }
    public void GetData()
    {
        string path = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.03/" + "/data.json";

        if (File.Exists(path))
        {
            string data = File.ReadAllText(path);
            Data9x9 data9x9 = JsonUtility.FromJson<Data9x9>(data);
            //Debug.Log("data9x9: " + data9x9.answers.Length + "     " + data9x9.questions.Length);
            string pathAnswer;
            for (int i = 0; i < data9x9.answers.Length; i++)
            {
                int po = i + 1;
                pathAnswer = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.03/" + "/A" + po + ".png";
                Debug.Log("pathAnswer: " + pathAnswer);
                if (File.Exists(pathAnswer))
                {
                    listSpriteAnswer.Add(GetSprite(pathAnswer));
                }
            }
            string pathQuestion;
            for (int j = 0; j < data9x9.questions.Length; j++)
            {
                int po = j + 1;
                pathQuestion = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.03/" + "/Q" + po + ".png";
                Debug.Log("pathAnswer: " + pathQuestion);
                if (File.Exists(pathQuestion))
                {
                    listSpriteQuestion.Add(GetSprite(pathQuestion));
                }
            }
        }
    }
    public Sprite GetSprite(string pathImg)
    {
        byte[] bytes = System.IO.File.ReadAllBytes(pathImg);
        Texture2D texture = new Texture2D(1, 1);
        texture.LoadImage(bytes);
        Sprite sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
        return sprite;
    }
    public void InitAnswer()
    {
        List<int> listID = new List<int>();
        for (int i = 0; i < listSpriteAnswer.Count; i++)
        {
            listID.Add(i + 1);
        }
        Debug.Log("listId: " + listID.Count);
        Debug.Log("listSpriteAnswer: " + listSpriteAnswer.Count);
        for (int j = 0; j < listSpriteAnswer.Count; j++)
        {
            Answer9x9 an = Instantiate(answer99);
            an.gameObject.transform.SetParent(panelAnswer.transform);
            an.transform.localScale = new Vector3(1, 1, 1);
            an.id = listID[Random.Range(0, listID.Count - 1)];
            an.imgContent.sprite = listSpriteAnswer[an.id - 1];
            an.imgColor.sprite = listSpriteColor[an.id - 1];
            an.baitoan9x9 = this;
            listAnswer9x9.Add(an);
            listID.Remove(an.id);
            Debug.Log("id " + an.id);
        }
    }
    public void InitQuestion()
    {
        List<int> listID = new List<int>();
        for (int i = 0; i < listSpriteQuestion.Count; i++)
        {
            listID.Add(i + 1);
        }
        for (int j = 0; j < listSpriteQuestion.Count; j++)
        {
            Question9x9 an = Instantiate(question99);
            an.gameObject.transform.SetParent(panelQuestion.transform);
            an.transform.localScale = new Vector3(1, 1, 1);
            an.id = listID[Random.Range(0, listID.Count - 1)];
            an.imgContent.sprite = listSpriteQuestion[an.id - 1];
            an.imgColor.gameObject.SetActive(false);
            listQuestion9x9.Add(an);
            an.baitoan9x9 = this;
            listID.Remove(an.id);
            Debug.Log("id " + an.id);
        }
    }
    public void AnswerClick(Answer9x9 answer)
    {
        Debug.Log("answer position: " + answer.transform.position);
        answerReceive = answer;
        panelShowAnswer.SetActive(true);
        imgShowAnser.sprite = answer.imgContent.sprite;
        panelShowAnswer.transform.position.Scale(Vector3.zero);
        panelShowAnswer.transform.position = answer.transform.position;

        LeanTween.move(panelShowAnswer, posPanelShowAnswer, 0.3f);
        LeanTween.scale(panelShowAnswer, Vector3.one, 0.3f).setEase(LeanTweenType.animationCurve);
    }
    public void ClosePanelShowAnswer()
    {
        LeanTween.scale(panelShowAnswer, Vector3.zero, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(OffPanelShowAnswer);
        LeanTween.move(panelShowAnswer, answerReceive.transform.position, 0.3f);
        //panelShowAnswer.SetActive(false);
        //answerReceive.CancelAnswer();
        //answerReceive = null;

    }
    private void OffPanelShowAnswer()
    {
        panelShowAnswer.SetActive(false);
        answerReceive.CancelAnswer();
        answerReceive = null;
    }

    public void QuestionReceiveAnswer(Question9x9 question)
    {

        LeanTween.scale(panelShowAnswer, Vector3.zero, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(answerReceive.LockAnswer);
        LeanTween.move(panelShowAnswer, answerReceive.transform.position, 0.3f);
       
        imgColorMoveTo.sprite = answerReceive.imgColor.sprite;
        imgColorMoveTo.transform.position = answerReceive.transform.position;
        imgColorMoveTo.gameObject.SetActive(true);
        LeanTween.move(imgColorMoveTo.gameObject, question.transform.position, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(question.ReceiveAnswer);
        answerReceive = null;
        //panelShowAnswer.SetActive(false);
        //answerReceive.LockAnswer();
        //answerReceive = null;
    }
    public void QuestionCancelAnswer(Answer9x9 answer, Question9x9 question)
    {
        imgColorMoveTo.sprite = question.imgColor.sprite;
        imgColorMoveTo.transform.position = question.transform.position;
        imgColorMoveTo.gameObject.SetActive(true);
        LeanTween.move(imgColorMoveTo.gameObject, answer.transform.position, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(answer.CancelAnswer);
        //answer.CancelAnswer();
    }
    public void CheckComplete()
    {
        Debug.Log("Check Complete");
        int totalAnswer = 0;
        int totalAnswerTrue = 0;
        for (int i = 0; i < listQuestion9x9.Count; i++)
        {
            if (listQuestion9x9[i].answer != null)
            {
                totalAnswer++;
                if (listQuestion9x9[i].id == listQuestion9x9[i].answer.id)
                {
                    totalAnswerTrue++;
                }
            }
        }
        if (totalAnswer == listQuestion9x9.Count)
        {
            Debug.Log("Check Complete : " + totalAnswerTrue + "/" + totalAnswer);
            Timer.timerIsRunning = false;
            EndGame();
        }
        else
        {
            Debug.Log("Chua hoan thanh");
        }
    }
    public void ButCloseGame()
    {
        //AudioManager.Instance.PlayButtonClickSound();
        ////PopupManager.Instance.LoadPop("Prefabs/Week/Popup_Tuan99");
        //PopupManager.Instance.popupTuan99.gameObject.SetActive(true);
        Destroy(gameObject);
    }
    #endregion
    #region EndGame
    public void EndGame()
    {
        Debug.Log("End Game");
        panelGamePlay.SetActive(false);
        panelGameEnd.SetActive(true);
        panelGameEnd.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGameEnd, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        int totalQuestion = listQuestion9x9.Count;
        int totalAnswerTrue = 0;
        for (int i = 0; i < totalQuestion; i++)
        {
            if (listQuestion9x9[i].answer != null)
            {
                if (listQuestion9x9[i].id == listQuestion9x9[i].answer.id)
                {
                    totalAnswerTrue++;
                }
            }
        }
        // ?ánh giá k?t qu?
        if (totalAnswerTrue <= 5)
        {
            txtHoanThanh.text = "Làm L?i B?n ?i";
            imgStar.sprite = spriteStarBreak;
            txtStar.text = totalAnswerTrue + "/" + totalQuestion;
            txtTime.text = Timer.timeText.text;
        }
        else
        {
            txtHoanThanh.text = "Hoàn Thành";
            imgStar.sprite = spriteStar;
            txtStar.text = totalAnswerTrue + "/" + totalQuestion;
            txtTime.text = Timer.timeText.text;
        }
        //init hinh anh
        for (int i = 0; i < listAnswer9x9.Count; i++)
        {
            //panel Answer EndGame
            Qa9x9 obj = Instantiate(qa9x9);
            obj.transform.SetParent(panelAnswerEndGame.transform);
            obj.imgContent.sprite = listAnswer9x9[i].imgContent.sprite;
            obj.imgTF.gameObject.SetActive(false);
            obj.transform.localScale = Vector3.one;


            //panel Question EndGGame
            Qa9x9 qt = Instantiate(qa9x9);
            qt.transform.SetParent(panelQuestionEndGame.transform);
            qt.imgContent.sprite = listAnswer9x9[i].imgColor.sprite;
            if (listQuestion9x9[i].answer == null)
            {
                qt.imgTF.sprite = spriteFalse;
            }
            else
            {
                if (listQuestion9x9[i].id == listQuestion9x9[i].answer.id)
                {
                    qt.imgTF.sprite = spriteTrue;
                }
                else
                {
                    qt.imgTF.sprite = spriteFalse;
                }
            }
            qt.transform.localScale = Vector3.one;

        }
    }

    public void ButReplay()
    {
        Reset();
    }
    private void Reset()
    {
        //h?y gameobject trong panelAnswer và panelQuestion
        for (int i = 0; i < listAnswer9x9.Count; i++)
        {
            Destroy(listAnswer9x9[i].gameObject);
            Destroy(listQuestion9x9[i].gameObject);
        }
        // gán listAnwser và listQuestion m?i
        listAnswer9x9 = new List<Answer9x9>();
        listQuestion9x9 = new List<Question9x9>();
        // h?y gameobject trong panelAnswerEndgame và panelQuestionEndgame
        foreach (Transform child in panelAnswerEndGame.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in panelQuestionEndGame.transform)
        {
            Destroy(child.gameObject);
        }
        //init l?i giá tr? ?? không gi?ng l??t ch?i ??u
        Init();
        InitAnswer();
        InitQuestion();
        // Reset l?i th?i gian
        Timer.Reset();
    }
   
    #endregion 
}
