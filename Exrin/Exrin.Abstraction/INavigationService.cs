﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrin.Abstraction
{
    public interface INavigationService
    {
        void Init(INavigationPage page);

        Task Navigate(string pageKey);

        Task Navigate(string pageKey, object args);

        Task GoBack();

        Task GoBack(object parameter);

        void Map(string pageKey, Type pageType);

    }
}