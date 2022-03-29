Imports System
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Hosting

Friend Module Program
  Public Sub Main(Args As String())
    CreateHostBuilder(Args).Build.Run
  End Sub



  Public Function CreateHostBuilder(Args As String()) As IHostBuilder
    Dim oAction As Action(Of IWebHostBuilder)

    oAction = Sub(WebBuilder) WebBuilder.UseStartup(Of Startup)

    Return Host.CreateDefaultBuilder(Args).ConfigureWebHostDefaults(oAction)
  End Function
End Module
