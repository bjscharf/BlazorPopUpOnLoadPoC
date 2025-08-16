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

        public ToastData GetToastData()
        {
            return new ToastData
            {
                IsSticky = IsSticky,
                Message = ToastMessage,
                Title = ToastTitle,
                Type = TypeOfToast
            };
        }

        public void Show()
        {
            OnShow?.Invoke();
        }

        public void Hide()
        {
            OnHide?.Invoke();
        }

        public void ToastShow(string message, string title, ToastType toastType, bool isSticky)
        {
            OnToastShow?.Invoke();
        }

        public void ToastHide()
        {
            OnToastHide?.Invoke();
        }
    }
}

