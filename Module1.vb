Module Module1

    Sub Main()
        FunCType()
        FunCBool()
        FunCByte()
        FunCDbl()
        FunCInt()
        FunCStr()
        FunCDatate()
        Console.Read()
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

End Module
