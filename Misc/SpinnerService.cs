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

        public void Show()
        {
            OnShow?.Invoke();
        }

        public void Hide()
        {
            OnHide?.Invoke();
        }
    }
}

