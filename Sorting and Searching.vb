Module Module1

    Sub Main()

        Dim intTestScores() As Integer = {9, 8, 7, 6, 5, 4, 3, 2, 1}

        Console.WriteLine("Orginal Order")
        showTestScores(intTestScores)
        Console.WriteLine()
        Console.WriteLine("Sorting")
        sortScores(intTestScores)
        Console.WriteLine()
        Console.WriteLine("Sorted Order")
        showTestScores(intTestScores)
        Console.WriteLine()
        Console.Write("Press the enter key to terminate program.")
        Console.Read()

    End Sub

    Private Sub showTestScores(ByRef intTestScores() As Integer)

        For intIndex As Integer = 0 To intTestScores.GetUpperBound(0)

            Console.Write(intTestScores(intIndex) & ControlChars.Tab) 'Stay on same display line

            For intTimer As Int16 = 1 To 10000
                For inttimer2 As Integer = 1 To 20000
                    'Delay execution for a couple of seconds to slow display
                Next
            Next

        Next

        Console.WriteLine() 'Move the cursor down to the next line

    End Sub

    Private Sub sortScores(ByRef intTestScores() As Integer)

        Dim intMaxElement As Integer = 0
        Dim intIndex As Integer = 0

        For intMaxElement = intTestScores.GetUpperBound(0) To 0 Step -1
            'Outer loop reduces the size of the array with each completed pass

            Console.WriteLine("Pass through arry for index 0 to " & intMaxElement)
            'Above line demonstrates how the arry shrinks with each completed pass

            For intIndex = 0 To intMaxElement - 1

                If intTestScores(intIndex) > intTestScores(intIndex + 1) Then
                    swap(intTestScores(intIndex), intTestScores(intIndex + 1))
                End If

                showTestScores(intTestScores)

            Next

            Console.WriteLine(intMaxElement & " now has the highest remaining score")
            'Above line marks the end of the outer loop
            Console.WriteLine()

        Next

    End Sub

    Private Sub swap(ByRef intScoreA As Integer, ByRef intScoreB As Integer)
        Dim intTemp As Integer = 0

        intTemp = intScoreA
        intScoreA = intScoreB
        intScoreB = intTemp

    End Sub

End Module
