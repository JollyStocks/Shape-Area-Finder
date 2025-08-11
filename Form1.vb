Public Class Form1
    Dim base As Single
    Dim ht As Single
    Dim area As Single
    Dim PI As Single = 3.142

    Private Sub RectangleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleToolStripMenuItem.Click
        'Input
        base = Val(TxtBox1.Text)
        ht = Val(TxtBox2.Text)

        'Process
        area = base * ht

        Txtbox3.Text = area
        PicBx1.Image = My.Resources.area_formula_of_rectangle_shapes_area_formulas_for_rectangle_2d_shapes_vector_illustration_isolated_on_white_background_2RCXBHR
    End Sub

    Private Sub TriangleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TriangleToolStripMenuItem.Click
        'Input
        base = Val(TxtBox1.Text)
        ht = Val(TxtBox2.Text)

        'Process
        area = 0.5 * base * ht

        Txtbox3.Text = area
        PicBx1.Image = My.Resources.images

    End Sub

    Private Sub CircleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CircleToolStripMenuItem.Click
        'Input
        base = Val(TxtBox1.Text)
        ht = Val(TxtBox2.Text)

        'Process
        area = PI * ht * ht

        Txtbox3.Text = area
        PicBx1.Image = My.Resources.Circles_in_Maths_08
    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        LblBase.ForeColor = Color.Blue
        lblHeight.ForeColor = Color.Blue
        Label1.ForeColor = Color.Blue
    End Sub

    Private Sub YellowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YellowToolStripMenuItem.Click
        LblBase.ForeColor = Color.Yellow
        lblHeight.ForeColor = Color.Yellow
        Label1.ForeColor = Color.Yellow
    End Sub

    Private Sub BrownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrownToolStripMenuItem.Click
        LblBase.ForeColor = Color.Brown
        lblHeight.ForeColor = Color.Brown
        Label1.ForeColor = Color.Brown
    End Sub

    Private Sub GreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub GreyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreyToolStripMenuItem.Click
        Me.BackColor = Color.Gray
    End Sub

    Private Sub RedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        TxtBox1.Text = ""
        TxtBox2.Text = ""
        Txtbox3.Text = ""
    End Sub

    Private Sub ActiceCaptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiceCaptionToolStripMenuItem.Click
    End Sub
End Class
