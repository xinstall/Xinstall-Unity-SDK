package com.shubao.xinstallunitysdk;

import android.content.Intent;
import android.os.Bundle;

import com.unity3d.player.UnityPlayerActivity;
import com.xinstall.XInstall;

public class XUnityActivity extends UnityPlayerActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        XInstall.getWakeUpParam(getIntent(), wakeupCallback);
    }

    @Override
    protected void onNewIntent(Intent intent) {
        super.onNewIntent(intent);
        XInstall.getWakeUpParam(intent, wakeupCallback);
    }


    XWakeUpCallback wakeupCallback = new XWakeUpCallback();
}