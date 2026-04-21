Imports System
Imports System.Collections.Generic


Partial Public Class Interactions
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set(value As Integer)
            m_Id = value
        End Set
    End Property
    Private m_Id As Integer
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property
    Private m_Name As String
    Public Property SurName() As String
        Get
            Return m_SurName
        End Get
        Set(value As String)
            m_SurName = value
        End Set
    End Property
    Private m_SurName As String

    Public Property ContactPhone() As String
        Get
            Return m_ContactPhone
        End Get
        Set(value As String)
            m_ContactPhone = value
        End Set
    End Property
    Private m_ContactPhone As String

    Public Property InfoSource() As String
        Get
            Return m_InfoSource
        End Get
        Set(value As String)
            m_InfoSource = value
        End Set
    End Property
    Private m_InfoSource As String


End Class



