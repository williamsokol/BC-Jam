using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicBarsController : MonoBehaviour


{
    public static CinematicBarsController Instance { get; private set; }

    [SerializeField] private GameObject _cinematicConteiner;
    [SerializeField] private Animator _animator;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else if (Instance != this)
        {
            Destroy(gameObject);
        }

    }

    public void ShowBars()
    {
        _cinematicConteiner.SetActive(true);
    }

    public void HideBars()
    {   if (_cinematicConteiner.activeSelf)
        {
            StartCoroutine(DisableBars());
        }
        
    }

    //Corutine to desactive the bars controller after the hide animation
    private IEnumerator DisableBars ()
    {
        _animator.SetTrigger("HideBarsTrig");
        yield return new WaitForSeconds(1f);
        _cinematicConteiner.SetActive(false);
    }

}
