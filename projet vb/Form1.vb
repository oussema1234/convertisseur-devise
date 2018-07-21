Imports System.Math
Public Class Form1
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As String
        x = InputBox("Donnez la devise à ajouté")
        ListBox1.Items.Add(x)
        ListBox2.Items.Add(x)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim li(0) As Object
        For Each Obj As Object In ListBox1.SelectedItems
            li(UBound(li)) = Obj
            ReDim Preserve li(li.Length)
        Next
        For Each Obj As Object In li
            ListBox1.Items.Remove(Obj)
        Next

        Dim lj(0) As Object
        For Each Obj As Object In ListBox2.SelectedItems
            lj(UBound(lj)) = Obj
            ReDim Preserve lj(lj.Length)
        Next
        For Each Obj As Object In lj
            ListBox2.Items.Remove(Obj)
        Next


    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Not (IsNumeric(TextBox1.Text)) Then
            MsgBox("Ooups! la valeur doit etre numérique")
            TextBox1.Text = ""



        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim eur As Double = 1.08
        Dim din As Double = 2.6
        Dim dol As Double = 2.4
        Dim res As String

            If ListBox1.SelectedItem = "EURO" And ListBox2.SelectedItem = "dollar" Then
                res = (Val(TextBox1.Text) * eur)
            Label3.Text = "le montant vaut:" + res

            ElseIf ListBox1.SelectedItem = "EURO" And ListBox2.SelectedItem = "dinar" Then
                res = (Val(TextBox1.Text) * din)
            Label3.Text = "le montant vaut:" + res
            ElseIf ListBox1.SelectedItem = "EURO" And ListBox2.SelectedItem = "EURO" Then
                res = Val(TextBox1.Text)
            Label3.Text = "le montant vaut:" + res
            End If


            If ListBox1.SelectedItem = "dollar" And ListBox2.SelectedItem = "EURO" Then
                res = (Val(TextBox1.Text) / eur)
            Label3.Text = "le montant vaut:" + res
            ElseIf ListBox1.SelectedItem = "dollar" And ListBox2.SelectedItem = "dinar" Then
                res = (Val(TextBox1.Text) * dol)
            Label3.Text = "le montant vaut:" + res
            ElseIf ListBox1.SelectedItem = "dollar" And ListBox2.SelectedItem = "dollar" Then
                res = Val(TextBox1.Text)
            Label3.Text = "le montant vaut:" + res
      
            End If



            If ListBox1.SelectedItem = "dinar" And ListBox2.SelectedItem = "EURO" Then
                res = (Val(TextBox1.Text) / din)
            Label3.Text = "le montant vaut:" + res
            ElseIf ListBox1.SelectedItem = "dinar" And ListBox2.SelectedItem = "dollar" Then
            res = (Val(TextBox1.Text) / dol)
        ElseIf ListBox1.SelectedItem = "dinar" And ListBox2.SelectedItem = "dinar" Then
            res = Val(TextBox1.Text)
            Label3.Text = "le montant vaut:" + res
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
