======================
Separated List Project
======================

Description
===========

This is a test harness for the SeparatedList class.

This class provides properties and methods for embedding and extracting arrays of string values inside a single string variable using a predetermined or chosen separator character.

The separator character used is stored as the first character within the string, so does not need to be known outside of the string value.

Multiple levels of string lists can be embedded within a single string variable by using a different separator character for each level.

e.g.

,Geof,John,Mildred,Dave

Features
--------

* Provides a simple form interface to test the capabilities of the separated list class

Authors
=======

Geof Petit, 2022

Requirements
============

* Visual Studio.Net (VB and c#)

Usage
=====

To start the application, open the SeparatedList.sln file in Visual Studio.Net and run.

General Notes
=============

The are two versions of the Separated List class. The original VB version (vb_SeparatedList) and the newer c# version (cSharp_SeparatedList). The test harness is setup to run the c# version.