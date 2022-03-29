Imports System.Diagnostics
Imports System.Xml.Linq

Partial Public Class IndexView
  <CodeAnalysis.SuppressMessage("Style", "IDE0047:Remove unnecessary parentheses", Justification:="<Pending>")>
  Public Overrides Function GetVbXml() As XElement
    Return _
    <zml xmlns:z="zml">
      <z:model type="List(Of VazorMVC1.Models.Student)"/>
      <z:viewdata Title='"test"' Message='"OK"' Key='"value"'/>

      <h3 fff=""> Browse Students</h3>
      <p>Select from <%= Students.Count %> students:</p>
      <ul>
        <!--Use lambda expressions to execute vb code block-->
        <%= (Iterator Function()
               For Each oStudent In Students
                 Yield <li><%= oStudent.Name %></li>
               Next
             End Function).Invoke %>
      </ul>
      <!--Or use ZML tags directly-->
      <z:if condition="Model.Count > 1 andalso not (Model.Count >= 10)">
        <p>Students details:</p>
        <ul>
          <z:foreach var="m" in="Model">
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
        document.writeln("students count = @Model.Count");
      </script>
    </zml>
  End Function
End Class
