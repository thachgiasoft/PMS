using System;
using System.Windows.Forms;
using PMS.BLL;
using System.Collections.Generic;
using System.Linq;

namespace PMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    //Init Skin
        //    DevExpress.UserSkins.BonusSkins.Register();
        //    DevExpress.UserSkins.OfficeSkins.Register();
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    //DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
        //    //Application.Run(new PMS.UI.Forms.NghiepVu.frmInPhieuGhiDiem);
        //    Application.Run(new frmMain());
        //}

         [STAThread]
        static void Main(string[] args)
        {
            try
            {

                UserInfo._UserID = "";
                UserInfo._UserPass = "";
                UserInfo._UserGroup = "";
                UserInfo._ParaFromUIS = new string[] { };

                List<CommandLine> cmdLine = new List<CommandLine>();
                if (args != null)
                {
                    if (args.Contains("?") || args.Contains("-help"))
                    {
                        MessageBox.Show("-f : File thực thi\n"
                            + "-u: Username đăng nhập tự động vào ứng dụng\n"
                            + "-p: Password đăng nhập tự động vào ứng dụng\n"
                            + "-g: Nhóm sử dụng\n"
                            + "-form: Form tự động mở sau khi đăng nhập\n"
                            );
                        return;
                    }
                    if (args.Any(p => new string[] { "-u", "-p", "-form" }.Any(q => p.ToLower() == q)))
                    {
                        foreach (var cmd in args)
                        {
                            switch (cmd)
                            {
                                case "-f":
                                case "-u":
                                case "-p":
                                case "-g":
                                case "-form":
                                    {
                                        cmdLine.Add(new CommandLine { Name = cmd, Value = "" });
                                    }
                                    break;
                                default:
                                    {
                                        if (cmdLine.Count == 0)
                                        {
                                            cmdLine.Add(new CommandLine { Name = "-form", Value = "" });
                                        }

                                        cmdLine[cmdLine.Count - 1].Value += cmd;
                                    }
                                    break;
                            }
                        }
                        CommandLine cmd1 = cmdLine.FirstOrDefault(c => c.Name.ToLower() == "-u");
                        if (cmd1 != null)
                            UserInfo._UserID = cmd1.Value;
                        cmd1 = cmdLine.FirstOrDefault(c => c.Name.ToLower() == "-p");
                        if (cmd1 != null)
                            UserInfo._UserPass = cmd1.Value;
                        cmd1 = cmdLine.FirstOrDefault(c => c.Name.ToLower() == "-form");
                        if (cmd1 != null)
                            UserInfo._ParaFromUIS = new string[] { cmd1.Value };
                        cmd1 = cmdLine.FirstOrDefault(c => c.Name.ToLower() == "-g");
                        if (cmd1 != null)
                            UserInfo._UserGroup = cmd1.Value;
                    }
                    else
                    {
                        if (args.Length > 0)
                            UserInfo._UserID = args[0];
                        else
                            UserInfo._UserID = "";
                        if (args.Length > 1)
                            UserInfo._UserPass = args[1];
                        else
                            UserInfo._UserPass = "";
                        if (args.Length > 2)
                            UserInfo._UserGroup = args[2];
                        else
                            UserInfo._UserGroup = "";
                        if (UserInfo._ParaFromUIS == null)
                            UserInfo._ParaFromUIS = new string[] { };
                        if (args.Length > 3)
                        {
                            for (int i = 3; i < args.Length; i++)
                            {
                                if (args[i].Trim() != "")
                                {
                                    if (UserInfo._ParaFromUIS.Length == 0)
                                    {
                                        Array.Resize(ref UserInfo._ParaFromUIS, UserInfo._ParaFromUIS.Length + 1);
                                    }
                                    UserInfo._ParaFromUIS[0] = args[i];
                                }
                            }
                        }
                    }
                }

                // //SetErrorMode(SetErrorMode(0) | ErrorModes.SEM_NOGPFAULTERRORBOX | ErrorModes.SEM_FAILCRITICALERRORS | ErrorModes.SEM_NOOPENFILEERRORBOX);
                //SetErrorMode(SetErrorMode(0) | ErrorModes.SEM_NOGPFAULTERRORBOX);
                // //UserInfo._UserID = "uisteam";
                //  //UserInfo._UserPass = "thanhcong";
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //DevExpress.Skins.SkinManager.EnableFormSkins();
                //DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
                //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                //Application.CurrentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                //Application.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
                //Application.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";
                //Application.Run(new UIStudents.rfrmMain());

                //string Lauch = Application.StartupPath + "\\LauchPMS.exe";
                //if (System.IO.File.Exists(Lauch))
                //{
                //    string arg = "-f PMS.exe";
                //    if (UserInfo._UserID != "")
                //    {
                //        arg += (arg == "" ? "" : " ") + "-u " + UserInfo._UserID;
                //    }
                //    if (UserInfo._UserPass != "")
                //    {
                //        arg += (arg == "" ? "" : " ") + "-p " + UserInfo._UserPass;
                //    }
                //    try
                //    {
                //        System.Diagnostics.Process.Start(Lauch, arg);
                //    }
                //    catch
                //    {
                //        System.Diagnostics.Process.Start(Lauch);
                //    }
                //    Application.Exit();
                //}

                //Init Skin
                DevExpress.UserSkins.BonusSkins.Register();
                DevExpress.UserSkins.OfficeSkins.Register();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
                //Application.Run(new PMS.UI.Forms.NghiepVu.frmInPhieuGhiDiem);
                Application.Run(new frmMain());
            }
            catch
            {
                Application.Exit();
            }



        }
    }

    class CommandLine
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
