Imports System.Diagnostics
Imports Microsoft.AspNetCore.Mvc
Imports VazorMVC1.Models

Namespace Controllers
  Public Class HomeController : Inherits Controller
    Public Function Index() As IActionResult
      Return Me.View(IndexView.CreateNew(Students, Me.ViewData), Students)
    End Function



    Public Function Privacy() As IActionResult
      Return Me.View()
    End Function



    <ResponseCache(Duration:=0, Location:=ResponseCacheLocation.None, NoStore:=True)>
    Public Function [Error]() As IActionResult
      Return Me.View(New ErrorViewModel With {.RequestId = If(Activity.Current?.Id, Me.HttpContext.TraceIdentifier)})
    End Function
  End Class
End Namespace
