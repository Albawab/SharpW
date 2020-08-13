using Impott.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Data;

namespace Impott.Service
{
    public class INavigationIService : INavigation
    {
        public event Action<RenderFragment> OnNavigationUpdate;

        public void UpdateNav(RenderFragment r) => OnNavigationUpdate?.Invoke(r);
    }
}
