Imports System.Net

Module Module1

    Sub Main()

        'PracticaMartes26sep2023()
        PracticaJueves28sep2023()
        Console.Read()
    End Sub
    Sub PracticaMartes26sep2023()
        FunCType()
        FunCBool()
        FunCByte()
        FunCDbl()
        FunCInt()
        FunCStr()
        FunCDatate()

    End Sub

    Sub FunCType() 'conversio de dato a tipo Single
        Dim numero As Long = 15000
        Console.WriteLine(numero)

        Dim nuevoTipo As Single = CType(numero, Single)
        Console.WriteLine(nuevoTipo.GetType.ToString)

    End Sub

    Sub FunCBool()
        Dim a, b, c As Integer
        Dim validar As Boolean

        a = 7
        b = 7
        validar = CBool(a = b)
        Console.WriteLine(validar)

        c = 2
        validar = CBool(a = c)
        Console.WriteLine(validar)
    End Sub

    Sub FunCByte() 'aproximacion de 135 a 136
        Dim numD As Double
        Dim numByte As Byte

        numD = 135.5648
        numByte = CByte(numD)
        Console.WriteLine(numByte)
    End Sub


    Sub FunCDbl()
        Dim numDec As Decimal
        Dim numDbl As Double

        numDec = 234.684785D

        numDbl = CDbl(numDec * 8.2 * 0.01D)
        Console.WriteLine(numDbl)

    End Sub

    Sub FunCInt()
        Dim numD As Double
        Dim numI As Integer

        numD = 4368.54785
        numI = CInt(numD)
        Console.WriteLine(numI)

    End Sub

    Sub FunCStr()
        Dim numDbl As Double = 437.324
        Dim varStr As String
        varStr = CStr(numDbl)
        Console.WriteLine(varStr.GetType.ToString)

    End Sub

    Sub FunCChar()
        Dim varStr As String = "ABC"
        Dim varChar As Char

        varChar = CChar(varStr)
        Console.WriteLine(varChar.GetType.ToString)
    End Sub

    Sub FunCDatate() 'no funciona :(
        Dim fechaStr, horaStr As String
        Dim fecha, hora As Date

        fechaStr = "septiembre 26, 2023 "
        horaStr = "17:57:27"

        fecha = CDate(fechaStr)
        Console.WriteLine(fecha)

        hora = CDate(horaStr)
        Console.WriteLine(hora)

    End Sub

    Sub PracticaJueves28sep2023()
        'Operadores()
        'FonWhile()
        'DoWhile()
        cicloFor()
    End Sub

    Sub Operadores()

        Dim a, b As Integer
        a = 12
        b = 5
        Console.WriteLine("Los valores de la variables a operar  son: a = " & a & " y b= " & b)

        'a = a + b
        ' a += b
        ' Console.WriteLine("el resultado de la suma es " & a)

        'a = a - b
        ' a -= b
        ' Console.WriteLine("el resultado de la resta es " & a)

        'a = a * b
        'a *= b
        'Console.WriteLine("el resultado de la multiplicacion es " & a)

        'a = a / b
        ' a /= b
        'Console.WriteLine("el resultado de la divicion es " & a)

        'a = a + b
        a = a Mod b
        Console.WriteLine("el resultado del resto es " & a)
    End Sub

    Sub FonWhile()
        Console.WriteLine("por favor ingrese un numero: ")
        Dim i = 1
        While i <= 10
            Console.WriteLine("El interador = " & i)
            i += 1
            'es como que yo diga i = i+1. Es lo mismo i += 1
        End While
        Console.WriteLine(i) 'nuevo valor de i

        While i >= 1
            Console.WriteLine("El interador = " & i)
            i -= 1
            'es como que yo diga i = i+1. Es lo mismo i -= 1
        End While


    End Sub

    Sub DoWhile()
        Dim i = 1
        'Do
        '    Console.WriteLine("El iterador = " & i)
        '    i += 4

        'Loop While i <= 10


        Dim random = New Random()
        Dim aleatorio = random.Next(1, 6)
        Console.WriteLine("El valor random es: " & aleatorio)
        Do
            Console.WriteLine("El iterador = " & i)
            i += 1

        Loop While i <= aleatorio

    End Sub

    Sub cicloFor()

        'For i = 1 To 10
        '    Console.WriteLine("El itterador = " & i)

        'Next


        'For i = 1 To 10 Step 1
        '    Console.WriteLine("El itterador = " & i)

        'Next

        'For i = 1 To 10 Step -1
        '    Console.WriteLine("El itterador = " & i)

        'Next

        Dim a, b As Integer
        a = 10
        b = Integer.Parse(Console.ReadLine())

        For i = a To b Step -1
            Console.WriteLine(" El iterador es = " & i)
        Next

    End Sub

End Module
