Imports Microsoft.AspNetCore.Mvc.ViewFeatures
Imports VazorPages1.Data

Partial Public Class VazorPageModel
  Private Function GetVbXml(Students As List(Of Student), ViewData As ViewDataDictionary) As XElement
    Return _
 _
    <zml xmlns:z="zml">
      <z:viewdata Title='"test"' Message='"OK"' Key='"value"'/>

      <h3 fff=""> Browse Students</h3>
      <p>Select from <%= Students.Count() %> students:</p>
      <ul>
        <!--Use lambda expressions to execute vb code block-->
        <%= Iterator Function()
              For Each oStudent In Students
                Yield <li><%= oStudent.Name %></li>
              Next
            End Function() %>
      </ul>
      <!--Or use ZML tags directly-->
      <z:if condition="Model.Students.Count > 1 AndAlso Not (Model.Students.Count >= 10)">
        <p>Students details:</p>
        <ul>
          <z:foreach var="m" in="Model.Students">
            <li>
              Id: @m.Id<br/>
              Name: @m.Name<br/>
              <p>Grade: @m.Grade</p>
            </li>
          </z:foreach>
        </ul>
      </z:if>
      <script>
        var x = 5;
        document.writeln("students count = @Model.Students.Count");                
      </script>
    </zml>
  End Function
End Class
