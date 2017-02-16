Option Explicit On
Public Module modAddressPath
    Public Structure AddressPath
        Dim baseModule As String
        Dim baseAddress As Integer
        Dim lastJumpIndex As Integer
        Dim jump() As Integer
    End Structure
    Public Function ReadAddressPath(ByVal strRawAddressPath As String) As AddressPath
        Dim res As AddressPath
        Dim parts() As String
        Dim parts0() As String
        Dim lastPartIndex As Integer
        Dim i As Integer
        Dim modNameParts() As String
        Dim newMode As Boolean
        strRawAddressPath = Replace(strRawAddressPath, " ", "")
        res.baseAddress = &H0
        res.lastJumpIndex = -1
        ReDim res.jump(0)
        parts = Split(strRawAddressPath, ">")
        parts0 = Split(parts(0), "+")
        If UBound(parts0) = 0 Then
            newMode = False
            res.baseAddress = parts(0)
            res.baseModule = ""
        Else
            newMode = True
            res.baseAddress = CInt("&H" & parts0(1))
            modNameParts = Split(parts0(0), """")
            res.baseModule = modNameParts(1)
        End If
        lastPartIndex = UBound(parts)
        If lastPartIndex > 0 Then
            res.lastJumpIndex = lastPartIndex - 1
            ReDim res.jump(lastPartIndex - 1)
            For i = 1 To lastPartIndex
                If (newMode) Then
                    res.jump(i - 1) = CInt("&H" & parts(i))
                Else
                    res.jump(i - 1) = CInt(parts(i))
                End If
            Next i
        End If
        Return res
    End Function

    Public Function ReadCurrentAddress2BYTES(ByVal pid As Integer, ByRef adrPath As AddressPath, Optional ByVal desiredErrorValue As Integer = -1) As Integer
        Dim adr As Integer
        adr = ReadCurrentAddress(pid, adrPath, -1, False)
        If adr = -1 Then
            ReadCurrentAddress2BYTES = desiredErrorValue
            Exit Function
        End If
        ReadCurrentAddress2BYTES = QMemory_Read2Bytes(pid, adr)
    End Function

    Public Function ReadCurrentAddress(ByVal pid As Integer, ByRef adrPath As AddressPath, Optional ByVal desiredErrorValue As Integer = -1, Optional ByVal readFinalValue As Boolean = True) As Integer
        Dim res As Integer = 0
        Dim realBase As Integer = 0
        Dim reqKey As String
        If adrPath.baseAddress = 0 Then
            Return desiredErrorValue
            Exit Function
        End If
        Try
            If adrPath.baseModule = "" Then
                realBase = adrPath.baseAddress
                res = Memory_ReadLong(pid, realBase, , False)
            Else
                reqKey = adrPath.baseModule & CStr(pid)
                If moduleDictionary.ContainsKey(reqKey) Then
                    realBase = moduleDictionary(adrPath.baseModule & CStr(pid))
                    realBase = realBase + adrPath.baseAddress
                    res = QMemory_Read4Bytes(pid, realBase)
                Else
                    ' refresh all base addresses and region sizes
                    GetAllBaseAddressesAndRegionSizes(tibiaMainName, className)
                    If moduleDictionary.ContainsKey(reqKey) Then
                        realBase = moduleDictionary(adrPath.baseModule & CStr(pid))
                        realBase = realBase + adrPath.baseAddress
                        res = QMemory_Read4Bytes(pid, realBase)
                    Else
                        Return desiredErrorValue
                        Exit Function
                    End If
                End If

            End If

            If adrPath.lastJumpIndex >= 0 Then
                For i = 0 To adrPath.lastJumpIndex
                    ' follow the path of jumps
                    If (res <= 1000) Then ' Detects bad address
                        Return desiredErrorValue
                        Exit Function
                    End If
                    res = res + adrPath.jump(i)
                    If i = adrPath.lastJumpIndex Then
                        If readFinalValue = True Then
                            res = QMemory_Read4Bytes(pid, res)
                        End If
                    Else
                        res = QMemory_Read4Bytes(pid, res)
                    End If
                Next i
            End If
            Return res
        Catch ex As Exception
            Return desiredErrorValue
        End Try
    End Function
    Public Function ReadCurrentString(ByVal pid As Integer, ByRef adrPath As AddressPath, Optional ByVal desiredErrorValue As Integer = -1, Optional ByVal readFinalValue As Boolean = True) As String
        Dim adrString As Integer
        Dim adrRes As String
        adrString = ReadCurrentAddress(pid, adrPath, -1, False)
        If ((adrString = 0) Or (adrString = -1)) Then
            ReadCurrentString = ""
            Exit Function
        End If
        adrRes = readMemoryStringVBNET(pid, adrString)
        ReadCurrentString = adrRes
    End Function
End Module
