Imports System.Threading.Tasks
Imports Grpc.Core
Imports Helloworld

Friend Class Service
  Inherits Greeter.GreeterBase

  Public Overrides Function SayHello(Request As HelloRequest, Context As ServerCallContext) As Task(Of HelloReply)
    Dim oReply As HelloReply

    oReply = New HelloReply With {.Message = $"Hello {Request.Name}"}

    Return Task.FromResult(oReply)
  End Function
End Class
