using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using OnExcel.Composition;

namespace onExcel.HttEndpoint.App_Start
{
    public class ControllerActivator : IHttpControllerActivator
    {
        public IHttpController Create(
            HttpRequestMessage request,
            HttpControllerDescriptor controllerDescriptor,
            Type controllerType)
        {
            return Bootstrapper.Resolve(controllerType) as IHttpController;
        }
    }
}