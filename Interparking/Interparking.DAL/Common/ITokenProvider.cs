using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interparking.DAL.Common
{
    public interface ITokenProvider
    {
        string CurrentToken { get; }
    }
}
