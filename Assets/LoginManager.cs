using System;
using System.Collections;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    TestScript testScript = null;

    private void Awake() 
    {
        testScript = GetComponent<TestScript>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Login();
    }

    private void Login()
    {
        if (string.IsNullOrEmpty(PlayFabSettings.TitleId))
        {
            PlayFabSettings.TitleId = "D8E6D";
        }
        
        PlayFabClientAPI.LoginWithCustomID(new LoginWithCustomIDRequest
        {
            CreateAccount = true,
            TitleId = PlayFabSettings.TitleId,
            CustomId = "TestCustomID"
        },
        OnLoginSuccess, OnSharedError);
    }

    private void OnSharedError(PlayFabError obj)
    {
        Debug.Log(obj.GenerateErrorReport());
    }

    private void OnLoginSuccess(LoginResult result)
    {
        testScript.RunTest();
    }
}
