Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmHTTT
    Private _DBAccess As New DataBaseAccess

    Private _isEdit As Boolean = False
    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub
    Private Function InsertKHACHHANG() As Boolean
        Dim sqlQuery As String = "INSERT INTO KHACHHANG (MA_KH,TEN_KH,PHONE,ADDRESS,ClassID)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}')",
                                   txtMA_KH.Text, txtTEN_KH.Text, txtADDRESS.Text, txtPHONE.Text, txtClassID.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function UpdateKHACHHANG() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE KHACHHANG SET TEN_KH='{0}',  PHONE='{2}', ADDRESS='{1}' WHERE MA_KH='{3}'",
                                               Me.txtTEN_KH.Text, Me.txtPHONE.Text, Me.txtADDRESS.Text, Me.txtMA_KH.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function



    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMA_KH.Text) OrElse _
                String.IsNullOrEmpty(txtTEN_KH.Text) OrElse _
                String.IsNullOrEmpty(txtADDRESS.Text) OrElse _
                String.IsNullOrEmpty(txtPHONE.Text) OrElse _
                String.IsNullOrEmpty(txtClassID.Text))
    End Function
    Private Sub FrmHTTT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then
            MessageBox.Show("Hay nhap vao gia tri vao truoc khi ghi vao database", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If UpdateKHACHHANG() Then
                    MessageBox.Show("Sua du lieu thanh cong", "Thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi sua du lieu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = System.Windows.Forms.DialogResult.No
                End If
            Else
                If InsertKHACHHANG() Then
                    MessageBox.Show("Them du lieu thanh cong", "Thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi them du lieu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = System.Windows.Forms.DialogResult.No
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lblClassID_Click(sender As Object, e As EventArgs) Handles lblClassID.Click

    End Sub


End Class