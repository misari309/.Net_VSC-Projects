Imports System.Buffers

Public Class Form1
    Dim row = 1
    Dim list As List(Of Integer) = New List(Of Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num = CInt(TextBox1.Text)
        list.Add(num)
        DataGridView1.Rows.Add(row, num)
        row = row + 1
        TextBox1.Text = ""
        DataGridView3.Rows.Add()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fi = 1
        Dim n As String
        Dim nAux As String
        Dim nAnt = " "
        Dim listR As List(Of String) = New List(Of String)
        For index = 0 To list.Count - 1
            n = CStr(list(index))
            nAux = n.Substring(0, n.Length - 1)
            listR.Add(nAux)
        Next
        Dim max = 0, cont = 1
        For index = 0 To listR.Count - 1
            If index < listR.Count - 1 Then
                If listR(index) = listR(index + 1) Then
                    cont = cont + 1
                    If cont > max Then
                        max = cont
                    End If
                Else
                    If cont > max Then
                        max = cont
                    End If
                    cont = 1
                End If
            End If
        Next
        For index = 1 To max - 1
            DataGridView3.Columns.Add(0, index)
        Next
        Dim row = 0
        Dim column = 0
        DataGridView3.Rows.Add()
        For index = 0 To listR.Count - 1
            If index < listR.Count - 1 Then
                If listR(index) = listR(index + 1) Then
                    DataGridView3.Rows(row).Cells(0).Value = listR(index)
                Else
                    DataGridView3.Rows(row).Cells(0).Value = listR(index)
                    DataGridView3.Rows.Add()
                    row = row + 1
                End If
            Else
                If listR(listR.Count - 1) IsNot listR(listR.Count - 2) Then
                    DataGridView3.Rows.Add()
                    DataGridView3.Rows(row).Cells(0).Value = listR(listR.Count - 1)
                End If
            End If
        Next
        Dim row1 = 0
        Dim column1 = 1
        Dim sheet = CStr(list(0))
        Dim longs = sheet.Length
        Dim sheeta = sheet.Substring(longs - 1)
        DataGridView3.Rows(row1).Cells(column1).Value = sheeta
        For index = 1 To listR.Count - 1
            sheet = CStr(list(index))
            longs = sheet.Length
            Dim hoaa = sheet.Substring(longs - 1)
            If listR(index) = listR(index - 1) Then
                column1 = column1 + 1
                DataGridView3.Rows(row1).Cells(column1).Value = hoaa
            Else
                column1 = 1
                row1 = row1 + 1
                DataGridView3.Rows(row1).Cells(column1).Value = hoaa
            End If

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For index = 0 To list.Count - 1
            Dim lim = list.Count - 1
            If index < lim Then
                If list(index) > list(index + 1) Then
                    Dim aux = list(index + 1)
                    list(index + 1) = list(index)
                    list(index) = aux
                    index = -1
                End If
            End If
        Next
        Dim fi = 1
        Dim n
        For index = 0 To list.Count - 1
            n = list(index)
            DataGridView2.Rows.Add(fi, n)
            fi = fi + 1
        Next
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class
