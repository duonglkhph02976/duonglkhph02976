Public Class FrmQLBH
    Private _DBAccess As New DataBaseAccess
    Private _isLoading As Boolean = False

    Private Sub LoadDataOnComBobox()
        Dim sqlQuery As String = "SELECT ClassID,ClassName FROM dbo.HTTT"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.CmbClass.DataSource = dTable
        Me.CmbClass.ValueMember = "ClassID"
        Me.CmbClass.DisplayMember = "ClassName"
    End Sub

    Private Sub LoadDataOnGridView(ClassID As String)
        Dim sqlQuery As String =
            String.Format("  SELECT MA_KH, TEN_KH, PHONE, ADDRESS FROM dbo.KHACHHANG WHERE ClassID = '{0}'", ClassID)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvKHACHHANG.DataSource = dTable
        With Me.dgvKHACHHANG
            .Columns(0).HeaderText = "MA_KH"
            .Columns(1).HeaderText = "TEN_KH"
            .Columns(2).HeaderText = "PHONE"
            .Columns(3).HeaderText = "ADDRESS"
            .Columns(3).Width = 200
        End With
    End Sub

    Private Sub FrmQLBH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True

        LoadDataOnComBobox()
        LoadDataOnGridView(Me.CmbClass.SelectedValue)

        _isLoading = False
    End Sub

    Private Sub CmbClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbClass.SelectedIndexChanged
        If Not _isLoading Then
            LoadDataOnGridView(Me.CmbClass.SelectedValue)
        End If
    End Sub

    Private Sub SearchKHACHHANG(ClassID As String, value As String)
        Dim sqlQuery As String =
            String.Format("  SELECT MA_KH, TEN_KH, PHONE, ADDRESS FROM dbo.KHACHHANG WHERE ClassID = '{0}'", ClassID)
        If Me.cmbSearch.SelectedIndex = 0 Then
            sqlQuery += String.Format(" AND MA_KH  LIKE '{0}%'", value)
        ElseIf Me.cmbSearch.SelectedIndex = 1 Then
            sqlQuery += String.Format(" AND TEN_KH LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvKHACHHANG.DataSource = dTable
        With Me.dgvKHACHHANG
            .Columns(0).HeaderText = "MA_KH"
            .Columns(1).HeaderText = "TEN_KH"
            .Columns(2).HeaderText = "PHONE"
            .Columns(3).HeaderText = "ADDRESS"
            .Columns(3).Width = 200
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchKHACHHANG(Me.CmbClass.SelectedValue, Me.txtSearch.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New FrmHTTT(False)
        frm.txtClassID.Text = Me.CmbClass.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = System.Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.CmbClass.SelectedValue)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New FrmHTTT(True)
        frm.txtClassID.Text = Me.CmbClass.SelectedValue
        With Me.dgvKHACHHANG
            frm.txtMA_KH.Text = .Rows(.CurrentCell.RowIndex).Cells("MA_KH").Value
            frm.txtTEN_KH.Text = .Rows(.CurrentCell.RowIndex).Cells("TEN_KH").Value
            frm.txtADDRESS.Text = .Rows(.CurrentCell.RowIndex).Cells("ADDRESS").Value
            frm.txtPHONE.Text = .Rows(.CurrentCell.RowIndex).Cells("PHONE").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = System.Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.CmbClass.SelectedValue)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim MA_KH As String = Me.dgvKHACHHANG.Rows(Me.dgvKHACHHANG.CurrentCell.RowIndex).Cells("MA_KH").Value

        Dim sqlQuery As String = String.Format("DELETE KHACHHANG WHERE MA_KH = '{0}'", MA_KH)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Da xoa du lieu")
            LoadDataOnGridView(Me.CmbClass.SelectedValue)
        Else
            MessageBox.Show("Loi xoa")
        End If
    End Sub

End Class