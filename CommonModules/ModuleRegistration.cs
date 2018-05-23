using System;
using System.Web;


[assembly: PreApplicationStartMethod(typeof(CommonModules.ModuleRegistration), "RegisterModules")]
namespace CommonModules
{
    public class ModuleRegistration
    {
        public static void RegisterModules()
        {
            Type[] moduleTypes = { typeof(LogModule), typeof(TimerModule) };
            foreach (var module in moduleTypes)
            {
                HttpApplication.RegisterModule(module);
            }
        }
    }
}
