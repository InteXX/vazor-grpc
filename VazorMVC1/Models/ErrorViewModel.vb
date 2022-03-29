Namespace Models
  Public Class ErrorViewModel
    Public ReadOnly Property ShowRequestId() As Boolean
      Get
        Return Not String.IsNullOrEmpty(Me.RequestId)
      End Get
    End Property



    Public Property RequestId As String
  End Class
End Namespace
