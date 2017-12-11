Public Class Form1

    Dim dsgrade As DataSet
    Dim newgrade As New DataSet
    Dim inc As Integer

    Dim MaxRows As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim a As Integer
        Dim b As Decimal

		If IsNumeric(txtAttend1.Text) Then
			If txtAttend1.Text <= 20 Then
				a = (txtAttend1.Text * 100) / 20
				txtAttendperc.Text = a
				b = a * 0.1
				txtAttendTotal.Text = CDec(b)
			Else
				MsgBox("Please Enter value equal to 20 and below!")
			End If
		End If
		If IsNumeric(txtQuiz1.Text) Then

			If txtQuiz1.Text <= 50 Then
				Dim c As Integer
				Dim d As Decimal
				c = (txtQuiz1.Text * 100) / 50
				txtQuiz1perc.Text = c
				d = c * 0.1
				txtQuiz1total.Text = CDec(d)

			Else
				MsgBox("Please Enter value equal to 50 and below!")


			End If
		End If

		If IsNumeric(txtQuiz2.Text) Then
			If txtQuiz2.Text <= 50 Then
				Dim g As Integer
				Dim f As Decimal
				g = (txtQuiz2.Text * 100) / 50
				txtQuiz2perc.Text = g
				f = g * 0.2
				txtQuiz2total.Text = CDec(f)

			Else
				MsgBox("Please Enter value equal to 50 and below!")


			End If
		End If
		If IsNumeric(txtProject.Text) Then
			If txtProject.Text <= 100 Then
				Dim g As Integer
				Dim f As Decimal
				g = (txtProject.Text * 100) / 100
				txtProjectperc.Text = g
				f = g * 0.3
				txtProjecttotal.Text = CDec(f)

			Else
				MsgBox("Please Enter value equal to 100 and below!")


			End If
		End If

		If IsNumeric(txtFinalexam.Text) Then
			If txtFinalexam.Text <= 100 Then
				Dim j As Integer
				Dim f1 As Decimal
				j = (txtFinalexam.Text * 100) / 100
				txtFinalexamperc.Text = j
				f1 = j * 0.3
				txtFinalexamtotal.Text = CDec(f1)

			Else
				MsgBox("Please Enter value equal to 100 and below!")


			End If
		End If

		Dim adal As Decimal
		adal = Val(txtAttendTotal.Text) + Val(txtQuiz1total.Text) + Val(txtQuiz2total.Text) + Val(txtProjecttotal.Text) + Val(txtFinalexamtotal.Text)

		txtFinalgrade.Text = adal

		If Val(txtFinalgrade.Text) <= 60 Then

			txtRemark.Text = "Failed"
			txtRemark.ForeColor = Color.Black
		Else
			txtRemark.Text = "Passed"
			txtRemark.ForeColor = Color.White


		End If


	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()

	End Sub

	Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

		txtFirstname.Text = ""
		txtProject.Text = ""
		txtAttend1.Text = ""
		txtAttendperc.Text = ""
		txtAttendTotal.Text = ""
		txtQuiz1.Text = ""
		txtQuiz1perc.Text = ""
		txtQuiz1total.Text = ""
		txtQuiz2.Text = ""
		txtQuiz2perc.Text = ""
		txtQuiz2total.Text = ""
		txtProject.Text = ""
		txtProjectperc.Text = ""
		txtProjecttotal.Text = ""
		txtFinalexam.Text = ""
		txtFinalexamperc.Text = ""
		txtFinalexamtotal.Text = ""
		txtFinalgrade.Text = ""
		txtRemark.Text = ""


	End Sub

#Region "my data"
	Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
		MyBase.OnLoad(e)
		Dim sPath As String = Application.ExecutablePath
		sPath = System.IO.Path.GetDirectoryName(sPath)

		If sPath.EndsWith("\bin") Then
			sPath = sPath.Substring(0, Len(sPath) - 4)
		End If

		gradeclass.DataModule = New gradeclass(sPath)

	End Sub
