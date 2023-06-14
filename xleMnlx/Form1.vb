Public Class Form1

    Private Sub button_left_Click(sender As Object, e As EventArgs) Handles button_left.Click
        Try
            picture_left.Image = Image.FromFile("D:\emn33\Documents\Visual Studio 2013\Projects\xleMnlx\DOG.jpg")
            label_pickadoor.Text = txt_name.Text & " is a DOG!!"
            picture_right.Image = Image.FromFile("D:\emn33\Documents\Visual Studio 2013\Projects\xleMnlx\DOOR.jpg")
            txt_name.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub button_right_Click(sender As Object, e As EventArgs) Handles button_right.Click
        Try
            picture_right.Image = Image.FromFile("D:\emn33\Documents\Visual Studio 2013\Projects\xleMnlx\PUPPY.jpg")
            label_pickadoor.Text = txt_name.Text & " is a PUPPY!!"
            picture_left.Image = Image.FromFile("D:\emn33\Documents\Visual Studio 2013\Projects\xleMnlx\DOOR.jpg")
            txt_name.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        label_pickadoor.Text = "Pick Your Door Wisely"
        txt_name.Text = ""
        picture_left.Image = Image.FromFile("D:\emn33\Documents\Visual Studio 2013\Projects\xleMnlx\DOOR.jpg")
        picture_right.Image = Image.FromFile("D:\emn33\Documents\Visual Studio 2013\Projects\xleMnlx\DOOR.jpg")
    End Sub
End Class
