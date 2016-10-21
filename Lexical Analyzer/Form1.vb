Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim sText, token As String ' sText stands for stringText - Deklarasi Variabel
        Dim i, length As Integer ' Deklarasi Variabel
        sText = txtInput.Text + " " 'Memeasukan isi TextBoxInput ke variabel string (sText) & fungsi ditambah spasi sebagai penanda agar token keluar karena setiap token dikeluarkan bila sText.chars(i) = " " 
        sText = sText.ToLower ' << set ke lower agar tidak case sensitive
        length = sText.Length
        i = 0

Space:
        'On Error Resume Next
        If i < length Then
            Select Case sText.Chars(i)
                Case "p", "q", "r", "s" ' PQRS
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case " "
                            i = i + 1
                            token = token + " 1" ' Token dikeluarkan saat sText.chars(i) = " " agar mengetahui apakan suatu sintaks tidak ada lanjutannya, misal ifg agar menghasilkan error bukan 6error
                            GoTo Space
                        Case Else
                            token = token + "error"
                    End Select
                Case "n" ' NOT
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "o"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case "t"
                                    i = i + 1
                                    Select Case sText.Chars(i)
                                        Case " "
                                            token = token + " 2"
                                            i = i + 1
                                            GoTo Space
                                        Case Else
                                            token = token + "error"
                                    End Select
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "a" ' AND
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "n"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case "d"
                                    i = i + 1
                                    Select Case sText.Chars(i)
                                        Case " "
                                            token = token + " 3"
                                            i = i + 1
                                            GoTo Space
                                        Case Else
                                            token = token + "error"
                                    End Select
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "o" ' OR
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "r"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case " "
                                    i = i + 1
                                    token = token + " 4"
                                    GoTo Space
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "x" ' XOR
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "o"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case "r"
                                    i = i + 1
                                    Select Case sText.Chars(i)
                                        Case " "
                                            i = i + 1
                                            token = token + " 5"
                                            GoTo Space
                                        Case Else
                                            token = token + "error"
                                    End Select
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "i" ' IF
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "f"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case " "
                                    i = i + 1
                                    token = token + " 6"
                                    GoTo Space
                                Case "f"
                                    i = i + 1
                                    Select Case sText.Chars(i)
                                        Case " "
                                            i = i + 1
                                            token = token + " 8"
                                            GoTo Space
                                        Case Else
                                            token = token + "error"
                                    End Select
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "t" ' THEN
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case "h"
                            i = i + 1
                            Select Case sText.Chars(i)
                                Case "e"
                                    i = i + 1
                                    Select Case sText.Chars(i)
                                        Case "n"
                                            i = i + 1
                                            token = token + " 7"
                                            Select Case sText.Chars(i)
                                                Case " "
                                                    i = i + 1
                                                    GoTo Space
                                                Case Else
                                                    token = token + "error"
                                            End Select
                                        Case Else
                                            token = token + "error"
                                    End Select
                                Case Else
                                    token = token + "error"
                            End Select
                        Case Else
                            token = token + "error"
                    End Select
                Case "(" ' GROUPING
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case " "
                            token = token + " 9"
                            i = i + 1
                            GoTo Space
                        Case Else
                            token = token + "error"
                    End Select

                Case ")" ' GROUPING JAGA- JAGA KALAU ADA GROUPING SETELAH GROUPING
                    i = i + 1
                    Select Case sText.Chars(i)
                        Case " "
                            token = token + " 10"
                            i = i + 1
                            GoTo Space
                        Case Else
                            token = token + "error"
                    End Select
                Case " "
                    token = token
                Case Else
                    token = token + "error"
            End Select
        End If

        lblToken.Text = token 'Set LabelToken menjadi token
    End Sub
End Class
