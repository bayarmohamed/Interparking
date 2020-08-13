using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interparking.WeppApp.Command
{
    public class ICommand<T>:IRequest<T>
    {

    }
}