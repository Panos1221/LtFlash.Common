﻿
namespace LtFlash.Common.ScriptManager.ScriptStarters
{
    interface IScriptStarter
    {
        bool HasFinishedSuccessfully { get; }
        bool HasFinishedUnsuccessfully { get; }
        string Id { get; }
        string[] NextScriptsToRun { get; }
        void Start();
        void Stop();
        Managers.ScriptStatus GetScriptStatus();
    }
}
