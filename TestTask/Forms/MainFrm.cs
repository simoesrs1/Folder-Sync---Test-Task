using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TestTask.Logs;

namespace TestTask.Forms
{
    public partial class MainFrm : DevExpress.XtraEditors.XtraForm
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void beOriginFolder_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (var dialog = new XtraFolderBrowserDialog())
            {
                dialog.ShowDialog();
                beOriginFolder.Text = dialog.SelectedPath;
            }
        }

        private void beOriginFolder_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (IsFolderValid(beOriginFolder.Text))
                tsValidOriginPath.IsOn = true;
            else
                tsValidOriginPath.IsOn = false;
        }

        private void beDestinationFolder_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (var dialog = new XtraFolderBrowserDialog())
            {
                dialog.ShowDialog();
                beDestinationFolder.Text = dialog.SelectedPath;
            }
        }

        private void beDestinationFolder_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (IsFolderValid(beDestinationFolder.Text))
                tsValidDestinationPath.IsOn = true;
            else
                tsValidDestinationPath.IsOn = false;
        }

        private void sbSynchronize_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (!tsValidOriginPath.IsOn)
                    throw new ArgumentException("The origin path is not valid.", beOriginFolder.Properties.AdvancedModeOptions.Label);
                else if (!tsValidDestinationPath.IsOn)
                    throw new ArgumentException("The destination path is not valid.", beDestinationFolder.Properties.AdvancedModeOptions.Label);
                string[] originFiles = Directory.GetFiles(beOriginFolder.Text);
                string[] originDirectories = Directory.GetDirectories(beOriginFolder.Text);

                string[] originDocs = originFiles.Concat(originDirectories).ToArray();


                if (originDocs.Length > 0)
                {
                    foreach (string doc in originDocs)
                    {
                        string fileName = (doc.Substring(doc.LastIndexOf("\\"))).Trim('\\');

                        DirectoryInfo dInfo = new DirectoryInfo(doc);
                        DirectorySecurity dSecurity = dInfo.GetAccessControl();
                        dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
                        dInfo.SetAccessControl(dSecurity);

                        if (!File.Exists(beDestinationFolder.Text + "\\" + fileName))
                        {
                            File.Copy(doc, beDestinationFolder.Text + "\\" + fileName, false);
                            LogControl.WriteLog($"File {beDestinationFolder.Text + "\\" + fileName} was created!");
                        }
                        else
                        {
                            File.Copy(doc, beDestinationFolder.Text + "\\" + fileName, true);
                            LogControl.WriteLog($"File {beDestinationFolder.Text + "\\" + fileName} was modified!");
                        }
                    }
                }
                LogControl.WriteLog($"Folder {beOriginFolder.Text} synchronized successfully to {beDestinationFolder.Text}!");
                XtraMessageBox.Show($"Folder {beOriginFolder.Text} synchronized successfully to {beDestinationFolder.Text}!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Watch(beOriginFolder.Text);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error has ocurred during the synchronization.{Environment.NewLine}ERROR: {ex.Message}", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogControl.WriteLog($"An error has ocurred during the synchronization.{Environment.NewLine}ERROR: {ex.Message}");
            }
        }

        private void beOriginFolder_EditValueChanged(object sender, EventArgs e)
        {
            if (IsFolderValid(beOriginFolder.Text))
                tsValidOriginPath.IsOn = true;
            else
                tsValidOriginPath.IsOn = false;
        }

        private bool IsFolderValid(string path)
        {
            if (Directory.Exists(path))
                return true;
            else
                return false;
        }

        private void beDestinationFolder_EditValueChanged(object sender, EventArgs e)
        {
            if (IsFolderValid(beDestinationFolder.Text))
                tsValidDestinationPath.IsOn = true;
            else
                tsValidDestinationPath.IsOn = false;
        }

        private void Watch(string path)
        {
            var watcher = new FileSystemWatcher
            {
                Path = path,
                NotifyFilter = NotifyFilters.Attributes |
                NotifyFilters.CreationTime |
                NotifyFilters.DirectoryName |
                NotifyFilters.FileName |
                NotifyFilters.LastAccess |
                NotifyFilters.LastWrite |
                NotifyFilters.Security |
                NotifyFilters.Size,
                Filter = "*.*",
                EnableRaisingEvents = true
            };

            watcher.Changed += new FileSystemEventHandler(OnChanged);
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            //Console.WriteLine("Something changed!");
            XtraMessageBox.Show("Something changed in the origin folder!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            if (ceAutoSync.Checked)
                teMinutes.ReadOnly = false;
            else
                teMinutes.ReadOnly = true;
        }

        private void ExecuteSync()
        {

        }

        private void ceAutoSync_CheckedChanged(object sender, EventArgs e)
        {
            if (ceAutoSync.Checked)
                teMinutes.ReadOnly = false;
            else
                teMinutes.ReadOnly = true;
        }

        private void teMinutes_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!tsValidOriginPath.IsOn || !tsValidDestinationPath.IsOn)
                {
                    throw new Exception("One of the paths is not valid. Timer is not initializing!");
                }

                int.TryParse(teMinutes?.Text, out int minutes);

                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = (int)TimeSpan.FromMinutes(minutes).TotalMilliseconds;
                timer.Enabled = true;
                timer.Tick += sbSynchronize_Click;

                LogControl.WriteLog("Timer initialized successfully!");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error has ocurred initializing the synchronization timer.{Environment.NewLine}ERROR: {ex.Message}", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogControl.WriteLog($"An error has ocurred initializing the synchronization timer.{Environment.NewLine}ERROR: {ex.Message}");
            }
        }
    }
}