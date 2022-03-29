Imports System.Collections.Generic
Imports VazorMVC1.Models

Friend Module SomeStudents
  Public Property Students As New List(Of Student) From {
      New Student With {.Id = 1, .Name = "Adam", .Age = 20, .Grade = 69},
      New Student With {.Id = 2, .Name = "Mark", .Age = 21, .Grade = 80},
      New Student With {.Id = 3, .Name = "Bill", .Age = 23, .Grade = 92},
      New Student With {.Id = 4, .Name = "Tom", .Age = 18, .Grade = 51}
  }
End Module
