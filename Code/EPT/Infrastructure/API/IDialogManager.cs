﻿using Caliburn.Micro;
using EPT.Infrastructure.Framework;
using System;

namespace EPT.Infrastructure.API
{
    public interface IDialogManager
    {
        void ShowDialog(IScreen dialogModel);
        void ShowMessageBox(string message, string title = null, MessageBoxOptions options = MessageBoxOptions.Ok, Action<IMessageBox> callback = null);
    }
}