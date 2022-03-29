Imports Microsoft.AspNetCore.Mvc.RazorPages
Imports Vazor
Imports ZML

Public Class VazorPageModel : Inherits PageModel

  ' This property is used in the VazorPage.cshtml,
  ' to inject our vbxml code in the page as a pratial view

  Const Title = "VazorPage"

  Public ReadOnly Property ViewName As String
    Get
      ViewData("Title") = Title
      Dim html = GetVbXml(Students, ViewData).Parsezml()
      ' Change "Pages" to the actual folder that contains the Page. For example Pages\Users
      Return VazorPage.CreateNew("VazorPage", "Pages", Title, html)
    End Get
  End Property

  Public ReadOnly Property Students As List(Of Student)
    Get
      Return SomeStudents.Students
    End Get
  End Property

  Public Sub OnGet()

  End Sub

End Class
