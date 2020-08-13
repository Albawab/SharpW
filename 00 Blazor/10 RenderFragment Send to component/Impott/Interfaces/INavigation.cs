using Microsoft.AspNetCore.Components;
using System;

namespace Impott.Interfaces
{
    public interface INavigation
    {
        event Action<RenderFragment> OnNavigationUpdate;

        void UpdateNav(RenderFragment r);
    }
}
