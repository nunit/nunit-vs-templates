Option Explicit On

Imports System
Imports NUnit.Framework

Namespace $rootnamespace$

    <TestFixture>
    Public Class $safeitemname$

        <Test>
        Public Sub TestMethod()
            ' TODO Add your test code here
            Dim answer = 42
            Assert.That(answer, [Is].EqualTo(42), "Some useful error message")
        End Sub

    End Class

End Namespace