Namespace PartTwo
    Public Class Sales
        Inherits Employee
        Private _bonus As Double
        Private _commision As Double

        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional bonus As Double = Nothing, Optional commision As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary, "Sales")
            _bonus = bonus
            _commision = commision
            MyBase.TotalSalary = basicSalary + _bonus + _commision

        End Sub

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
            End Set
        End Property

        Public Property Bonus As Double
            Get
                Return _bonus
            End Get
            Set(value As Double)
                _bonus = value
                MyBase.TotalSalary = BasicSalary + value + Commision
            End Set
        End Property

        Public Property Commision As Double
            Get
                Return _commision
            End Get
            Set(value As Double)
                _commision = value
                MyBase.TotalSalary = BasicSalary + value + Bonus
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return $"
{MyBase.ToString()}, 
bonus : {Bonus},
Commision : {Commision}, 
Total Sallary : {MyBase.TotalSalary}"
        End Function
    End Class
End Namespace
