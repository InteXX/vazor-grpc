Imports System.Collections.Generic
Imports Microsoft.AspNetCore.Mvc.ViewFeatures
Imports Vazor
Imports VazorMVC1.Models

' To add anew vzor view, right-click the folder in solution explorer
' click Add/New item, and chosse the "VazorView" item from the window
' This will add both the vazor.vb and vbxml.vb files to the folder.

' GetVbXml( ) is defiend in the Index.vbxml.vb file, 
' and it contains the view design
Public Class IndexView
  Inherits VazorView

  ' Supply your actual view name, path, and title to the MyBas.New
  ' By defualt, UTF encoding is used to render the view. 
  ' You can send another encoding to the forth param of the MyBase.New.
  Public Sub New(Students As List(Of Student), ViewData As ViewDataDictionary)
    MyBase.New("Index", "Views\Home", "Hello")

    Me.Students = Students
    Me.ViewData = ViewData

    ViewData("Title") = Me.Title
  End Sub



  ' This function is called in the "Index" action method in the HomeController:
  ' View(IndexView.CreateNew(Students, ViewData))
  Public Shared Function CreateNew(Students As List(Of Student), ViewData As ViewDataDictionary) As String
    Return VazorViewMapper.Add(New IndexView(Students, ViewData))
  End Function



  Public ReadOnly Property Students As List(Of Student)
  Public ReadOnly Property ViewData As ViewDataDictionary
End Class
