﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Admin
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("04ab11f5-d7c7-4bbb-8874-2282e5258798", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AdminRepository repository.
        /// </summary>
        public static AdminRepository repo = AdminRepository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            StartAutProcessIDVar = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT Instance
        {
            get { return instance; }
        }

#region Variables

        string _StartAutProcessIDVar;

        /// <summary>
        /// Gets or sets the value of variable StartAutProcessIDVar.
        /// </summary>
        [TestVariable("0bd06f96-2ab3-4e21-9a5f-d0db6f8f3a3e")]
        public string StartAutProcessIDVar
        {
            get { return _StartAutProcessIDVar; }
            set { _StartAutProcessIDVar = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application '\"C:\\Program Files\\SOLIDWORKS PDM\\ConisioAdmin.exe\"' with arguments 'Administration' in normal mode. Return value bound to $StartAutProcessIDVar.", new RecordItemIndex(0));
            StartAutProcessIDVar = ValueConverter.ToString(Host.Local.RunApplication("\"C:\\Program Files\\SOLIDWORKS PDM\\ConisioAdmin.exe\"", "Administration", "C:\\Windows\\Installer\\{0C4A53B0-256B-46A8-B6A0-7CEED3610006}", false));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(1));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.About' at 14;6.", repo.SOLIDWORKSPDMAdministration.AboutInfo, new RecordItemIndex(2));
            repo.SOLIDWORKSPDMAdministration.About.Click("14;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='SOLIDWORKS PDM 2025 (SP 2.0)') on item 'AboutSOLIDWORKSPDMAdministration.Text1021'.", repo.AboutSOLIDWORKSPDMAdministration.Text1021Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.AboutSOLIDWORKSPDMAdministration.Text1021Info, "Text", "SOLIDWORKS PDM 2025 (SP 2.0)");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'AboutSOLIDWORKSPDMAdministration.Text1571' at 63;11.", repo.AboutSOLIDWORKSPDMAdministration.Text1571Info, new RecordItemIndex(4));
            repo.AboutSOLIDWORKSPDMAdministration.Text1571.MoveTo("63;11");
            repo.AboutSOLIDWORKSPDMAdministration.Text1571.MouseDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'AboutSOLIDWORKSPDMAdministration.Text1571' at -37;6.", repo.AboutSOLIDWORKSPDMAdministration.Text1571Info, new RecordItemIndex(5));
            repo.AboutSOLIDWORKSPDMAdministration.Text1571.MoveTo("-37;6");
            repo.AboutSOLIDWORKSPDMAdministration.Text1571.MouseUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F15}' with focus on 'AboutSOLIDWORKSPDMAdministration'.", repo.AboutSOLIDWORKSPDMAdministration.SelfInfo, new RecordItemIndex(6));
            repo.AboutSOLIDWORKSPDMAdministration.Self.EnsureVisible();
            Keyboard.Press("{F15}");
            Delay.Milliseconds(80);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='33.2 (B130)') on item 'AboutSOLIDWORKSPDMAdministration.Text1571'.", repo.AboutSOLIDWORKSPDMAdministration.Text1571Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.AboutSOLIDWORKSPDMAdministration.Text1571Info, "Text", "33.2 (B130)");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AboutSOLIDWORKSPDMAdministration.ButtonOK' at 40;4.", repo.AboutSOLIDWORKSPDMAdministration.ButtonOKInfo, new RecordItemIndex(8));
            repo.AboutSOLIDWORKSPDMAdministration.ButtonOK.Click("40;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.Tree10011.SOLIDWORKSPDMAdministration' at 150;6.", repo.SOLIDWORKSPDMAdministration.Tree10011.SOLIDWORKSPDMAdministrationInfo, new RecordItemIndex(9));
            repo.SOLIDWORKSPDMAdministration.Tree10011.SOLIDWORKSPDMAdministration.Click("150;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SOLIDWORKSPDMAdministration.Tree10011.SOLIDWORKSPDMAdministration' at 150;6.", repo.SOLIDWORKSPDMAdministration.Tree10011.SOLIDWORKSPDMAdministrationInfo, new RecordItemIndex(10));
            repo.SOLIDWORKSPDMAdministration.Tree10011.SOLIDWORKSPDMAdministration.Click(System.Windows.Forms.MouseButtons.Right, "150;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.Tree10011.SOLIDWORKSPDMAdministration' at 143;6.", repo.SOLIDWORKSPDMAdministration.Tree10011.SOLIDWORKSPDMAdministrationInfo, new RecordItemIndex(11));
            repo.SOLIDWORKSPDMAdministration.Tree10011.SOLIDWORKSPDMAdministration.Click("143;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1920 units.", new RecordItemIndex(12));
            Mouse.ScrollWheel(-1920);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.Tree10011.Tree1001' at 35;34.", repo.SOLIDWORKSPDMAdministration.Tree10011.Tree1001Info, new RecordItemIndex(13));
            repo.SOLIDWORKSPDMAdministration.Tree10011.Tree1001.Click("35;34");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F15}' with focus on 'SOLIDWORKSPDMAdministration.Tree10011.Tree1001'.", repo.SOLIDWORKSPDMAdministration.Tree10011.Tree1001Info, new RecordItemIndex(14));
            repo.SOLIDWORKSPDMAdministration.Tree10011.Tree1001.PressKeys("{F15}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.Tree10011.KeywordTest' at 9;13.", repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestInfo, new RecordItemIndex(15));
            repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTest.Click("9;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SOLIDWORKSPDMAdministration.Tree10011.KeywordTest' at 9;13.", repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestInfo, new RecordItemIndex(16));
            repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTest.Click(System.Windows.Forms.MouseButtons.Right, "9;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.Tree10011.CEPA' at 28;35.", repo.SOLIDWORKSPDMAdministration.Tree10011.CEPAInfo, new RecordItemIndex(17));
            repo.SOLIDWORKSPDMAdministration.Tree10011.CEPA.Click("28;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SOLIDWORKSPDMAdministration.Tree10011.KeywordTest' at 28;13.", repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestInfo, new RecordItemIndex(18));
            repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTest.Click(System.Windows.Forms.MouseButtons.Right, "28;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContextMenuHash32768.None' at 63;9.", repo.ContextMenuHash32768.NoneInfo, new RecordItemIndex(19));
            repo.ContextMenuHash32768.None.Click("63;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'SOLIDWORKSPDMLoginKeywordTest.Text2001' at 60;14.", repo.SOLIDWORKSPDMLoginKeywordTest.Text2001Info, new RecordItemIndex(20));
            repo.SOLIDWORKSPDMLoginKeywordTest.Text2001.MoveTo("60;14");
            repo.SOLIDWORKSPDMLoginKeywordTest.Text2001.MouseDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'SOLIDWORKSPDMLoginKeywordTest.Text2001' at -124;-4.", repo.SOLIDWORKSPDMLoginKeywordTest.Text2001Info, new RecordItemIndex(21));
            repo.SOLIDWORKSPDMLoginKeywordTest.Text2001.MoveTo("-124;-4");
            repo.SOLIDWORKSPDMLoginKeywordTest.Text2001.MouseUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'admin' with focus on 'SOLIDWORKSPDMLoginKeywordTest.SOLIDWORKSPDMLoginKeywordTest'.", repo.SOLIDWORKSPDMLoginKeywordTest.SOLIDWORKSPDMLoginKeywordTestInfo, new RecordItemIndex(22));
            repo.SOLIDWORKSPDMLoginKeywordTest.SOLIDWORKSPDMLoginKeywordTest.EnsureVisible();
            Keyboard.Press("admin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMLoginKeywordTest.SOLIDWORKSPDMLoginKeywordTest' at 406;232.", repo.SOLIDWORKSPDMLoginKeywordTest.SOLIDWORKSPDMLoginKeywordTestInfo, new RecordItemIndex(23));
            repo.SOLIDWORKSPDMLoginKeywordTest.SOLIDWORKSPDMLoginKeywordTest.Click("406;232");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.Tree10011.Tree1001' at 51;120.", repo.SOLIDWORKSPDMAdministration.Tree10011.Tree1001Info, new RecordItemIndex(24));
            repo.SOLIDWORKSPDMAdministration.Tree10011.Tree1001.Click("51;120");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin' at 7;11.", repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdminInfo, new RecordItemIndex(25));
            repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin.DoubleClick("7;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin' at 69;5.", repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdminInfo, new RecordItemIndex(26));
            repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin.Click("69;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin' at 69;5.", repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdminInfo, new RecordItemIndex(27));
            repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin.Click(System.Windows.Forms.MouseButtons.Right, "69;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContextMenuHash32768.None' at 100;12.", repo.ContextMenuHash32768.NoneInfo, new RecordItemIndex(28));
            repo.ContextMenuHash32768.None.Click("100;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1440 units.", new RecordItemIndex(29));
            Mouse.ScrollWheel(-1440);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin' at 21;11.", repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdminInfo, new RecordItemIndex(30));
            repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin.Click("21;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin' at 21;11.", repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdminInfo, new RecordItemIndex(31));
            repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin.Click(System.Windows.Forms.MouseButtons.Right, "21;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContextMenuHash32768.None' at 131;8.", repo.ContextMenuHash32768.NoneInfo, new RecordItemIndex(32));
            repo.ContextMenuHash32768.None.Click("131;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F15}' with focus on 'SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration'.", repo.SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministrationInfo, new RecordItemIndex(33));
            repo.SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration.EnsureVisible();
            Keyboard.Press("{F15}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministrationFileVau.TitleBar' at 159;10.", repo.SOLIDWORKSPDMAdministrationFileVau.TitleBarInfo, new RecordItemIndex(34));
            repo.SOLIDWORKSPDMAdministrationFileVau.TitleBar.Click("159;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SOLIDWORKSPDMAdministrationFileVau.TitleBar'.", repo.SOLIDWORKSPDMAdministrationFileVau.TitleBarInfo, new RecordItemIndex(35));
            Validate.Exists(repo.SOLIDWORKSPDMAdministrationFileVau.TitleBarInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1516' at 123;7.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1516Info, new RecordItemIndex(36));
            repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1516.MoveTo("123;7");
            repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1516.MouseDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1516' at 123;7.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1516Info, new RecordItemIndex(37));
            repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1516.MoveTo("123;7");
            repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1516.MouseUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='walswkqa04587') on item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1518'.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1518Info, new RecordItemIndex(38));
            Validate.AttributeEqual(repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1518Info, "Text", "walswkqa04587");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1518'.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1518Info, new RecordItemIndex(39));
            Validate.Exists(repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.Text1518Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministrationFileVau.Maximize' at 19;8.", repo.SOLIDWORKSPDMAdministrationFileVau.MaximizeInfo, new RecordItemIndex(40));
            repo.SOLIDWORKSPDMAdministrationFileVau.Maximize.Click("19;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGet'.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGetInfo, new RecordItemIndex(41));
            Validate.Exists(repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGetInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGet'.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGetInfo, new RecordItemIndex(42));
            Validate.Exists(repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGetInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGet' at 5;9.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGetInfo, new RecordItemIndex(43));
            repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGet.Click("5;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.IncludeRefreshCacheDuringLogIn'.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.IncludeRefreshCacheDuringLogInInfo, new RecordItemIndex(44));
            Validate.AttributeEqual(repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.IncludeRefreshCacheDuringLogInInfo, "Checked", "False");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.IncludeRefreshCacheDuringLogIn' at 7;6.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.IncludeRefreshCacheDuringLogInInfo, new RecordItemIndex(45));
            repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.IncludeRefreshCacheDuringLogIn.Click("7;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGet' at 7;5.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGetInfo, new RecordItemIndex(46));
            repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.CheckBoxGet.Click("7;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.LogInAndLogOut' at 5;10.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.LogInAndLogOutInfo, new RecordItemIndex(47));
            repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.LogInAndLogOut.Click("5;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministrationFileVau.Form65280.LogInAndLogOut' at 5;10.", repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.LogInAndLogOutInfo, new RecordItemIndex(48));
            repo.SOLIDWORKSPDMAdministrationFileVau.Form65280.LogInAndLogOut.Click("5;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin' at 74;11.", repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdminInfo, new RecordItemIndex(49));
            repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin.Click("74;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin' at 74;11.", repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdminInfo, new RecordItemIndex(50));
            repo.SOLIDWORKSPDMAdministration.Tree10011.KeywordTestAdmin.Click(System.Windows.Forms.MouseButtons.Right, "74;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ConisioAdmin.Refresh' at 41;13.", repo.ConisioAdmin.RefreshInfo, new RecordItemIndex(51));
            repo.ConisioAdmin.Refresh.Click("41;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Down') on item 'SOLIDWORKSPDMAdministration.Tree10011.Down'.", repo.SOLIDWORKSPDMAdministration.Tree10011.DownInfo, new RecordItemIndex(52));
            Validate.AttributeEqual(repo.SOLIDWORKSPDMAdministration.Tree10011.DownInfo, "Text", "Down");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'SOLIDWORKSPDMAdministration.Tree10011.Down' at 5;11.", repo.SOLIDWORKSPDMAdministration.Tree10011.DownInfo, new RecordItemIndex(53));
            repo.SOLIDWORKSPDMAdministration.Tree10011.Down.MoveTo("5;11");
            repo.SOLIDWORKSPDMAdministration.Tree10011.Down.MouseDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministrationFileVau.Tree1001' at 69;366.", repo.SOLIDWORKSPDMAdministrationFileVau.Tree1001Info, new RecordItemIndex(54));
            repo.SOLIDWORKSPDMAdministrationFileVau.Tree1001.Click("69;366");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministrationFileVau.Columns' at 7;10.", repo.SOLIDWORKSPDMAdministrationFileVau.ColumnsInfo, new RecordItemIndex(55));
            repo.SOLIDWORKSPDMAdministrationFileVau.Columns.Click("7;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SOLIDWORKSPDMAdministrationFileVau.Columns' at 13;10.", repo.SOLIDWORKSPDMAdministrationFileVau.ColumnsInfo, new RecordItemIndex(56));
            repo.SOLIDWORKSPDMAdministrationFileVau.Columns.Click(System.Windows.Forms.MouseButtons.Right, "13;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContextMenuHash32768.None' at 19;9.", repo.ContextMenuHash32768.NoneInfo, new RecordItemIndex(57));
            repo.ContextMenuHash32768.None.Click("19;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Test' with focus on 'CustomizableColumnsNewView'.", repo.CustomizableColumnsNewView.SelfInfo, new RecordItemIndex(58));
            repo.CustomizableColumnsNewView.Self.EnsureVisible();
            Keyboard.Press("Test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsNewView.ButtonAdd' at 66;5.", repo.CustomizableColumnsNewView.ButtonAddInfo, new RecordItemIndex(59));
            repo.CustomizableColumnsNewView.ButtonAdd.Click("66;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsNewView.ButtonAdd' at 54;2.", repo.CustomizableColumnsNewView.ButtonAddInfo, new RecordItemIndex(60));
            repo.CustomizableColumnsNewView.ButtonAdd.Click("54;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsNewView.CellArchiveServerPath' at 107;15.", repo.CustomizableColumnsNewView.CellArchiveServerPathInfo, new RecordItemIndex(61));
            repo.CustomizableColumnsNewView.CellArchiveServerPath.Click("107;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsNewView.CellArchiveServerPath' at 267;12.", repo.CustomizableColumnsNewView.CellArchiveServerPathInfo, new RecordItemIndex(62));
            repo.CustomizableColumnsNewView.CellArchiveServerPath.Click("267;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F15}' with focus on 'CustomizableColumnsNewView'.", repo.CustomizableColumnsNewView.SelfInfo, new RecordItemIndex(63));
            repo.CustomizableColumnsNewView.Self.EnsureVisible();
            Keyboard.Press("{F15}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsNewView.Delete' at 71;9.", repo.CustomizableColumnsNewView.DeleteInfo, new RecordItemIndex(64));
            repo.CustomizableColumnsNewView.Delete.Click("71;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsNewView.Permissions' at 24;12.", repo.CustomizableColumnsNewView.PermissionsInfo, new RecordItemIndex(65));
            repo.CustomizableColumnsNewView.Permissions.Click("24;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsNewView.Table9037.View' at 14;14.", repo.CustomizableColumnsNewView.Table9037.ViewInfo, new RecordItemIndex(66));
            repo.CustomizableColumnsNewView.Table9037.View.Click("14;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsNewView.Table9037.SomeCell' at 9;8.", repo.CustomizableColumnsNewView.Table9037.SomeCellInfo, new RecordItemIndex(67));
            repo.CustomizableColumnsNewView.Table9037.SomeCell.Click("9;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsNewView.Table9037.SomeCell1' at 4;2.", repo.CustomizableColumnsNewView.Table9037.SomeCell1Info, new RecordItemIndex(68));
            repo.CustomizableColumnsNewView.Table9037.SomeCell1.Click("4;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F15}' with focus on 'CustomizableColumnsTest'.", repo.CustomizableColumnsTest.SelfInfo, new RecordItemIndex(69));
            repo.CustomizableColumnsTest.Self.EnsureVisible();
            Keyboard.Press("{F15}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsTest.TitleBar' at 265;10.", repo.CustomizableColumnsTest.TitleBarInfo, new RecordItemIndex(70));
            repo.CustomizableColumnsTest.TitleBar.Click("265;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CustomizableColumnsTest.TabPageList9025'.", repo.CustomizableColumnsTest.TabPageList9025Info, new RecordItemIndex(71));
            Validate.Exists(repo.CustomizableColumnsTest.TabPageList9025Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'CustomizableColumnsTest.ButtonOK' at 29;18.", repo.CustomizableColumnsTest.ButtonOKInfo, new RecordItemIndex(72));
            repo.CustomizableColumnsTest.ButtonOK.Click(System.Windows.Forms.MouseButtons.Right, "29;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomizableColumnsTest.ButtonOK' at 35;13.", repo.CustomizableColumnsTest.ButtonOKInfo, new RecordItemIndex(73));
            repo.CustomizableColumnsTest.ButtonOK.Click("35;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration1' at 282;35.", repo.SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration1Info, new RecordItemIndex(74));
            repo.SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration1.Click("282;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration1' at 282;35.", repo.SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration1Info, new RecordItemIndex(75));
            repo.SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration1.Click(System.Windows.Forms.MouseButtons.Right, "282;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F15}' with focus on 'SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration1'.", repo.SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration1Info, new RecordItemIndex(76));
            repo.SOLIDWORKSPDMAdministration.SOLIDWORKSPDMAdministration1.PressKeys("{F15}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.Text65535' at 194;12.", repo.SOLIDWORKSPDMAdministration.Text65535Info, new RecordItemIndex(77));
            repo.SOLIDWORKSPDMAdministration.Text65535.Click("194;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='The file vault already contains a column set named 'Test'.\r\nDo you want to replace 'File List' column set?') on item 'SOLIDWORKSPDMAdministration.Text65535'.", repo.SOLIDWORKSPDMAdministration.Text65535Info, new RecordItemIndex(78));
            Validate.AttributeEqual(repo.SOLIDWORKSPDMAdministration.Text65535Info, "Text", "The file vault already contains a column set named 'Test'.\r\nDo you want to replace 'File List' column set?");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SOLIDWORKSPDMAdministration.ButtonYes' at 19;11.", repo.SOLIDWORKSPDMAdministration.ButtonYesInfo, new RecordItemIndex(79));
            repo.SOLIDWORKSPDMAdministration.ButtonYes.Click("19;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
