static class ServiceService
{
    public const string KORN_PATH_VAR_NAME = "KORN_PATH";

    public static bool IsInstalled => SystemVariablesUtils.IsExistVariable(KORN_PATH_VAR_NAME);

    public static string? KornPath
    { 
        get => SystemVariablesUtils.GetVariable(KORN_PATH_VAR_NAME); 
        set => SystemVariablesUtils.SetVariable(KORN_PATH_VAR_NAME, value);
    }
}