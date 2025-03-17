Public Class DinerMenuForm
    ''' <summary>
    ''' On startup this sets the tool tips and the defaults for each item.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DinerMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDefaults()
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(SoupButton, "Displays soup selection")
        ToolTip1.SetToolTip(SaladButton, "Displays salad selection")
        ToolTip1.SetToolTip(FishButton, "Displays fish selection")
        ToolTip1.SetToolTip(ExitButton, "Exits the program")

    End Sub
    ''' <summary>
    ''' This is the code that will set the defaults in the system.
    ''' </summary>
    Sub setDefaults()
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter
        DisplaySpecialLabel.Text = ""
    End Sub
    ''' <summary>
    ''' Displays the Salad selection in Label 2 which is the "DisplaySpectialLabel".
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter
        DisplaySpecialLabel.Text = $"~ The Finest Fried Chicken BBQ Ceasar Salad ~

Made exclusively from the chickens raised in mister fredricks back yard and the ceasar dressing, well that is a family secret."
    End Sub
    ''' <summary>
    ''' Displays the Soup selection in Label 2 which is the "DisplaySpectialLabel".
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter
        DisplaySpecialLabel.Text = $"~ Fried Split-Pea Soup ~

Don't ask us because we wont tell you how or what it is."
    End Sub
    ''' <summary>
    ''' Displays the Fish selection in Label 2 which is the "DisplaySpectialLabel".
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter
        DisplaySpecialLabel.Text = $"~ Fish and Chips ~
(but instead of fries it is actually chips)

Hopefully you like vinegar because it is chock full of the stuff."
    End Sub
    ''' <summary>
    ''' Closes the program once the exit button is activated or clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
