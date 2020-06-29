using System.Collections;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{

    #region Fields

    //Movement Variables
    [SerializeField] private Vector2 startPoint;
    [SerializeField] private Vector2 endPoint;
    private bool movingTowardsStartPoint = false;
    [SerializeField] private float movementSpeed = 3f;

    //Turn Around Variables
    [SerializeField] private float turnAroundWaitTime = 0.5f;
    private float currentTurnAroundTime = 0f;
    private bool turnAround = false;
    private bool checkForMovement = false;
    [SerializeField] private float checkForMovementTimer = 0.5f;


    //Component Refrences
    private Rigidbody2D enemyRigidbody;

    #endregion

    #region Constructor

    private void Awake()
    {
        enemyRigidbody = this.GetComponent<Rigidbody2D>();
    }

    #endregion

    #region Methods

    private void Update()
    {
        Check_For_Position();
        move();
        Check_For_Turn_Around();
        StartCoroutine(Check_For_Movement_Start());
    }

    private void Check_For_Position()
    {
        if (checkForMovement)
        {
            if (this.transform.position.x >= endPoint.x)
            {
                movingTowardsStartPoint = true;
                turnAround = true;
            }
            else if (this.transform.position.x <= startPoint.x)
            {
                movingTowardsStartPoint = false;
                turnAround = true;
            }
        }
    }

    private IEnumerator Check_For_Movement_Start()
    {
        if(!checkForMovement)
        {
            yield return new WaitForSeconds(checkForMovementTimer);
            checkForMovement = true;
        }
    }

    private void move()
    {
        if (movingTowardsStartPoint && !turnAround)
        {
            this.transform.position += new Vector3(-movementSpeed, 0f, 0f) * Time.deltaTime;
        }
        else if(!movingTowardsStartPoint && !turnAround)
        {
            this.transform.position += new Vector3(movementSpeed, 0f, 0f) * Time.deltaTime;
        }
    }

    private void Check_For_Turn_Around()
    {
        if(turnAround)
        {
            currentTurnAroundTime += Time.deltaTime;

            if(currentTurnAroundTime >= turnAroundWaitTime)
            {
                currentTurnAroundTime = 0f;
                turnAround = false;
                checkForMovement = false;
            }
        }
    }

    #endregion

}
