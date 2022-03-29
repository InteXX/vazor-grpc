Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
Imports Vazor

Public Class Startup
  Public Sub New(Configuration As IConfiguration)
    Me.Configuration = Configuration
  End Sub



  ' This method gets called by the runtime. Use this method to add services to the container.
  Public Sub ConfigureServices(Services As IServiceCollection)
    Dim oProvider As VazorViewProvider
    Dim oAction As Action(Of MvcRazorRuntimeCompilationOptions)

    oProvider = New VazorViewProvider
    oAction = Sub(Options) Options.FileProviders.Add(oProvider)

    Services.AddControllersWithViews.AddRazorRuntimeCompilation(oAction)
  End Sub



  ' This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
  Public Sub Configure(App As IApplicationBuilder, Env As IWebHostEnvironment)
    ' Compile Shared Vazor Views
    Vazor.VazorSharedView.CreateAll()

    If Env.IsDevelopment() Then
      App.UseDeveloperExceptionPage()
    Else
      App.UseExceptionHandler("/Home/Error")
      ' The default HSTS value Is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
      App.UseHsts()
    End If

    App.UseHttpsRedirection()
    App.UseStaticFiles()

    App.UseRouting()
    App.UseAuthorization()

    App.UseEndpoints(Sub(Routes) Routes.MapRazorPages)
  End Sub



  Public ReadOnly Property Configuration As IConfiguration
End Class
