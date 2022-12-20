Namespace PartTwo


    Module ModuleArray
        Function GetArray() As Integer()
            Dim Arr() As Integer = New Integer(2) {1, 2, 3}
            Return Arr
        End Function
        Sub DisplayArray()

            Dim Array() As Integer

            Array = GetArray()
            For i = 0 To Array.Length - 1
                Console.WriteLine($"{Array(i)}")

            Next


        End Sub

        Sub InitListGeneric()
            Dim listCode As New List(Of String) From {"Code", "COdi", "Codo"} 'setelah of define tipe data apapun
            For Each list In listCode
                Console.WriteLine(list)

            Next

        End Sub




    End Module
End Namespace
