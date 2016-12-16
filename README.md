# Filename Renamer Tool
A simple .NET WinForms tool for renaming a large number of files. 
I work for a large Telecoms company and wrote this tool to help me rename large numbers of audio files for uploading to an Interactive voice response (IVR) server.

A csv file is used to map the old filename to a new filename.

The form has a number of fields:-

* Mapping Csv File - A Csv file to map an old to new filenames.
* Import Directory - A directory to read the files from.
* Export Directory - A directory to export the renamed files to.
* File Extension - File extension to append to renamed files

Although this is very specific to my needs, this code could be reused by other developers that want to rename a large number of files using csv file to remap filenames.
