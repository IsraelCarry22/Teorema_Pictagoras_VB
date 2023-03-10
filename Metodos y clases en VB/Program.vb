Imports System

Class Program
    Class triangulo_rectangulo
        Private Shared Sub Main(ByVal args As String())
            Dim final As Boolean = False
            Dim cateto_OP As Double
            Dim cateto_AD As Double
            Dim Hip As Double
            Dim val As Integer
            Dim TR As triangulo_rectangulo
            TR = New triangulo_rectangulo()

            While Not final
                Console.Clear()
                Console.WriteLine("//Teorema de pictagoras, area y preimetro//" & vbLf)
                Console.WriteLine("/Elige una Opcion/" & vbLf & "[1]Calculo Area." & vbLf & "[2]Calculo Perimetro." & vbLf & "[3]Calculo Cateto Opuesto." & vbLf & "[4]Calculo Cateto Adyacente." & vbLf & "[5]Calculo Hipotenusa." & vbLf & "[6]Salir")
                val = Integer.Parse(Console.ReadLine())

                Select Case val
                    Case 1
                        Console.Clear()
                        Console.Write("Cateto Adyacente: ")
                        cateto_AD = Double.Parse(Console.ReadLine())
                        Console.Write("Cateto Opuesto: ")
                        cateto_OP = Double.Parse(Console.ReadLine())
                        Console.WriteLine("Area del triangulo es: " & TR.teorema_pictagoras(cateto_OP, cateto_AD))
                        Console.WriteLine("Pulsa cualquier tecla para continuar...")
                    Case 2
                        Console.Clear()
                        Console.Write("Cateto Adyacente: ")
                        cateto_AD = Double.Parse(Console.ReadLine())
                        Console.Write("Cateto Opuesto: ")
                        cateto_OP = Double.Parse(Console.ReadLine())
                        Console.Write("Hipotenusa: ")
                        Hip = Double.Parse(Console.ReadLine())
                        Console.WriteLine("Area del triangulo es: " & TR.teorema_pictagoras(cateto_OP, cateto_AD, Hip))
                        Console.WriteLine("Pulsa cualquier tecla para continuar...")
                    Case 3
                        Console.Clear()
                        Console.Write("Cateto Adyacente: ")
                        cateto_AD = Double.Parse(Console.ReadLine())
                        Console.Write("Hipotenusa: ")
                        Hip = Double.Parse(Console.ReadLine())
                        Console.WriteLine("Cateto Opuesto es: " & TR.Cal_Cateto_Opuesto(cateto_AD, Hip))
                        Console.WriteLine("Pulsa cualquier tecla para continuar...")
                    Case 4
                        Console.Clear()
                        Console.Write("Cateto Opuesto: ")
                        cateto_OP = Double.Parse(Console.ReadLine())
                        Console.Write("Hipotenusa: ")
                        Hip = Double.Parse(Console.ReadLine())
                        Console.WriteLine("Cateto Adyacente es: " & TR.Cal_Cateto_Adyacente(cateto_OP, Hip))
                        Console.WriteLine("Pulsa cualquier tecla para continuar...")
                    Case 5
                        Console.Clear()
                        Console.Write("Cateto Adyacente: ")
                        cateto_AD = Double.Parse(Console.ReadLine())
                        Console.Write("Cateto Opuesto: ")
                        cateto_OP = Double.Parse(Console.ReadLine())
                        Console.WriteLine("Hipotenusa es: " & TR.Cal_Hipotenusa(cateto_OP, cateto_AD))
                        Console.WriteLine("Pulsa cualquier tecla para continuar...")
                    Case 6
                        Console.Clear()
                        final = True
                        Console.WriteLine("Adios :)")
                    Case Else
                        Console.Clear()
                        Console.WriteLine("Valor invalido o fuera de rango...")
                End Select

                Console.ReadKey()
            End While
        End Sub

        Public Function teorema_pictagoras(ByVal Cateto_Opuesto As Double, ByVal Cateto_Adyacente As Double) As Double
            Return (Cateto_Adyacente * Cateto_Opuesto / 2)
        End Function

        Public Function teorema_pictagoras(ByVal Cateto_Opuesto As Double, ByVal Cateto_Adyacente As Double, ByVal Hipotenusa As Double) As Double
            Return (Cateto_Adyacente + Cateto_Opuesto + Hipotenusa)
        End Function

        Public Function Cal_Hipotenusa(ByVal Cateto_Opuesto As Double, ByVal Cateto_Adyacente As Double) As Double
            Return Math.Sqrt(Math.Pow(Cateto_Opuesto, 2) + Math.Pow(Cateto_Adyacente, 2))
        End Function

        Public Function Cal_Cateto_Opuesto(ByVal Cateto_Adyacente As Double, ByVal Hipotenusa As Double) As Double
            Return Math.Sqrt(Math.Pow(Cateto_Adyacente, 2) - Math.Pow(Hipotenusa, 2))
        End Function

        Public Function Cal_Cateto_Adyacente(ByVal Cateto_Opuesto As Double, ByVal Hipotenusa As Double) As Double
            Return Math.Sqrt(Math.Pow(Cateto_Opuesto, 2) - Math.Pow(Hipotenusa, 2))
        End Function
    End Class

End Class
