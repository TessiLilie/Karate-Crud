<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMember
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Date_JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.KarateMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet = New _21.Karate_CRUD.karateDataSet()
        Me.MembersTableAdapter = New _21.Karate_CRUD.karateDataSetTableAdapters.MembersTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        CType(Me.KarateMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 11)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 35
        IDLabel.Text = "ID:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(12, 40)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 28
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(12, 66)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 31
        First_NameLabel.Text = "First Name:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(12, 92)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 33
        PhoneLabel.Text = "Phone:"
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.Location = New System.Drawing.Point(12, 119)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(67, 13)
        Date_JoinedLabel.TabIndex = 34
        Date_JoinedLabel.Text = "Date Joined:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KarateMembersBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(85, 37)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_NameTextBox.TabIndex = 26
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KarateMembersBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(85, 63)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.First_NameTextBox.TabIndex = 27
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KarateMembersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(85, 89)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 29
        '
        'Date_JoinedDateTimePicker
        '
        Me.Date_JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KarateMembersBindingSource, "Date_Joined", True))
        Me.Date_JoinedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_JoinedDateTimePicker.Location = New System.Drawing.Point(85, 115)
        Me.Date_JoinedDateTimePicker.Name = "Date_JoinedDateTimePicker"
        Me.Date_JoinedDateTimePicker.Size = New System.Drawing.Size(105, 20)
        Me.Date_JoinedDateTimePicker.TabIndex = 30
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(115, 153)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KarateMembersBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(85, 11)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(60, 20)
        Me.IDTextBox.TabIndex = 25
        '
        'KarateMembersBindingSource
        '
        Me.KarateMembersBindingSource.DataMember = "Members"
        Me.KarateMembersBindingSource.DataSource = Me.KarateDataSet
        '
        'KarateDataSet
        '
        Me.KarateDataSet.DataSetName = "karateDataSet"
        Me.KarateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'frmAddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 189)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Date_JoinedLabel)
        Me.Controls.Add(Me.Date_JoinedDateTimePicker)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.IDTextBox)
        Me.Name = "frmAddMember"
        Me.Text = "frmAddMember"
        CType(Me.KarateMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Date_JoinedDateTimePicker As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents KarateMembersBindingSource As BindingSource
    Friend WithEvents KarateDataSet As karateDataSet
    Friend WithEvents MembersTableAdapter As karateDataSetTableAdapters.MembersTableAdapter
End Class
