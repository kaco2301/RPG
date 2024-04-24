using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginScene : BaseScene
{
    protected override void Init()
    {
        base.Init();

        SceneType = Define.Scene.Login;


        List<GameObject> list = new List<GameObject>();

        foreach(GameObject obj in list)
        {
            Managers.Resource.Destroy(obj);
        }

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Managers.Scene.LoadScene(Define.Scene.Game);
        }
    }
    public override void Clear()
    {
        Debug.Log("Login Scene Clear");
    }
}
