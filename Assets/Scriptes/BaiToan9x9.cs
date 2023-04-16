using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaiToan9x9 : MonoBehaviour
{
    public List<Sprite> listSpriteColor = new List<Sprite>();
    public List<Sprite> listSpriteColorChapter2Class1 = new List<Sprite>();
    public List<Sprite> listSpriteColorChapter1Class2 = new List<Sprite>();
    public List<Sprite> listSpriteColorTongHop = new List<Sprite>();
    [SerializeField] private Answer9x9 answer99;
    [SerializeField] private Question9x9 question99;
    [HideInInspector] public int currentWeek;
    [HideInInspector] public int currentPractices;
    [HideInInspector] public int currentPlayables;
    [SerializeField] private GameObject panelAnswer;
    [SerializeField] private GameObject panelQuestion;
    [SerializeField] private GameObject panelAnswerClass1Chapter2;
    [SerializeField] private GameObject panelQuestionClass1Chapter2;
    [SerializeField] private GameObject panelAnswerClass2Chapter1;
    [SerializeField] private GameObject panelQuestionClass2Chapter1;
    [SerializeField] private GameObject panelAnswerTongHop;
    [SerializeField] private GameObject panelQuestionTongHop;
    [HideInInspector] public Answer9x9 answerReceive;
    [HideInInspector] public Answer9x9 answerReceiveClass1Chapter2;
    [HideInInspector] public Answer9x9 answerReceiveClass2Chapter1;
    [HideInInspector] public Answer9x9 answerReceiveTongHop;
    public GameObject panelShowAnswer;
    [SerializeField] private Image imgShowAnser;
    public GameObject panelShowAnswerClass1Chapter2;
    [SerializeField] private Image imgShowAnserClass1Chapter2;
    public GameObject panelShowAnswerClass2Chapter1;
    [SerializeField] private Image imgShowAnserClass2Chapter1;
    public GameObject panelShowAnswerTongHop;
    [SerializeField] private Image imgShowAnserTongHop;
    public Image imgColorMoveTo;
    [SerializeField] private GameObject panelGamePlay;
    [SerializeField] private GameObject panelGameMenu;
    [SerializeField] private GameObject panelClass;
    [SerializeField] private GameObject panelGameClassChapter;
    [SerializeField] private GameObject panelGameClassChapter2;
    [SerializeField] private GameObject panelSettingGame;
    [SerializeField] private GameObject panelFormClass1Chapter1;
    [SerializeField] private GameObject panelFormClass1Chapter2;
    [SerializeField] private GameObject panelFormClass2Chapter1;
    [SerializeField] private GameObject panelFormTongHop;
    [SerializeField] private GameObject panelHuongDanChapter1Class1;
    [SerializeField] private GameObject panelHuongDanChapter2Class1;
    [SerializeField] private GameObject panelDanhgiaThucLuc;
    [SerializeField] private GameObject panelCommingSoon;
    [SerializeField] private GameObject ButtonCheckChapter1Class1;
    [SerializeField] private GameObject ButtonCheckChapter2Class1;
    [SerializeField] private GameObject ButtonCheckChapter1Class2;
    [SerializeField] private GameObject ButtonCheckTongHop;
    [SerializeField] private GameObject ButtonChapter1;
    [SerializeField] private GameObject ButtonChapter1Replay;
    [SerializeField] private GameObject ButtonChapter2;
    [SerializeField] private GameObject ButtonChapter2Replay;
    [SerializeField] private GameObject ButtonChapter1Class2;
    [SerializeField] private GameObject ButtonChapter1ReplayClass2;
    [SerializeField] private GameObject ButtonChapter2Class2;
    [SerializeField] private GameObject ButtonChapter2ReplayClass2;
    [SerializeField] private GameObject ButtonSynthensis;
    [SerializeField] private GameObject ButtonSynthensisReplay;
    [SerializeField] private GameObject ButtonSubmitChapter1;
    [SerializeField] private GameObject ButtonSubmitChapter2;
    [SerializeField] private GameObject ButtonSubmitChapter1Class2;
    [SerializeField] private GameObject ButtonSubmitTongHop;
    [SerializeField] private GameObject ButtonReplayChapter1Class1;
    [SerializeField] private GameObject ButtonReplayChapter2Class1;
    [SerializeField] private GameObject ButtonReplayChapter1Class2;
    [SerializeField] private GameObject ButtonReplayTongHop;
    [SerializeField] private GameObject ButtonReplayInGameTongHop;
    [SerializeField] private GameObject ButtonReplayInGameChapter2Class1;
    [SerializeField] private GameObject ButtonReplayInGameChapter1Class2;
    [SerializeField] private GameObject ButtonReplayInGameChapter1Class1;
    [SerializeField] private GameObject ButtonHelp;
    [SerializeField] private GameObject ButtonHelpChapter2;
    [SerializeField] private GameObject ButtonAudioPause;
    [SerializeField] private GameObject ButtonAudioUnPause;
    [SerializeField] private GameObject ButtonAudioPauseIngame;
    [SerializeField] private GameObject ButtonAudioUnPauseIngame;

    [HideInInspector] public List<Sprite> listSpriteAnswer = new List<Sprite>();
    [HideInInspector] public List<Sprite> listSpriteQuestion = new List<Sprite>();
    [HideInInspector] public List<Sprite> listSpriteAnswerClass1Chapter2 = new List<Sprite>();
    [HideInInspector] public List<Sprite> listSpriteQuestionClass1Chapter2 = new List<Sprite>();
    [HideInInspector] public List<Sprite> listSpriteAnswerClass2Chapter1 = new List<Sprite>();
    [HideInInspector] public List<Sprite> listSpriteQuestionClass2Chapter1 = new List<Sprite>();
    [HideInInspector] public List<Sprite> listSpriteAnswerTongHop = new List<Sprite>();
    [HideInInspector] public List<Sprite> listSpriteQuestionTongHop = new List<Sprite>();
    private List<Answer9x9> listAnswer9x9 = new List<Answer9x9>();
    private List<Question9x9> listQuestion9x9 = new List<Question9x9>();
    private List<Answer9x9> listAnswer9x9Class1Chapter2 = new List<Answer9x9>();
    private List<Question9x9> listQuestion9x9Class1Chapter2 = new List<Question9x9>();
    private List<Answer9x9> listAnswer9x9Class2Chapter1 = new List<Answer9x9>();
    private List<Question9x9> listQuestion9x9Class2Chapter1 = new List<Question9x9>();
    private List<Answer9x9> listAnswer9x9TongHop = new List<Answer9x9>();
    private List<Question9x9> listQuestion9x9TongHop = new List<Question9x9>();
    [HideInInspector] public Vector3 posPanelShowAnswer;
    [HideInInspector] public Vector3 posPanelShowAnswerClass1Chapter2;
    [HideInInspector] public Vector3 posPanelShowAnswerClass2Chapter1;
    [HideInInspector] public Vector3 posPanelShowAnswerTongHop;

    [Header("EndGame")]
    [SerializeField] private GameObject panelGameEnd;
    [SerializeField] private GameObject image_BKQChapter1Class1;
    [SerializeField] private GameObject image_BKQChapter2Class1;
    [SerializeField] private GameObject image_BKQChapter1Class2;
    [SerializeField] private GameObject image_BKQTongHop;
    [SerializeField] private TextMeshProUGUI txtHoanThanh;
    [SerializeField] private TextMeshProUGUI txtHoanThanhChapter2Class1;
    [SerializeField] private TextMeshProUGUI txtHoanThanhChapter1Class2;
    [SerializeField] private TextMeshProUGUI txtHoanThanhTongHop;
    [SerializeField] private Image imgStar;
    [SerializeField] private Sprite spriteStarBreak;
    [SerializeField] private Sprite spriteStar;
    [SerializeField] private TextMeshProUGUI txtStar;
    [SerializeField] private TextMeshProUGUI txtStarChapter2Class1;
    [SerializeField] private TextMeshProUGUI txtStarChapter1Class2;
    [SerializeField] private TextMeshProUGUI txtStarTongHop;
    [SerializeField] private TextMeshProUGUI txtStarChapter1;
    [SerializeField] private TextMeshProUGUI txtStarChapter2;
    [SerializeField] private TextMeshProUGUI txtStarChapter1Class2ChoseClass;
    [SerializeField] private TextMeshProUGUI txtHoanThanhChapter1;
    [SerializeField] private TextMeshProUGUI txtHoanThanhChapter2;
    [SerializeField] private TextMeshProUGUI txtHoanThanhChapter1Class2ChoseClass;
    [SerializeField] private TextMeshProUGUI txtHoanThanhTongHopDanhGia;
    [SerializeField] private TextMeshProUGUI txtHoanThanhTongHopDanhGiaStar;
    [SerializeField] private TextMeshProUGUI txtHoanThanhDanhGia;
    [SerializeField] private TextMeshProUGUI txtTime;
    [SerializeField] private TextMeshProUGUI txtTimeChapter2Class1;
    [SerializeField] private TextMeshProUGUI txtTimeChapter1Class2;
    [SerializeField] private TextMeshProUGUI txtTimeTongHop;
    [SerializeField] private GameObject panelAnswerEndGame;
    [SerializeField] private GameObject panelQuestionEndGame;
    [SerializeField] private GameObject panelAnswerEndGameClass1Chapter2;
    [SerializeField] private GameObject panelQuestionEndGameClass1Chapter2;
    [SerializeField] private GameObject panelAnswerEndGameClass2Chapter1;
    [SerializeField] private GameObject panelQuestionEndGameClass2Chapter1;
    [SerializeField] private GameObject panelAnswerEndGameTongHop;
    [SerializeField] private GameObject panelQuestionEndGameTongHop;
    [SerializeField] private Timer Timer;
    [SerializeField] private Timer TimerChapter2Class1;
    [SerializeField] private Timer TimerChapter1Class2;
    [SerializeField] private Timer TimerTongHop;
    [SerializeField] private Qa9x9 qa9x9;
    [SerializeField] private Sprite spriteTrue;
    [SerializeField] private Sprite spriteFalse;
    public void Start()
    {
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.offsetMin = Vector2.zero;
        rectTransform.offsetMax = Vector2.zero;
        //posPanelShowAnswer = panelShowAnswer.transform.position;
        Init();
        //GetData();
        //InitAnswer();
        //InitQuestion();
        //Reset();
        panelGameMenu.transform.localScale = new Vector3(1, 1, 1);
        panelFormClass1Chapter2.gameObject.SetActive(false);
        panelClass.gameObject.SetActive(false);
        panelGameClassChapter.gameObject.SetActive(false);
        panelGameClassChapter2.gameObject.SetActive(false);
        panelSettingGame.gameObject.SetActive(false);
        panelGameMenu.gameObject.SetActive(true);
        panelGamePlay.gameObject.SetActive(false);
        panelGamePlay.transform.localScale = new Vector3(1, 1, 1);
        ButtonChapter1.gameObject.SetActive(true);
        ButtonChapter1Replay.gameObject.SetActive(false);
        ButtonChapter2.gameObject.SetActive(true);
        ButtonChapter2Replay.gameObject.SetActive(false);
        ButtonChapter1Class2.gameObject.SetActive(true);
        ButtonChapter1ReplayClass2.gameObject.SetActive(false);
        ButtonChapter2Class2.gameObject.SetActive(true);
        ButtonChapter2ReplayClass2.gameObject.SetActive(false);
        ButtonSynthensis.gameObject.SetActive(true);
        ButtonSynthensisReplay.gameObject.SetActive(false);
        panelHuongDanChapter1Class1.gameObject.SetActive(false);
        panelHuongDanChapter2Class1.gameObject.SetActive(false);
        panelDanhgiaThucLuc.gameObject.SetActive(false);
        panelCommingSoon.gameObject.SetActive(false);
        ButtonAudioPause.gameObject.SetActive(true);
        ButtonAudioUnPause.gameObject.SetActive(false);
    }
    #region GamePlay
    //In it Class1 Chapter1
    public void Init()
    {
        imgColorMoveTo.gameObject.SetActive(false);
        panelGamePlay.SetActive(true);
        panelGamePlay.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGamePlay, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelGameMenu.gameObject.SetActive(false);
        panelClass.gameObject.SetActive(false);
        panelGameEnd.SetActive(false);
        
        panelShowAnswer.SetActive(false);
        panelShowAnswer.transform.localScale = Vector3.zero;

    }
    // In it Class1 Chapter2
    public void InitClass1Chapter2()
    {
        imgColorMoveTo.gameObject.SetActive(false);
        panelGamePlay.SetActive(true);
        panelGamePlay.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGamePlay, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelGameMenu.gameObject.SetActive(false);
        panelClass.gameObject.SetActive(false);
        panelGameEnd.SetActive(false);

        panelShowAnswerClass1Chapter2.SetActive(false);
        panelShowAnswerClass1Chapter2.transform.localScale = Vector3.zero;
    }
    // In it Class2 Chapter1
    public void InitClass2Chapter1()
    {
        imgColorMoveTo.gameObject.SetActive(false);
        panelGamePlay.SetActive(true);
        panelGamePlay.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGamePlay, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelGameMenu.gameObject.SetActive(false);
        panelClass.gameObject.SetActive(false);
        panelGameEnd.SetActive(false);

        panelShowAnswerClass2Chapter1.SetActive(false);
        panelShowAnswerClass2Chapter1.transform.localScale = Vector3.zero;
    }
    // In it Bai tap tong hop
    public void InitTongHop()
    {
        imgColorMoveTo.gameObject.SetActive(false);
        panelGamePlay.SetActive(true);
        panelGamePlay.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGamePlay, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelGameMenu.gameObject.SetActive(false);
        panelClass.gameObject.SetActive(false);
        panelGameEnd.SetActive(false);

        panelShowAnswerTongHop.SetActive(false);
        panelShowAnswerTongHop.transform.localScale = Vector3.zero;
    }
    //Chon Class
    public void choseClass()
    {
        panelClass.gameObject.SetActive(true);
        panelClass.transform.localScale = Vector3.zero;
        LeanTween.scale(panelClass, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelGameMenu.gameObject.SetActive(false);
        panelGamePlay.gameObject.SetActive(false);
    }    
    //Chon Chapter cua Class1
    public void choseChapterOfClass1()
    {
       panelGameClassChapter.gameObject.SetActive(true);
       panelGameClassChapter.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGameClassChapter, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelClass.gameObject.SetActive(false);
        panelGameMenu.gameObject.SetActive(false);
        panelGameEnd.gameObject.SetActive(false);
        panelGamePlay.gameObject.SetActive(false);
    }
    //Chon Chapter cua Class2
    public void choseChapterOfClass2()
    {
        panelGameClassChapter.gameObject.SetActive(false);
        panelGameClassChapter2.gameObject.SetActive(true);
        panelGameClassChapter2.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGameClassChapter2, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelClass.gameObject.SetActive(false);
        panelGameMenu.gameObject.SetActive(false);
        panelGameEnd.gameObject.SetActive(false);
        panelGamePlay.gameObject.SetActive(false);
    }
    //Chon Chapter2 cua Class1
    public void choseChapter2OfClasss1()
    {
        panelShowAnswerClass1Chapter2.transform.position = new Vector3(-4, 0, -2);
        posPanelShowAnswerClass1Chapter2 = panelShowAnswerClass1Chapter2.transform.position;
        InitClass1Chapter2();
        GetDataChapter2();
        InitAnswerChapter2();
        InitQuestionChapter2();
        ResetChapter2();
        panelGameMenu.gameObject.SetActive(false);
        panelHuongDanChapter2Class1.SetActive(true);
        panelHuongDanChapter2Class1.transform.localScale = Vector3.zero;
        LeanTween.scale(panelHuongDanChapter2Class1, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelFormClass1Chapter2.gameObject.SetActive(true);
        panelFormClass1Chapter1.gameObject.SetActive(false);
        panelFormClass2Chapter1.gameObject.SetActive(false);
        panelFormTongHop.gameObject.SetActive(false);
        ButtonCheckChapter1Class1.gameObject.SetActive(false);
        ButtonCheckChapter2Class1.gameObject.SetActive(true);
        ButtonSubmitChapter2.gameObject.SetActive(true);
        ButtonSubmitChapter1.gameObject.SetActive(false);
        ButtonSubmitChapter1Class2.gameObject.SetActive(false);
        ButtonSubmitTongHop.gameObject.SetActive(false);
        ButtonHelpChapter2.SetActive(true);
        ButtonHelp.SetActive(false);
        ButtonReplayInGameChapter2Class1.SetActive(true);
        ButtonReplayInGameChapter1Class1.SetActive(false);
        ButtonReplayInGameChapter1Class2.SetActive(false);
        ButtonReplayInGameTongHop.SetActive(false);
        panelSettingGame.gameObject.SetActive(false);
    }
    //Chon Chapter1 cua Class1
    public void choseChapter1OfClasss1()
    {
        panelShowAnswer.transform.position = new Vector3(-4, 0, -2);
        posPanelShowAnswer = panelShowAnswer.transform.position;
        Init();
        GetData();
        InitAnswer();
        InitQuestion();
        Reset();
        panelGameMenu.gameObject.SetActive(false);
        panelHuongDanChapter1Class1.gameObject.SetActive(true);
        panelHuongDanChapter1Class1.transform.localScale = Vector3.zero;
        LeanTween.scale(panelHuongDanChapter1Class1, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelFormClass1Chapter2.gameObject.SetActive(false);
        panelFormTongHop.gameObject.SetActive(false);
        panelFormClass1Chapter1.gameObject.SetActive(false);
        panelFormClass1Chapter1.gameObject.SetActive(true);
        ButtonCheckChapter1Class1.gameObject.SetActive(true);
        ButtonCheckChapter2Class1.gameObject.SetActive(false);
        ButtonSubmitChapter1.gameObject.SetActive(true);
        ButtonSubmitChapter2.gameObject.SetActive(false);
        ButtonSubmitChapter1Class2.gameObject.SetActive(false);
        ButtonSubmitTongHop.gameObject.SetActive(false);
        ButtonHelpChapter2.SetActive(false);
        ButtonHelp.SetActive(true);
        ButtonReplayInGameChapter2Class1.SetActive(false);
        ButtonReplayInGameChapter1Class1.SetActive(true);
        ButtonReplayInGameChapter1Class2.SetActive(false);
        ButtonReplayInGameTongHop.SetActive(false);
        panelSettingGame.gameObject.SetActive(false);
    }
    //Chon Chapter1 cua Class2
    public void choseChapter1OfClasss2()
    {
        panelShowAnswerClass2Chapter1.transform.position = new Vector3(-4, 0, -2);
        posPanelShowAnswerClass2Chapter1 = panelShowAnswerClass2Chapter1.transform.position;
        InitClass2Chapter1();
        GetDataChapter1Class2();
        InitAnswerChapter1Class2();
        InitQuestionChapter1Class2();
        ResetChapter1Class2();
        panelGameMenu.gameObject.SetActive(false);
        panelHuongDanChapter2Class1.SetActive(true);
        panelHuongDanChapter2Class1.transform.localScale = Vector3.zero;
        LeanTween.scale(panelHuongDanChapter2Class1, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelFormClass2Chapter1.gameObject.SetActive(true);
        panelFormClass1Chapter2.gameObject.SetActive(false);
        panelFormTongHop.gameObject.SetActive(false);
        panelFormClass1Chapter1.gameObject.SetActive(false);
        ButtonCheckChapter1Class2.gameObject.SetActive(true);
        ButtonCheckChapter1Class1.gameObject.SetActive(false);
        ButtonCheckChapter2Class1.gameObject.SetActive(false);
        ButtonSubmitChapter1Class2.gameObject.SetActive(true);
        ButtonSubmitChapter1.gameObject.SetActive(false);
        ButtonSubmitChapter2.gameObject.SetActive(false);
        ButtonSubmitTongHop.gameObject.SetActive(false);
        ButtonHelpChapter2.SetActive(true);
        ButtonHelp.SetActive(false);
        ButtonReplayInGameChapter2Class1.SetActive(false);
        ButtonReplayInGameChapter1Class1.SetActive(false);
        ButtonReplayInGameChapter1Class2.SetActive(true);
        ButtonReplayInGameTongHop.SetActive(false);
        panelSettingGame.gameObject.SetActive(false);
    }
    //Chon Bai Tap Tong Hop
    public void choseTongHop()
    {
        panelShowAnswerTongHop.transform.position = new Vector3(-4, 0, -2);
        posPanelShowAnswerTongHop = panelShowAnswerTongHop.transform.position;
        InitTongHop();
        GetDataTongHop();
        InitAnswerTongHop();
        InitQuestionTongHop();
        ResetTongHop();
        panelGameMenu.gameObject.SetActive(false);
        panelHuongDanChapter2Class1.SetActive(true);
        panelHuongDanChapter2Class1.transform.localScale = Vector3.zero;
        LeanTween.scale(panelHuongDanChapter2Class1, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        panelFormClass2Chapter1.gameObject.SetActive(false);
        panelFormClass1Chapter2.gameObject.SetActive(false);
        panelFormClass1Chapter1.gameObject.SetActive(false);
        ButtonCheckTongHop.gameObject.SetActive(true);
        ButtonCheckChapter1Class2.gameObject.SetActive(false);
        ButtonCheckChapter1Class1.gameObject.SetActive(false);
        ButtonCheckChapter2Class1.gameObject.SetActive(false);
        ButtonSubmitTongHop.gameObject.SetActive(true);
        ButtonSubmitChapter1Class2.gameObject.SetActive(false);
        ButtonSubmitChapter1.gameObject.SetActive(false);
        ButtonSubmitChapter2.gameObject.SetActive(false);
        ButtonHelpChapter2.SetActive(true);
        ButtonHelp.SetActive(false);
        ButtonReplayInGameChapter2Class1.SetActive(false);
        ButtonReplayInGameChapter1Class1.SetActive(false);
        ButtonReplayInGameChapter1Class2.SetActive(false);
        ButtonReplayInGameTongHop.SetActive(true);
        panelSettingGame.gameObject.SetActive(false);
    }
    //Chon Bai Tap Tong Hop
    public void choseChapter3()
    {
        panelCommingSoon.SetActive(true);
    }
    public void closePanelCommingsSoon()
    {
        panelCommingSoon.SetActive(false);
        panelGameClassChapter.SetActive(true);
    }
    //Data Class1 Chapter1
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
    //Data Class1 Chapter2
    public void GetDataChapter2()
    {
        string path = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.04/" + "/data.json";

        if (File.Exists(path))
        {
            string data = File.ReadAllText(path);
            Data9x9 data9x9 = JsonUtility.FromJson<Data9x9>(data);
            //Debug.Log("data9x9: " + data9x9.answers.Length + "     " + data9x9.questions.Length);
            string pathAnswer;
            for (int i = 0; i < data9x9.answers.Length; i++)
            {
                int po = i + 1;
                pathAnswer = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.04/" + "/A" + po + ".png";
                Debug.Log("pathAnswer: " + pathAnswer);
                if (File.Exists(pathAnswer))
                {
                    listSpriteAnswerClass1Chapter2.Add(GetSprite(pathAnswer));
                }
            }
            string pathQuestion;
            for (int j = 0; j < data9x9.questions.Length; j++)
            {
                int po = j + 1;
                pathQuestion = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.04/" + "/Q" + po + ".png";
                Debug.Log("pathAnswer: " + pathQuestion);
                if (File.Exists(pathQuestion))
                {
                   listSpriteQuestionClass1Chapter2.Add(GetSprite(pathQuestion));
                }
            }
        }
    }
    //Data Class2 Chapter1
    public void GetDataChapter1Class2()
    {
        string path = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.05/" + "/data.json";

        if (File.Exists(path))
        {
            string data = File.ReadAllText(path);
            Data9x9 data9x9 = JsonUtility.FromJson<Data9x9>(data);
            //Debug.Log("data9x9: " + data9x9.answers.Length + "     " + data9x9.questions.Length);
            string pathAnswer;
            for (int i = 0; i < data9x9.answers.Length; i++)
            {
                int po = i + 1;
                pathAnswer = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.05/" + "/A" + po + ".png";
                Debug.Log("pathAnswer: " + pathAnswer);
                if (File.Exists(pathAnswer))
                {
                    listSpriteAnswerClass2Chapter1.Add(GetSprite(pathAnswer));
                }
            }
            string pathQuestion;
            for (int j = 0; j < data9x9.questions.Length; j++)
            {
                int po = j + 1;
                pathQuestion = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.05/" + "/Q" + po + ".png";
                Debug.Log("pathAnswer: " + pathQuestion);
                if (File.Exists(pathQuestion))
                {
                    listSpriteQuestionClass2Chapter1.Add(GetSprite(pathQuestion));
                }
            }
        }
    }
    //Data Bai tap Tong Hop
    public void GetDataTongHop()
    {
        string path = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.06/" + "/data.json";

        if (File.Exists(path))
        {
            string data = File.ReadAllText(path);
            Data9x9 data9x9 = JsonUtility.FromJson<Data9x9>(data);
            //Debug.Log("data9x9: " + data9x9.answers.Length + "     " + data9x9.questions.Length);
            string pathAnswer;
            for (int i = 0; i < data9x9.answers.Length; i++)
            {
                int po = i + 1;
                pathAnswer = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.06/" + "/A" + po + ".png";
                Debug.Log("pathAnswer: " + pathAnswer);
                if (File.Exists(pathAnswer))
                {
                    listSpriteAnswerTongHop.Add(GetSprite(pathAnswer));
                }
            }
            string pathQuestion;
            for (int j = 0; j < data9x9.questions.Length; j++)
            {
                int po = j + 1;
                pathQuestion = Application.persistentDataPath + "/Playables/" + "/toan/" + "/TPLB.06/" + "/Q" + po + ".png";
                Debug.Log("pathAnswer: " + pathQuestion);
                if (File.Exists(pathQuestion))
                {
                    listSpriteQuestionTongHop.Add(GetSprite(pathQuestion));
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
    //Init Answer Class1 Chapter 1
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
    //Init Question Class1 Chapter 1
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
    //Init Answer Class1 Chapter 2
    public void InitAnswerChapter2()
    {
        List<int> listID = new List<int>();
        for (int i = 0; i < listSpriteAnswerClass1Chapter2.Count; i++)
        {
            listID.Add(i + 1);
        }
        Debug.Log("listId: " + listID.Count);
        Debug.Log("listSpriteAnswer: " + listSpriteAnswerClass1Chapter2.Count);
        for (int j = 0; j < listSpriteAnswerClass1Chapter2.Count; j++)
        {
            Answer9x9 an = Instantiate(answer99);
            an.gameObject.transform.SetParent(panelAnswerClass1Chapter2.transform);
            an.transform.localScale = new Vector3(1, 1, 1);
            an.id = listID[Random.Range(0, listID.Count - 1)];
            an.imgContent.sprite = listSpriteAnswerClass1Chapter2[an.id - 1];
            an.imgColor.sprite = listSpriteColorChapter2Class1[an.id - 1];
            an.baitoan9x9 = this;
            listAnswer9x9Class1Chapter2.Add(an);
            listID.Remove(an.id);
            Debug.Log("id " + an.id);
        }
    }
    //Init Question Class1 Chapter 2
    public void InitQuestionChapter2()
    {
        List<int> listID = new List<int>();
        for (int i = 0; i < listSpriteQuestionClass1Chapter2.Count; i++)
        {
            listID.Add(i + 1);
        }
        for (int j = 0; j < listSpriteQuestionClass1Chapter2.Count; j++)
        {
            Question9x9 an = Instantiate(question99);
            an.gameObject.transform.SetParent(panelQuestionClass1Chapter2.transform);
            an.transform.localScale = new Vector3(1, 1, 1);
            an.id = listID[Random.Range(0, listID.Count - 1)];
            an.imgContent.sprite = listSpriteQuestionClass1Chapter2[an.id - 1];
            an.imgColor.gameObject.SetActive(false);
            listQuestion9x9Class1Chapter2.Add(an);
            an.baitoan9x9 = this;
            listID.Remove(an.id);
            Debug.Log("id " + an.id);
        }
    }
    //Init Answer Class2 Chapter 1
    public void InitAnswerChapter1Class2()
    {
        List<int> listID = new List<int>();
        for (int i = 0; i < listSpriteAnswerClass2Chapter1.Count; i++)
        {
            listID.Add(i + 1);
        }
        Debug.Log("listId: " + listID.Count);
        Debug.Log("listSpriteAnswer: " + listSpriteAnswerClass2Chapter1.Count);
        for (int j = 0; j < listSpriteAnswerClass2Chapter1.Count; j++)
        {
            Answer9x9 an = Instantiate(answer99);
            an.gameObject.transform.SetParent(panelAnswerClass2Chapter1.transform);
            an.transform.localScale = new Vector3(1, 1, 1);
            an.id = listID[Random.Range(0, listID.Count - 1)];
            an.imgContent.sprite = listSpriteAnswerClass2Chapter1[an.id - 1];
            an.imgColor.sprite = listSpriteColorChapter1Class2[an.id - 1];
            an.baitoan9x9 = this;
            listAnswer9x9Class2Chapter1.Add(an);
            listID.Remove(an.id);
            Debug.Log("id " + an.id);
        }
    }
    //Init Question Class2 Chapter 1
    public void InitQuestionChapter1Class2()
    {
        List<int> listID = new List<int>();
        for (int i = 0; i < listSpriteQuestionClass2Chapter1.Count; i++)
        {
            listID.Add(i + 1);
        }
        for (int j = 0; j < listSpriteQuestionClass2Chapter1.Count; j++)
        {
            Question9x9 an = Instantiate(question99);
            an.gameObject.transform.SetParent(panelQuestionClass2Chapter1.transform);
            an.transform.localScale = new Vector3(1, 1, 1);
            an.id = listID[Random.Range(0, listID.Count - 1)];
            an.imgContent.sprite = listSpriteQuestionClass2Chapter1[an.id - 1];
            an.imgColor.gameObject.SetActive(false);
            listQuestion9x9Class2Chapter1.Add(an);
            an.baitoan9x9 = this;
            listID.Remove(an.id);
            Debug.Log("id " + an.id);
        }
    }
    //Init Answer Tong Hop
    public void InitAnswerTongHop()
    {
        List<int> listID = new List<int>();
        for (int i = 0; i < listSpriteAnswerTongHop.Count; i++)
        {
            listID.Add(i + 1);
        }
        Debug.Log("listId: " + listID.Count);
        Debug.Log("listSpriteAnswer: " + listSpriteAnswerTongHop.Count);
        for (int j = 0; j < listSpriteAnswerTongHop.Count; j++)
        {
            Answer9x9 an = Instantiate(answer99);
            an.gameObject.transform.SetParent(panelAnswerTongHop.transform);
            an.transform.localScale = new Vector3(1, 1, 1);
            an.id = listID[Random.Range(0, listID.Count - 1)];
            an.imgContent.sprite = listSpriteAnswerTongHop[an.id - 1];
            an.imgColor.sprite = listSpriteColorTongHop[an.id - 1];
            an.baitoan9x9 = this;
            listAnswer9x9TongHop.Add(an);
            listID.Remove(an.id);
            Debug.Log("id " + an.id);
        }
    }
    //Init Question Bai tap Tong Hop
    public void InitQuestionTongHop()
    {
        List<int> listID = new List<int>();
        for (int i = 0; i < listSpriteQuestionTongHop.Count; i++)
        {
            listID.Add(i + 1);
        }
        for (int j = 0; j < listSpriteQuestionTongHop.Count; j++)
        {
            Question9x9 an = Instantiate(question99);
            an.gameObject.transform.SetParent(panelQuestionTongHop.transform);
            an.transform.localScale = new Vector3(1, 1, 1);
            an.id = listID[Random.Range(0, listID.Count - 1)];
            an.imgContent.sprite = listSpriteQuestionTongHop[an.id - 1];
            an.imgColor.gameObject.SetActive(false);
            listQuestion9x9TongHop.Add(an);
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

        AudioController.Ins.Playrightsound();
        LeanTween.move(panelShowAnswer, posPanelShowAnswer, 0.3f);
        LeanTween.scale(panelShowAnswer, Vector3.one, 0.3f).setEase(LeanTweenType.animationCurve);
    }

    public void AnswerClickClass1Chapter2(Answer9x9 answer)
    {
        Debug.Log("answer position: " + answer.transform.position);
        answerReceiveClass1Chapter2 = answer;
        panelShowAnswerClass1Chapter2.SetActive(true);
        imgShowAnserClass1Chapter2.sprite = answer.imgContent.sprite;
        panelShowAnswerClass1Chapter2.transform.position.Scale(Vector3.zero);
        panelShowAnswerClass1Chapter2.transform.position = answer.transform.position;

        AudioController.Ins.Playrightsound();
        LeanTween.move(panelShowAnswerClass1Chapter2, posPanelShowAnswerClass1Chapter2, 0.3f);
        LeanTween.scale(panelShowAnswerClass1Chapter2, Vector3.one, 0.3f).setEase(LeanTweenType.animationCurve);
    }

    public void AnswerClickClass2Chapter1(Answer9x9 answer)
    {
        Debug.Log("answer position: " + answer.transform.position);
        answerReceiveClass2Chapter1 = answer;
        panelShowAnswerClass2Chapter1.SetActive(true);
        imgShowAnserClass2Chapter1.sprite = answer.imgContent.sprite;
        panelShowAnswerClass2Chapter1.transform.position.Scale(Vector3.zero);
        panelShowAnswerClass2Chapter1.transform.position = answer.transform.position;

        AudioController.Ins.Playrightsound();
        LeanTween.move(panelShowAnswerClass2Chapter1, posPanelShowAnswerClass2Chapter1, 0.3f);
        LeanTween.scale(panelShowAnswerClass2Chapter1, Vector3.one, 0.3f).setEase(LeanTweenType.animationCurve);
    }
    public void AnswerClickTongHop(Answer9x9 answer)
    {
        Debug.Log("answer position: " + answer.transform.position);
        answerReceiveTongHop = answer;
        panelShowAnswerTongHop.SetActive(true);
        imgShowAnserTongHop.sprite = answer.imgContent.sprite;
        panelShowAnswerTongHop.transform.position.Scale(Vector3.zero);
        panelShowAnswerTongHop.transform.position = answer.transform.position;

        AudioController.Ins.Playrightsound();
        LeanTween.move(panelShowAnswerTongHop, posPanelShowAnswerTongHop, 0.3f);
        LeanTween.scale(panelShowAnswerTongHop, Vector3.one, 0.3f).setEase(LeanTweenType.animationCurve);
    }
    public void ClosePanelShowAnswer()
    {
        LeanTween.scale(panelShowAnswer, Vector3.zero, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(OffPanelShowAnswer);
        LeanTween.move(panelShowAnswer, answerReceive.transform.position, 0.3f);
        //panelShowAnswer.SetActive(false);
        //answerReceive.CancelAnswer();
        //answerReceive = null;
    }
    public void ClosePanelShowAnswerClass1Chapter2()
    {
        LeanTween.scale(panelShowAnswerClass1Chapter2, Vector3.zero, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(OffPanelShowAnswerClass1Chpater2);
        LeanTween.move(panelShowAnswerClass1Chapter2, answerReceiveClass1Chapter2.transform.position, 0.3f);
        //panelShowAnswer.SetActive(false);
        //answerReceive.CancelAnswer();
        //answerReceive = null;
    }
    public void ClosePanelShowAnswerClass2Chapter1()
    {
        LeanTween.scale(panelShowAnswerClass2Chapter1, Vector3.zero, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(OffPanelShowAnswerClass2Chpater1);
        LeanTween.move(panelShowAnswerClass2Chapter1, answerReceiveClass2Chapter1.transform.position, 0.3f);
        //panelShowAnswer.SetActive(false);
        //answerReceive.CancelAnswer();
        //answerReceive = null;
    }
    public void ClosePanelShowAnswerTongHop()
    {
        LeanTween.scale(panelShowAnswerTongHop, Vector3.zero, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(OffPanelShowAnswerTongHop);
        LeanTween.move(panelShowAnswerTongHop, answerReceiveTongHop.transform.position, 0.3f);
        //panelShowAnswer.SetActive(false);
        //answerReceive.CancelAnswer();
        //answerReceive = null;
    }
    public void OpenPanelHuongDanChapter1Class1()
    {
        panelHuongDanChapter1Class1.gameObject.SetActive(true);
    }
    public void ClosePanelHuongDanChapter1Class1()
    {
        panelHuongDanChapter1Class1.gameObject.SetActive(false);  
    }
    public void OpenPanelHuongDanChapter2Class1()
    {
        panelHuongDanChapter2Class1.gameObject.SetActive(true);
    }
    public void ClosePanelHuongDanChapter2Class1()
    {
        panelHuongDanChapter2Class1.gameObject.SetActive(false);
    }
    public void ClosePanelDanhGiaTongHop()
    {
        panelDanhgiaThucLuc.gameObject.SetActive(false);
    }
    private void OffPanelShowAnswer()
    {
        panelShowAnswer.SetActive(false);
        answerReceive.CancelAnswer();
        answerReceive = null;
    }
    private void OffPanelShowAnswerClass1Chpater2()
    {
        panelShowAnswerClass1Chapter2.SetActive(false);
        answerReceiveClass1Chapter2.CancelAnswerClass1Chapter2();
        answerReceiveClass1Chapter2 = null;
    }
    private void OffPanelShowAnswerClass2Chpater1()
    {
        panelShowAnswerClass2Chapter1.SetActive(false);
        answerReceiveClass2Chapter1.CancelAnswerClass2Chapter1();
        answerReceiveClass2Chapter1 = null;
    }
    private void OffPanelShowAnswerTongHop()
    {
        panelShowAnswerTongHop.SetActive(false);
        answerReceiveTongHop.CancelAnswerTongHop();
        answerReceiveTongHop = null;
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
        AudioController.Ins.Playrightsound();
    }
    public void QuestionReceiveAnswerClass1Chapter2(Question9x9 question)
    {

        LeanTween.scale(panelShowAnswerClass1Chapter2, Vector3.zero, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(answerReceiveClass1Chapter2.LockAnswerClass1Chapter2);
        LeanTween.move(panelShowAnswerClass1Chapter2, answerReceiveClass1Chapter2.transform.position, 0.3f);

        imgColorMoveTo.sprite = answerReceiveClass1Chapter2.imgColor.sprite;
        imgColorMoveTo.transform.position = answerReceiveClass1Chapter2.transform.position;
        imgColorMoveTo.gameObject.SetActive(true);
        LeanTween.move(imgColorMoveTo.gameObject, question.transform.position, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(question.ReceiveAnswerClass1Chapter2);
        answerReceiveClass1Chapter2 = null;
        AudioController.Ins.Playrightsound();
    }
    public void QuestionReceiveAnswerClass2Chapter1(Question9x9 question)
    {

        LeanTween.scale(panelShowAnswerClass2Chapter1, Vector3.zero, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(answerReceiveClass2Chapter1.LockAnswerClass2Chapter1);
        LeanTween.move(panelShowAnswerClass2Chapter1, answerReceiveClass2Chapter1.transform.position, 0.3f);

        imgColorMoveTo.sprite = answerReceiveClass2Chapter1.imgColor.sprite;
        imgColorMoveTo.transform.position = answerReceiveClass2Chapter1.transform.position;
        imgColorMoveTo.gameObject.SetActive(true);
        LeanTween.move(imgColorMoveTo.gameObject, question.transform.position, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(question.ReceiveAnswerClass2Chapter1);
        answerReceiveClass1Chapter2 = null;
        AudioController.Ins.Playrightsound();
    }
    public void QuestionReceiveAnswerTongHop(Question9x9 question)
    {

        LeanTween.scale(panelShowAnswerTongHop, Vector3.zero, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(answerReceiveTongHop.LockAnswerTongHop);
        LeanTween.move(panelShowAnswerTongHop, answerReceiveTongHop.transform.position, 0.3f);

        imgColorMoveTo.sprite = answerReceiveTongHop.imgColor.sprite;
        imgColorMoveTo.transform.position = answerReceiveTongHop.transform.position;
        imgColorMoveTo.gameObject.SetActive(true);
        LeanTween.move(imgColorMoveTo.gameObject, question.transform.position, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(question.ReceiveAnswerTongHop);
        answerReceiveTongHop = null;
        AudioController.Ins.Playrightsound();
    }
    public void QuestionCancelAnswer(Answer9x9 answer, Question9x9 question)
    {
        imgColorMoveTo.sprite = question.imgColor.sprite;
        imgColorMoveTo.transform.position = question.transform.position;
        imgColorMoveTo.gameObject.SetActive(true);
        LeanTween.move(imgColorMoveTo.gameObject, answer.transform.position, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(answer.CancelAnswer);
        //answer.CancelAnswer();
    }
    public void QuestionCancelAnswerClass1Chapter2(Answer9x9 answer, Question9x9 question)
    {
        imgColorMoveTo.sprite = question.imgColor.sprite;
        imgColorMoveTo.transform.position = question.transform.position;
        imgColorMoveTo.gameObject.SetActive(true);
        LeanTween.move(imgColorMoveTo.gameObject, answer.transform.position, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(answer.CancelAnswerClass1Chapter2);
        //answer.CancelAnswer();
    }
    public void QuestionCancelAnswerClass2Chapter1(Answer9x9 answer, Question9x9 question)
    {
        imgColorMoveTo.sprite = question.imgColor.sprite;
        imgColorMoveTo.transform.position = question.transform.position;
        imgColorMoveTo.gameObject.SetActive(true);
        LeanTween.move(imgColorMoveTo.gameObject, answer.transform.position, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(answer.CancelAnswerClass2Chapter1);
        //answer.CancelAnswer();
    }
    public void QuestionCancelAnswerTongHop(Answer9x9 answer, Question9x9 question)
    {
        imgColorMoveTo.sprite = question.imgColor.sprite;
        imgColorMoveTo.transform.position = question.transform.position;
        imgColorMoveTo.gameObject.SetActive(true);
        LeanTween.move(imgColorMoveTo.gameObject, answer.transform.position, 0.3f).setEase(LeanTweenType.animationCurve).setOnComplete(answer.CancelAnswerTongHop);
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

    public void CheckCompleteClass1Chapter2()
    {
        Debug.Log("Check Complete");
        int totalAnswer = 0;
        int totalAnswerTrue = 0;
        for (int i = 0; i < listQuestion9x9Class1Chapter2.Count; i++)
        {
            if (listQuestion9x9Class1Chapter2[i].answer != null)
            {
                totalAnswer++;
                if (listQuestion9x9Class1Chapter2[i].id == listQuestion9x9Class1Chapter2[i].answer.id)
                {
                    totalAnswerTrue++;
                }
            }
        }
        if (totalAnswer == listQuestion9x9Class1Chapter2.Count)
        {
            Debug.Log("Check Complete : " + totalAnswerTrue + "/" + totalAnswer);
            TimerChapter2Class1.timerIsRunning = false;
            EndGameChapter2();
        }
        else
        {
            Debug.Log("Chua hoan thanh");
        }
    }
    public void CheckCompleteClass2Chapter1()
    {
        Debug.Log("Check Complete");
        int totalAnswer = 0;
        int totalAnswerTrue = 0;
        for (int i = 0; i < listQuestion9x9Class2Chapter1.Count; i++)
        {
            if (listQuestion9x9Class2Chapter1[i].answer != null)
            {
                totalAnswer++;
                if (listQuestion9x9Class2Chapter1[i].id == listQuestion9x9Class2Chapter1[i].answer.id)
                {
                    totalAnswerTrue++;
                }
            }
        }
        if (totalAnswer == listQuestion9x9Class2Chapter1.Count)
        {
            Debug.Log("Check Complete : " + totalAnswerTrue + "/" + totalAnswer);
            TimerChapter1Class2.timerIsRunning = false;
            EndGameChapter1Class2();
        }
        else
        {
            Debug.Log("Chua hoan thanh");
        }
    }
    public void CheckCompleteTongHop()
    {
        Debug.Log("Check Complete");
        int totalAnswer = 0;
        int totalAnswerTrue = 0;
        for (int i = 0; i < listQuestion9x9TongHop.Count; i++)
        {
            if (listQuestion9x9TongHop[i].answer != null)
            {
                totalAnswer++;
                if (listQuestion9x9TongHop[i].id == listQuestion9x9TongHop[i].answer.id)
                {
                    totalAnswerTrue++;
                }
            }
        }
        if (totalAnswer == listQuestion9x9TongHop.Count)
        {
            Debug.Log("Check Complete : " + totalAnswerTrue + "/" + totalAnswer);
            TimerTongHop.timerIsRunning = false;
            EndGameTongHop();
        }
        else
        {
            Debug.Log("Chua hoan thanh");
        }
    }
    public void ButSettingGame()
    {
        panelSettingGame.gameObject.SetActive(true);
        LeanTween.scale(panelSettingGame, Vector3.one, 0.3f).setEase(LeanTweenType.animationCurve);
    }    
    public void ButCloseGame()
    {
        panelGamePlay.gameObject.SetActive(false);
        panelGameEnd.gameObject.SetActive(false);
        panelClass.gameObject.SetActive(false);
        panelGameClassChapter.gameObject.SetActive(false);
        panelGameClassChapter2.gameObject.SetActive(false);
        panelSettingGame.gameObject.SetActive(false);
        panelGameMenu.gameObject.SetActive(true);
    }
    public void PauseAudio()
    {
        ButtonAudioPause.gameObject.SetActive(false);
        ButtonAudioUnPause.gameObject.SetActive(true);
        AudioController.Ins.StopMusic();
        ButtonAudioPauseIngame.gameObject.SetActive(false);
        ButtonAudioUnPauseIngame.gameObject.SetActive(true);
    }
    public void PauseAudioInGame()
    {
        ButtonAudioPauseIngame.gameObject.SetActive(false);
        ButtonAudioUnPauseIngame.gameObject.SetActive(true);
        AudioController.Ins.StopMusic();
    }
    public void UnPauseAudio()
    {
        ButtonAudioPause.gameObject.SetActive(true);
        ButtonAudioUnPause.gameObject.SetActive(false);
        AudioController.Ins.ContinueMusic();
        ButtonAudioPauseIngame.gameObject.SetActive(true);
        ButtonAudioUnPauseIngame.gameObject.SetActive(false);
    }
    public void UnPauseAudioInGame()
    {
        ButtonAudioPauseIngame.gameObject.SetActive(true);
        ButtonAudioUnPauseIngame.gameObject.SetActive(false);
        AudioController.Ins.ContinueMusic();
    }
    #endregion
    #region EndGame
    public void EndGame()
    {
        AudioController.Ins.StopMusic();
        Debug.Log("End Game");
        panelGamePlay.SetActive(false);
        panelGameEnd.SetActive(true);
        image_BKQChapter1Class1.gameObject.SetActive(true);
        image_BKQChapter2Class1.gameObject.SetActive(false);
        image_BKQChapter1Class2.gameObject.SetActive(false);
        image_BKQTongHop.gameObject.SetActive(false);
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
        if (totalAnswerTrue <= 3)
        {
            txtHoanThanh.text = "Bad";
            imgStar.sprite = spriteStarBreak;
            txtStar.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarChapter1.text = txtStar.text;
            txtHoanThanhChapter1.text = txtHoanThanh.text;
            txtTime.text = Timer.timeText.text;
            AudioController.Ins.Playlosesound();
        }
        else if (totalAnswerTrue <= 6)
        {
            txtHoanThanh.text = "Nice";
            imgStar.sprite = spriteStarBreak;
            txtStar.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarChapter1.text = txtStar.text;
            txtHoanThanhChapter1.text = txtHoanThanh.text;
            txtTime.text = Timer.timeText.text;
            AudioController.Ins.Playwinsound();
        }
        else
        {
            txtHoanThanh.text = "Good";
            imgStar.sprite = spriteStar;
            txtStar.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarChapter1.text = txtStar.text;
            txtHoanThanhChapter1.text = txtHoanThanh.text;
            txtTime.text = Timer.timeText.text;
            AudioController.Ins.Playwinsound();
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
        ButtonChapter1.gameObject.SetActive(false);
        ButtonChapter1Replay.gameObject.SetActive(true);
        ButtonReplayChapter1Class1.gameObject.SetActive(true);
        ButtonReplayChapter1Class2.gameObject.SetActive(false);
        ButtonReplayTongHop.gameObject.SetActive(false);
        ButtonReplayChapter2Class1.gameObject.SetActive(false);
    }

    public void EndGameChapter2()
    {
        Debug.Log("End Game");
        panelGamePlay.SetActive(false);
        panelGameEnd.SetActive(true);
        image_BKQChapter2Class1.gameObject.SetActive(true);
        image_BKQChapter1Class1.gameObject.SetActive(false);
        image_BKQChapter1Class2.gameObject.SetActive(false);
        image_BKQTongHop.gameObject.SetActive(false);
        panelGameEnd.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGameEnd, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        int totalQuestion = listQuestion9x9Class1Chapter2.Count;
        int totalAnswerTrue = 0;
        for (int i = 0; i < totalQuestion; i++)
        {
            if (listQuestion9x9Class1Chapter2[i].answer != null)
            {
                if (listQuestion9x9Class1Chapter2[i].id == listQuestion9x9Class1Chapter2[i].answer.id)
                {
                    totalAnswerTrue++;
                }
            }
        }
        // ?ánh giá k?t qu?
        if (totalAnswerTrue <= 3)
        {
            txtHoanThanhChapter2Class1.text = "Bad";
            imgStar.sprite = spriteStarBreak;
            txtStarChapter2Class1.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarChapter2.text = txtStarChapter2Class1.text;
            txtHoanThanhChapter2.text = txtHoanThanhChapter2Class1.text;
            txtTimeChapter2Class1.text = TimerChapter2Class1.timeText.text;
            AudioController.Ins.Playlosesound();
        }
        else if(totalAnswerTrue <= 6)
        {
            txtHoanThanhChapter2Class1.text = "Nice";
            imgStar.sprite = spriteStarBreak;
            txtStarChapter2Class1.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarChapter2.text = txtStarChapter2Class1.text;
            txtHoanThanhChapter2.text = txtHoanThanhChapter2Class1.text;
            txtTimeChapter2Class1.text = TimerChapter2Class1.timeText.text;
            AudioController.Ins.Playwinsound();
        }
        else
        {
            txtHoanThanhChapter2Class1.text = "Good";
            imgStar.sprite = spriteStar;
            txtStarChapter2Class1.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarChapter2.text = txtStarChapter2Class1.text;
            txtHoanThanhChapter2.text = txtHoanThanhChapter2Class1.text;
            txtTimeChapter2Class1.text = TimerChapter2Class1.timeText.text;
            AudioController.Ins.Playwinsound();
        }
        //init hinh anh
        for (int i = 0; i < listAnswer9x9Class1Chapter2.Count; i++)
        {
            Debug.Log(listAnswer9x9Class1Chapter2);
            //panel Answer EndGame
            Qa9x9 obj = Instantiate(qa9x9);
            obj.transform.SetParent(panelAnswerEndGameClass1Chapter2.transform);
            obj.imgContent.sprite = listAnswer9x9Class1Chapter2[i].imgContent.sprite;
            obj.imgTF.gameObject.SetActive(false);
            obj.transform.localScale = Vector3.one;


            //panel Question EndGGame
            Qa9x9 qt = Instantiate(qa9x9);
            qt.transform.SetParent(panelQuestionEndGameClass1Chapter2.transform);
            qt.imgContent.sprite = listAnswer9x9Class1Chapter2[i].imgColor.sprite;
            if (listQuestion9x9Class1Chapter2[i].answer == null)
            {
                qt.imgTF.sprite = spriteFalse;
            }
            else
            {
                if (listQuestion9x9Class1Chapter2[i].id == listQuestion9x9Class1Chapter2[i].answer.id)
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
        ButtonChapter2.gameObject.SetActive(false);
        ButtonChapter2Replay.gameObject.SetActive(true);
        ButtonReplayChapter1Class1.gameObject.SetActive(false);
        ButtonReplayChapter2Class1.gameObject.SetActive(true);
        ButtonReplayChapter1Class2.gameObject.SetActive(false);
        ButtonReplayTongHop.gameObject.SetActive(false);
    }
    public void EndGameChapter1Class2()
    {
        Debug.Log("End Game");
        panelGamePlay.SetActive(false);
        panelGameEnd.SetActive(true);
        image_BKQChapter1Class2.gameObject.SetActive(true);
        image_BKQChapter1Class1.gameObject.SetActive(false);
        image_BKQChapter2Class1.gameObject.SetActive(false);
        image_BKQTongHop.gameObject.SetActive(false);
        panelGameEnd.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGameEnd, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        int totalQuestion = listQuestion9x9Class2Chapter1.Count;
        int totalAnswerTrue = 0;
        for (int i = 0; i < totalQuestion; i++)
        {
            if (listQuestion9x9Class2Chapter1[i].answer != null)
            {
                if (listQuestion9x9Class2Chapter1[i].id == listQuestion9x9Class2Chapter1[i].answer.id)
                {
                    totalAnswerTrue++;
                }
            }
        }
        // ?ánh giá k?t qu?
        if (totalAnswerTrue <= 3)
        {
            txtHoanThanhChapter1Class2.text = "Bad";
            imgStar.sprite = spriteStarBreak;
            txtStarChapter1Class2.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarChapter1Class2.text = txtStarChapter1Class2.text;
            txtHoanThanhChapter1Class2ChoseClass.text = txtHoanThanhChapter1Class2.text;
            txtTimeChapter1Class2.text = TimerChapter1Class2.timeText.text;
            AudioController.Ins.Playlosesound();
        }
        else if (totalAnswerTrue <= 6)
        {
            txtHoanThanhChapter1Class2.text = "Nice";
            imgStar.sprite = spriteStarBreak;
            txtStarChapter1Class2.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarChapter1Class2.text = txtStarChapter1Class2.text;
            txtHoanThanhChapter1Class2ChoseClass.text = txtHoanThanhChapter1Class2.text;
            txtTimeChapter1Class2.text = TimerChapter1Class2.timeText.text;
            AudioController.Ins.Playwinsound();
        }
        else
        {
            txtHoanThanhChapter1Class2.text = "Good";
            imgStar.sprite = spriteStar;
            txtStarChapter1Class2.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarChapter1Class2.text = txtStarChapter1Class2.text;
            txtHoanThanhChapter1Class2ChoseClass.text = txtHoanThanhChapter1Class2.text;
            txtTimeChapter2Class1.text = TimerChapter2Class1.timeText.text;
            AudioController.Ins.Playwinsound();
        }
        //init hinh anh
        for (int i = 0; i < listAnswer9x9Class2Chapter1.Count; i++)
        {
            Debug.Log(listAnswer9x9Class2Chapter1);
            //panel Answer EndGame
            Qa9x9 obj = Instantiate(qa9x9);
            obj.transform.SetParent(panelAnswerEndGameClass2Chapter1.transform);
            obj.imgContent.sprite = listAnswer9x9Class2Chapter1[i].imgContent.sprite;
            obj.imgTF.gameObject.SetActive(false);
            obj.transform.localScale = Vector3.one;


            //panel Question EndGGame
            Qa9x9 qt = Instantiate(qa9x9);
            qt.transform.SetParent(panelQuestionEndGameClass2Chapter1.transform);
            qt.imgContent.sprite = listAnswer9x9Class2Chapter1[i].imgColor.sprite;
            if (listQuestion9x9Class2Chapter1[i].answer == null)
            {
                qt.imgTF.sprite = spriteFalse;
            }
            else
            {
                if (listQuestion9x9Class2Chapter1[i].id == listQuestion9x9Class2Chapter1[i].answer.id)
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
        ButtonChapter1Class2.gameObject.SetActive(false);
        ButtonChapter1ReplayClass2.gameObject.SetActive(true);
        ButtonReplayChapter1Class1.gameObject.SetActive(false);
        ButtonReplayChapter2Class1.gameObject.SetActive(false);
        ButtonReplayTongHop.gameObject.SetActive(false);
        ButtonReplayChapter1Class2.gameObject.SetActive(true);
    }
    public void EndGameTongHop()
    {
        Debug.Log("End Game");
        panelGamePlay.SetActive(false);
        panelGameEnd.SetActive(true);
        panelDanhgiaThucLuc.gameObject.SetActive(true);
        image_BKQTongHop.gameObject.SetActive(true);
        image_BKQChapter1Class2.gameObject.SetActive(false);
        image_BKQChapter1Class1.gameObject.SetActive(false);
        image_BKQChapter2Class1.gameObject.SetActive(false);
        panelGameEnd.transform.localScale = Vector3.zero;
        LeanTween.scale(panelGameEnd, Vector3.one, 0.5f).setEase(LeanTweenType.animationCurve);
        int totalQuestion = listQuestion9x9TongHop.Count;
        int totalAnswerTrue = 0;
        for (int i = 0; i < totalQuestion; i++)
        {
            if (listQuestion9x9TongHop[i].answer != null)
            {
                if (listQuestion9x9TongHop[i].id == listQuestion9x9TongHop[i].answer.id)
                {
                    totalAnswerTrue++;
                }
            }
        }
        // ?ánh giá k?t qu?
        if (totalAnswerTrue <= 3)
        {
            txtHoanThanhTongHop.text = "Bad";
            imgStar.sprite = spriteStarBreak;
            txtStarTongHop.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarTongHop.text = txtStarTongHop.text;
            txtHoanThanhTongHop.text = txtHoanThanhTongHop.text;
            txtHoanThanhTongHopDanhGia.text = txtHoanThanhTongHop.text;
            txtHoanThanhTongHopDanhGiaStar.text = txtStarTongHop.text;
            txtHoanThanhDanhGia.text = "From the results obtained in general, I recommend that you join the combination course from grade 1 to get a good background and continue practicing to achieve better results.";
            txtTimeTongHop.text = TimerTongHop.timeText.text;
            AudioController.Ins.Playlosesound();
        }
        else if (totalAnswerTrue <= 6)
        {
            txtHoanThanhTongHop.text = "Nice";
            imgStar.sprite = spriteStarBreak;
            txtStarTongHop.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarTongHop.text = txtStarTongHop.text;
            txtHoanThanhTongHop.text = txtHoanThanhTongHop.text;
            txtHoanThanhTongHopDanhGia.text = txtHoanThanhTongHop.text;
            txtHoanThanhTongHopDanhGiaStar.text = txtStarTongHop.text;
            txtHoanThanhDanhGia.text = "From the results obtained together, I recommend that you join the class 2 course to continue practicing to achieve better results.";
            txtTimeChapter1Class2.text = TimerChapter1Class2.timeText.text;
            AudioController.Ins.Playwinsound();
        }
        else
        {
            txtHoanThanhTongHop.text = "Good";
            imgStar.sprite = spriteStar;
            txtStarTongHop.text = totalAnswerTrue + "/" + totalQuestion;
            txtStarTongHop.text = txtStarChapter1Class2.text;
            txtHoanThanhTongHopDanhGiaStar.text = txtStarTongHop.text;
            txtHoanThanhTongHop.text = txtHoanThanhTongHop.text;
            txtHoanThanhTongHopDanhGia.text = txtHoanThanhTongHop.text;
            txtHoanThanhTongHopDanhGiaStar.text = txtStarTongHop.text;
            txtHoanThanhDanhGia.text = "You finished the exam with the best results, keep practicing.";
            txtTimeTongHop.text = TimerTongHop.timeText.text;
            AudioController.Ins.Playwinsound();
        }
        //init hinh anh
        for (int i = 0; i < listAnswer9x9TongHop.Count; i++)
        {
            Debug.Log(listAnswer9x9TongHop);
            //panel Answer EndGame
            Qa9x9 obj = Instantiate(qa9x9);
            obj.transform.SetParent(panelAnswerEndGameTongHop.transform);
            obj.imgContent.sprite = listAnswer9x9TongHop[i].imgContent.sprite;
            obj.imgTF.gameObject.SetActive(false);
            obj.transform.localScale = Vector3.one;


            //panel Question EndGGame
            Qa9x9 qt = Instantiate(qa9x9);
            qt.transform.SetParent(panelQuestionEndGameTongHop.transform);
            qt.imgContent.sprite = listAnswer9x9TongHop[i].imgColor.sprite;
            if (listQuestion9x9TongHop[i].answer == null)
            {
                qt.imgTF.sprite = spriteFalse;
            }
            else
            {
                if (listQuestion9x9TongHop[i].id == listQuestion9x9TongHop[i].answer.id)
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
        ButtonReplayTongHop.gameObject.SetActive(true);
        ButtonReplayChapter1Class1.gameObject.SetActive(false);
        ButtonReplayChapter1Class2.gameObject.SetActive(false);
        ButtonReplayChapter2Class1.gameObject.SetActive(false);
        ButtonSynthensis.gameObject.SetActive(false);
        ButtonSynthensisReplay.gameObject.SetActive(true);
    }
    public void ButReplay()
    {
        Reset();
        panelSettingGame.gameObject.SetActive(false);
    }
    public void ButReplayChapter2()
    {
        ResetChapter2();
        panelSettingGame.gameObject.SetActive(false);
    }
    public void ButReplayChapter1Class2()
    {
        ResetChapter1Class2();

        panelSettingGame.gameObject.SetActive(false);
    }
    public void ButReplayTongHop()
    {
        ResetTongHop();

        panelSettingGame.gameObject.SetActive(false);
    }
    private void Reset()
    {
        panelFormClass1Chapter1.gameObject.SetActive(true);
        panelFormClass1Chapter2.gameObject.SetActive(false);
        panelFormClass2Chapter1.gameObject.SetActive(false);
        panelFormTongHop.gameObject.SetActive(false);
        ButtonSubmitChapter1.gameObject.SetActive(true);
        ButtonSubmitChapter2.gameObject.SetActive(false);
        ButtonSubmitChapter1Class2.gameObject.SetActive(false);
        ButtonSubmitTongHop.gameObject.SetActive(false);
        panelHuongDanChapter1Class1.gameObject.SetActive(true);

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
        //choseChapter1OfClasss1();
        Timer.Reset();
    }
    private void ResetChapter2()
    {
        panelFormClass1Chapter1.gameObject.SetActive(false);
        panelFormClass2Chapter1.gameObject.SetActive(false);
        panelFormTongHop.gameObject.SetActive(false);
        panelFormClass1Chapter2.gameObject.SetActive(true);
        ButtonSubmitChapter2.gameObject.SetActive(true);
        ButtonSubmitChapter1.gameObject.SetActive(false);
        ButtonSubmitChapter1Class2.gameObject.SetActive(false);
        ButtonSubmitTongHop.gameObject.SetActive(false);
        //h?y gameobject trong panelAnswer và panelQuestion
        for (int i = 0; i < listAnswer9x9Class1Chapter2.Count; i++)
        {
            Destroy(listAnswer9x9Class1Chapter2[i].gameObject);
            Destroy(listQuestion9x9Class1Chapter2[i].gameObject);
        }
        // gán listAnwser và listQuestion m?i
        listAnswer9x9Class1Chapter2 = new List<Answer9x9>();
        listQuestion9x9Class1Chapter2 = new List<Question9x9>();
        // h?y gameobject trong panelAnswerEndgame và panelQuestionEndgame
        foreach (Transform child in panelAnswerEndGameClass1Chapter2.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in panelQuestionEndGameClass1Chapter2.transform)
        {
            Destroy(child.gameObject);
        }
        //init l?i giá tr? ?? không gi?ng l??t ch?i ??u
        InitClass1Chapter2();
        InitAnswerChapter2();
        InitQuestionChapter2();
        // Reset l?i th?i gian
        Timer.Reset();
    }
    private void ResetChapter1Class2()
    {
        panelFormClass1Chapter1.gameObject.SetActive(false);
        panelFormClass1Chapter2.gameObject.SetActive(false);
        panelFormTongHop.gameObject.SetActive(false);
        panelFormClass2Chapter1.gameObject.SetActive(true);
        ButtonSubmitChapter1Class2.gameObject.SetActive(true);
        ButtonSubmitChapter1.gameObject.SetActive(false);
        ButtonSubmitChapter2.gameObject.SetActive(false);
        ButtonSubmitTongHop.gameObject.SetActive(false);
        //h?y gameobject trong panelAnswer và panelQuestion
        for (int i = 0; i < listAnswer9x9Class2Chapter1.Count; i++)
        {
            Destroy(listAnswer9x9Class2Chapter1[i].gameObject);
            Destroy(listQuestion9x9Class2Chapter1[i].gameObject);
        }
        // gán listAnwser và listQuestion m?i
        listAnswer9x9Class2Chapter1 = new List<Answer9x9>();
        listQuestion9x9Class2Chapter1 = new List<Question9x9>();
        // h?y gameobject trong panelAnswerEndgame và panelQuestionEndgame
        foreach (Transform child in panelAnswerEndGameClass2Chapter1.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in panelQuestionEndGameClass2Chapter1.transform)
        {
            Destroy(child.gameObject);
        }
        //init l?i giá tr? ?? không gi?ng l??t ch?i ??u
        InitClass2Chapter1();
        InitAnswerChapter1Class2();
        InitQuestionChapter1Class2();
        // Reset l?i th?i gian
        Timer.Reset();
    }
    private void ResetTongHop()
    {
        panelFormClass1Chapter1.gameObject.SetActive(false);
        panelFormClass1Chapter2.gameObject.SetActive(false);
        panelFormClass2Chapter1.gameObject.SetActive(false);
        panelFormTongHop.gameObject.SetActive(true);
        ButtonSubmitTongHop.gameObject.SetActive(true);
        ButtonSubmitChapter1Class2.gameObject.SetActive(false);
        ButtonSubmitChapter1.gameObject.SetActive(false);
        ButtonSubmitChapter2.gameObject.SetActive(false);
        //h?y gameobject trong panelAnswer và panelQuestion
        for (int i = 0; i < listAnswer9x9TongHop.Count; i++)
        {
            Destroy(listAnswer9x9TongHop[i].gameObject);
            Destroy(listQuestion9x9TongHop[i].gameObject);
        }
        // gán listAnwser và listQuestion m?i
        listAnswer9x9TongHop = new List<Answer9x9>();
        listQuestion9x9TongHop = new List<Question9x9>();
        // h?y gameobject trong panelAnswerEndgame và panelQuestionEndgame
        foreach (Transform child in panelAnswerEndGameTongHop.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in panelQuestionEndGameTongHop.transform)
        {
            Destroy(child.gameObject);
        }
        //init l?i giá tr? ?? không gi?ng l??t ch?i ??u
        InitTongHop();
        InitAnswerTongHop();
        InitQuestionTongHop();
        // Reset l?i th?i gian
        Timer.Reset();
    }
    #endregion 
}