#End Region

	Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
		newgrade = gradeclass.DataModule.GetLoad
		DataGridView1.DataSource = newgrade
		DataGridView1.DataMember = "grade1"

	End Sub

	Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

		Dim strmessage As String
		Dim dgrResult As DialogResult

		strmessage = "Are you sure you want to save data?"
		dgrResult = MessageBox.Show(strmessage, "Save data", MessageBoxButtons.YesNo,
						MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)


		If dgrResult = Windows.Forms.DialogResult.Yes Then

			newgrade = gradeclass.DataModule.SaveItem
		End If

	End Sub

	Public Sub NavRecords()

		txtStudentID.Text = dsgrade.Tables("grade1").Rows(inc).Item(1)
		txtFirstname.Text = dsgrade.Tables("grade1").Rows(inc).Item(2)
		txtLastname.Text = dsgrade.Tables("grade1").Rows(inc).Item(3)
		txtAttend1.Text = dsgrade.Tables("grade1").Rows(inc).Item(4)
		txtAttendperc.Text = dsgrade.Tables("grade1").Rows(inc).Item(5)
		txtAttendTotal.Text = dsgrade.Tables("grade1").Rows(inc).Item(6)
		txtQuiz1.Text = dsgrade.Tables("grade1").Rows(inc).Item(7)
		txtQuiz1perc.Text = dsgrade.Tables("grade1").Rows(inc).Item(8)
		txtQuiz1total.Text = dsgrade.Tables("grade1").Rows(inc).Item(9)
		txtQuiz2.Text = dsgrade.Tables("grade1").Rows(inc).Item(10)
		txtQuiz2perc.Text = dsgrade.Tables("grade1").Rows(inc).Item(11)
		txtQuiz2total.Text = dsgrade.Tables("grade1").Rows(inc).Item(12)
		txtProject.Text = dsgrade.Tables("grade1").Rows(inc).Item(13)
		txtProjectperc.Text = dsgrade.Tables("grade1").Rows(inc).Item(14)
		txtProjecttotal.Text = dsgrade.Tables("grade1").Rows(inc).Item(15)
		txtFinalexam.Text = dsgrade.Tables("grade1").Rows(inc).Item(16)
		txtFinalexamperc.Text = dsgrade.Tables("grade1").Rows(inc).Item(17)
		txtFinalexamtotal.Text = dsgrade.Tables("grade1").Rows(inc).Item(18)
		txtFinalgrade.Text = dsgrade.Tables("grade1").Rows(inc).Item(19)
		txtRemark.Text = dsgrade.Tables("grade1").Rows(inc).Item(20)

	End Sub



	Private Sub FRST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FRST.Click
		dsgrade = gradeclass.DataModule.navigate
		If inc <> 0 Then
			inc = 0
			NavRecords()
			MsgBox("First Record")
		End If
	End Sub

	Private Sub PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PREV.Click

		dsgrade = gradeclass.DataModule.navigate
		If inc > 0 Then
			inc = inc - 1
			NavRecords()
		ElseIf inc = -1 Then
			MsgBox("No Records Yet")
		ElseIf inc = 0 Then
			MsgBox("First Record")
		End If


	End Sub

	Private Sub LAST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAST.Click
		dsgrade = gradeclass.DataModule.navigate
		MaxRows = dsgrade.Tables("grade1").Rows.Count
		If inc <> MaxRows Then
			inc = MaxRows - 1
			NavRecords()
		Else
			MsgBox("Last Record")
		End If
	End Sub

	Private Sub NXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NXT.Click
		dsgrade = gradeclass.DataModule.navigate
		Try
			If inc <> MaxRows - 1 Then
				inc = inc + 1
				NavRecords()
			End If
		Catch ex As Exception
			MsgBox("No More Rows")
		End Try
	End Sub
	Dim dsupdate As DataSet

	Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowdeets.Click

		txtFirstname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
		txtLastname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
		txtAttend1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
		txtAttendperc.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
		txtAttendTotal.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
		txtQuiz1.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
		txtQuiz1perc.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
		txtQuiz1total.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
		txtQuiz2.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
		txtQuiz2perc.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
		txtQuiz2total.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
		txtProject.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
		txtProjectperc.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
		txtProjecttotal.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
		txtFinalexam.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString
		txtFinalexamperc.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString
		txtFinalexamtotal.Text = DataGridView1.CurrentRow.Cells(17).Value.ToString
		txtFinalgrade.Text = DataGridView1.CurrentRow.Cells(18).Value.ToString
		txtRemark.Text = DataGridView1.CurrentRow.Cells(19).Value.ToString
		txtStudentID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString

	End Sub

	Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
		Dim strmessage As String
		Dim dgrResult As DialogResult

		strmessage = "Are you sure you want to Delete this record?"
		dgrResult = MessageBox.Show(strmessage, "Delete Record", MessageBoxButtons.YesNo,
						MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)


		If dgrResult = Windows.Forms.DialogResult.Yes Then

			dsgrade = gradeclass.DataModule.deldata

		End If



	End Sub

	Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
		dsgrade = gradeclass.DataModule.updtedata
	End Sub
	Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
		txtFirstname.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
		txtLastname.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
		txtAttend1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
		txtAttendperc.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
        txtAttendTotal.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
        txtQuiz1.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
        txtQuiz1perc.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
        txtQuiz1total.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
        txtQuiz2.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
        txtQuiz2perc.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString
        txtQuiz2total.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString
        txtProject.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString
        txtProjectperc.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value.ToString
        txtProjecttotal.Text = DataGridView1.Rows(e.RowIndex).Cells(14).Value.ToString
        txtFinalexam.Text = DataGridView1.Rows(e.RowIndex).Cells(15).Value.ToString
        txtFinalexamperc.Text = DataGridView1.Rows(e.RowIndex).Cells(16).Value.ToString
        txtFinalexamtotal.Text = DataGridView1.Rows(e.RowIndex).Cells(17).Value.ToString
        txtFinalgrade.Text = DataGridView1.Rows(e.RowIndex).Cells(18).Value.ToString
        txtRemark.Text = DataGridView1.Rows(e.RowIndex).Cells(19).Value.ToString
        txtStudentID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString


    End Sub

End Class
