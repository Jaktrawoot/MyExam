﻿Public Class BaseMainForm
    Protected member As New Member
    Private Sub LogoutLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LogoutLinkLabel.LinkClicked
        LoginForm.Show()
        Close()
    End Sub

    Private Sub MainLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim main As New MainForm(member)
        main.Show()
        Close()
    End Sub

    Private Sub ProfileLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProfileLinkLabel.LinkClicked
        For Each form As Form In Application.OpenForms
            If form.Name.Equals("ProfileForm") Then
                Exit Sub
            End If
        Next
        Dim profile As New ProfileForm(member)
        profile.Show()
        Close()
    End Sub

    Private Sub BaseMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WelcomeLabel.Text = "ยินดีต้อนรับ " & member.Username
    End Sub

    Private Sub MainLinkLabel_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MainLinkLabel.LinkClicked
        For Each form As Form In Application.OpenForms
            If form.Name.Equals("MainForm") Then
                Exit Sub
            End If
        Next
        Dim main As New MainForm(member)
        main.Show()
        Close()
    End Sub
End Class
