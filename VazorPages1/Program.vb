Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Hosting

Friend Module Program
  Public Sub Main(Args As String())
    CreateHostBuilder(Args).Build.Run
  End Sub



  Public Function CreateHostBuilder(Args As String()) As IHostBuilder
    Return Host.
      CreateDefaultBuilder(Args).
      ConfigureWebHostDefaults(Sub(WebBuilder)
                                 WebBuilder.UseStartup(Of Startup)
                               End Sub)
  End Function
End Module
