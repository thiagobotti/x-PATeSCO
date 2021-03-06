
using System;

namespace UnitTestProject
{
    public static class ProjectConfig
    {
    
        public static string OutputPath { get; private set; }
        public static string OutputDeviceID { get; private set; }

        public static string PlataformName { get; private set; }
        public static string PlatformVersion { get; private set; }
        public static string DeviceName { get; private set; }
        public static string AppPackage { get; private set; }
        public static string AppPath { get; private set; }
        public static string AppActivity { get; private set; }

        public static string AppiumServer { get; private set; }
        public static string Uuid { get; private set; }
        public static int IndexDeviceUnderTest { get; private set; }

        static ProjectConfig()
        {

            /*Configure here your device*/

            var configs = new[] {
                new { OutputDeviceID = "Android6.0.1-MotoG4", PlataformName = "Android", PlatformVersion = "6.0.1", DeviceName = "0027098861", AppPackage = "com.xamarin.samples.taskyandroid", Uuid = "", AppPath = @"C:\Users\Andr�\OneDrive\Documentos\Mestrado\Disserta��o\Experimento\Recursos\Apps\Xamarin\Tasky\com.xamarin.samples.taskyandroid-Signed.apk", AppActivity = @"md5bbb25a9058d34cf10a190d1b73f3f1de.HomeScreen"},
                new { OutputDeviceID = "Android5.1-MotoG1", PlataformName = "Android", PlatformVersion = "5.1", DeviceName = "T0997063PS", AppPackage = "com.xamarin.samples.taskyandroid", Uuid = "", AppPath = @"C:\Users\Andr�\OneDrive\Documentos\Mestrado\Disserta��o\Experimento\Recursos\Apps\Xamarin\Tasky\com.xamarin.samples.taskyandroid-Signed.apk", AppActivity = @"md5bbb25a9058d34cf10a190d1b73f3f1de.HomeScreen"},
                new { OutputDeviceID = "IOS9.3-iPad", PlataformName = "iOS", PlatformVersion = "7.3", DeviceName = "iPadWeb", AppPackage = "Tasky.Xamarin", Uuid = "b35c1fcf89f97266dac59d48037b52dfabe5fccb", AppPath = @"", AppActivity = @""},
                new { OutputDeviceID = "IOS7.1.2-iPhone", PlataformName = "iOS", PlatformVersion = "7.1.2", DeviceName = "iPhoneAndre", AppPackage = "Tasky.Xamarin", Uuid = "e5da05bf8763bbd6e853205b6e57a89af0ee8c4d", AppPath = @"", AppActivity = @""},
                new { OutputDeviceID = "IOS10.2-iPad4", PlataformName = "iOS", PlatformVersion = "10.2", DeviceName = "iPad4", AppPackage = "Tasky.Xamarin", Uuid = "3b5a62f85e1d2b47237b79b12fb3f42490f8d1e7", AppPath = @"", AppActivity = ""},
                new { OutputDeviceID = "Android4.4-TabletSamsung", PlataformName = "Android", PlatformVersion = "4.4", DeviceName = "3004d2af55e18200", AppPackage = "com.xamarin.samples.taskyandroid", Uuid = "", AppPath = @"C:\Users\Andr�\OneDrive\Documentos\Mestrado\Disserta��o\Experimento\Recursos\Apps\Xamarin\Tasky\com.xamarin.samples.taskyandroid-Signed.apk",  AppActivity = "md5bbb25a9058d34cf10a190d1b73f3f1de.HomeScreen"}
            };


            
            //OutputDeviceID = ""; //Sample: android6.1-table-samsung
            //PlataformName = "Android"; //use "Android" or "iOS"
            //PlatformVersion = ""; //sample: "6.0.1", "7.3");
            //DeviceName = ""; //for Android, execute in CMD adb devices, for iOS use XCODE 
            //AppPackage = ""; //sample: com.unoeste.teste
            //Uuid = "";
            //AppPath = "";

            OutputPath = @"c:\temp";
            
            int indexDeviceUnderTest = 4;

            IndexDeviceUnderTest = indexDeviceUnderTest;


            OutputDeviceID = configs[indexDeviceUnderTest].OutputDeviceID;
            PlataformName = configs[indexDeviceUnderTest].PlataformName;
            PlatformVersion = configs[indexDeviceUnderTest].PlatformVersion;
            DeviceName = configs[indexDeviceUnderTest].DeviceName;
            AppPackage = configs[indexDeviceUnderTest].AppPackage;
			AppPath = configs[indexDeviceUnderTest].AppPath;
			AppActivity = configs[indexDeviceUnderTest].AppActivity;

            if (PlataformName == "Android")
            {
                AppiumServer = "http://127.0.0.1:4723/wd/hub";
            }
            else if (PlataformName == "iOS")
            {
                Uuid = configs[indexDeviceUnderTest].Uuid;
                AppiumServer = "http://192.168.159.129:4723/wd/hub";        
			}
        }


    }
}
