Public Class Sofigma
    Dim ar As Char() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "#", "$", "%", "&", "(", ")", "*", "+", ",", "-", ".", ":", ";", "<", "=", ">", "?", "@", "[", " ", "]", "^", "_", "'", "{", "}", "~"}
    Dim r1 As Char() = {"|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|"}
    Dim r2 As Char() = {"|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|"}
    Dim r3 As Char() = {"|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|", "|"}

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        rotor1.Text = 1
        rotor2.Text = 1
        rotor3.Text = 1
        input.Clear()
        copycode.Clear()
        output.Clear()
    End Sub

    Private Sub input_TextChanged(sender As Object, e As EventArgs) Handles input.TextChanged
        If rotor1.Text = "" Or rotor2.Text = "" Or rotor3.Text = "" Then
            input.Clear()
            MsgBox("Please enter valid number")
        Else
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''setting r1 START''''''''''''''''''''''''''''''''''''''''
            If rotor1.Text <> "" Then
                For i = 0 To 63
                    r1(i) = "|"
                Next
                Dim n As Integer = rotor1.Text
                For i = 0 To 63
                    If r1(i) = "|" Then
                        If (i + n) > 63 Then
                            Dim st As Integer = i
                            Dim en As Integer = 63
                            While r1(en) <> "|"
                                en -= 1
                            End While
                            'MsgBox("end = " + en.ToString)
                            For j = st To en
                                r1(j) = ar(en)
                                'MsgBox("r1(" + j.ToString + ") = " + r1(j))
                                en -= 1
                            Next
                        Else
                            r1(i) = ar(i + n)
                            'MsgBox("r1(" + i.ToString + ") = " + r1(i))
                            r1(i + n) = ar(i)
                            'MsgBox("r1(" + (i + n).ToString + ") = " + r1(i + n))
                        End If
                    Else
                        Continue For
                    End If
                Next
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''setting r1 END''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''SETTING r2 START''''''''''''''''''''''''''''''''''''''''''''''''''
            If rotor2.Text <> "" Then
                For i = 0 To 63
                    r2(i) = "|"
                Next
                Dim n As Integer = rotor2.Text
                For i = 0 To 63
                    If r2(i) = "|" Then
                        If (i + n) > 63 Then
                            Dim st As Integer = i
                            Dim en As Integer = 63
                            While r2(en) <> "|"
                                en -= 1
                            End While
                            'MsgBox("end = " + en.ToString)
                            For j = st To en
                                r2(j) = ar(en)
                                'MsgBox("r1(" + j.ToString + ") = " + r1(j))
                                en -= 1
                            Next
                        Else
                            r2(i) = ar(i + n)
                            'MsgBox("r1(" + i.ToString + ") = " + r1(i))
                            r2(i + n) = ar(i)
                            'MsgBox("r1(" + (i + n).ToString + ") = " + r1(i + n))
                        End If
                    Else
                        Continue For
                    End If
                Next
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''SETTING r2 END''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''SETTING r3 START''''''''''''''''''''''''''''''''''''''''''''''''''
            If rotor3.Text <> "" Then
                For i = 0 To 63
                    r2(i) = "|"
                Next
                Dim n As Integer = rotor3.Text
                For i = 0 To 63
                    If r3(i) = "|" Then
                        If (i + n) > 63 Then
                            Dim st As Integer = i
                            Dim en As Integer = 63
                            While r3(en) <> "|"
                                en -= 1
                            End While
                            'MsgBox("end = " + en.ToString)
                            For j = st To en
                                r3(j) = ar(en)
                                'MsgBox("r1(" + j.ToString + ") = " + r1(j))
                                en -= 1
                            Next
                        Else
                            r3(i) = ar(i + n)
                            'MsgBox("r1(" + i.ToString + ") = " + r1(i))
                            r3(i + n) = ar(i)
                            'MsgBox("r1(" + (i + n).ToString + ") = " + r1(i + n))
                        End If
                    Else
                        Continue For
                    End If
                Next
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''SETTING r3 END''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''ENCODING START'''''''''''''''''''''''''''''''''''''''''''''''
            If input.Text <> "" Then
                Dim ip As Integer
                Dim op As Char
                Dim ip_str As String = input.Text
                Dim op_str As String = output.Text
                For i = 0 To 63
                    If ar(i) = ip_str(ip_str.Length - 1) Then
                        ip = i
                        op = r1(ip)
                        op_str = op_str + op
                    End If
                Next
                'MsgBox(op)
                'For i = 0 To 63
                '    If ar(i) = op Then
                '        ip = i
                '        op = r2(ip)
                '        op_str = op_str + op
                '    End If
                'Next
                'MsgBox(op)
                'For i = 0 To 63
                '    If ar(i) = op Then
                '        ip = i
                '        op = r3(ip)
                '        op_str = op_str + op
                '    End If
                'Next
                'MsgBox(op)
                output.Text = op_str
                rotor1.Text = rotor1.Text + 1
                ''''''''''''''''''''''''''''''''''''''CHECK ROTOR POSITIONS START''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                If rotor1.Text > 63 Then
                    rotor2.Text = rotor2.Text + 1
                    For i = 0 To 63
                        r1(i) = "|"
                    Next
                    If rotor2.Text > 63 Then
                        rotor3.Text = rotor3.Text + 1
                        For i = 0 To 63
                            r2(i) = "|"
                        Next
                        If rotor3.Text > 63 Then
                            rotor3.Text = 1
                            rotor2.Text = 1
                            rotor1.Text = 1
                            For i = 0 To 63
                                r1(i) = "|"
                                r2(i) = "|"
                                r3(i) = "|"
                            Next
                        End If
                        rotor2.Text = 1
                    End If
                    rotor1.Text = 1
                End If
                ''''''''''''''''''''''''''''''''''''''CHECK ROTOR POSITIONS END''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            End If
            Dim a As Integer = 34'''''''''''''''''''double quote
            Dim b As Integer = 124''''''''''''''''''logical or
            Dim c As Integer = 47'''''''''''''''''''slash
            If input.Text.Contains("`") Or input.Text.Contains(Convert.ToChar(a)) Or input.Text.Contains(Convert.ToChar(b)) Or input.Text.Contains(Convert.ToChar(c)) Then
                MsgBox("Please do not enter double quotation marks instead use single quotation marks. Please do not enter ` or |(this is pipe not capital i) or slash. Now reset the machine, set key again & start over. Remember you will not get correct value if u use backspace in input you will need to reset the machine")
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''ENCODING END'''''''''''''''''''''''''''''''''''''''''''''''
        End If
    End Sub

    Private Sub output_TextChanged(sender As Object, e As EventArgs) Handles output.TextChanged
        Dim o As String = output.Text
        o = o.Trim("|")
        output.Text = o
    End Sub

    Private Sub rotor1_TextChanged(sender As Object, e As EventArgs) Handles rotor1.TextChanged
        Dim num As Integer
        If Integer.TryParse(rotor1.Text, num) Then
            If rotor1.Text = 0 Then
                rotor1.Text = 1
                MsgBox("Please enter valid number")
            End If
        Else
            rotor1.Text = 1
            MsgBox("Please enter valid number")
        End If
    End Sub

    Private Sub rotor2_TextChanged(sender As Object, e As EventArgs) Handles rotor2.TextChanged
        Dim num As Integer
        If Integer.TryParse(rotor2.Text, num) Then
            If rotor2.Text = 0 Then
                rotor2.Text = 1
                MsgBox("Please enter valid number")
            End If
        Else
            rotor2.Text = 1
            MsgBox("Please enter valid number")
        End If
    End Sub

    Private Sub rotor3_TextChanged(sender As Object, e As EventArgs) Handles rotor3.TextChanged
        Dim num As Integer
        If Integer.TryParse(rotor3.Text, num) Then
            If rotor3.Text = 0 Then
                rotor3.Text = 1
                MsgBox("Please enter valid number")
            End If
        Else
            rotor3.Text = 1
            MsgBox("Please enter valid number")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        input.Clear()
        output.Clear
        Dim copy As Char() = copycode.Text
        For i = 0 To copycode.Text.Length - 1
            input.Text = input.Text + copy(i)
        Next
    End Sub

    Private Sub copycode_TextChanged(sender As Object, e As EventArgs) Handles copycode.TextChanged
        input.Clear()
        output.Clear()
        rotor1.Text = 1
        rotor2.Text = 1
        rotor3.Text = 1
    End Sub

    Private Sub Sofigma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Remember you will need to RESET THE MACHINE & START ALL OVER AGAIN if you did a mistake in input. You CANNOT rely on backspace as it leads to wrong encoding-decoding. So better be careful while typing the input.")
    End Sub
End Class