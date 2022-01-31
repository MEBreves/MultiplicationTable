'Miranda Breves
'RCET0265
'Spring 2022
'Multiplication Table
'url here

Option Explicit On
Option Strict On

Module MultiplicationTable

    Sub Main()

        'Declaring Variables
        Dim userInput As String
        Dim sizeCheck As Boolean = False
        Dim tableSize As Integer
        Dim outputFactor As Integer

        'Asking the user for the desired size of the table
        Console.WriteLine("What is the maximum level of your desired multiplication table?")
        Console.Write("> ")
        userInput = Console.ReadLine()
        Console.WriteLine()

        'Verifying the value
        Do

            Try
                tableSize = CInt(userInput)
                sizeCheck = True
            Catch ex As Exception
                Console.WriteLine("The input was not valid. Please enter a whole number for the table size.")
                Console.Write("> ")
                userInput = Console.ReadLine()
                Console.WriteLine()
            End Try

        Loop Until sizeCheck

        'Presenting the multiplication table
        Console.WriteLine($"Enjoy your {tableSize} x {tableSize} Multiplication Table:")
        Console.WriteLine()


        'The first for loop sets up the rows of the multiplication table by moving the values down a line each iteration
        For i As Integer = 1 To tableSize

            'The second for loop creates the columns and values of the multiplication table by writing the factors of the
            'multiplication table and spacing out each factor by an overall value of 6 (using padding)
            For j As Integer = 1 To tableSize

                'To make sure each column contains a factor of the first value in the row, the column number (j) is mulitplied
                'by the row number (i)
                outputFactor = i * j
                Console.Write(outputFactor.ToString().PadLeft(6))
            Next

            Console.WriteLine()
        Next

        'Letting the user know how to end the program
        Console.WriteLine()
        Console.WriteLine("Please press the Enter key to exit the program.")
        Console.ReadLine()



    End Sub

End Module
