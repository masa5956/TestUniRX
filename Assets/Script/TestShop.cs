using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
public class TestShop : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Panel = new List<GameObject>();
    [SerializeField]
    List<Button> buttons = new List<Button>();
   // Start is called before the first frame update
    void Start()
    {
        //購入、売却選択画面
        Panel[0].SetActive(false);
        //アイテム一覧
        Panel[1].SetActive(false);

        //購入画面を開く
        buttons[0].OnClickAsObservable()
            .Subscribe(x => Panel[0].SetActive(true));


        //アイテム一覧を開く
        buttons[1].OnClickAsObservable()
            .Subscribe(x => Panel[1].SetActive(true));

        buttons[2].OnClickAsObservable()
            .Subscribe(x => Close());
        
    }
    void Close()
    {
        foreach (GameObject C in Panel)
        {
            C.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
