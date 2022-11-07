'******************************************************************************************************************************************
'*                                                                                                                                        *
'*  Description:                                                                                                                          *
'*                                                                                                                                        *
'*  This class allows a list of entries to be stored in a string value with a user specified separator character stored in the first      *
'*  position of the string                                                                                                                *
'*                                                                                                                                        *
'******************************************************************************************************************************************
'*  Usage:                                                                                                                                *
'*                                                                                                                                        *
'*  This class can be instantiated in 3 ways                                                                                              *
'*                                                                                                                                        *
'*  1)  From an existing list held within a string                                                                                        *
'*      The first character of the string value supplied is used as the separator character and the entries are split accordingly         *
'*                                                                                                                                        *
'*  2)  From a separator character with an array of initial string value entries                                                          *
'*                                                                                                                                        *
'*  3)  From a list of possible separator characters with an array of initial string value entries                                        *
'*      The entries are scanned to find the first of the separator characters that are not used in the supplied list of entries           *
'*                                                                                                                                        *
'*  Once instantiated, entries can be added, replaced or removed.                                                                         *
'*                                                                                                                                        *
'*  The list can then be converted back to a single string value (with the first character as the separator used)                         *
'*                                                                                                                                        *
'*  NOTE:                                                                                                                                 *
'*  The Null, Carriage return and line feed characters cannot be used as separators                                                       *
'*                                                                                                                                        *
'******************************************************************************************************************************************
'*                                                                                                                                        *
'*  Amendment Log:                                                                                                                        *
'*                                                                                                                                        *
'*  Date        By          Reference    Details                                                                                          *
'*  ----------  ----------  ---------    -----------------------------------------------------------------------------------------------  *
'*  ccyy-mm-dd  xxxxxxxxxx  xxxxxxxxx    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  *
'*                                                                                                                                        *
'******************************************************************************************************************************************

Public Class vb_SeparatedList

#Region "Private Variables"
    '*******************************************************************************************************************************
    '* Private variables                                                                                                           *
    '*******************************************************************************************************************************
    Private _separator As Char
    Private _entries As List(Of String)
    Private _unusedSeparators As List(Of Char)

    Public Shared InvalidSeparatorCharacters As New List(Of Char)(Convert.ToChar(0) & Environment.NewLine)
    Public Shared ValidSeparatorCharacters As List(Of Char)
#End Region

#Region "Public Properties"
    Public ReadOnly Property Entries() As List(Of String)
        Get
            Return _entries
        End Get
    End Property

    Public Property Separator() As Char
        Get
            Return _separator
        End Get

        Set(value As Char)
            _separator = value
        End Set
    End Property

    Public ReadOnly Property UnusedSeparators() As List(Of Char)
        Get
            Return _unusedSeparators
        End Get
    End Property
#End Region

#Region "Public Methods"
    '*******************************************************************************************************************************
    '* Public methods                                                                                                              *
    '*******************************************************************************************************************************

    Shared Sub New()

        ' Initialise a list of all available separator characters
        ValidSeparatorCharacters = New List(Of Char)

        For CharCode As Int16 = 0 To 255
            Dim currentCharacter As Char = Convert.ToChar(CharCode)

            If Not InvalidSeparatorCharacters.Contains(currentCharacter) Then
                ValidSeparatorCharacters.Add(currentCharacter)
            End If
        Next
    End Sub

    Public Sub New(fromString As String)

        ' Initialise the separator value
        If fromString.Length > 0 Then
            _separator = Convert.ToChar(fromString.Substring(0, 1))
        Else
            _separator = Convert.ToChar(String.Empty)
        End If

        ' Split the string into a list using the extracted separator
        If fromString.Length > 1 Then
            _entries = New List(Of String)(fromString.Substring(1).Split(_separator))
        Else
            _entries = New List(Of String)
        End If

        _unusedSeparators = New List(Of Char)
    End Sub

    Public Sub New(separator As Char, ParamArray entries As String())

        ' Initialise the separator value and list using the values specified
        _separator = separator
        _entries = New List(Of String)(entries)
        _unusedSeparators = New List(Of Char)
    End Sub

    Public Sub New(separators() As Char, ParamArray entries As String())

        ' Add any initial entries to the list
        _entries = New List(Of String)(entries)

        Select Case separators.Length
            Case 1
                ' Choose the single separator character specified
                _separator = separators(0)

            Case Is > 1
                ' Choose the next unused separator from the values specified
                _findNextNotUsedSeparator(separators)

            Case Else
                ' Choose the next unused separator from the list of all available valid separators
                separators = ValidSeparatorCharacters.ToArray()
                _findNextNotUsedSeparator(separators)
        End Select
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Separator & String.Join(Me.Separator, Me.Entries)
    End Function
#End Region

#Region "Private Methods"
    '*******************************************************************************************************************************
    '* Private methods                                                                                                             *
    '*******************************************************************************************************************************

    Private Sub _findNextNotUsedSeparator(separators() As Char)

        Dim searchString As String = String.Join(String.Empty, _entries)
        _unusedSeparators = New List(Of Char)
        Dim found As Boolean = False

        For Each separator As Char In separators
            If Not found Then
                If Not searchString.Contains(separator) Then
                    _separator = separator
                    found = True
                End If
            Else
                _unusedSeparators.Add(separator)
            End If
        Next
    End Sub
#End Region
End Class
