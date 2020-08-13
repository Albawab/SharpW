using Microsoft.AspNetCore.Components;
using System;

namespace Impott.Interfaces
{
    public interface INavigation
    {
        event Action<IhandleNavigation> OnNavigationUpdate;

        void UpdateNav(IhandleNavigation handle);
    }
}
