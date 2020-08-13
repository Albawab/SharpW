using Impott.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Data;

namespace Impott.Service
{
    public class INavigationIService : INavigation
    {
        public event Action<IhandleNavigation> OnNavigationUpdate;

        public void UpdateNav(IhandleNavigation r) => OnNavigationUpdate?.Invoke(r);
    }
}
