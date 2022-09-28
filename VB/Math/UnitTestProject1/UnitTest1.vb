Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Math
<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim F As New Form1
        Assert(F.TriangleArea(2, 1) = 1)
    End Sub

End Class