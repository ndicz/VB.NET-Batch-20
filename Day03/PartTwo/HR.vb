Namespace PartTwo

    Public Class HR
        Implements IHR

        Public Sub DisplayEmployee(listEmps As List(Of Employee)) Implements IHR.DisplayEmployee
            For Each emp In listEmps
                Console.WriteLine(emp)

            Next



        End Sub

        Public Function InitEmployee() As List(Of Employee) Implements IHR.InitEmployee
            Dim listEmp As New List(Of Employee) From {
                New Sales("Mahendrata", "Harpi", DateTime.Now, 5_000_000, 5_000_000, 5_000_000),
                New QA("Joko", "Mamat", DateTime.Now, 5_000_000, 5_000_000),
                New Programmer("Budi", "Budiman", DateTime.Now, 6_500_000, 5_000_000),
                New Sales("Mahendrata", "Harpi", DateTime.Now, 5_000_000, 5_000_000, 5_000_000),
                New QA("Joko", "Mamat", DateTime.Now, 5_000_000, 5_000_000),
                New Programmer("Budi", "Budiman", DateTime.Now, 6_500_000, 5_000_000),
                New Sales("Mahendrata", "Harpi", DateTime.Now, 5_000_000, 5_000_000, 5_000_000),
                New QA("Joko", "Mamat", DateTime.Now, 5_000_000, 5_000_000),
                New Programmer("Budi", "Budiman", DateTime.Now, 6_500_000, 5_000_000),
                New Programmer("Anton", "Pratama", #03/03/2015#, 6_000_000, 500_000),
                New Programmer("Budi", "Junaedi", #08/15/2016#, 6_000_000, 500_000),
                New Programmer("Charlie", "Van Dijk", #09/05/2017#, 6_000_000, 500_000),
                New Sales("Dian", "Permana", #10/12/2017#, 3_000_000, 500_000, 200_000),
                New Sales("Fatur", "Rohman", #01/15/2019#, 3_000_000, 350_000, 250_000),
                New QA("Ellise", "Toon", #01/15/2019#, 4_500_000, 10_000),
                New QA("Gita", "Gutawa", #03/01/2019#, 4_500_000, 10_000)
            }
            Return listEmp

        End Function

        Public Function FindEmployee(ListEmp As List(Of Employee), id As Integer) As Employee Implements IHR.FindEmployee

            ' Dim emp As Employee = Nothing
            For Each list In ListEmp
                If (list.EmpId.Equals(id)) Then
                    Return list
                    'emp = list
                End If
            Next
            Return Nothing

        End Function

        Public Function TotalGaji(listEmp As List(Of Employee)) As Double Implements IHR.TotalGaji

            Dim total As Double = 0
            For Each list In listEmp

                total += list.TotalSalary


            Next

            Return total
        End Function

        Public Function GajiEmpTotRole(listEmp As List(Of Employee), role As String) As Double Implements IHR.GajiEmpTotRole

            Dim totalgajirole As Double
            For Each gajirole In listEmp
                If gajirole.Rolejob = role Then totalgajirole = gajirole.TotalSalary
            Next
            Return totalgajirole

        End Function



        Public Function TotalEmpRole(listEmp As List(Of Employee), role As String) As Integer Implements IHR.TotalEmpRole

            Dim totalemp As Integer
            For Each totem In listEmp
                If totem.rolejob = role Then totalemp += 1
            Next

            Return totalemp
        End Function
    End Class



End Namespace
