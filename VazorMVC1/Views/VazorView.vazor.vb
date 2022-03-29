Imports System.Collections.Generic
Imports Microsoft.AspNetCore.Mvc.ViewFeatures
Imports Vazor
Imports VazorMVC1.Models

' To add anew vzor view, right-click the folder in solution explorer
' click Add/New item, and chosse the "VazorView" item from the window
' This will add both the vazor.vb and vbxml.vb files to the folder.

' GetVbXml( ) is defiend in the VazorView.vbxml.vb file, 
' and it contains the view design
Public Class VazorViewView
  Inherits VazorView
  ' Supply your actual view name, path, and title to the MyBase.New
  ' By defualt, UTF encoding is used to render the view. 
  ' You can send another encoding to the forth param of the MyBase.New.

  Public Sub New(Students As List(Of Student), ViewData As ViewDataDictionary)
    ' Change Views\Home to the actual folder that contains the view
    MyBase.New("VazorView", "Views\Home", "VazorView")

    Me.Students = Students
    Me.ViewData = ViewData

    ViewData("Title") = Me.Title
  End Sub



  ' This function is called by the "VazorView" action method in the HomeController:
  ' View(VazorViewView.CreateNew(Students, ViewData))
  Public Shared Function CreateNew(Students As List(Of Student), viewData As ViewDataDictionary) As String
    Return VazorViewMapper.Add(New VazorViewView(Students, viewData))
  End Function



  Public ReadOnly Property Students As List(Of Student)
  Public ReadOnly Property ViewData As ViewDataDictionary
End Class
