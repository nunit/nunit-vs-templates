Option Explicit On

Imports System
Imports NUnit.Framework

Namespace $rootnamespace$

    <SetUpFixture>
    Public Class $safeitemname$

        <OneTimeSetUp>
        Public Sub OneTimeSetUp()
            ' TODO Add code here that is run before
            '  all tests in the assembly are run
        End Sub

        <OneTimeTearDown>
        Public Sub OneTimeTearDown()
            ' TODO Add code here that is run after
            '  all tests in the assembly have been run
        End Sub

    End Class

End Namespace