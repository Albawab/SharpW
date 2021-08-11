using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_UserManager_Auhtentication.Domein.Interface
{
    interface IAmIdentifiableEntity<out TIdentifier>
    {
        TIdentifier Id { get; }
    }
}
