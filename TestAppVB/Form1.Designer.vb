Imports System.ComponentModel

Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough>
    Private Sub InitializeComponent()
        Me.components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))
        Me.automaticUpdater = New wyDay.Controls.AutomaticUpdater()
        Me.mainMenu1 = New MenuStrip()
        Me.menuHelp = New ToolStripMenuItem()
        Me.menuCheckForUpdates = New ToolStripMenuItem()

        ' 
        'automaticUpdater
        ' 
        Me.automaticUpdater.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.automaticUpdater.ContainerForm = Me
        Me.automaticUpdater.GUID = "d6cf5d38-a9b5-48dd-a0e0-225a1aa25862"
        Me.automaticUpdater.Location = New Point(256, 12)
        Me.automaticUpdater.MenuItem = Nothing ' No direct integration with MenuStrip in .NET 8
        Me.automaticUpdater.Name = "automaticUpdater"
        Me.automaticUpdater.Size = New Size(16, 16)
        Me.automaticUpdater.TabIndex = 0
        Me.automaticUpdater.wyUpdateCommandline = Nothing
        ' 
        'mainMenu1
        ' 
        Me.mainMenu1.Items.AddRange(New ToolStripItem() {Me.menuHelp})
        Me.mainMenu1.Location = New Point(0, 0)
        Me.mainMenu1.Name = "mainMenu1"
        Me.mainMenu1.Size = New Size(284, 24)
        Me.mainMenu1.TabIndex = 1
        Me.mainMenu1.Text = "MenuStrip"

        ' 
        'menuHelp
        ' 
        Me.menuHelp.DropDownItems.AddRange(New ToolStripItem() {Me.menuCheckForUpdates})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New Size(44, 20)
        Me.menuHelp.Text = "Help"
        ' 
        'menuCheckForUpdates
        ' 
        Me.menuCheckForUpdates.Name = "menuCheckForUpdates"
        Me.menuCheckForUpdates.Size = New Size(180, 22)
        Me.menuCheckForUpdates.Text = "Check for Updates"
        AddHandler Me.menuCheckForUpdates.Click, AddressOf Me.MenuCheckForUpdates_Click
        ' 
        'Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(284, 100)
        Me.Controls.Add(Me.automaticUpdater)
        Me.Controls.Add(Me.mainMenu1)
        Me.MainMenuStrip = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private Sub MenuCheckForUpdates_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Checking for updates...")
    End Sub
    Friend WithEvents automaticUpdater As wyDay.Controls.AutomaticUpdater
    Private WithEvents mainMenu1 As MenuStrip
    Private WithEvents menuHelp As ToolStripMenuItem
    Private WithEvents menuCheckForUpdates As ToolStripMenuItem

End Class
