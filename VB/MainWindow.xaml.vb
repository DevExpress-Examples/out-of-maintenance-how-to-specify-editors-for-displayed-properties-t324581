Imports System.IO
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Xpf.Core
Imports DevExpress.Mvvm.DataAnnotations

Namespace DXSample

    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Dim contact = New Contact With {.FirstName = "Carolyn", .LastName = "Baker", .Email = "carolyn.baker@example.com", .Phone = "(555)349-3010", .Address = "1198 Theresa Cir", .City = "Whitinsville", .State = "MA", .Zip = "01582"}
            contact.Photo = GetPhoto(contact)
            DataContext = contact
            Me.InitializeComponent()
        End Sub

        Private Function GetPhoto(ByVal contact As Contact) As Byte()
            Return GetPhoto(contact.FirstName & contact.LastName & ".jpg")
        End Function

        Private Function GetPhoto(ByVal name As String) As Byte()
            Return File.ReadAllBytes("Images\" & name)
        End Function
    End Class

    Public Class Contact

        Public Property FirstName As String

        Public Property LastName As String

        Public Property CreditCardNumber As String

        Public Property Email As String

        Public Property Phone As String

        Public Property Address As String

        Public Property City As String

        Public Property State As String

        Public Property Zip As String

        <PropertyGridEditor(TemplateKey:="ImageTemplate")>
        Public Property Photo As Byte()
    End Class
End Namespace
