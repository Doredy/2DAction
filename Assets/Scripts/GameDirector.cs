using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private GoalChecker goalHousePrefab;
    [SerializeField]
    private PlayerController playerController;
    [SerializeField]
    private FloorGenerator[] floorGenerators;
    [SerializeField]
    private RandomObjectGenerator[] randomObjectGenerators;
    [SerializeField]
    private AudioManager audioManager;
    private bool isSetUp;
    private bool isGameUp;
    private int generateCount;

    public int GenerateCount
    {
        set
        {
            generateCount = value;
            Debug.Log("������ / �N���A�ڕW�� : " + generateCount + " / " + clearCount);
            if (generateCount >= clearCount)
            {
                GenerateGoal();
                GameUp();
            }
        }
        get
        {
            return generateCount;
        }
    }

    public int clearCount;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(audioManager.PlayBGM(0));
        isGameUp = false;
        isSetUp = false;
        SetUpFloorGenerators();
        Debug.Log("������~");
        StopGenerators();
    }

    private void SetUpFloorGenerators()
    {
        for (int i = 0; i < floorGenerators.Length; i++)
        {
            floorGenerators[i].SetUpGenerator(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.isFirstGenerateBallon && isSetUp == false)
        {
            isSetUp = true;
            Debug.Log("�����X�^�[�g");
            ActivateGenerators();
            StartCoroutine(audioManager.PlayBGM(1));
        }
    }

    private void GenerateGoal()
    {
        GoalChecker goalHouse = Instantiate(goalHousePrefab);
        Debug.Log("�S�[���n�_����");
        goalHouse.SetUpGoalHouse(this);
    }

    public void GameUp()
    {
        isGameUp = true;
        Debug.Log("������~");
        StopGenerators();
    }

    private void StopGenerators()
    {
        for (int i = 0; i < randomObjectGenerators.Length; i++)
        {
            randomObjectGenerators[i].SwitchActivation(false);
        }
        for (int i = 0; i < floorGenerators.Length; i++)
        {
            floorGenerators[i].SwitchActivation(false);
        }
    }
    private void ActivateGenerators()
    {
        for (int i = 0; i < randomObjectGenerators.Length; i++)
        {
            randomObjectGenerators[i].SwitchActivation(true);
        }
        for (int i = 0; i < floorGenerators.Length; i++)
        {
            floorGenerators[i].SwitchActivation(true);
        }
    }
    
    public void GoalClear()
    {
        StartCoroutine(audioManager.PlayBGM(2));
    }
}
