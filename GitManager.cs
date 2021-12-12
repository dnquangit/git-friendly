using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace GitApp
{
    public class GitManager
    {
        private String _source = "";
        private String _directoryBat = "";
        public GitManager(String source, String directoryBat) 
        {
            _source = source;
            _directoryBat = directoryBat;
        }

        public Boolean ValidGit()
        {
            String status = GetStatus();
            return true;
        }

        public String GetStatus()
        {
            String statement = "";
            String error = "";
            RunBatFile(
                BatGit.GetStatusBranch,
                _directoryBat,
                _source,
                out statement,
                out error);
            return statement + error;
        }

        public String GetCurrentBranch()
        {
            String branch = "";
            String statement = "";
            String error = "";
            RunBatFile(
                BatGit.GetCurrentBranch,
                _directoryBat,
                _source,
                out statement,
                out error);

            if (error == "")
            {
                String statementRunning = "git branch --show-current";

                branch = statement.Substring(statement.IndexOf(statementRunning) + statementRunning.Length);

                branch = Regex.Replace(branch, @"\r\n?|\n", "");
            }

            return branch;
        }

        public void GetAllBranch(out String statement, out String error)
        {
            RunBatFile(
                BatGit.ShowAllBranch,
                _directoryBat,
                _source,
                out statement,
                out error);
        }

        public void SwitchBranch(String branch, out String statement, out String error)
        {
            RunBatFile(
                BatGit.SwitchBranch,
                _directoryBat,
                _source + " " + branch,
                out statement,
                out error);
        }
        public void AddNewBranch(String branch, out String statement, out String error)
        {
            RunBatFile(
                BatGit.AddNewBranch,
                _directoryBat,
                _source + " " + branch,
                out statement,
                out error);
        }

        public void PullBranch(String branch, out String statement, out String error)
        {
            RunBatFile(
                BatGit.PullBranch,
                _directoryBat,
                _source + " " + branch,
                out statement,
                out error);
        }
        public void ShowLogBranch()
        {
            RunBatFileWithOutWait(
                BatGit.LogBranch,
                _directoryBat,
                _source);
        }

        public void CommitBranch()
        {
            RunBatFileWithOutWait(
                BatGit.CommitBranch,
                _directoryBat,
                _source);
        }

        public void PushBranch(String branch, out String statement, out String error)
        {
            RunBatFile(
                BatGit.PushBranch,
                _directoryBat,
                 _source + " " + branch,
                out statement,
                out error);
        }

        public void RunBatFile(
            String name, 
            String directory, 
            String arguments, 
            out String strOutput, 
            out String strError)
        {
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = name;
            pProcess.StartInfo.Arguments = arguments;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.RedirectStandardError = true;
            pProcess.StartInfo.WorkingDirectory = directory;
            pProcess.StartInfo.CreateNoWindow = false;
            pProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pProcess.Start();

            strOutput = pProcess.StandardOutput.ReadToEnd();
            strError = pProcess.StandardError.ReadToEnd();
            pProcess.WaitForExit();

            strOutput = FormatOutput(strOutput);
        }

        public void RunBatFileWithOutWait(
            String name,
            String directory,
            String arguments)
        {
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            pProcess.StartInfo.FileName = name;
            pProcess.StartInfo.Arguments = arguments;
            pProcess.StartInfo.WorkingDirectory = directory;
            pProcess.StartInfo.CreateNoWindow = false;
            pProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pProcess.Start();
        }

        public String FormatOutput(String output) 
        {
            string[] stringSeparators = new string[] { "\r\n" };
            string[] lines = output.Split(stringSeparators, StringSplitOptions.None);
            string cdLine = "cd " + _source;
            string cdFullLine = "";
            int indexcdFullLine = 0;
            string result = "";

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line.Contains(cdLine))
                {
                    cdFullLine = line;
                    indexcdFullLine = i;
                    break;
                }
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i > indexcdFullLine)
                {
                    if (i == indexcdFullLine + 1 && line == "")
                    {
                        /* don't do any thing */
                    }
                    else
                    {
                        result = result + Environment.NewLine + line;
                    }
                }
            }

            return result;
        }
    }
}
