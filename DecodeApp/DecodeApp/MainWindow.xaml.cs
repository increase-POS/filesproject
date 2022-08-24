using DecodeApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using netoaster;

namespace DecodeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region decode Error
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        #endregion
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                HelpClass.StartAwait(grid_mainWindow);
                #region fill process type
                var typelist = new[] {
                new { Text = "Decode API File", Value = "APIFile" },
                new { Text = "Decode Backup File", Value = "backupFile" },
                new { Text = "Decode Error File", Value = "errorFile" },
                 };
                cb_type.DisplayMemberPath = "Text";
                cb_type.SelectedValuePath = "Value";
                cb_type.ItemsSource = typelist;
                cb_type.SelectedIndex = 0;
                #endregion
                HelpClass.EndAwait(grid_mainWindow);
            }
            catch (Exception ex)
            {
                HelpClass.EndAwait(grid_mainWindow);
                HelpClass.ExceptionMessage(ex, this);
            }
           
        }

        

        private void Btn_decode_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HelpClass.StartAwait(grid_mainWindow);
                #region
                //Mr.naji, set your code here
                if (cb_type.SelectedValue.ToString() == "APIFile")
                {
                    APIDecode Apicls = new APIDecode();
                    bool res = false;
                    string sourcPath = "";
                    openFileDialog.Filter = "TEXT|*.txt; ";
                    openFileDialog.Title = "The Api File";
                    if (openFileDialog.ShowDialog() == true)
                    {
                        sourcPath = openFileDialog.FileName;
                    }
                    saveFileDialog.Filter = "File|*.txt;";
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        string Destpath = saveFileDialog.FileName;
                        saveFileDialog.Title = "The Text File";
                        res = Apicls.decodefile(sourcPath, Destpath);
                        // rc.DelFile(pdfpath);
                        //  rc.decodefile(DestPath,@"D:\error.xls");
                        if (res)
                        {
                            Toaster.ShowSuccess(Window.GetWindow(this), message: "Success", animation: ToasterAnimation.FadeIn);
                        }
                        else
                        {
                            Toaster.ShowWarning(Window.GetWindow(this), message: "Not complete", animation: ToasterAnimation.FadeIn);
                        }
                    }
                }
                else if (cb_type.SelectedValue.ToString() == "backupFile")
                {
                   
                    BackupDecode backupcls = new BackupDecode();
                    bool res = false;
                    string sourcPath = "";
                    openFileDialog.Filter = "INC|*.inc; ";
                    openFileDialog.Title = "The Backup File";
                    if (openFileDialog.ShowDialog() == true)
                    {
                        sourcPath = openFileDialog.FileName;
                    }
                    saveFileDialog.Filter = "File|*.bak;";
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        string Destpath = saveFileDialog.FileName;
                        saveFileDialog.Title = "The bak File";
                        res = backupcls.decodefile(sourcPath, Destpath);
                        // rc.DelFile(pdfpath);
                        //  rc.decodefile(DestPath,@"D:\error.xls");
                        if (res)
                        {
                            Toaster.ShowSuccess(Window.GetWindow(this), message: "Success", animation: ToasterAnimation.FadeIn);
                        }
                        else
                        {
                            Toaster.ShowWarning(Window.GetWindow(this), message: "Not complete", animation: ToasterAnimation.FadeIn);
                        }
                    }
                }
                else if (cb_type.SelectedValue.ToString() == "errorFile")
                {
                    ReportCls rc = new ReportCls();
                    bool res = false;
                    string sourcPath = "";
                    openFileDialog.Filter = "File|*.er;";
                    openFileDialog.Title = "The Error File";
                    if (openFileDialog.ShowDialog() == true)
                    {
                        sourcPath = openFileDialog.FileName;
                    }
                    saveFileDialog.Filter = "File|*.xls;";
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        string Destpath = saveFileDialog.FileName;
                        saveFileDialog.Title = "The Excel File";
                        res = rc.decodefile(sourcPath, Destpath);
                        // rc.DelFile(pdfpath);
                        //  rc.decodefile(DestPath,@"D:\error.xls");
                        if (res)
                        {
                            Toaster.ShowSuccess(Window.GetWindow(this), message:"Success", animation: ToasterAnimation.FadeIn);
                        }
                        else
                        {
                            Toaster.ShowWarning(Window.GetWindow(this), message:"Not complete", animation: ToasterAnimation.FadeIn);
                        }
                    }
                }
                //MessageBox.Show("Hello, you select to decode file type: " + cb_type.SelectedValue);
                #endregion

                HelpClass.EndAwait(grid_mainWindow);
            }
            catch (Exception ex)
            {
                HelpClass.EndAwait(grid_mainWindow);
                HelpClass.ExceptionMessage(ex, this);
            }
        }

        private void Btn_colse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Application.Current.Shutdown();
            }
            catch (Exception ex)
            {
                HelpClass.ExceptionMessage(ex, this);
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch
            { }
        }
    }
}
