namespace BlazorPopUpOnLoadPoC.Misc
{
    public class ToastData
    {
        public bool IsSticky { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public ToastType Type { get; set; } = ToastType.Info;

    }

    public enum ToastType
    {
        Danger,
        Info,
        Success
    }

    public enum ToastCommand
    {
        Show,
        Hide,
        ShowSticky
    }
}
