Namespace PartTwo
    Public Interface IHR

        Function InitEmployee() As List(Of Employee)

        Function FindEmployee(ListEmp As List(Of Employee), id As Integer) As Employee

        Function TotalGaji(listEmp As List(Of Employee)) As Double

        Function TotalEmpRole(listEmp As List(Of Employee), role As String) As Integer

        Function GajiEmpTotRole(listEmp As List(Of Employee), role As String) As Double

        Sub DisplayEmployee(listEmps As List(Of Employee))


    End Interface
End Namespace