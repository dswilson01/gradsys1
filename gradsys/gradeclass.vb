

Public Class gradeclass
    Dim mDataPath As String
    Public Shared DataModule As gradeclass

    Private Function GetConnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & mDataPath & "\grade1.accdb")
    End Function

    Public Sub New(ByVal sDatapath As String)
        MyBase.new()
        Me.mDataPath = sDatapath
        gradeclass.DataModule = Me

    End Sub

    Public Overloads Function GetLoad() As DataSet
        Return Me.GetLoad("data1")
    End Function

    Public Overloads Function GetLoad(ByVal sortfield As String) As DataSet

        Dim conn As OleDb.OleDbConnection = GetConnection()
        Dim ds As New DataSet

        Try


            Dim sql As String = "SELECT STUDENTID,data1 AS Firstname, data2 AS Lastname," & _
                                "data3 AS 20, data4 AS EG, data5 AS [1st-10%], data6 AS 50pt," & _
                                "data7 AS EG1, data8 AS [2nd-10%], data9 AS 50pts, data10 AS EG2," & _
                                "data11 AS [20%], data12 AS 100pt, data13 AS EG3, data14 AS [30%]," & _
                                "data15 AS 100, data16 AS EG4, data17 AS [2nd-30%], data18 AS PrelimGrade," & _
                                "data19 AS Remarks FROM Table1 ORDER BY ID"

            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conn)
            Try
                da.Fill(ds, "grade1")
            Finally
                da.Dispose()
            End Try
            Return ds
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Function
    Sub RefreshDGV()

        Dim conn As OleDb.OleDbConnection = GetConnection()
        Dim sql As String
        sql = "SELECT STUDENTID,data1 AS Firstname, data2 AS Lastname," & _
                                "data3 AS 20, data4 AS EG, data5 AS [1st-10%], data6 AS 50pt," & _
                                "data7 AS EG1, data8 AS [2nd-10%], data9 AS 50pts, data10 AS EG2," & _
                                "data11 AS [20%], data12 AS 100pt, data13 AS EG3, data14 AS [30%]," & _
                                "data15 AS 100, data16 AS EG4, data17 AS [2nd-30%], data18 AS PrelimGrade," & _
                                "data19 AS Remarks FROM Table1 ORDER BY ID"

        Dim da As New OleDb.OleDbDataAdapter(sql, conn)
        Dim dt As New DataTable("grade1")
        da.Fill(dt)
        Form1.DataGridView1.DataSource = dt
    End Sub
    Sub clearall()
        Form1.txtFirstname.Text = ""
        Form1.txtLastname.Text = ""
		Form1.txtAttend1.Text = ""
		Form1.txtAttendperc.Text = ""
		Form1.txtAttendTotal.Text = ""
		Form1.txtQuiz1.Text = ""
		Form1.txtQuiz1perc.Text = ""
		Form1.txtQuiz1total.Text = ""
		Form1.txtQuiz2.Text = ""
		Form1.txtQuiz2perc.Text = ""
		Form1.txtQuiz2total.Text = ""
		Form1.txtProject.Text = ""
		Form1.txtProjectperc.Text = ""
		Form1.txtProjecttotal.Text = ""
		Form1.txtFinalexam.Text = ""
		Form1.txtFinalexamperc.Text = ""
		Form1.txtFinalexamtotal.Text = ""
		Form1.txtFinalgrade.Text = ""
		Form1.txtRemark.Text = ""
		Form1.txtStudentID.Text = ""


	End Sub

	Public Overloads Function SaveItem() As DataSet
		Return Me.SaveItem("data1")
	End Function
	Public Overloads Function SaveItem(ByVal sortfield As String) As DataSet

		Dim conn As OleDb.OleDbConnection = GetConnection()

		Try

			Dim SQL As String

			SQL = "INSERT INTO TABLE1 (STUDENTID, DATA1, DATA2, DATA3, DATA4, DATA5,DATA6, DATA7," &
				  "DATA8, DATA9, DATA10, DATA11, DATA12, DATA13, DATA14, DATA15, DATA16, DATA17, DATA18," &
				  "DATA19) VALUES(@STUDENTID, @DATA1, @DATA2, @DATA3, @DATA4, @DATA5,@DATA6, @DATA7,DATA8, @DATA9," &
				  "@DATA10, @DATA11, @DATA12, @DATA13, @DATA14, @DATA15, @DATA16, @DATA17, @DATA18, @DATA19)"
			Dim cmd As New OleDb.OleDbCommand(SQL, conn)
			cmd.Parameters.Add(New OleDb.OleDbParameter("@STUDENTID", Form1.txtStudentID.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA1", Form1.txtFirstname.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA2", Form1.txtLastname.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA3", Form1.txtAttend1.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA4", Form1.txtAttendperc.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA5", Form1.txtAttendTotal.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA6", Form1.txtQuiz1.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA7", Form1.txtQuiz1perc.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA8", Form1.txtQuiz1total.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA9", Form1.txtQuiz2.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA10", Form1.txtQuiz2perc.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA11", Form1.txtQuiz2total.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA12", Form1.txtProject.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA13", Form1.txtProjectperc.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA14", Form1.txtProjecttotal.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA15", Form1.txtFinalexam.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA16", Form1.txtFinalexamperc.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA17", Form1.txtFinalexamtotal.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA18", Form1.txtFinalgrade.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA19", Form1.txtRemark.Text))

			conn.Open()
			cmd.ExecuteNonQuery()
			conn.Close()
			MessageBox.Show("New data is Added!")

			Form1.txtFirstname.Text = ""
			Form1.txtLastname.Text = ""
			Form1.txtAttend1.Text = ""
			Form1.txtAttendperc.Text = ""
			Form1.txtAttendTotal.Text = ""
			Form1.txtQuiz1.Text = ""
			Form1.txtQuiz1perc.Text = ""
			Form1.txtQuiz1total.Text = ""
			Form1.txtQuiz2.Text = ""
			Form1.txtQuiz2perc.Text = ""
			Form1.txtQuiz2total.Text = ""
			Form1.txtProject.Text = ""
			Form1.txtProjectperc.Text = ""
			Form1.txtProjecttotal.Text = ""
			Form1.txtFinalexam.Text = ""
			Form1.txtFinalexamperc.Text = ""
			Form1.txtFinalexamtotal.Text = ""
			Form1.txtFinalgrade.Text = ""
			Form1.txtRemark.Text = ""
			Form1.txtStudentID.Text = ""

			RefreshDGV()

		Finally
			conn.Close()
			conn.Dispose()
		End Try

	End Function

	Public Overloads Function navigate() As DataSet
		Return Me.navigate("data2")
	End Function
	Public Overloads Function navigate(ByVal sortfield As String) As DataSet

		Dim conn As OleDb.OleDbConnection = GetConnection()
		Dim ds As New DataSet

		Try

			Dim inc As Integer
			Dim MaxRows As Integer

			Dim sql As String = "select * from table1"
			Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conn)

			Try
				da.Fill(ds, "grade1")
				MaxRows = ds.Tables("grade1").Rows.Count
				inc = -1


			Finally
				da.Dispose()
			End Try

			Return ds
		Finally
			conn.Close()
			conn.Dispose()
		End Try
	End Function
	Public Overloads Function deldata() As DataSet
		Return Me.deldata("data2")
	End Function
	Public Overloads Function deldata(ByVal sortfield As String) As DataSet

		Dim conn As OleDb.OleDbConnection = GetConnection()
		Dim ds As New DataSet

		Try

			Dim inc As Integer
			Dim MaxRows As Integer

			Try

				Dim sqldelete As String
				sqldelete = "DELETE * FROM  table1 WHERE STUDENTID='" & Form1.txtStudentID.Text & "'"
				Dim da As New OleDb.OleDbDataAdapter(sqldelete, conn)

				' Gets the records from the table and fills our adapter with those.
				Dim dt As New DataTable("grade1")
				da.Fill(dt)
				MsgBox("Data has been deleted")
				clearall()

				Form1.DataGridView1.DataSource = dt

				RefreshDGV()

			Finally
				'da.Dispose()
			End Try

			Return ds
		Finally
			conn.Close()
			conn.Dispose()
		End Try
	End Function

	Public Overloads Function updtedata() As DataSet
		Return Me.updtedata("data0")
	End Function
	Public Overloads Function updtedata(ByVal sortfield As String) As DataSet

		Dim conn As OleDb.OleDbConnection = GetConnection()
		Dim ds As New DataSet

		Try

			Dim sqlupdate As String

			sqlupdate = "UPDATE Table1 set STUDENTID=@STUDENTID, data1=@data1, data2=@data2, data3=@data3, data4=@data4," &
						"data5=@data5, data6=@data6, data7=@data7, data8=@data8, data9=@data9, data10=@data10," &
						"data11=@data11, data12=@data12, data13=@data13, data14=@data14, data15=@data15, data16=@data16," &
						"data17=@data17, data18=@data18, data19=@data19 where STUDENTID='" & Form1.txtStudentID.Text & "'"
			Dim cmd As New OleDb.OleDbCommand(sqlupdate, conn)

			cmd.Parameters.Add(New OleDb.OleDbParameter("@STUDENTID", Form1.txtStudentID.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA1", Form1.txtFirstname.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA2", Form1.txtLastname.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA3", Form1.txtAttend1.Text))
			cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA4", Form1.txtAttendperc.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA5", Form1.txtAttendTotal.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA6", Form1.txtQuiz1.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA7", Form1.txtQuiz1perc.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA8", Form1.txtQuiz1total.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA9", Form1.txtQuiz2.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA10", Form1.txtQuiz2perc.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA11", Form1.txtQuiz2total.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA12", Form1.txtProject.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA13", Form1.txtProjectperc.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA14", Form1.txtProjecttotal.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA15", Form1.txtFinalexam.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA16", Form1.txtFinalexamperc.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA17", Form1.txtFinalexamtotal.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA18", Form1.txtFinalgrade.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DATA19", Form1.txtRemark.Text))

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Data Updated in the Database")
            RefreshDGV()

        Finally
        End Try
        Return ds
    End Function


End Class