Imports System.Web.Mvc
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace Models
    Public Class listclassController
        Inherits Controller

        ' GET: listclass
        Function Index(Optional numberoflines As Int32 = 0) As ActionResult

            ViewBag.numberoflines = numberoflines

            Return View()
        End Function
    End Class
End Namespace