Imports System
Imports VbAppConsole.PartOne
Imports VbAppConsole.PartTwo

Module Program
    Sub Main(args As String())

        'call method SayMyName
        'SayMyName()

        'call method from ModuleVariables
        'ModuleVariables.StoreVariable()
        'ModuleVariables.SwapTwoVariable()
        'ModuleMath.OperationMath()
        'ModuleMath.BagiSisa()
        'ModuleDecision.Grade()
        'ModuleDecision.GradeCase()
        'ModuleDecision.WhoIsTheGreatest()
        'ModuleDecision.OddEvenNumber
        'ModuleDateTime.ShowDate()

        'Day 02

        'ModuleIteration.DoWhile(12)
        'ModuleIteration.ForLoop()
        'ModuleIteration.KotakBintang(5)
        'ModuleIteration.WhileLoop(10)

        'Day 03
        'ModulePartOne.InitEmployee()
        'ModulePartTwo.InitEmployee()

        'Array
        'ModuleArray.InitListGeneric()
        'ModuleArray.DisplayArray()

        'Interface and Implementation

        Dim IHr As IHR = New HR

        Dim listEmp = IHr.InitEmployee()
        IHr.DisplayEmployee(listEmp)



        Dim salary = IHr.TotalGaji(listEmp)
        Console.WriteLine($"Total Gaji: {salary}")

        Dim inputrole = "QA"
        Dim totem = IHr.TotalEmpRole(listEmp, inputrole)
        Console.WriteLine($"Total {inputrole} : {totem}")


        Dim inputsales = "Sales"
        Dim totsal = IHr.TotalEmpRole(listEmp, inputsales)
        Console.WriteLine($"Total {inputsales} : {totsal}")


        Dim inputpro = "Programmer"
        Dim totpro = IHr.TotalEmpRole(listEmp, inputpro)
        Console.WriteLine($"Total {inputpro} : {totpro}")


        Dim inputQaGaji = "QA"
        Dim gajiQA = IHr.GajiEmpTotRole(listEmp, inputQaGaji)
        Console.WriteLine($"Gaji QA {inputQaGaji} : {gajiQA}")



        'Dim emp = IHr.FindEmployee(listEmp, 1)
        'If emp IsNot Nothing Then
        '    Console.WriteLine($"EMployee : {emp}")
        'Else
        '    Console.WriteLine("Ga ada")

        'End If






    End Sub

    '    Sub SayMyName()
    '        'declaration variable string
    '        Dim myName As String
    '        Console.Write("Enter your name: ")
    '        myName = Console.ReadLine()

    '        'display result
    '        Console.WriteLine("Your Name: " & myName)
    '    End Sub
End Module
