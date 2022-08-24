using netoaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;

namespace DecodeApp.Classes
{
    class HelpClass
    {

        static public void StartAwait(Grid grid, string progressRingName = "")
        {
            grid.IsEnabled = false;
            grid.Opacity = 0.6;
            MahApps.Metro.Controls.ProgressRing progressRing = new MahApps.Metro.Controls.ProgressRing();
            progressRing.Name = "prg_awaitRing" + progressRingName;
            progressRing.Foreground = App.Current.Resources["Blue"] as Brush;
            progressRing.IsActive = true;
            Grid.SetRowSpan(progressRing, 10);
            Grid.SetColumnSpan(progressRing, 10);
            grid.Children.Add(progressRing);
        }
        static public void EndAwait(Grid grid, string progressRingName = "")
        {
            MahApps.Metro.Controls.ProgressRing progressRing = FindControls.FindVisualChildren<MahApps.Metro.Controls.ProgressRing>(grid)
                .Where(x => x.Name == "prg_awaitRing" + progressRingName).FirstOrDefault();
            grid.Children.Remove(progressRing);

            var progressRingList = FindControls.FindVisualChildren<MahApps.Metro.Controls.ProgressRing>(grid)
                 .Where(x => x.Name == "prg_awaitRing" + progressRingName);
            if (progressRingList.Count() == 0)
            {
                grid.IsEnabled = true;
                grid.Opacity = 1;
            }

        }

        static async public void ExceptionMessage(Exception ex, object window)
        {
            try
            {

                //Message
                if (ex.HResult == -2146233088)
                    //Toaster.ShowError(window as Window, message: MainWindow.resourcemanager.GetString("trNoConnection"), animation: ToasterAnimation.FadeIn);
                    Toaster.ShowError(window as Window, message: "trNoConnection", animation: ToasterAnimation.FadeIn);
                else if (ex.HResult != -2147467261)
                    Toaster.ShowError(window as Window, message: ex.HResult + " || " + ex.Message, animation: ToasterAnimation.FadeIn);

                ////- 2146233088     An error occurred while sending the request.
                ////-2147467261    Void MoveNext()
                //if (ex.HResult != -2146233088 && ex.HResult != -2147467261)
                //{
                //    ErrorClass errorClass = new ErrorClass();
                //    errorClass.num = ex.HResult.ToString();
                //    errorClass.msg = ex.Message;
                //    errorClass.stackTrace = ex.StackTrace;
                //    errorClass.targetSite = ex.TargetSite.ToString();
                //    errorClass.posId = MainWindow.posID;
                //    errorClass.branchId = MainWindow.branchID;
                //    errorClass.createUserId = MainWindow.userLogin.userId;
                //    await errorClass.save(errorClass);
                //}
            }
            catch
            {

            }
        }
    }
}
