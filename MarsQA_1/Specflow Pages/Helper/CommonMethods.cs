﻿using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

//namespace MarsQA_1.Specflow_Pages.Helper
//{
//    class CommonMethods
//    {
//        //Screenshots
//        //Screenshot

//        public class SaveScreenShotClass
//        {
//            public static object ConstantHelpers { get; private set; }

//            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
//            {
//                var folderLocation = ConstantHelpers.ScreenshotPath;

//                if (!System.IO.Directory.Exists(folderLocation))
//                {
//                    System.IO.Directory.CreateDirectory(folderLocation);
//                }

//                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
//                var fileName = new StringBuilder(folderLocation);

//                fileName.Append(ScreenShotFileName);
//                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
//                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
//                fileName.Append(".jpeg");
//                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
//                return fileName.ToString();
//            }
//        }

//        //ExtentReports
//        #region reports
//        public static ExtentTest test;
//        public static ExtentReports Extent;

//        public static object DisplayOrder { get; private set; }

//        public static void ExtentReports()
//        {
//            Extent = new ExtentReports(ConstantHelpers.ReportsPath, true, DisplayOrder.NewestFirst);
//            Extent.LoadConfig(ConstantHelpers.ReportXMLPath);
//        }

//    }
//}
//}