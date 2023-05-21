using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_MouseOverEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler

{
    public GameObject objSubMenu;
    public Button btnMenu;

    void Start(){
        objSubMenu.SetActive(false);
        btnMenu.onClick.AddListener(ToggleSubMenu);
        Debug.Log("4");
    }

    void ToggleSubMenu(){
        objSubMenu.SetActive(!objSubMenu.activeSelf);
        Debug.Log("3");
    }
    public void OnPointerEnter(PointerEventData eventData){
        objSubMenu.SetActive(true);
        Debug.Log("2");
    }

    public void OnPointerExit(PointerEventData eventData){
        objSubMenu.SetActive(false);
        Debug.Log("1");
    }
    
}
