namespace BlazorPopUpOnLoadPoC.Misc
{
    using System;

    public enum SpinnerType
    {
        Icon = 1,
        Text = 2
    }

    public class SpinnerService
    {
        public event Action? OnShow;
        public event Action? OnHide;

        public event Action? OnToastShow;
        public event Action? OnToastHide;

        public string ToastMessage { get; set; } = "test";
        public string ToastTitle { get; set; } = "test2";
        public ToastType TypeOfToast { get; set; } = ToastType.Success;
        public bool IsSticky { get; set; } = false;
        private ToastData? toastData { get; set; }

        public SpinnerService()
        {
            toastData = new ToastData();
        }

        public ToastData GetToastData()
        {
            if (toastData == null)
                toastData = new ToastData();
            return toastData;
        }

        public void Show()
        {
            OnShow?.Invoke();
        }

        public void Hide()
        {
            OnHide?.Invoke();
        }

        public void ToastShow(string message, string title, ToastType toastType = ToastType.Success, bool isSticky = false)
        {
            if (toastData is null)
                return;
            toastData.Message = message;
            toastData.Title = title;
            toastData.Type = toastType;
            toastData.IsSticky = isSticky;
            OnToastShow?.Invoke();
        }

        public void ToastHide()
        {
            OnToastHide?.Invoke();
        }
    }
}

