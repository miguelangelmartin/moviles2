using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MVC_VentaMoviles.Models.ViewModel;
using Servicios.Servicios;
using Unity.Mvc4;
using Servicos.Servicios;

namespace MVC_VentaMoviles
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {

        container.RegisterType<IServicios<DispositivosViewModel>,
            Servicios<DispositivosViewModel>>
            (new InjectionConstructor("http://localhost:54918/Api/Dispositivo"));

      
        
    }
  }
}