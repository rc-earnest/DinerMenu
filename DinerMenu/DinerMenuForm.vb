﻿Public Class DinerMenuForm
    Private Sub DinerMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDefaults()
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(SoupButton, "Displays soup selection")
        ToolTip1.SetToolTip(SaladButton, "Displays salad selection")
        ToolTip1.SetToolTip(FishButton, "Displays fish selection")
        ToolTip1.SetToolTip(ExitButton, "Exits the program")

    End Sub
    Sub setDefaults()
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter
        DisplaySpecialLabel.Text = ""
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter
        DisplaySpecialLabel.Text = $"~ The Finest Fried Chicken BBQ Ceasar Salad ~

Made exclusively from the chickens raised in mister fredricks back yard and the ceasar dressing, well that is a family secret."
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter
        DisplaySpecialLabel.Text = $"~ Fried Split-Pea Soup ~

Don't ask us because we wont tell you how or what it is."
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter
        DisplaySpecialLabel.Text = $"~ Fish and Chips ~
(but instead of fries it is actually chips)

Hopefully you like vinegar because it is chock full of the stuff."
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
