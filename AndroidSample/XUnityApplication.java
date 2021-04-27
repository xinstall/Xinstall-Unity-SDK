package com.shubao.xinstallunitysdk;

import android.app.Application;

import com.xinstall.XInstall;

public class XUnityApplication extends Application {

    @Override
    public void onCreate() {
        super.onCreate();

        if (XInstall.isMainProcess(this)) {
            XInstall.init(this);
        }
    }
}