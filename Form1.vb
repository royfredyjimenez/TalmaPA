Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lines = IO.File.ReadAllLines("F:\cargacsv.csv")
        Dim dTable = New DataTable
        Dim numeroColumnas = lines.First.Split(","c).Length

        For i As Int32 = 1 To numeroColumnas
            'Agrega columnas a DataTable.
            dTable.Columns.Add(New DataColumn("Columna_" & i, GetType(String)))
            Debug.Print("Columna_" & i)
        Next

        '**********************
        For Each line In lines
            Dim objFields = From field In line.Split(","c)
            Dim newRow = dTable.Rows.Add()
            newRow.ItemArray = objFields.ToArray()
            txtCSV.Text = objFields.ToArray().GetValue(0).ToString
            txtCSV.Text = objFields.ToArray().GetValue(1).ToString
            txtCSV.Text = objFields.ToArray().GetValue(2).ToString
            'txtCSV.Text = objFields.ToArray().GetValue(1).ToString
            'txtCSV.Text = objFields.ToArray().GetValue(1).ToString

            'Debug.Print("columna_1: " & objFields.ToArray().GetValue(0).ToString)
            'Debug.Print("columna_2: " & objFields.ToArray().GetValue(1).ToString)
            'Debug.Print("columna_3: " & objFields.ToArray().GetValue(2).ToString)
        Next

        'Debug.Print("finaliza!")


    End Sub
End Class
