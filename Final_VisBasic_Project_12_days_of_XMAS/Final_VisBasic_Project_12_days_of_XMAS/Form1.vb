Public Class Form1

    'Final Project. Visual Basic
    'Ashley Faul
    'December, 7, 2016
    'This program displays and calculates the total cost
    'of 12 Days of Christmas!

    'This makes the first button visible when the project loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
    End Sub



    'Button 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Function 1
        Display1()

    End Sub

    'Button 2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Function 2

        Display2()

    End Sub


    'Button 3

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Function 3

        Display3()

    End Sub

    'Button 4
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'Function 4
        Display4()

    End Sub

    'Button 5
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        'Function 5
        Display5()

    End Sub

    'Button 6

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        'Function 6
        Display6()

    End Sub

    'Button 7

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        'Function 7
        Display7()

    End Sub

    'Button 8
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        'Function 8

        Display8()

    End Sub

    'Button 9
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        'Function 9
        Display9()

    End Sub

    'Button 10
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        'Function 10
        Display10()

    End Sub

    'Button 11
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        'Function 11
        Display11()

    End Sub

    'Button 12
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        'Function 11
        Display12()

    End Sub

    'Button 13
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        'Function 13
        Display13()

    End Sub

    'Method 1
    Function Display1()

        'Array of pictures
        Dim debt(0 To 12) As PictureBox

        'Array of costs
        Dim cost(0 To 12) As Double

        'all 12 pictures
        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        'The costs are integers
        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1


        'This displays which picture I want to see
        debt(0).Visible = True

        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = False

        'The text and cost of the item displayed
        Label1.Text = "A Partridge in a Pear Tree: $" & cost(0)

        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        'Shows which buttons I want to see.



        Return cost
        Return debt

    End Function
    'All functions are mostly the same
    Function Display2()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1


        debt(0).Visible = False
        debt(1).Visible = True
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = False

        Label1.Text = "Two Turtle Doves: $" & cost(1)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = True
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False

        Return debt
        Return cost



    End Function


    Function Display3()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1


        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = True
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = False

        Label1.Text = "Three French Hens: $" & cost(2)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = True
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False

        Return debt
        Return cost



    End Function

    Function Display4()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1


        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = True
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = False

        Label1.Text = "Four Calling Birds: $" & cost(3)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = True
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False

        Return debt
        Return cost



    End Function


    Function Display5()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1


        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = True
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = False

        Label1.Text = "FIIIVE GOL-DEN RIIINGS: $" & cost(4)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = True
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False

        Return debt
        Return cost



    End Function


    Function Display6()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1


        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = True
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = False

        Label1.Text = "Six Geese a Laying: $" & cost(5)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = True
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False

        Return debt
        Return cost



    End Function

    Function Display7()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1


        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = True
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = False

        Label1.Text = "Seven Swans a Swimming: $" & cost(6)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = True
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False

        Return debt
        Return cost



    End Function


    Function Display8()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1


        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = True
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = False

        Label1.Text = "Eight Maids a Milking: $" & cost(7)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = True
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False

        Return debt
        Return cost



    End Function

    Function Display9()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1


        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = True
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = False

        Label1.Text = "Nine Ladies Dancing: $" & cost(8)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = True
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False

        Return debt
        Return cost



    End Function

    Function Display10()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1


        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = True
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = False

        Label1.Text = "Ten Lords a Leaping: $" & cost(9)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = True
        Button12.Visible = False
        Button13.Visible = False

        Return debt
        Return cost



    End Function


    Function Display11()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1



        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = True
        debt(11).Visible = False
        debt(12).Visible = False

        Label1.Text = "Eleven Pipers Piping: $" & cost(10)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = True
        Button13.Visible = False

        Return debt
        Return cost



    End Function

    Function Display12()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1



        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = True
        debt(12).Visible = False

        Label1.Text = "12 Drummers Drumming: $" & cost(11)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = True

        Return debt
        Return cost



    End Function

    '13 adds all of the costs together to make a total.

    Function Display13()

        Dim debt(0 To 12) As PictureBox
        Dim cost(0 To 12) As Double

        debt(0) = PictureBox1
        debt(1) = PictureBox2
        debt(2) = PictureBox3
        debt(3) = PictureBox4
        debt(4) = PictureBox5
        debt(5) = PictureBox6
        debt(6) = PictureBox7
        debt(7) = PictureBox8
        debt(8) = PictureBox9
        debt(9) = PictureBox10
        debt(10) = PictureBox11
        debt(11) = PictureBox12
        debt(12) = PictureBox13

        cost(0) = 209.99
        cost(1) = 375.0
        cost(2) = 181.5
        cost(3) = 599.96
        cost(4) = 750.0
        cost(5) = 360.0
        cost(6) = 13125.0
        cost(7) = 58.0
        cost(8) = 7552.84
        cost(9) = 5508.7
        cost(10) = 2708.4
        cost(11) = 2934.1
        cost(12) = (cost(0) + cost(1) + cost(2) + cost(3) + cost(4) + cost(5) + cost(6) + cost(7) + cost(8) + cost(9) + cost(10) + cost(11))



        debt(0).Visible = False
        debt(1).Visible = False
        debt(2).Visible = False
        debt(3).Visible = False
        debt(4).Visible = False
        debt(5).Visible = False
        debt(6).Visible = False
        debt(7).Visible = False
        debt(8).Visible = False
        debt(9).Visible = False
        debt(10).Visible = False
        debt(11).Visible = False
        debt(12).Visible = True

        Label1.Text = "Your Christmas Debt: $" & cost(12)

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False

        Return debt
        Return cost



    End Function


    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

    End Sub
End Class