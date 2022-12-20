Namespace PartTwo
    Public Class QA
        Inherits Employee

        Private _makan As Double

        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional makan As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary, "QA")
            _makan = makan
            MyBase.TotalSalary += _makan
        End Sub

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + makan
            End Set
        End Property

        Public Property makan As Double
            Get
                Return _makan
            End Get
            Set(value As Double)
                _makan = value
                MyBase.TotalSalary = BasicSalary + value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}, Makan : {makan}, TotalSalary: {MyBase.TotalSalary}"
        End Function
    End Class
End Namespace