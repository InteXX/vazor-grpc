Namespace Data
  Friend Module SomeStudents
    Public Students As New List(Of Student) From {
      New Student With {.Id = 1, .Name = "Adam", .Age = 20, .Grade = 69},
      New Student With {.Id = 2, .Name = "Mark", .Age = 21, .Grade = 80},
      New Student With {.Id = 3, .Name = "Tom", .Age = 18, .Grade = 51}
  }
  End Module
End Namespace
