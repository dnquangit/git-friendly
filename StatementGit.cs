using System;

namespace GitApp
{
    public static class StatementGit
    {
        public static String ShowAllBranch = "git branch -a";
        public static String GetCurrentBranch = "git branch --show-current";
        public static String SwitchBranch = "git switch &branch-name";
        public static String PullBranch = "git pull origin &branch-name";
        public static String PushBranch = "git push origin &branch-name";
        public static String PushBranchUpStream = "git push origin &branch-name -u";
        public static String AddNewBranch = "git branch &branch-name";
        public static String CommitBranch = "TortoiseGitProc.exe /command:commit";
        public static String LogBranch = "TortoiseGitProc.exe /command:log";
    }

    public static class BatGit
    {
        public static String GetStatusBranch = "get-status-branch.bat";
        public static String ShowAllBranch = "get-all-branch.bat";
        public static String GetCurrentBranch = "get-current-branch.bat";
        public static String SwitchBranch = "switch-branch.bat";
        public static String PullBranch = "pull-branch.bat";
        public static String PushBranch = "push-branch.bat";
        public static String PushBranchUpStream = "push-branch.bat";
        public static String CommitBranch = "commit-branch.bat";
        public static String LogBranch = "show-log-branch.bat";
        public static String AddNewBranch = "add-new-branch.bat";
    }
}