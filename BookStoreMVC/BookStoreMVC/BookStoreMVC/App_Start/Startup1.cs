using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Microsoft.EntityFrameworkCore;
using Owin;
using BookStoreMVC.Data;
[assembly: OwinStartup(typeof(BookStoreMVC.Startup1))]

namespace BookStoreMVC
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
           
        }
    }
}
