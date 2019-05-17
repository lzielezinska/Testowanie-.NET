Imports Microsoft.VisualStudio.TestTools.UITesting
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Microsoft.VisualStudio.TestTools.UITest.Input
Imports Microsoft.VisualStudio.TestTools.UITest.Extension
Imports Microsoft.VisualStudio.TestTools.UITesting.Keyboard
Imports Microsoft.VisualStudio.TestTools.UITesting.HtmlControls
Imports Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls
Imports Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls

<CodedUITest(CodedUITestType.WindowsStore)>
Public Class CodedUITest1

    <TestMethod()>
    Public Sub CodedUITestMethod1()
        '            
        ' Aby wygenerować kod dla tego testu, wybierz pozycję „Generuj kod dla kodowanego testu interfejsu użytkownika” z menu skrótów i wybierz jeden z elementów menu.
        '
    End Sub

#Region "Dodatkowe atrybuty testu"
    '
    ' Można użyć następujących dodatkowych atrybutów w trakcie pisania testów:
    '
    '' Użyj TestInitialize do uruchomienia kodu przed uruchomieniem każdego testu
    '<TestInitialize()> Public Sub MyTestInitialize()
    '    '
    '    ' Aby wygenerować kod dla tego testu wybierz "Generuj kod dla kodowanego testu interfejsu użytkownika" z menu skrótów i wybierz jeden z elementów menu.
    '    '
    'End Sub

    '' Użyj TestCleanup do uruchomienia kodu po wykonaniu każdego testu
    '<TestCleanup()> Public Sub MyTestCleanup()
    '    '
    '    ' Aby wygenerować kod dla tego testu wybierz "Generuj kod dla kodowanego testu interfejsu użytkownika" z menu skrótów i wybierz jeden z elementów menu.
    '    '
    'End Sub

#End Region

    '''<summary>
    '''Pobiera lub ustawia kontekst testu, który udostępnia
    '''funkcjonalność i informację o bieżącym przebiegu testu.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

    Private testContextInstance As TestContext
End Class
