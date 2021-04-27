using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using com.shubao.xinstallunitysdk;

public class FirstUnity : MonoBehaviour
{
	private XinstallBehaviour xinstall;

    public Text installResult;
    public Text wakeupResult;
    // Start is called before the first frame update
    void Start()
    {
        xinstall = GameObject.Find("XinstallBehaviour").GetComponent<XinstallBehaviour>(); 

        installResult = GameObject.Find("InstallText").GetComponent<Text>();
        wakeupResult = GameObject.Find("WakeupText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getInstallButtonClick()
    {
    	Debug.Log("chao");
        // xinstall.reportRegister();
        installResult.text = "开始安装";
        xinstall.getInstallParam(10,getInstallData);
        
    }

    public void registerWakeupHandlerButtonClick()
    {
        xinstall.RegisterWakeupHandler(getWakeupData);
        wakeupResult.text = "开始获取唤起";
    }

    public void reportRegisterButtonClick()
    {
        xinstall.reportRegister();
    }

    public void reportEffectEventButtonClick() 
    {
        xinstall.reportEffectEvent("250",1);
    }

    // callback
    public void getInstallData(XinstallInstallData installData)
    {
        if (installData == null) {
            Debug.Log("未获取到安装数据");
            installResult.text = "未获取到安装数据";
        } else {
            Debug.Log("XinstallSample getInstallData : 渠道编号=" + installData.channelCode + "，自定义数据=" + installData.data + "，是否是第一次获取安装参数=" + installData.isFirstFetch);
            installResult.text = "安装参数：" + JsonUtility.ToJson(installData);
        }
        
    }

    public void getWakeupData(XinstallData wakeupData)
    {
		if (wakeupData == null) {
		    Debug.Log("未获取到调起数据");
		    wakeupResult.text = "未获取到调起数据";
		} else {
			Debug.Log("XinstallSample getWakeupData : 渠道编号=" + wakeupData.channelCode + "， 自定义数据=" + wakeupData.data);
			wakeupResult.text = "拉起参数：" + JsonUtility.ToJson(wakeupData);
		}
    }
}
