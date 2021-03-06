// <copyright file="IMarkerEditBoxPresentationModel.cs" company="Microsoft Corporation">
// ===============================================================================
//
//
// Project: Microsoft Silverlight Rough Cut Editor
// FILES: IMarkerEditBoxPresentationModel.cs                     
//
// ===============================================================================
// Copyright 2010 Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
// ===============================================================================
// </copyright>

namespace RCE.Modules.Markers
{
    using System.ComponentModel;
    using Infrastructure.Models;
    using Microsoft.Practices.Composite.Presentation.Commands;

    public interface IMarkerEditBoxPresentationModel : ITimelineBarElementModel, INotifyPropertyChanged
    {
        IMarkerEditBox View { get; }
        
        DelegateCommand<object> CloseCommand { get; }
        
        DelegateCommand<object> SaveCommand { get; }
        
        DelegateCommand<object> DeleteCommand { get; }
        
        double Time { get; set; }

        string Text { get; set; }
                
        void ShowEditBox();
    }
}